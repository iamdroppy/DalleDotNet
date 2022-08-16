using System.Text.Json.Serialization;

namespace DalleDotNet;

public class DallePromptResponse
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("created")]
    public int Created { get; set; }

    [JsonPropertyName("object")]
    public string? ObjectType { get; set; }

    [JsonPropertyName("prompt_type")]
    public string? PromptType { get; set; }

    [JsonPropertyName("prompt")]
    public DallePromptCaptionResponse? Prompt { get; set; }
    
    [JsonPropertyName("parent_generation_id")]
    public string? ParentGenerationId { get; set; }
}