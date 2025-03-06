namespace Turin.OpenAI.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class OpenAiResponseChoice
    {
        public int index { get; set; }

        /// <summary>
        /// 结束原因
        /// </summary>
        /// <remarks>
        /// <p>stop: API返回完整回复内容，或者调用参数中设置了stop</p>
        /// <p>length: 在允许的token限制内返回完整回复</p>
        /// <p>tool_calls: 工具调用</p>
        /// </remarks>
        public string finish_reason { get; set; }

        public OpenAiMessageInfo message { get; set; }
    }
}