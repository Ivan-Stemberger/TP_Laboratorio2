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
