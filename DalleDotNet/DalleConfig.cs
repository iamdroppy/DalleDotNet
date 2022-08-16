namespace DalleDotNet;

public class DalleConfig
{
    public string Endpoint { get; set; } = "https://labs.openai.com/api/labs/tasks";
}

/*
{
  "object": "list",
  "data": [
    {
      "object": "task",
      "id": "task-DqOrNYnK5tzNXwi7dAdtZIyQ",
      "created": 1660681226,
      "task_type": "text2im",
      "status": "pending",
      "status_information": {},
      "prompt_id": "prompt-F4QHHoeiTMgvIoOoJ0awYY1S",
      "prompt": {
        "id": "prompt-F4QHHoeiTMgvIoOoJ0awYY1S",
        "object": "prompt",
        "created": 1660681226,
        "prompt_type": "CaptionPrompt",
        "prompt": {
          "caption": "Vaporwave '80s gaming room with a commodore 64"
        },
        "parent_generation_id": null
      }
    }
  ]
}

*/