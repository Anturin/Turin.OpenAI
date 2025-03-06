using System;
using System.Threading.Tasks;

namespace Turin.OpenAI.Test
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var client = new QwenOpenAiClient("sk-9970ebfxxxxxxxxxxxxxxxxxxxxxxxxxde7de"))
            {
                var result = await client.AskAsync("你是什么模型", Models.QwenAiModel.QwenPlus);
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
