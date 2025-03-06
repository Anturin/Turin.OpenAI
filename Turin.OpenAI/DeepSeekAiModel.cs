using Newtonsoft.Json;
using Turin.OpenAI.Models;

namespace Turin.OpenAI
{
    [JsonConverter(typeof(OpenAiEnumConverter))]
    public enum DeepseekAiModel
    {
        DeepseekChat,
    }
}