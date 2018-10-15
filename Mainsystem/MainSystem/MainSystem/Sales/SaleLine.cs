using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainSystem.Sales
{
    public class SaleLine
    {
        private string mProductName;
        private int mQuantity;
        private double mPrice;
        private double mTotalPrice;


        private int mProductID;

        public int ProductID
        {
            get { return mProductID; }
            set { mProductID = value; }
        }

        public string ProductName
        {
            get
            {
                return mProductName;
            }

            set
            {
                mProductName = value;
            }
        }

        public int Quantity
        {
            get
            {
                return mQuantity;
            }

            set
            {
                mQuantity = value;
            }
        }

        public double Price
        {
            get
            {
                return mPrice;
            }

            set
            {
                mPrice = value;
            }
        }

        public double Total
        {
            get
            {
                return mTotalPrice;
            }

            set
            {
                mTotalPrice = value;
            }
        }

        public SaleLine(int productID, string n, int q, double price, double total)
        {
            mProductID = productID;
            mProductName = n;
            mQuantity = q;
            mPrice = price;
            mTotalPrice = total;

        }
    }
}

