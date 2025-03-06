using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Turin.OpenAI.Models;

namespace Turin.OpenAI
{
    public abstract class OpenAiClient<E> : IDisposable where E : Enum
    {
        /// <summary>
        /// 获取API地址
        /// </summary>
        /// <returns></returns>
        protected abstract string GetApiUrl();

        private HttpClient httpClient;

        private string _apiKey;

        public OpenAiClient(string apiKey)
        {
            _apiKey = apiKey;
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _apiKey);
            client.Timeout = TimeSpan.FromMinutes(30);
        }

        protected List<OpenAiMessageInfo> _messages = new List<OpenAiMessageInfo>();

        /// <summary>
        /// 设置提示
        /// </summary>
        /// <param name="prompt"></param>
        public void SetPrompt(string prompt)
        {
            _messages.Add(new OpenAiMessageInfo()
            {
                role = OpenAiRole.system,
                content = prompt
            });
        }

        /// <summary>
        /// 提问
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        public async Task<string> AskAsync(string question, E model)
        {
            _messages.Add(new OpenAiMessageInfo()
            {
                role = OpenAiRole.user,
                content = question
            });
            var body = JsonConvert.SerializeObject(new OpenAiRequest<E>()
            {
                model = model,
                messages = _messages.ToArray()
            }, new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore
            });
            using (var content = new StringContent(body, Encoding.UTF8, "application/json"))
            {
                var response = await httpClient.PostAsync(GetApiUrl(), content);
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var res = JsonConvert.DeserializeObject<OpenAiResponse>(result);
                    _messages.Add(res.choices[0].message);
                    return res.choices[0].message.content;
                }

                throw new Exception($"请求失败：{response.ReasonPhrase}");
            }
        }

        public void Dispose()
        {
            httpClient.Dispose();
        }
    }
}