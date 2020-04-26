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

        //private int GetProductIndex(Product product) //sprawdzamy czy taki produkt 
        //                                             //jest juz w koszyku
        //{
        //    int result = -1;

        //    for (int i = 0; i < items.Count; i++)
        //    {
        //        if (items[i].ProductName.Equals(product.ToString()))
        //        {
        //            return i;
        //        }
        //    }

        //    return result;
        //}

        //zamiast getproductindex uzylismy metody anonimowej, więc możemy zakomentowac powyższą

        public bool AddProduct(Product product, int qnty)
        {
            //akcja dodania produktu do listy produktów
            
            // if, bo jesli np zamówienie jest wysłane, to nie można niczego dodać do zamówienia

            if (status == OrderStatus.NewOrder && qnty > 0 && product != null)
            {   //wyrazenie lambda, czyli funkcja anonimowa (zamiast użycia metody GetProductIndex)
               int productIndex = items.FindIndex(x => x.ProductName.Equals(product.ToString()));
                // x to element naszej kolekcji
                // => nasz x kierujemy do wyrażenia
               // int productIndex = GetProductIndex(product); //metoda sprawdza czy produkt jest w koszyku

                if (productIndex == -1)
                {
                    items.Add(new OrderItem(product, qnty));
                }
                else
                {
                    items[productIndex].Qnty += qnty;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveProduct(Product product, int qnty = 0)
        {
            if (status == OrderStatus.NewOrder && qnty >= 0 && product != null)
            {
                //int productIndex = GetProductIndex(product);
                int productIndex = items.FindIndex(x => x.ProductName.Equals(product.ToString()));
                if (productIndex == -1) return false; //jesli produktu nie ma w koszyku
                if (qnty > items[productIndex].Qnty) return false; //jesli w koszyku jest mniej niz chcemy usunąć
                if (qnty==0 || qnty==items[productIndex].Qnty) //jesli nie podamy wartości, lub podamy ilość taką,m jaka jest w koszyku
                {
                    items.RemoveAt(productIndex);
                    return true;
                }
                
                items[productIndex].Qnty -= qnty;
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

            items.ForEach(e => amount += e.ProductPrice * e.Qnty);
            
            //zastosowanie wyrażenia zamiast poniższego foreacha

            //przeglądamy wszytskie elementy z order item
            //foreach (var item in items)
            //{
            //    amount += item.ProductPrice * item.Qnty;
            //}

            if (discount > 0 && discount <= 100)
            {
                amount *= (100 - discount) / 100.0;
            }

            return amount;

        }

        public void Print()
        {
            Console.WriteLine("Elementy zamówienia:");

            items.ForEach(e => Console.WriteLine("{0,-40}|{1,10}|{2,10:0.00}|{3,10:0.00}|",
                       e.ProductName, e.Qnty, e.ProductPrice, e.ProductPrice * e.Qnty));

            //zastosowanie wyrażenia zamiast poniższego foreacha, bo elementy kolekcji mają swoje metody

            //foreach (var item in items)
            //{
            //    Console.WriteLine("{0,-40}|{1,10}|{2,10:0.00}|{3,10:0.00}|",
            //           item.ProductName, item.Qnty, item.ProductPrice, item.ProductPrice*item.Qnty);
            //    // -40 = 40 znaków dla nazwy, justowanie do lewej
            //    // {2,10:0.00} - wyswietlaj na 10 polach z dwoma miejscami po przecinku
            //}
            Console.WriteLine("Do zapłaty: {0,10:0.00}", CalcTotalAmount());
        }
    }
}
