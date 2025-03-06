using Newtonsoft.Json;

namespace Turin.OpenAI.Models
{
    [JsonConverter(typeof(OpenAiEnumConverter))]
    public enum DeepseekAiModel
    {
        DeepseekChat,
    }
}