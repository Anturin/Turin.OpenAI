using System;

namespace Turin.OpenAI.Models
{
    [AttributeUsage(AttributeTargets.Field)]
    public class EnumValueAttribute : Attribute
    {
        public string Value { get; }

        public EnumValueAttribute(string value)
        {
            Value = value;
        }
    }
}