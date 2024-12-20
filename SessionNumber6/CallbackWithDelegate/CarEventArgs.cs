using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbackWithDelegate
{
    public class CarEventArgs : EventArgs
    {
        public string Message { get; set; }

        public CarEventArgs(string message)
        {
            this.Message = message;
        }
    }
}
