using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal.ClassLibrary
{
    public interface IAnalisis
    {
        int Win { get; set; }

        double calcularRate(int win, int champ);
    }
}
