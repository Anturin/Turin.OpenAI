namespace Turin.OpenAI.Models
{
    public class OpenAiResponseFormat
    {
        OpenAiResponseFormat()
        {
        }

        public string type { get; set; }

        /// <summary>
        /// JSON对象”
        /// </summary>
        /// <remarks>
        /// <p>注意：需要在 system/user 消息中引导模型输出 json 格式，如：“请按照 json 格式输出。</p>
        /// <p>当设置为 json_object 时，模型将返回一个 JSON 对象，其中包含生成的文本和其他相关信息。</p>
        /// </remarks>
        public static OpenAiResponseFormat Json = new OpenAiResponseFormat() { type = "json_object" };

        /// <summary>
        /// 纯文本
        /// </summary>
        public static OpenAiResponseFormat Text = new OpenAiResponseFormat() { type = "text" };
    }
}