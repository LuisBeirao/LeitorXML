using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Leitor_XML.Classes.Serializacao
{
    public class revista
    {
        [System.Xml.Serialization.XmlAttribute()]
        public Int64 numero { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string data { get; set; }

        [System.Xml.Serialization.XmlElement()]
        public Processo[] processo { get; set; }
    }

    public class Processo
    {
        [System.Xml.Serialization.XmlAttribute()]
        public Int64 numero { get; set; }

        [System.Xml.Serialization.XmlElement()]
        public Despachos despachos { get; set; }
        public object[] titulares { get; set; }
        public Sobrestadores sobrestadores { get; set; }
        public string procurador { get; set; }
    }

    public class Despachos
    { 
        public Despacho despacho { get; set; }
    }
    public class Sobrestadores  
    {
        public Sobrestador[] sobrestador { get; set; }
    }
    public class Despacho
    {
        [System.Xml.Serialization.XmlAttribute()]
        public string codigo { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string nome { get; set; }

        [System.Xml.Serialization.XmlElement()]
        public string textocomplementar { get; set; }
    }

    public class Sobrestador
    {
        [System.Xml.Serialization.XmlAttribute()]
        public string marca { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string processo { get; set; }

    }
}
