using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leitor_XML.Classes
{
    class Class1
    {
        
    }

    // OBSERVAÇÃO: o código gerado pode exigir pelo menos .NET Framework 4.5 ou .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class revista
    {

        private revistaProcesso[] processoField;

        private ushort numeroField;

        private string dataField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("processo")]
        public revistaProcesso[] processo
        {
            get
            {
                return this.processoField;
            }
            set
            {
                this.processoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort numero
        {
            get
            {
                return this.numeroField;
            }
            set
            {
                this.numeroField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class revistaProcesso
    {

        private object[] itemsField;

        private ItemsChoiceType1[] itemsElementNameField;

        private uint numeroField;

        private string datadepositoField;

        private string dataconcessaoField;

        private string datavigenciaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("apostila", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("classe-nacional", typeof(revistaProcessoClassenacional))]
        [System.Xml.Serialization.XmlElementAttribute("classes-vienna", typeof(revistaProcessoClassesvienna))]
        [System.Xml.Serialization.XmlElementAttribute("dados-de-madri", typeof(revistaProcessoDadosdemadri))]
        [System.Xml.Serialization.XmlElementAttribute("despachos", typeof(revistaProcessoDespachos))]
        [System.Xml.Serialization.XmlElementAttribute("lista-classe-nice", typeof(revistaProcessoListaclassenice))]
        [System.Xml.Serialization.XmlElementAttribute("marca", typeof(revistaProcessoMarca))]
        [System.Xml.Serialization.XmlElementAttribute("prioridade-unionista", typeof(revistaProcessoPrioridadeunionista))]
        [System.Xml.Serialization.XmlElementAttribute("procurador", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("sobrestadores", typeof(revistaProcessoSobrestadores))]
        [System.Xml.Serialization.XmlElementAttribute("titulares", typeof(revistaProcessoTitulares))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType1[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint numero
        {
            get
            {
                return this.numeroField;
            }
            set
            {
                this.numeroField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-deposito")]
        public string datadeposito
        {
            get
            {
                return this.datadepositoField;
            }
            set
            {
                this.datadepositoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-concessao")]
        public string dataconcessao
        {
            get
            {
                return this.dataconcessaoField;
            }
            set
            {
                this.dataconcessaoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-vigencia")]
        public string datavigencia
        {
            get
            {
                return this.datavigenciaField;
            }
            set
            {
                this.datavigenciaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class revistaProcessoClassenacional
    {

        private string especificacaoField;

        private revistaProcessoClassenacionalSubclassenacional[] subclassesnacionalField;

        private byte codigoField;

        /// <remarks/>
        public string especificacao
        {
            get
            {
                return this.especificacaoField;
            }
            set
            {
                this.especificacaoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute("sub-classes-nacional")]
        [System.Xml.Serialization.XmlArrayItemAttribute("sub-classe-nacional", IsNullable = false)]
        public revistaProcessoClassenacionalSubclassenacional[] subclassesnacional
        {
            get
            {
                return this.subclassesnacionalField;
            }
            set
            {
                this.subclassesnacionalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class revistaProcessoClassenacionalSubclassenacional
    {

        private byte codigoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class revistaProcessoClassesvienna
    {

        private revistaProcessoClassesviennaClassevienna[] classeviennaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("classe-vienna")]
        public revistaProcessoClassesviennaClassevienna[] classevienna
        {
            get
            {
                return this.classeviennaField;
            }
            set
            {
                this.classeviennaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class revistaProcessoClassesviennaClassevienna
    {

        private string codigoField;

        private byte edicaoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte edicao
        {
            get
            {
                return this.edicaoField;
            }
            set
            {
                this.edicaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class revistaProcessoDadosdemadri
    {

        private uint numeroinscricaointernacionalField;

        private string datarecebimentoinpiField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("numero-inscricao-internacional")]
        public uint numeroinscricaointernacional
        {
            get
            {
                return this.numeroinscricaointernacionalField;
            }
            set
            {
                this.numeroinscricaointernacionalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-recebimento-inpi")]
        public string datarecebimentoinpi
        {
            get
            {
                return this.datarecebimentoinpiField;
            }
            set
            {
                this.datarecebimentoinpiField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class revistaProcessoDespachos
    {

        private revistaProcessoDespachosDespacho[] despachoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("despacho")]
        public revistaProcessoDespachosDespacho[] despacho
        {
            get
            {
                return this.despachoField;
            }
            set
            {
                this.despachoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class revistaProcessoDespachosDespacho
    {

        private object[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        private string codigoField;

        private string nomeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("protocolo", typeof(revistaProcessoDespachosDespachoProtocolo))]
        [System.Xml.Serialization.XmlElementAttribute("texto-complementar", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("texto-sobrestamento", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nome
        {
            get
            {
                return this.nomeField;
            }
            set
            {
                this.nomeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class revistaProcessoDespachosDespachoProtocolo
    {

        private revistaProcessoDespachosDespachoProtocoloRequerente requerenteField;

        private string procuradorField;

        private revistaProcessoDespachosDespachoProtocoloCedente[] cedentesField;

        private revistaProcessoDespachosDespachoProtocoloCessionario[] cessionariosField;

        private ulong numeroField;

        private string dataField;

        private string codigoServicoField;

        /// <remarks/>
        public revistaProcessoDespachosDespachoProtocoloRequerente requerente
        {
            get
            {
                return this.requerenteField;
            }
            set
            {
                this.requerenteField = value;
            }
        }

        /// <remarks/>
        public string procurador
        {
            get
            {
                return this.procuradorField;
            }
            set
            {
                this.procuradorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("cedente", IsNullable = false)]
        public revistaProcessoDespachosDespachoProtocoloCedente[] cedentes
        {
            get
            {
                return this.cedentesField;
            }
            set
            {
                this.cedentesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("cessionario", IsNullable = false)]
        public revistaProcessoDespachosDespachoProtocoloCessionario[] cessionarios
        {
            get
            {
                return this.cessionariosField;
            }
            set
            {
                this.cessionariosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong numero
        {
            get
            {
                return this.numeroField;
            }
            set
            {
                this.numeroField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codigoServico
        {
            get
            {
                return this.codigoServicoField;
            }
            set
            {
                this.codigoServicoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class revistaProcessoDespachosDespachoProtocoloRequerente
    {

        private string nomerazaosocialField;

        private string paisField;

        private string ufField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("nome-razao-social")]
        public string nomerazaosocial
        {
            get
            {
                return this.nomerazaosocialField;
            }
            set
            {
                this.nomerazaosocialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string pais
        {
            get
            {
                return this.paisField;
            }
            set
            {
                this.paisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string uf
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class revistaProcessoDespachosDespachoProtocoloCedente
    {

        private string nomerazaosocialField;

        private string paisField;

        private string ufField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("nome-razao-social")]
        public string nomerazaosocial
        {
            get
            {
                return this.nomerazaosocialField;
            }
            set
            {
                this.nomerazaosocialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string pais
        {
            get
            {
                return this.paisField;
            }
            set
            {
                this.paisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string uf
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class revistaProcessoDespachosDespachoProtocoloCessionario
    {

        private string nomerazaosocialField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("nome-razao-social")]
        public string nomerazaosocial
        {
            get
            {
                return this.nomerazaosocialField;
            }
            set
            {
                this.nomerazaosocialField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        protocolo,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("texto-complementar")]
        textocomplementar,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("texto-sobrestamento")]
        textosobrestamento,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class revistaProcessoListaclassenice
    {

        private revistaProcessoListaclasseniceClassenice[] classeniceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("classe-nice")]
        public revistaProcessoListaclasseniceClassenice[] classenice
        {
            get
            {
                return this.classeniceField;
            }
            set
            {
                this.classeniceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class revistaProcessoListaclasseniceClassenice
    {

        private string especificacaoField;

        private string traducaoespecificacaoField;

        private string statusField;

        private byte codigoField;

        /// <remarks/>
        public string especificacao
        {
            get
            {
                return this.especificacaoField;
            }
            set
            {
                this.especificacaoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("traducao-especificacao")]
        public string traducaoespecificacao
        {
            get
            {
                return this.traducaoespecificacaoField;
            }
            set
            {
                this.traducaoespecificacaoField = value;
            }
        }

        /// <remarks/>
        public string status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class revistaProcessoMarca
    {

        private string nomeField;

        private string apresentacaoField;

        private string naturezaField;

        /// <remarks/>
        public string nome
        {
            get
            {
                return this.nomeField;
            }
            set
            {
                this.nomeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string apresentacao
        {
            get
            {
                return this.apresentacaoField;
            }
            set
            {
                this.apresentacaoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string natureza
        {
            get
            {
                return this.naturezaField;
            }
            set
            {
                this.naturezaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class revistaProcessoPrioridadeunionista
    {

        private revistaProcessoPrioridadeunionistaPrioridade[] prioridadeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("prioridade")]
        public revistaProcessoPrioridadeunionistaPrioridade[] prioridade
        {
            get
            {
                return this.prioridadeField;
            }
            set
            {
                this.prioridadeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class revistaProcessoPrioridadeunionistaPrioridade
    {

        private string dataField;

        private string numeroField;

        private string paisField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string numero
        {
            get
            {
                return this.numeroField;
            }
            set
            {
                this.numeroField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string pais
        {
            get
            {
                return this.paisField;
            }
            set
            {
                this.paisField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class revistaProcessoSobrestadores
    {

        private revistaProcessoSobrestadoresSobrestador[] sobrestadorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("sobrestador")]
        public revistaProcessoSobrestadoresSobrestador[] sobrestador
        {
            get
            {
                return this.sobrestadorField;
            }
            set
            {
                this.sobrestadorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class revistaProcessoSobrestadoresSobrestador
    {

        private uint processoField;

        private string marcaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint processo
        {
            get
            {
                return this.processoField;
            }
            set
            {
                this.processoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string marca
        {
            get
            {
                return this.marcaField;
            }
            set
            {
                this.marcaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class revistaProcessoTitulares
    {

        private revistaProcessoTitularesTitular[] titularField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("titular")]
        public revistaProcessoTitularesTitular[] titular
        {
            get
            {
                return this.titularField;
            }
            set
            {
                this.titularField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class revistaProcessoTitularesTitular
    {

        private string nomerazaosocialField;

        private string paisField;

        private string ufField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("nome-razao-social")]
        public string nomerazaosocial
        {
            get
            {
                return this.nomerazaosocialField;
            }
            set
            {
                this.nomerazaosocialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string pais
        {
            get
            {
                return this.paisField;
            }
            set
            {
                this.paisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string uf
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemsChoiceType1
    {

        /// <remarks/>
        apostila,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("classe-nacional")]
        classenacional,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("classes-vienna")]
        classesvienna,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("dados-de-madri")]
        dadosdemadri,

        /// <remarks/>
        despachos,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("lista-classe-nice")]
        listaclassenice,

        /// <remarks/>
        marca,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("prioridade-unionista")]
        prioridadeunionista,

        /// <remarks/>
        procurador,

        /// <remarks/>
        sobrestadores,

        /// <remarks/>
        titulares,
    }


}
