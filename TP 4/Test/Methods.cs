using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinal.ClassLibrary;

namespace Test
{
    /*static class Methods
    {
        public static void testAbm()
        {
            ListadoLol.populateLolList();
            List<Lol> list = ListadoLol.getListaLol();

            writer(list);

            if(ListadoLol.searchId(3))
            {
                ListadoLol.editList(new Lol("Aphelios", "ADC", "Silver",0),3);
            }

            writeEdition();

            ListadoLol.deleteLol(4);

            Console.WriteLine("");
            Console.WriteLine("/////Test Delete////");
            Console.WriteLine("");
            writer(list);
            
        }

        private static void writer(List<Lol> list)
        {
            foreach (Lol item in list)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("ID " + item.Id);
                sb.Append(" Champion " + item.champion);
                sb.Append(" Role " + item.role);
                sb.Append(" Rank " + item.rank);
                sb.Append(" Result " + item.Win.ToString());

                Console.WriteLine(sb.ToString());
            }
        }

        private static void writeEdition()
        {
            foreach (Lol item in ListadoLol.getListaLol())
            {
                if (item.Id == 3)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("ID " + item.Id);
                    sb.Append(" Champion " + item.champion);
                    sb.Append(" Role " + item.role);
                    sb.Append(" Rank " + item.rank);
                    sb.AppendLine(" Result " + item.Win.ToString());

                    Console.WriteLine("");
                    Console.WriteLine("/////Test Edit////");
                    Console.WriteLine("");
                    Console.WriteLine(sb.ToString());
                }
            }
        }
    }*/
}
