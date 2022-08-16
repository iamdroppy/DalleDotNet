using System.Text.Json.Serialization;

namespace DalleDotNet;

public class GenerationResponse
{
    [JsonPropertyName("image_path")]
    public string ImagePath { get; set; }
}