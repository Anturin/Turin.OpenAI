using System;
using System.Collections.Generic;

namespace Turin.OpenAI.Models
{
    public class OpenAiRequest<E> where E : Enum
    {
        /// <summary>
        /// 请求语言模型
        /// </summary>
        public E model { get; set; }

        /// <summary>
        /// 是否流式对话
        /// </summary>
        public bool? stream { get; set; }

        /// <summary>
        /// 采样温度，控制模型的创造力，和top_p选择其中一个进行赋值
        /// </summary>
        /// <remarks>
        /// <p>取值范围：[0-2)</p>
        /// <p>值越高，生成的文本更多样，反之，生成的文本更确定</p>
        /// </remarks>
        public float? temperature { get; set; }

        /// <summary>
        /// 采样概率阈值，控制模型的创造力，和temperature选择其中一个进行赋值
        /// </summary>
        /// <remarks>
        /// <p>取值范围：(0-1]</p>
        /// <p>值越高，生成的文本更多样，反之，生成的文本更确定</p>
        /// </remarks>
        public float? top_p { get; set; }

        /// <summary>
        /// 控制模型生成文本时的重复度
        /// </summary>
        /// <remarks>
        /// <p>取值范围：[-2.0,2.0]。负数会增加重复度，正数会减少重复度。</p>
        /// <p>适用场景：</p>
        /// <p>较高的 presence_penalty 适用于要求多样性，趣味性或创造性的场景，如创意写作或头脑风暴。</p>
        /// <p>较低的 presence_penalty 适用于要求一致性和逻辑性的场景，如学术论文或学术报告。</p>
        /// </remarks>
        public float? presence_penalty { get; set; }

        /// <summary>
        /// 本次请求返回的最大 Token 数
        /// </summary>
        public int? max_tokens { get; set; }

        /// <summary>
        /// 生成响应的数量
        /// </summary>
        /// <remarks>
        /// <p>取值范围：[1,4]</p>
        /// <p>对于需要生成多个响应的场景（如创意写作、广告文案等等），可以设置较大的 n 值，以提高生成的多样性和创造性。</p>
        /// </remarks>
        public int? n { get; set; }

        /// <summary>
        /// 随机种子
        /// </summary>
        /// <remarks>
        /// <p>取值范围：[0,2^32-1]</p>
        /// <p>设置 seed 参数会使文本生成过程更具有确定性，通常用于使模型每次运行的结果一致</p>
        /// <p>在每次模型调用时候传入相同的 seed 值（由您指定），并保持其他参数不变，模型将尽可能返回相同的结果。</p>
        /// </remarks>
        public int? seed { get; set; }

        /// <summary>
        /// 结束符
        /// </summary>
        /// <remarks>
        /// <p>使用 stop 参数后，当模型生成的文本即将包含指定的字符串或者 token_id 时，将自动停止生成。</p>
        /// <p>stop 参数可以用于控制模型生成的文本的长度和内容，以避免生成过长或不相关的文本。</p>
        /// </remarks>
        public string[] stop { get; set; }

        /// <summary>
        /// 模型在生成文本时是否可以搜索外部信息
        /// </summary>
        /// <remakrs>
        /// 启用互联网搜索功能时，可能会额外增加 Token 的消耗。
        /// </remakrs>
        public bool? enable_search { get; set; }

        /// <summary>
        /// 返回格式
        /// </summary>
        public OpenAiResponseFormat response_format { get; set; }

        /// <summary>
        /// 消息列表
        /// </summary>
        public IEnumerable<OpenAiMessageInfo> messages { get; set; }
    }
}