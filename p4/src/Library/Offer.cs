using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ucu.Poo.Defense
{
    public class Offer
    {
        public DateTime EndDate { get; set; }

        public IReadOnlyCollection<IOfferItem> Items
        {
            get
            {
                return new ReadOnlyCollection<IOfferItem>(this.items);
            }
        }

        public double Total
        {
            get
            {
                double result = 0;
                foreach (IOfferItem item in this.items)
                {
                    result = result + item.SubTotal;
                }

                return result;
            }
        }

        private IList<IOfferItem> items = new List<IOfferItem>();

        public Offer(DateTime endDate)
        {
            this.EndDate = endDate;
        }

        public OfferItem AddItem(Residue Residue, int quantity, int price)
        {
            IOfferItem item = new OfferItem(Residue, quantity, price);
            this.items.Add(item);
            return (OfferItem)item;
        }

        public PromoCode AddDiscount (int discount)
        {
            PromoCode Discount = new PromoCode("Codigo de Promo", discount);
            this.items.Add(Discount);
            return Discount;
        }

        public void RemoveItem(IOfferItem item)
        {
            this.items.Remove(item);
        }
    }
}