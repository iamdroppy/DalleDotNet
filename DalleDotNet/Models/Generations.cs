using System.Text.Json.Serialization;

namespace DalleDotNet;

public class Generations
{
    [JsonPropertyName("object")]
    public string Object { get; set; }

    [JsonPropertyName("data")]
    public List<GenerationDataResponse> Data { get; set; }
}