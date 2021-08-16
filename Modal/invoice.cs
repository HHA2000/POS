using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    class invoice
    {
        private int _id;
        private int _totalPrice;
        private string _datetime;

        public string Datetime
        {
            get { return _datetime; }
            set { _datetime = value; }
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public int Total_Price
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }
    }
}
