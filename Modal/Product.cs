using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    public class Product
    {
        private int _id;
        private string _name;
        private int _quantity;
        private int _price;
        private int _category_id;
        private string _img;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
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
        public int Category_ID
        {
            get { return _category_id; }
            set { _category_id = value; }
        }
        public string Image
        {
            get { return _img; }
            set { _img = value; }
        }
    }
}
