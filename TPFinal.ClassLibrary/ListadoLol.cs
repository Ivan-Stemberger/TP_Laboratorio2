using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Linq;

namespace TPFinal.ClassLibrary
{
    public static class ListadoLol
    {
        public static List<Lol> listaLol = new List<Lol>();
        public static List<Lol> listaLolRole = new List<Lol>();
        public static List<Lol> listaLolElo = new List<Lol>();
        public static List<Lol> listaLolDefinitiva = new List<Lol>();
        public static List<Lol> listaLolSerializar = new List<Lol>();

        public static List<Lol> getListaLol()
        {
            return listaLol;
        }
        public static void setListaLol(List<Lol> lista)
        {
            listaLol = lista;
        }

        public static List<Lol> getLolElo()
        {
            return listaLolElo;
        }

        public static List<Lol> getLolRole()
        {
            return listaLolRole;
        }

        public static List<Lol> getLolListaDefinitiva()
        {
            return listaLolDefinitiva;
        }

        /// <summary>
        /// Completa la lista de partidas de Lol. Se utiliza si no se puede leer el file, si no existe o si está vacío/corrupto.
        /// </summary>
        public static void populateLolList()
        {
            listaLol.Add(new Lol(Lol.EChamp.Caitlyn, Lol.ERole.ADC, Lol.ERank.Gold,1,1));
            listaLol.Add(new Lol(Lol.EChamp.Alistar, Lol.ERole.SUPPORT, Lol.ERank.Gold,0,2));
            listaLol.Add(new Lol(Lol.EChamp.Akali, Lol.ERole.MID, Lol.ERank.Diamond, 0,3));
            listaLol.Add(new Lol(Lol.EChamp.Jhin, Lol.ERole.ADC, Lol.ERank.Platinum, 0,4));
            listaLol.Add(new Lol(Lol.EChamp.Leona, Lol.ERole.SUPPORT, Lol.ERank.Silver, 1,5));
            listaLol.Add(new Lol(Lol.EChamp.Leona, Lol.ERole.TOP, Lol.ERank.Diamond, 0, 6));
            listaLol.Add(new Lol(Lol.EChamp.LeeSin, Lol.ERole.JUNGLE, Lol.ERank.Gold, 1, 7));
            listaLol.Add(new Lol(Lol.EChamp.Nocturne, Lol.ERole.JUNGLE, Lol.ERank.Platinum, 1, 8));
            listaLol.Add(new Lol(Lol.EChamp.Qiyanna, Lol.ERole.MID, Lol.ERank.Silver, 0, 9));
            listaLol.Add(new Lol(Lol.EChamp.Qiyanna, Lol.ERole.JUNGLE, Lol.ERank.Gold, 0, 10));
            listaLol.Add(new Lol(Lol.EChamp.Zhilean, Lol.ERole.SUPPORT, Lol.ERank.Diamond, 1, 11));
            listaLol.Add(new Lol(Lol.EChamp.Zoe, Lol.ERole.MID, Lol.ERank.Platinum, 1, 12));
            listaLol.Add(new Lol(Lol.EChamp.Caitlyn, Lol.ERole.ADC, Lol.ERank.Bronze, 1, 13));
            listaLol.Add(new Lol(Lol.EChamp.Caitlyn, Lol.ERole.ADC, Lol.ERank.Diamond, 0, 14));
            listaLol.Add(new Lol(Lol.EChamp.LeeSin, Lol.ERole.TOP, Lol.ERank.Gold, 0, 15));
            listaLol.Add(new Lol(Lol.EChamp.Ziggs, Lol.ERole.ADC, Lol.ERank.Platinum, 1, 16));
            listaLol.Add(new Lol(Lol.EChamp.Ziggs, Lol.ERole.MID, Lol.ERank.Gold, 1, 17));
            listaLol.Add(new Lol(Lol.EChamp.Graves, Lol.ERole.TOP, Lol.ERank.Diamond, 1, 18));
            listaLol.Add(new Lol(Lol.EChamp.Caitlyn, Lol.ERole.ADC, Lol.ERank.Gold, 1, 19));

        }
        /// <summary>
        /// Crea una lista definitiva de partidas en función del filtro establecido. Es utilizada para evitar la repetición de champions.
        /// </summary>
        /// <param name="filtrada"></param>
        public static void populateListaDefinitiva(List<Lol> filtrada)
        {
            listaLolDefinitiva.Clear();
            foreach (Lol item in filtrada)
            {
                bool exists = false;
                item.Pick = item.setPickRate(filtrada, item);
                item.Win = item.setWinRate(filtrada, item);

                if (listaLolDefinitiva.Count == 0)
                {
                    listaLolDefinitiva.Add(item);
                }
                else
                {
                    for(int i = 0;i<listaLolDefinitiva.Count; i++)
                    {
                        if(listaLolDefinitiva[i].champion == item.champion && listaLolDefinitiva[i].rank == item.rank && item.role == listaLolDefinitiva[i].role)
                        {
                            exists = true;
                            break;
                        }
                    }

                    if(!exists)
                    {
                        listaLolDefinitiva.Add(item);
                    }
                    
                }
                
            }

        }
        /// <summary>
        /// Establece un filtro en función del rol deseado
        /// </summary>
        /// <param name="role">Rol para filtrar.</param>
        public static void filtroLolRole(string role)
        {
            
            foreach (var item in listaLol)
            {
                if (item.role.ToString() == role)
                {
                    listaLolRole.Add(item);
                }
            }

        }
        /// <summary>
        /// Filtra en función del Elo seleccionado
        /// </summary>
        /// <param name="elo">Elo utilizado para el filtro.</param>
        public static void filtroLolElo(string elo)
        {
            listaLolElo.Clear();
            foreach (var item in listaLol)
            {
                if (item.rank.ToString() == elo)
                {
                    listaLolElo.Add(item);
                }
            }

        }
        /// <summary>
        /// Elimina la partida en función del id proporcionado
        /// </summary>
        /// <param name="id">Id de la partida a eliminar</param>
        /// <returns>Devuelve True si encuentra la partida y la borra, False si no.</returns>
        public static bool deleteLol(int id)
        {
            
            foreach(Lol item in listaLol)
            {
                if(item.Id == id)
                {
                    listaLol.Remove(item);
                    return true;
                    
                }
            }
            return false;
        }
        /// <summary>
        /// Verifica la existencia una partica en función del ID
        /// </summary>
        /// <param name="id">Id proporcionado para verificar</param>
        /// <returns>Devuleve true si encuentra la partida, false si no.</returns>
        public static bool searchId(int id)
        {
            foreach (Lol item in listaLol)
            {
                if (item.Id == id)
                {
                    return true;
                }
            }

            return false;
        }
        /// <summary>
        /// Edita una partida determinada
        /// </summary>
        /// <param name="game">Partida proporcionada por el usuario</param>
        /// <param name="id">id de la partida para buscarla.</param>
        public static void editList(Lol game,int id)
        {
            foreach(Lol item in listaLol)
            {
                if(item.Id == id)
                {
                    item.champion = game.champion;
                    item.rank = game.rank;
                    item.role = game.role;
                    item.Win = game.Win;
                }
            }
        }
        /// <summary>
        /// Devuelve una partida en función del ID.
        /// </summary>
        /// <param name="id">Id de la partida</param>
        /// <returns>La partida si encuentra el game, null si no.</returns>
        public static Lol getGame(int id)
        {
            foreach(Lol item in listaLol)
            {
                if(item.Id == id)
                {
                    return item;
                }
            }

            return null;
        }

    }
}
