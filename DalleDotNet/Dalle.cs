using System.Text;
using System.Text.Json;

namespace DalleDotNet;

public class Dalle
{
    private readonly string _authKey;
    private readonly DalleConfig _config;
    private readonly HttpClient _client;

    public Dalle(string authKey, DalleConfig config)
    {
        _authKey = authKey;
        _config = config;
        _client = new();
        _client.DefaultRequestHeaders.Add("Authorization", "Bearer " + _authKey);
    }

    public Dalle(string authKey) : this(authKey, new()) {}

    public async Task<string[]> GenerateAsync(string caption, int delay = 500, CancellationToken token = default)
    {
        var generate = await GenerateRawAsync(caption);

        while (!token.IsCancellationRequested)
        {
            var waitData = await ViewTaskRawAsync(generate.Id);
            switch (waitData.Status)
            {
                case "succeeded":
                    return waitData.Generations?.Data?.Select(s => s.GenerationResponse.ImagePath).ToArray() ?? throw new NullReferenceException("Generations is null");
                case "pending":
                    await Task.Delay(delay, token);
                    break;
                default:
                    throw new Exception("Unknown status: " + waitData.Status);
            }
        }

        if (token.IsCancellationRequested)
            throw new TaskCanceledException();
        throw new Exception("No image generated.");
    }
    
    public async Task<DalleDataResponse> GenerateRawAsync(string caption)
    {
        // create a post to _config.Endpoint in json
        var request = new
        {
            prompt = new
            {
                batch_size = 4,
                caption = caption
            },
            task_type =	"text2im"
        };
        
        var json = JsonSerializer.Serialize(request);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await _client.PostAsync(_config.Endpoint, content);
        var responseString = await response.Content.ReadAsStringAsync();
        var responseObject = JsonSerializer.Deserialize<DalleDataResponse>(responseString);
        return responseObject;
    }

    public async Task<DalleDataResponse> ViewTaskRawAsync(string taskId)
    {
        var data = await _client.GetStringAsync($"{_config.Endpoint}/{taskId}");
        var responseObject = JsonSerializer.Deserialize<DalleDataResponse>(data);
        return responseObject;
    }
}