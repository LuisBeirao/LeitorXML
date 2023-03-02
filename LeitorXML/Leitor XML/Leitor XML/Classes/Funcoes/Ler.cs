using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Leitor_XML.Classes.Funcoes
{
    class Ler
    {
        public static String LERXML(string strCaminho)
        {
            Serializacao.revista Revista = null;

            XmlTextReader xmlReader = new XmlTextReader(strCaminho);
            StreamReader reader = new StreamReader(strCaminho);

            XmlSerializer serializer = new XmlSerializer(typeof(Serializacao.revista));
   
            Revista = (Serializacao.revista)serializer.Deserialize(reader);

            return "";
        }
    }
}
