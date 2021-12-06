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
        public static List<Lol> listaLolFiltrada = new List<Lol>();
        public static List<Lol> listaLolSerializar = new List<Lol>();

        public static List<Lol> getListaLol()
        {
            return listaLol;
        }
        public static void setListaLol(List<Lol> lista)
        {
            listaLol = lista;
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
