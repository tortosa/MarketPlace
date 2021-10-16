using System;

namespace Marketplace.Domain
{
    public class UserId
    {
        private readonly Guid value;

        public UserId(Guid value)
        {
            if(value == default)
                throw new ArgumentException("User id cannot be empty", nameof(value));
            this.value = value;
        }
    }
}