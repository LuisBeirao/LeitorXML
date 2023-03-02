using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Leitor_XML.Classes.Serializacao
{
    public class revista
    {
        [System.Xml.Serialization.XmlAttribute()]
        public Int64 numero;

        [System.Xml.Serialization.XmlAttribute()]
        public string data;

        [System.Xml.Serialization.XmlElement()]
        public Processo[] processo;
    }

    public class Processo
    {
        [System.Xml.Serialization.XmlAttribute()]
        public Int64 numero;

        [System.Xml.Serialization.XmlElement()]
        public Despachos despachos;
        public object[] titulares;
        public Sobrestadores sobrestadores;
        public string procurador;
    }

    public class Despachos
    { 
        public Despacho despacho;
    }
    public class Sobrestadores  
    {
        public Sobrestador sobrestador;
    }
    public class Despacho
    {
        [System.Xml.Serialization.XmlAttribute()]
        public string codigo;

        [System.Xml.Serialization.XmlAttribute()]
        public string nome;

        [System.Xml.Serialization.XmlElement()]
        public string textocomplementar;
    }

    public class Sobrestador
    {
        [System.Xml.Serialization.XmlAttribute()]
        public string marca;

        [System.Xml.Serialization.XmlAttribute()]
        public string processo;
        
    }
}
