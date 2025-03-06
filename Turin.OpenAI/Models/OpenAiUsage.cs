namespace Turin.OpenAI.Models;

/// <summary>
/// 本地调用的使用量
/// </summary>
public class OpenAiUsage
{
    /// <summary>
    /// 输入的token数量
    /// </summary>
    public int prompt_tokens { get; set; }

    /// <summary>
    /// 输出的token数量
    /// </summary>
    public int completion_tokens { get; set; }

    /// <summary>
    /// 输入和输出的总token数量
    /// </summary>
    public int total_tokens { get; set; }
}