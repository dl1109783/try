﻿namespace MLS.Protocol
{
    public class MarkdownString
    {
        public string Value { get; private set; }
        public bool IsTrusted { get; private set; }

        public MarkdownString(string value, bool isTrusted = false)
        {
            Value = value ?? "";
            IsTrusted = isTrusted;
        }

        public static implicit operator MarkdownString(string  value)  
        {
            return new MarkdownString(value);
        }
    }
}