using System;
using System.Collections.Generic;
using System.Text;

namespace Turin.OpenAI
{
    /// <summary>
    /// 阿里云通义千问
    /// </summary>
    public class QwenOpenAiClient : OpenAiClient<QwenAiModel>
    {
        public QwenOpenAiClient(string apiKey) : base(apiKey) { }

        protected override string GetApiUrl()
        {
            return "https://dashscope.aliyuncs.com/compatible-mode/v1/chat/completions";
        }
    }

}
