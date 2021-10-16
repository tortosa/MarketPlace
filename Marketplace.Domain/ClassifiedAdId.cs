using System;

namespace Marketplace.Domain
{
    public class ClassifiedAdId
    {
        private readonly Guid value;

        public ClassifiedAdId(Guid value)
        {
            if(value == default)
                throw new ArgumentException("Classified Ad id cannot be empty", nameof(value));
            this.value = value;
        }
    }
}