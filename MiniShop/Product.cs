using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    public class Product
    {
        private int id;
        private string name;
        private double price;
        private string descr = String.Empty;
        private UInt16 version = 0;
        private Boolean promo = false;
        private Boolean active = true;

        public double Price { get { return price; }  }

        //ustawianie parametrów
        public Product (int id, string name, double price, string descr="")
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.descr = descr;
        }

        public void ChangePrice(double newPrice)
        {
            //pomysleć nad mechanizmem logowania historii zmian ceny - myslę że stack??
        }

        public void ChangeDescription(string newDescr)
        {
            //
        }

        public void SetActive(bool isActive)
        {
            this.active = isActive;
        }

        public override string ToString() //pobieramy nazwę produktu
        {
            return name;
        }
    }
}
