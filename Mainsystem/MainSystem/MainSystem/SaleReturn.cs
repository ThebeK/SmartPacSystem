using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainSystem
{
   public  class SaleReturn
    {
        private int mSaleLineID;
        private int mProductID;
        private string mProductName;
        private int mQuantity;
        private double mGrossPrice;
        public int SaleLineID
        {
            get
            {
                return mSaleLineID;
            }

            set
            {
                mSaleLineID = value;
            }
        }
        public int ProductID
        {
            get
            {
                return mProductID;
            }

            set
            {
                mProductID = value;
            }
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

        public double GrossPrice
        {
            get
            {
                return mGrossPrice;
            }

            set
            {
                mGrossPrice = value;
            }
        }



        public SaleReturn(int SlID, int ID, string name, int q, double gp)
        {
            mSaleLineID = SlID;
            mProductID = ID;
            mProductName = name;
            mQuantity = q;
            mGrossPrice = gp;
        }
    }

}

