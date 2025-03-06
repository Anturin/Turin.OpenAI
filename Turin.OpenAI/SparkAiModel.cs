using Newtonsoft.Json;
using System;
using Turin.OpenAI.Models;

namespace Turin.OpenAI
{
    [JsonConverter(typeof(OpenAiEnumConverter))]
    public enum SparkAiModel
    {
        Lite,
        [EnumValue("generalv3")]
        Pro,
        [EnumValue("pro-128k")]
        Pro128K,
        [EnumValue("generalv3.5")]
        Max,
        [EnumValue("max-32k")]
        Max32K,
        [EnumValue("4.0Ultra")]
        Ultra
    }

}
