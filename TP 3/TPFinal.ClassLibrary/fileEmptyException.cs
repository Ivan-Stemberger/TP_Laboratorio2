using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal.ClassLibrary
{
    public class fileEmptyException : Exception
    {
        public override string Message
        {
            get
            {
                return "File vacío o inexistente";
            }
        }
    }
}
