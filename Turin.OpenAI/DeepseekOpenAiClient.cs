using Turin.OpenAI.Models;

namespace Turin.OpenAI
{
    /// <summary>
    /// DeepSeek
    /// </summary>
    public class DeepseekOpenAiClient : OpenAiClient<DeepseekAiModel>
    {
        public DeepseekOpenAiClient(string apiKey) : base(apiKey) { }

        protected override string GetApiUrl()
        {
            return "https://api.deepseek.com/chat/completions";
        }
    }
}
