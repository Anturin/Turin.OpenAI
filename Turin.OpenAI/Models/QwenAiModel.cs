using Newtonsoft.Json;

namespace Turin.OpenAI.Models
{
    [JsonConverter(typeof(OpenAiEnumConverter))]
    public enum QwenAiModel
    {
        QwenPlus,
        QwenPlusLatest,
        QwenTurbo,
        QwenTurboLatest,
        QwenLong,
        QwenLongLatest,
        QwenMax,
        QwenMaxLatest,
        QwenCoderPlus,
    }
}