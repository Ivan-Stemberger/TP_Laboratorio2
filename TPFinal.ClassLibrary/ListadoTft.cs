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

        public static void populateTftList()
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

        }

        public static void populateListaDefinitiva(List<Tft> filtrada)
        {
            listaTftDefinitiva.Clear();
            foreach (Tft item in filtrada)
            {
                bool exists = false;
                item.Win = item.winRate(filtrada, item);

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

        public static void editList(Tft game, int id)
        {
            foreach (Tft item in listaTft)
            {
                if (item.Id == id)
                {
                    item.composition = game.composition;
                    item.rank = game.rank;
                    item.position = game.position;
                    item.Win = game.setWin(game.position.ToString()); 
                }
            }
        }

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
