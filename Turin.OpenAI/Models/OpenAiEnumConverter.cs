using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Turin.OpenAI.Models
{
    public class OpenAiEnumConverter : StringEnumConverter
    {
        class OpenAiEnumNamingStrategy : NamingStrategy
        {
            private static Dictionary<string, string> _dict = new Dictionary<string, string>();

            protected override string ResolvePropertyName(string name)
            {
                if (_dict.ContainsKey(name))
                {
                    return _dict[name];
                }
                else
                {
                    var sb = new StringBuilder();
                    foreach (var c in name)
                    {
                        if (char.IsUpper(c))
                        {
                            if (sb.Length > 0)
                                sb.Append('-');
                            sb.Append(char.ToLower(c));
                        }
                        else
                        {
                            sb.Append(c);
                        }
                    }

                    _dict.Add(name, sb.ToString());
                    return _dict[name];
                }
            }
        }

        public OpenAiEnumConverter()
        {
            NamingStrategy = new OpenAiEnumNamingStrategy();
        }
    }
}