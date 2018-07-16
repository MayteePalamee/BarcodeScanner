using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeScanners
{
    public class Barcode
    {
        /**
      * event delegate.
      * Declare the event using EventHandler<T>
      **/

        public event EventHandler<Events> RaiseEvents;

        /**
         * delegate method handle raise event
         **/
        protected virtual void OnRaiseEvent(Events e)
        {
            RaiseEvents?.Invoke(this, e);
        }

        public Boolean Connect()
        {
            try
            {

            }catch(Exception e)
            {

            }
            return true;
        }
    }
}
