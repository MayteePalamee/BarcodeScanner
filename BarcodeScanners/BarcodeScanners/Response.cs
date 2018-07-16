using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeScanners
{
    public class Response
    {
        private String barCodeVID;
        private String message;

        public String BarCodeID
        {
            get { return barCodeVID; }
            set { barCodeVID = value; }
        }
        public String Message
        {
            get { return message; }
            set { message = value; }
        }
    }
}
