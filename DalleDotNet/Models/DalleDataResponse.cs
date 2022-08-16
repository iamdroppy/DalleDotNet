using System.Text.Json.Serialization;

namespace DalleDotNet;

public class DalleDataResponse
{
    [JsonPropertyName("object")]
    public string? ObjectType { get; set; }

    [JsonPropertyName("id")] public string Id { get; set; } = null!;

    [JsonPropertyName("created")]
    public int Created { get; set; }
    
    [JsonPropertyName("task_type")]
    public string? TaskType { get; set; }
    
    [JsonPropertyName("status")]
    public string? Status { get; set; }
    
    [JsonPropertyName("prompt_id")]
    public string? PromptId { get; set; }

    [JsonPropertyName("prompt")]
    public DallePromptResponse? Prompt { get; set; }
    
    [JsonPropertyName("generations")]
    public Generations? Generations { get; set; }
}