using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal.ClassLibrary
{
    public class listEmptyorNullException : Exception
    {
        public override string Message
        {
            get
            {
                return "La lista está vacía o es null.";
            }
        }
    }
}
