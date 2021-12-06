using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal.ClassLibrary
{
    public class Tft
    {
        public int Id { get; set; }
        public enum Ecomposition 
        {
            TANK = 1, ASSASINS, YORDLES, MAGES, DPS
        }
        public Ecomposition composition { get; set; }

        public enum ERank { Bronze = 1, Silver, Gold, Platinum, Diamond }
        public ERank rank { get; set; }

        public enum EPosition { First = 1,Second,Third,Fourth,Fifth,Sixth,Seventh,Eighth }
        public EPosition position { get; set; }

        public Tft()
        {

        }
        
        public Tft(int id, string composition, string rank, string position)
        {
            this.Id = id;
            this.composition = setComposition(composition);
            this.rank = setRank(rank);
            this.position = setPosition(position);
        }

        public Tft(string composition, string rank, string position)
        {
            this.Id = setId();
            this.composition = setComposition(composition);
            this.rank = setRank(rank);
            this.position = setPosition(position);
        }

        private EPosition setPosition(string ranking)
        {
            var values = Enum.GetValues(typeof(EPosition));

            foreach (EPosition item in values)
            {
                if (item.ToString() == ranking)
                {
                    return item;
                }
            }

            return 0;
        }

        private ERank setRank(string ranking)
        {
            var values = Enum.GetValues(typeof(ERank));

            foreach (ERank item in values)
            {
                if (item.ToString() == ranking)
                {
                    return item;
                }
            }

            return 0;
        }

        private Ecomposition setComposition(string ranking)
        {
            var values = Enum.GetValues(typeof(Ecomposition));

            foreach (Ecomposition item in values)
            {
                if (item.ToString() == ranking)
                {
                    return item;
                }
            }

            return 0;
        }

        private int setId()
        {
            List<Tft> list = ListadoTft.getListaTft();
            int size = list.Count;
            int id = size + 1;

            foreach (Tft item in list)
            {
                if (id == item.Id)
                {
                    id = item.Id++;
                }
            }
            return id;

        }

        public string analisisGlobal(string composicion)
        {
            List<Tft> lista;
            double promedio;
            int cantidad;

           
                lista = ListadoTft.getListaTft();
                cantidad = lista.FindAll(x => x.composition.ToString() == composicion).Count();
                promedio = calcularRate(cantidad, lista.Count());

            
            return $"{promedio}%";
        }

        private double calcularRate(int cantidad, int total)
        {
            double rate = (double)cantidad / total * 100;
            return Math.Round(rate, 2);
        }

        public string analisisEloMayor(string composicion)
        {
            List<Tft> lista;
            int numeroActual;
            int numeroAnterior = 0;
            double promedioActual;
            double promedioAnterior = 0;

            for (int i = 1; i <= 5; i++)
            {
                lista = ListadoTft.getListaTft().FindAll(x => x.rank == (ERank)i);
                promedioActual = promedioRank(composicion, lista);
                numeroActual = i;
                if (promedioActual > promedioAnterior)
                {
                    promedioAnterior = promedioActual;
                    numeroAnterior = numeroActual;
                }
            }

            return $"{(ERank)numeroAnterior}: {promedioAnterior}%";

        }

        public string analisisEloMenor(string composicion)
        {
            List<Tft> lista;
            int numeroActual;
            int numeroAnterior = 0;
            double promedioActual;
            double promedioAnterior = 0;

            for (int i = 1; i <= 5; i++)
            {
                lista = ListadoTft.getListaTft().FindAll(x => x.rank == (ERank)i);
                promedioActual = promedioRank(composicion, lista);
                numeroActual = i;
                if (promedioActual < promedioAnterior || promedioAnterior == 0)
                {
                    promedioAnterior = promedioActual;
                    numeroAnterior = numeroActual;
                }
            }

            return $"{(ERank)numeroAnterior}: {promedioAnterior}%";

        }


        public double promedioRank(string filtro, List<Tft> lista)
        {
            List<Tft> listaAux;
            int counter = 0;
            double promedio;

            listaAux = lista.FindAll(x => x.composition.ToString() == filtro);

            counter = listaAux.Count();
            promedio = calcularRate(counter, lista.Count());


            return promedio;
        }

       
    }
}
