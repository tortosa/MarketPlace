using Marketplace.Framework;
using System;
using System.Text.RegularExpressions;

namespace Marketplace.Domain
{
    public class ClassifiedAdTitle : Value<ClassifiedAdTitle>
    {
        private const int maxLenght = 100;
        private readonly string value;

        public static ClassifiedAdTitle FromHtml(string htmlTitle)
        {
            var supportedTagsReplaced = htmlTitle.Replace("<i>", "*")
                .Replace("<i>", "*")
                .Replace("<i>", "*")
                .Replace("<i>", "*");

            return new ClassifiedAdTitle(Regex.Replace(supportedTagsReplaced, "<.*?>", string.Empty));
        }

        private ClassifiedAdTitle(string value)
        {
            if(value.Length > maxLenght)
                throw new ArgumentOutOfRangeException($"Title cannot be longer than {maxLenght} characters", nameof(value));
            this.value = value;
        }
    }
}