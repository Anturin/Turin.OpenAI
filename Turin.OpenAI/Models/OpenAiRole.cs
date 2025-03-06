using Newtonsoft.Json;

namespace Turin.OpenAI.Models
{

    [JsonConverter(typeof(OpenAiEnumConverter))]
    public enum OpenAiRole
    {
        system,
        user,
        assistant
    }
}