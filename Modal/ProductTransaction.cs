using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    public class ProductTransaction
    {
        private int _id;
        private int _quantity;
        private int _price;
        private int _invoice_id;
        private int _product_id;
        private string _product_name;

        public string ProductName
        {
            get { return _product_name; }
            set { _product_name = value; }
        }


        public int ProductID
        {
            get { return _product_id; }
            set { _product_id = value; }
        }

        public int InvoiceID
        {
            get { return _invoice_id; }
            set { _invoice_id = value; }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

    }
}
