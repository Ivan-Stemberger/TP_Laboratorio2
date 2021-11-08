using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal.ClassLibrary
{
    public class Lol : IAnalisis
    {
        int id;

        public int Id { get; set; }
        public enum EChamp { Caitlyn, Jhin, 
                    Leona, Ziggs, 
                    Alistar, Zoe, 
                    Rumble, Graves,    
                    LeeSin, Syndra, 
                    Nocturne, Ryze, 
                    Akali, Zhilean, 
                    Qiyanna, Talon, 
                    Aphelios }

        public EChamp champion { get; set; }

        public enum ERole { ADC, TOP, MID, JUNGLE, SUPPORT }
        public ERole role{ get; set; }

    public enum ERank { Bronze, Silver, Gold, Platinum, Diamond}
        public ERank rank { get; set; }

        public double Pick { get; set; }
        public double Win { get; set; }
         
        public Lol()
        {

        }

        public Lol(string champion, string role, string rank, double win)
        {
            this.rank = setRank(rank);
            this.champion = setChampion(champion);
            this.role = setRole(role);
            this.Win = win;
            this.Pick = 0;
            this.id = setId();
        }

        public Lol(EChamp champion, ERole role, ERank rank, double win,int id)
        {
            this.rank = rank;
            this.champion = champion;
            this.role = role;
            Win = win;
            Pick = 0;
            this.Id = id;
        }


        private int setId()
        {
            int size = ListadoLol.getListaLol().Count;
            int id = size + 1;
            List<Lol> list = ListadoLol.getListaLol();

            foreach(Lol item in list)
            {
                if(id == item.id)
                {
                    id = item.id++;
                }
            }
            return id;

        }
        private ERank setRank(string ranking)
        {
            var values = Enum.GetValues(typeof(ERank));

            foreach(ERank item in values)
            {
                if(item.ToString() == ranking)
                {
                    return item;
                }
            }

            return 0;
        }

        private EChamp setChampion(string champ)
        {
            var values = Enum.GetValues(typeof(EChamp));

            foreach (EChamp item in values)
            {
                if (item.ToString() == champ)
                {
                    return item;
                }
            }

            return 0;
        }

        private ERole setRole(string role)
        {
            var values = Enum.GetValues(typeof(ERole));

            foreach (ERole item in values)
            {
                if (item.ToString() == role)
                {
                    return item;
                }
            }

            return 0;
        }
        
        public double calcularPickRate(double cantidad, int tamaño)
        {
            double rate;
            
            rate = Math.Round(cantidad/tamaño*100,2);
            return rate;
        }

        public double setPickRate(List<Lol> list, Lol game)
        {
            double counter = 0;
            double rate;

            foreach (Lol item in list)
            {
                if (item.champion == game.champion && item.role == game.role && item.rank == game.rank)
                {
                    counter++;
                }
            }
            rate = game.calcularPickRate(counter,list.Count);

            return rate;
        }
        
        public double calcularWinRate(double win, double champ)
        {
            double rate = win / champ * 100;
            return rate;
        }
        
        public double setWinRate(List<Lol> lol, Lol game)
        {
            double counterChamp = 0;
            double counterWin = 0;
            double rate;

            foreach (Lol item in lol)
            {
                if (item.champion == game.champion && item.role == game.role)
                {
                    counterChamp++;
                    if(item.Win == 1)
                    {
                        counterWin++;
                    }
                }
            }

            rate = calcularWinRate(counterWin, counterChamp);
            return rate;
        }

            
    }
}
