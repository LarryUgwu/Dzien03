using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    public class Order
    {
        // typ wyliczeniowy tzw etykietki
        enum OrderStatus
        {
            NewOrder,
            Complete,
            Confirmed,
            Shipped,
            Returned,
            Cancelled
        }

        private string orderNumber;
        private List<OrderItem> items = new List<OrderItem>(); //uworzona pusta lista
        private byte discount = 0;
        private string customerName;
        private string shipAddress;
        //private double totalAmount;
        private DateTime orderDate;
        private OrderStatus status = OrderStatus.NewOrder;

        public double TotalAmount { get { return CalcTotalAmount(); } }

        //metody

        public bool AddProduct(Product product, int qnty)
        {
            //akcja dodania produktu do listy produktów
            // dodać if, bo jesli np zamówienie jest wysłane, to nie można niczego dodać do zamówienia

            if (status == OrderStatus.NewOrder && qnty > 0 && product != null)
            {
                items.Add(new OrderItem(product, qnty));
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Clear()
        {
            if (status == OrderStatus.NewOrder)
            {
                items.Clear();
                return true;
            }
            else
            {
                return false;
            }
        }

        private double CalcTotalAmount()
        {
            double amount = 0.0;

            //przeglądamy wszytskie elementy z order item
            foreach (var item in items)
            {
                amount += item.ProductPrice * item.Qnty;
            }

            if (discount > 0 && discount <= 100)
            {
                amount *= (100 - discount) / 100.0;
            }

            return amount;

        }

        public void Print()
        {
            Console.WriteLine("Elementy zamówienia:");
            foreach (var item in items)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",
                        "", item.Qnty, item.ProductPrice, item.ProductPrice*item.Qnty);
            }
            Console.WriteLine("Do zapłaty: {0}", CalcTotalAmount());
        }
    }
}
