using System.Text.Json.Serialization;

namespace DalleDotNet;

public class DallePromptCaptionResponse
{
    [JsonPropertyName("caption")]
    public string? Caption { get; set; }
}