using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace ConsoleApplication2
{

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class catalog
    {

        private catalogBook[] bookField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("book")]
        public catalogBook[] book
        {
            get
            {
                return this.bookField;
            }
            set
            {
                this.bookField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class catalogBook
    {

        private string authorField;

        private string titleField;

        private string genreField;

        private decimal priceField;

        private System.DateTime publish_dateField;

        private string descriptionField;

        private string idField;

        /// <remarks/>
        public string author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        /// <remarks/>
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        public string genre
        {
            get
            {
                return this.genreField;
            }
            set
            {
                this.genreField = value;
            }
        }

        /// <remarks/>
        public decimal price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime publish_date
        {
            get
            {
                return this.publish_dateField;
            }
            set
            {
                this.publish_dateField = value;
            }
        }

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }


    class ClassXML
    {
        XmlSerializer ser = new XmlSerializer(typeof(catalog));
        public catalog Deserialize(Stream stream)
        {
            catalog cat = (catalog)ser.Deserialize(stream);
            return cat;
        }
        public GetStockPrice DeserializeSOAP(Stream stream)
        {
            XmlSerializer ser = new XmlSerializer(typeof(GetStockPrice));
            GetStockPrice price = (GetStockPrice)ser.Deserialize(stream);
            return price;
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2003/05/soap-envelope/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2003/05/soap-envelope/", IsNullable = false)]
    public partial class Envelope
    {

        private EnvelopeBody bodyField;

        private string encodingStyleField;

        /// <remarks/>
        public EnvelopeBody Body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string encodingStyle
        {
            get
            {
                return this.encodingStyleField;
            }
            set
            {
                this.encodingStyleField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2003/05/soap-envelope/")]
    public partial class EnvelopeBody
    {

        private GetStockPrice getStockPriceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.example.org/stock")]
        public GetStockPrice GetStockPrice
        {
            get
            {
                return this.getStockPriceField;
            }
            set
            {
                this.getStockPriceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.example.org/stock")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.example.org/stock", IsNullable = false)]
    public partial class GetStockPrice
    {

        private string stockNameField;

        /// <remarks/>
        public string StockName
        {
            get
            {
                return this.stockNameField;
            }
            set
            {
                this.stockNameField = value;
            }
        }
    }


}
