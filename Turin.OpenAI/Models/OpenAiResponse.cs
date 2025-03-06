namespace Turin.OpenAI.Models;

public class OpenAiResponse
{
    public string id { get; set; }

    public int created { get; set; }

    /// <summary>
    /// 请求语言模型
    /// </summary>
    public string model { get; set; }

    /// <summary>
    /// 响应内容
    /// </summary>
    public OpenAiResponseChoice[] choices { get; set; }

    /// <summary>
    /// 本地接口的使用量
    /// </summary>
    public OpenAiUsage usage { get; set; }
}