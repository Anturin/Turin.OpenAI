using Newtonsoft.Json;
using Turin.OpenAI.Models;

namespace Turin.OpenAI
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