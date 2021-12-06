using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal.ClassLibrary
{
    public static class ListadoTft
    {
        public static List<Tft> listaTft = new List<Tft>();
        public static List<Tft> listaTftComposition = new List<Tft>();
        public static List<Tft> listaTftElo = new List<Tft>();
        public static List<Tft> listaTftPosition = new List<Tft>();
        public static List<Tft> listaTftDefinitiva = new List<Tft>();
        public static List<Tft> listaTftSerializar = new List<Tft>();

        public static List<Tft> GetListaTft()
        {
            return listaTft;
        }
        public static void setListaTft(List<Tft> lista)
        {
            listaTft = lista;
        }

        public static List<Tft> getTftElo()
        {
            return listaTftElo;
        }

        public static List<Tft> getTftComposition()
        {
            return listaTftComposition;
        }

        public static List<Tft> getTftListaDefinitiva()
        {
            return listaTftDefinitiva;
        }

        public static List<Tft> getListaTft()
        {
            return listaTft;
        }

        /// <summary>
        /// Completa la lista de partidas de Tft. Se utiliza si no se puede leer el file, si no existe o si está vacío/corrupto.
        /// </summary>
        /*public static void populateTftList()
        {
            listaTft.Add(new Tft(1,Tft.Ecomposition.Tanks, Tft.ERank.Gold,Tft.EPosition.First));
            listaTft.Add(new Tft(2, Tft.Ecomposition.Mages, Tft.ERank.Silver, Tft.EPosition.Third));
            listaTft.Add(new Tft(3, Tft.Ecomposition.DPS, Tft.ERank.Gold, Tft.EPosition.Fourth));
            listaTft.Add(new Tft(4, Tft.Ecomposition.Assassins, Tft.ERank.Gold, Tft.EPosition.Second));
            listaTft.Add(new Tft(5, Tft.Ecomposition.Mages, Tft.ERank.Bronze, Tft.EPosition.Third));
            listaTft.Add(new Tft(6, Tft.Ecomposition.Tanks, Tft.ERank.Diamond, Tft.EPosition.First));
            listaTft.Add(new Tft(7, Tft.Ecomposition.Assassins, Tft.ERank.Gold, Tft.EPosition.Second));
            listaTft.Add(new Tft(8, Tft.Ecomposition.DPS, Tft.ERank.Platinum, Tft.EPosition.Seventh));
            listaTft.Add(new Tft(9, Tft.Ecomposition.Assassins, Tft.ERank.Bronze, Tft.EPosition.Sixth));
            listaTft.Add(new Tft(10, Tft.Ecomposition.Tanks, Tft.ERank.Gold, Tft.EPosition.Third));
            listaTft.Add(new Tft(11, Tft.Ecomposition.Yordles, Tft.ERank.Platinum, Tft.EPosition.Eighth));
            listaTft.Add(new Tft(12, Tft.Ecomposition.Tanks, Tft.ERank.Gold, Tft.EPosition.Fifth));

        }*/

        /// <summary>
        /// Crea una lista definitiva de partidas en función del filtro establecido. Es utilizada para evitar la repetición de champions.
        /// </summary>
        /// <param name="filtrada">lista filtrada</param>
        public static void populateListaDefinitiva(List<Tft> filtrada)
        {
            listaTftDefinitiva.Clear();
            foreach (Tft item in filtrada)
            {
                bool exists = false;

                if (listaTftDefinitiva.Count == 0)
                {
                    listaTftDefinitiva.Add(item);
                }
                else
                {
                    for (int i = 0; i < listaTftDefinitiva.Count; i++)
                    {
                        if (listaTftDefinitiva[i].composition == item.composition)
                        {
                            exists = true;
                            break;
                        }
                    }

                    if (!exists)
                    {
                        listaTftDefinitiva.Add(item);
                    }

                }

            }

        }
        /// <summary>
        /// Establece un filtro en función del elo deseado
        /// </summary>
        /// <param name="elo">Elo para filtrar.</param>
        public static void filtroTftRank(string elo)
        {
            listaTftElo.Clear();
            foreach (var item in listaTft)
            {
                if (item.rank.ToString() == elo)
                {
                    listaTftElo.Add(item);
                }
            }

        }
        /// <summary>
        /// Verifica la existencia una partica en función del ID
        /// </summary>
        /// <param name="id">Id proporcionado para verificar</param>
        /// <returns>Devuleve true si encuentra la partida, false si no.</returns>
        public static bool searchId(int id)
        {
            foreach (Tft item in listaTft)
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
        public static void editList(Tft game, int id)
        {
            foreach (Tft item in listaTft)
            {
                if (item.Id == id)
                {
                    item.composition = game.composition;
                    item.rank = game.rank;
                    item.position = game.position;
                }
            }
        }

        /// <summary>
        /// Devuelve una partida en función del ID.
        /// </summary>
        /// <param name="id">Id de la partida</param>
        /// <returns>La partida si encuentra el game, null si no.</returns>
        public static Tft getGame(int id)
        {
            foreach (Tft item in listaTft)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }

            return null;
        }
        /// <summary>
        /// Elimina la partida en función del id proporcionado
        /// </summary>
        /// <param name="id">Id de la partida a eliminar</param>
        /// <returns>Devuelve True si encuentra la partida y la borra, False si no.</returns>
        public static bool deleteTft(int id)
        {

            foreach (Tft item in listaTft)
            {
                if (item.Id == id)
                {
                    listaTft.Remove(item);
                    return true;

                }
            }
            return false;
        }
    }
}
