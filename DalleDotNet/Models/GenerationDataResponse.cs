using System.Text.Json.Serialization;

namespace DalleDotNet;

public class GenerationDataResponse
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("object")]
    public string Object { get; set; }

    [JsonPropertyName("created")]
    public int Created { get; set; }

    [JsonPropertyName("generation_type")]
    public string GenerationType { get; set; }

    [JsonPropertyName("generation")]
    public GenerationResponse GenerationResponse { get; set; }

    [JsonPropertyName("task_id")]
    public string TaskId { get; set; }

    [JsonPropertyName("prompt_id")]
    public string PromptId { get; set; }

    [JsonPropertyName("is_public")]
    public bool IsPublic { get; set; }
}