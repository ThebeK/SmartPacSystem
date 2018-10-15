using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainSystem
{
    public class SOSummary
    {
        private int lineID;
        private string product;
        private int qty;
        private string soNum;
        private int received;

        public int Received
        {
            get { return received; }
            set { received = value; }
        }


        public string SONumbuer
        {
            get { return soNum; }
            set { soNum = value; }
        }


        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }


        public string Product
        {
            get { return product; }
            set { product = value; }
        }


        public int LineID
        {
            get { return lineID; }
            set { lineID = value; }
        }

        public SOSummary()
        {

        }
    }
}
