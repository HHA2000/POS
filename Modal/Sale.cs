using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    class Sale
    {
        private string _name;
        private int _quantity;
        private int _price;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        


        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }


    }
}
