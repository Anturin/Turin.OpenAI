namespace Turin.OpenAI
{
    /// <summary>
    /// 讯飞星火
    /// </summary>
    public class SparkOpenAiClient : OpenAiClient<SparkAiModel>
    {
        public SparkOpenAiClient(string apiKey) : base(apiKey)
        {
        }

        protected override string GetApiUrl()
        {
            return "https://spark-api-open.xf-yun.com/v1/chat/completions";
        }
    }

}
