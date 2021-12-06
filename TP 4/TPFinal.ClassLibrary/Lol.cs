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
        public enum EChamp { Caitlyn = 1, Jhin, 
                    Leona, Ziggs, 
                    Alistar, Zoe, 
                    Rumble, Graves,    
                    LeeSin, Syndra, 
                    Nocturne, Ryze, 
                    Akali, Zhilean, 
                    Qiyanna, Talon, 
                    Aphelios }

        public EChamp champion { get; set; }
        public enum ERole { ADC = 1, TOP, MID, JUNGLE, SUPPORT }
        public ERole role{ get; set; }

        public enum ERegion { NA = 1, EUW, EUEast, Brazil, LAS, LAN, Asia, OCE}

        public ERegion region { get; set; }

        public enum ERank { Bronze = 1, Silver, Gold, Platinum, Diamond}
        public ERank rank { get; set; }

        public int Win { get; set; }

        
        public Lol()
        {

        }

        public Lol(string champion, string role, string rank, string region, int win)
        {
            this.rank = setRank(rank);
            this.champion = setChampion(champion);
            this.role = setRole(role);
            this.region = setRegion(region);
            this.Win = win;
            this.id = setId();
        }

        public Lol(int id, string champion, string role, string rank, string region, int win)
        {
            this.Id = id;
            this.rank = setRank(rank);
            this.champion = setChampion(champion);
            this.role = setRole(role);
            this.region = setRegion(region);
            Win = win;

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

        private ERegion setRegion(string region)
        {
            var values = Enum.GetValues(typeof(ERegion));

            foreach (ERegion item in values)
            {
                if (item.ToString() == region)
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
        
        
        public void setPickRate(List<Lol> list, Lol game)
        {
            double counter = 0;

            foreach (Lol item in list)
            {
                if (item.champion == game.champion && item.role == game.role && item.rank == game.rank 
                    && item.region == game.region)
                {
                    counter++;
                }
            }
            
        }

        public void setEloPickRate(List<Lol> list, Lol game)
        {
            double counter = 0;

            foreach (Lol item in list)
            {
                if (item.champion == game.champion && item.rank == game.rank)
                {
                    counter++;
                }
            }
            

        }

        public void setEloWinRate(List<Lol> lol, Lol game)
        {
            int counterChamp = 0;
            int counterWin = 0;

            foreach (Lol item in lol)
            {
                if (item.champion == game.champion && item.rank == game.rank)

                {
                    counterChamp++;
                    if (item.Win == 1)
                    {
                        counterWin++;
                    }
                }
            }

        }

        public double calcularRate(int win, int champ)
        {
            double rate = (double)win / champ * 100;
            return Math.Round(rate,2);
        }
        
        public void setWinRate(List<Lol> lol, Lol game)
        {
            int counterChamp = 0;
            double counterWin = 0;

            foreach (Lol item in lol)
            {
                if (item.champion == game.champion && item.role == game.role && item.rank == game.rank 
                    && item.region == game.region)
                {
                    counterChamp++;
                    if(item.Win == 1)
                    {
                        counterWin++;
                    }
                }
            }

        }

        public string analisisGlobal(string champion, int flag)
        {
            List<Lol> lista;
            double promedio;
            int cantidad;

            if (flag == 0)
            { 
                lista = ListadoLol.getListaLol().FindAll(x => x.champion.ToString() == champion);
                cantidad = lista.FindAll(x => x.Win == 1).Count();
                promedio = calcularRate(cantidad, lista.Count());
            }
            else
            {
                lista = ListadoLol.getListaLol();
                cantidad = lista.FindAll(x => x.champion.ToString() == champion).Count();
                promedio = calcularRate(cantidad, lista.Count());
                
            }
            return $"{promedio}%";
        }

        public string analisisRegionMayor(string champion, int flag)
        {
            List<Lol> lista;
            int numeroActual;
            int numeroAnterior = 0;
            double promedioActual;
            double promedioAnterior = 0;

            if(flag == 0)
            {
                lista = ListadoLol.getListaLol().FindAll(x => x.champion.ToString() == champion);
                for (int i = 1; i <= 8; i++)
                {
                    promedioActual = promedioRegion(((ERegion)i).ToString(), flag,lista);
                    numeroActual = i;

                    if (promedioActual > promedioAnterior)
                    {
                        promedioAnterior = promedioActual;
                        numeroAnterior = numeroActual;
                    }
                }
            }
            else
            {
                for (int i = 1; i <= 8; i++)
                {
                    lista = ListadoLol.getListaLol().FindAll(x => x.region == (ERegion)i);
                    promedioActual = promedioRegion(champion, flag, lista);
                    numeroActual = i;
                    if (promedioActual > promedioAnterior)
                    {
                        promedioAnterior = promedioActual;
                        numeroAnterior = numeroActual;
                    }
                }
            }            
            return $"{(ERegion)numeroAnterior}: {promedioAnterior}%";
        }

        public string analisisRegionMenor(string champion, int flag)
        {
            List<Lol> lista;
            int numeroActual;
            int numeroAnterior = 0;
            double promedioActual;
            double promedioAnterior = 0;

            if (flag == 0)
            {
                lista = ListadoLol.getListaLol().FindAll(x => x.champion.ToString() == champion);
                for (int i = 1; i <= 8; i++)
                {
                    promedioActual = promedioRegion(((ERegion)i).ToString(), flag, lista);
                    numeroActual = i;

                    if (promedioActual < promedioAnterior || promedioAnterior == 0)
                    {
                        promedioAnterior = promedioActual;
                        numeroAnterior = numeroActual;
                    }
                }
            }
            else
            {
                for (int i = 1; i <= 8; i++)
                {
                    lista = ListadoLol.getListaLol().FindAll(x => x.region == (ERegion)i);
                    promedioActual = promedioRegion(champion, flag, lista);
                    numeroActual = i;
                    if (promedioActual < promedioAnterior || promedioAnterior == 0)
                    {
                        promedioAnterior = promedioActual;
                        numeroAnterior = numeroActual;
                    }
                }
            }

            return $"{(ERegion)numeroAnterior}: {promedioAnterior}%";

        }

        public double promedioRegion(string filtro, int flag, List<Lol> lista)
        {
            List<Lol> listaAux; 
            int counter = 0;
            double promedio;
            
            if(flag == 0)
            {
                listaAux = lista.FindAll(x => x.region.ToString() == filtro);
                foreach (Lol item in listaAux)
                {
                    if (item.Win == 1)
                    {
                        counter++;
                    }
                }
                promedio = calcularRate(counter, listaAux.Count());
                
            }
            else
            {
                listaAux = lista.FindAll(x=> x.champion.ToString() == filtro);

                counter = listaAux.Count();
                promedio = calcularRate(counter, lista.Count());
            }
            return promedio;
        }

        public string analisisRolMayor(string champion, int flag)
        {
            List<Lol> lista;
            int numeroActual;
            int numeroAnterior = 0;
            double promedioActual;
            double promedioAnterior = 0;

            if (flag == 0)
            {
                lista = ListadoLol.getListaLol().FindAll(x => x.champion.ToString() == champion);
                for (int i = 1; i <= 5; i++)
                {
                    promedioActual = promedioRol(((ERole)i).ToString(), flag, lista);
                    numeroActual = i;

                    if (promedioActual > promedioAnterior)
                    {
                        promedioAnterior = promedioActual;
                        numeroAnterior = numeroActual;
                    }
                }
            }
            else
            {
                for (int i = 1; i <= 5; i++)
                {
                    lista = ListadoLol.getListaLol().FindAll(x => x.role == (ERole)i);
                    promedioActual = promedioRol(champion, flag, lista);
                    numeroActual = i;
                    if (promedioActual > promedioAnterior)
                    {
                        promedioAnterior = promedioActual;
                        numeroAnterior = numeroActual;
                    }
                }
            }

            return $"{(ERole)numeroAnterior}: {promedioAnterior}%";

        }

        public string analisisRolMenor(string champion, int flag)
        {
            List<Lol> lista;
            int numeroActual;
            int numeroAnterior = 0;
            double promedioActual;
            double promedioAnterior = 0;

            if (flag == 0)
            {
                lista = ListadoLol.getListaLol().FindAll(x => x.champion.ToString() == champion);
                for (int i = 1; i <= 5; i++)
                {
                    promedioActual = promedioRol(((ERole)i).ToString(), flag, lista);
                    numeroActual = i;

                    if (promedioActual < promedioAnterior || promedioAnterior == 0)
                    {
                        promedioAnterior = promedioActual;
                        numeroAnterior = numeroActual;
                    }
                }
            }
            else
            {
                for (int i = 1; i <= 5; i++)
                {
                    lista = ListadoLol.getListaLol().FindAll(x => x.role == (ERole)i);
                    promedioActual = promedioRol(champion, flag, lista);
                    numeroActual = i;
                    if (promedioActual < promedioAnterior || promedioAnterior == 0)
                    {
                        promedioAnterior = promedioActual;
                        numeroAnterior = numeroActual;
                    }
                }
            }

            return $"{(ERole)numeroAnterior}: {promedioAnterior}%";

        }

        public double promedioRol(string filtro, int flag, List<Lol> lista)
        {
            List<Lol> listaAux;
            int counter = 0;
            double promedio;

            if (flag == 0)
            {
                listaAux = lista.FindAll(x => x.role.ToString() == filtro);
                foreach (Lol item in listaAux)
                {
                    if (item.Win == 1)
                    {
                        counter++;
                    }
                }
                promedio = calcularRate(counter, listaAux.Count());

            }
            else
            {
                listaAux = lista.FindAll(x => x.champion.ToString() == filtro);

                counter = listaAux.Count();
                promedio = calcularRate(counter, lista.Count());
            }
            return promedio;
        }

        public string analisisEloMayor(string champion, int flag)
        {
            List<Lol> lista;
            int numeroActual;
            int numeroAnterior = 0;
            double promedioActual;
            double promedioAnterior = 0;

            if (flag == 0)
            {
                lista = ListadoLol.getListaLol().FindAll(x => x.champion.ToString() == champion);
                for (int i = 1; i <= 5; i++)
                {
                    promedioActual = promedioRank(((ERank)i).ToString(), flag, lista);
                    numeroActual = i;

                    if (promedioActual > promedioAnterior)
                    {
                        promedioAnterior = promedioActual;
                        numeroAnterior = numeroActual;
                    }
                }
            }
            else
            {
                for (int i = 1; i <= 5; i++)
                {
                    lista = ListadoLol.getListaLol().FindAll(x => x.rank == (ERank)i);
                    promedioActual = promedioRank(champion, flag, lista);
                    numeroActual = i;
                    if (promedioActual > promedioAnterior)
                    {
                        promedioAnterior = promedioActual;
                        numeroAnterior = numeroActual;
                    }
                }
            }

            return $"{(ERank)numeroAnterior}: {promedioAnterior}%";

        }

        public string analisisEloMenor(string champion, int flag)
        {
            List<Lol> lista;
            int numeroActual;
            int numeroAnterior = 0;
            double promedioActual;
            double promedioAnterior = 0;

            if (flag == 0)
            {
                lista = ListadoLol.getListaLol().FindAll(x => x.champion.ToString() == champion);
                for (int i = 1; i <= 5; i++)
                {
                    promedioActual = promedioRank(((ERank)i).ToString(), flag, lista);
                    numeroActual = i;

                    if (promedioActual < promedioAnterior || promedioAnterior == 0)
                    {
                        promedioAnterior = promedioActual;
                        numeroAnterior = numeroActual;
                    }
                }
            }
            else
            {
                for (int i = 1; i <= 5; i++)
                {
                    lista = ListadoLol.getListaLol().FindAll(x => x.rank == (ERank)i);
                    promedioActual = promedioRegion(champion, flag, lista);
                    numeroActual = i;
                    if (promedioActual < promedioAnterior || promedioAnterior == 0)
                    {
                        promedioAnterior = promedioActual;
                        numeroAnterior = numeroActual;
                    }
                }
            }

            return $"{(ERank)numeroAnterior}: {promedioAnterior}%";

        }


        public double promedioRank(string filtro, int flag, List<Lol> lista)
        {
            List<Lol> listaAux;
            int counter = 0;
            double promedio;

            if (flag == 0)
            {
                listaAux = lista.FindAll(x => x.rank.ToString() == filtro);
                foreach (Lol item in listaAux)
                {
                    if (item.Win == 1)
                    {
                        counter++;
                    }
                }
                promedio = calcularRate(counter, listaAux.Count());

            }
            else
            {
                listaAux = lista.FindAll(x => x.champion.ToString() == filtro);

                counter = listaAux.Count();
                promedio = calcularRate(counter, lista.Count());
            }
            return promedio;
        }

    }

}
