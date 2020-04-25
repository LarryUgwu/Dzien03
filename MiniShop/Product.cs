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

        public int Price { get { return Price; }  }

        //ustawianie parametrów
        public void SetParam(int id, string name, double price, string descr="")
        {
            //
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
    }
}
