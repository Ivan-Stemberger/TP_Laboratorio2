using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace TPFinal.ClassLibrary
{
    public class ImportExport<T>
    {
        public List<T> lista;

        public ImportExport(List<T> list)
        {
            lista = list;
        }
        /// <summary>
        /// Exporta un file con la información deseada por el usuario. El string filtro sirve para la formación del nombre del archivo.
        /// </summary>
        /// <param name="filtro">string para nombrar el file.</param>
        public void exportAnalisis(string filtro)
        {
            string name = "Analisis" + typeof(T).Name + filtro + ".xml";
            string fileName = AppDomain.CurrentDomain.BaseDirectory + name;

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            using (XmlTextWriter writer = new XmlTextWriter(fileName, System.Text.Encoding.UTF8))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));

                serializer.Serialize(writer, this.lista);

            }
        }
        /// <summary>
        /// Exporta la totalidad de las partidas del juego deseado.
        /// </summary>
        public void exportAll()
        {
            string name = "Complete list of " + typeof(T).Name + " games.xml";
            string fileName = AppDomain.CurrentDomain.BaseDirectory + name;

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            using (XmlTextWriter writer = new XmlTextWriter(fileName, System.Text.Encoding.UTF8))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));

                serializer.Serialize(writer, this.lista);

            }

        }
        /// <summary>
        /// Importa un archivo en función del tipo deseado, lo carga en una Lista y lo devuelve.
        /// </summary>
        /// <returns>Devuelve una lista de un objeto con la información leída del file.</returns>
        public List<T> Import()
        {
            string name = "Complete list of " + typeof(T).Name + " games.xml";
            string fileName = AppDomain.CurrentDomain.BaseDirectory + name;

            if (!File.Exists(fileName))
            {
                return null;
            }

            using (XmlTextReader reader = new XmlTextReader(fileName))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));


                this.lista = (List<T>)serializer.Deserialize(reader);
                return lista;
            }
        }
    }
}
