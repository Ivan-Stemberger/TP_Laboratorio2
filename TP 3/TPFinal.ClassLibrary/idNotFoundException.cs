using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal.ClassLibrary
{
    public class idNotFoundException : Exception
    {
        public override string Message
        {
            get
            {
                return "ID no válido.";
            }
        }
    }
}
