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
            Tanks, Assassins, Yordles, Mages, DPS
        }
        public Ecomposition composition { get; set; }

        public enum ERank { Bronze, Silver, Gold, Platinum, Diamond }
        public ERank rank { get; set; }

        public enum EPosition { First,Second,Third,Fourth,Fifth,Sixth,Seventh,Eighth }
        public EPosition position { get; set; }

        double win;
        public double Win { get; set; }

        public Tft(int id, Ecomposition composition, ERank rank, EPosition position)
        {
            this.Id = id;
            this.composition = composition;
            this.rank = rank;
            this.position = position;
            this.Win = setWin(position.ToString());
        }

        public Tft(string composition, string rank, string position)
        {
            this.Id = setId();
            this.composition = setComposition(composition);
            this.rank = setRank(rank);
            this.position = setPosition(position);
            this.Win = setWin(position);
        }

        public double setWin(string position)
        {
            if(isTop4(position))
            {
                return 1;
            }
            return 0;
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

        public double winRate(List<Tft> list, Tft game)
        {
            double counterComposition = 0;
            double counterWin = 0;
            double rate;

            foreach (Tft item in list)
            {
                if (item.composition == game.composition)
                {
                    counterComposition++;
                    if (item.Win == 1)
                    {
                        counterWin++;
                    }
                }
            }

            rate = calcularWinRate(counterWin, counterComposition);
            return rate;
        }

        private double calcularWinRate(double counter, double composition)
        {
            double rate = counter / composition * 100;
            return rate;
        }

        private bool isTop4(string position)
        {
            if(position == "First" || position == "Second" || position == "Third" || position == "Fourth")
            {
                return true;
            }
            return false;
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

    }
}
