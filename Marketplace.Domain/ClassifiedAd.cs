using System;

namespace Marketplace.Domain
{
    public class ClassifiedAd
    {
        public Guid Id { get; }

        public ClassifiedAd(Guid id, Guid ownerId)
        {
            if(id == default)
                throw new ArgumentException("Identity must be specified", nameof(id));
            if (ownerId == default)
                throw new ArgumentException("Owner id must be specified", nameof(ownerId));

            Id = id;
            this.ownerId = ownerId;
        }

        public void SetTitle(string title) => this.title = title;

        public void UpdateText(string text) => this.text = text;

        public void UpdatePrice(decimal price) => this.price = price;

        private Guid ownerId;
        private string title;
        private string text;
        private decimal price;
    }
}