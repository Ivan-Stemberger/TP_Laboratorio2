using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal.ClassLibrary
{
    public interface IAnalisis
    {
        double Pick { get; set; }
        double Win { get; set; }


        double calcularPickRate(double cantidad, int tamaño);
        double calcularWinRate(double win, double champ);
    }
}
