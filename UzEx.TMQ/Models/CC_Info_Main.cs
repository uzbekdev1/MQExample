using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzEx.TMQ.Models
{

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false, ElementName = "Info_Main")]
    public partial class CC_Info_Main
    {

        private System.DateTime info_DateField;

        private Info_MainImportData[] importDataField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime Info_Date
        {
            get
            {
                return this.info_DateField;
            }
            set
            {
                this.info_DateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ImportData")]
        public Info_MainImportData[] ImportData
        {
            get
            {
                return this.importDataField;
            }
            set
            {
                this.importDataField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Info_MainImportData
    {

        private string exprtData_IDField;

        private Info_MainImportDataConsignee consigneeField;

        private Info_MainImportDataTransport transportField;

        private byte customs_ModeField;

        private uint docNumberField;

        private ushort custCodeField;

        private System.DateTime docDateField;

        private string place_of_inspectionField;

        private Info_MainImportDataGoods[] goodsField;

        /// <remarks/>
        public string ExprtData_ID
        {
            get
            {
                return this.exprtData_IDField;
            }
            set
            {
                this.exprtData_IDField = value;
            }
        }

        /// <remarks/>
        public Info_MainImportDataConsignee Consignee
        {
            get
            {
                return this.consigneeField;
            }
            set
            {
                this.consigneeField = value;
            }
        }

        /// <remarks/>
        public Info_MainImportDataTransport Transport
        {
            get
            {
                return this.transportField;
            }
            set
            {
                this.transportField = value;
            }
        }

        /// <remarks/>
        public byte Customs_Mode
        {
            get
            {
                return this.customs_ModeField;
            }
            set
            {
                this.customs_ModeField = value;
            }
        }

        /// <remarks/>
        public uint DocNumber
        {
            get
            {
                return this.docNumberField;
            }
            set
            {
                this.docNumberField = value;
            }
        }

        /// <remarks/>
        public ushort CustCode
        {
            get
            {
                return this.custCodeField;
            }
            set
            {
                this.custCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DocDate
        {
            get
            {
                return this.docDateField;
            }
            set
            {
                this.docDateField = value;
            }
        }

        /// <remarks/>
        public string Place_of_inspection
        {
            get
            {
                return this.place_of_inspectionField;
            }
            set
            {
                this.place_of_inspectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Goods")]
        public Info_MainImportDataGoods[] Goods
        {
            get
            {
                return this.goodsField;
            }
            set
            {
                this.goodsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Info_MainImportDataConsignee
    {

        private string nameField;

        private string adressField;

        private uint iNNField;

        private uint oKPOField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string Adress
        {
            get
            {
                return this.adressField;
            }
            set
            {
                this.adressField = value;
            }
        }

        /// <remarks/>
        public uint INN
        {
            get
            {
                return this.iNNField;
            }
            set
            {
                this.iNNField = value;
            }
        }

        /// <remarks/>
        public uint OKPO
        {
            get
            {
                return this.oKPOField;
            }
            set
            {
                this.oKPOField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Info_MainImportDataTransport
    {

        private byte borderTrans_CodeField;

        private byte internalTrans_CodeField;

        /// <remarks/>
        public byte BorderTrans_Code
        {
            get
            {
                return this.borderTrans_CodeField;
            }
            set
            {
                this.borderTrans_CodeField = value;
            }
        }

        /// <remarks/>
        public byte InternalTrans_Code
        {
            get
            {
                return this.internalTrans_CodeField;
            }
            set
            {
                this.internalTrans_CodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Info_MainImportDataGoods
    {

        private ulong hS_CodeField;

        private string nameField;

        private byte countryOriginField;

        private byte unitQuantityCodeField;

        private decimal amountField;

        private decimal quantitySupUnitField;

        private decimal quantityField;

        private object edizmField;

        /// <remarks/>
        public ulong HS_Code
        {
            get
            {
                return this.hS_CodeField;
            }
            set
            {
                this.hS_CodeField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public byte CountryOrigin
        {
            get
            {
                return this.countryOriginField;
            }
            set
            {
                this.countryOriginField = value;
            }
        }

        /// <remarks/>
        public byte UnitQuantityCode
        {
            get
            {
                return this.unitQuantityCodeField;
            }
            set
            {
                this.unitQuantityCodeField = value;
            }
        }

        /// <remarks/>
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        public decimal QuantitySupUnit
        {
            get
            {
                return this.quantitySupUnitField;
            }
            set
            {
                this.quantitySupUnitField = value;
            }
        }

        /// <remarks/>
        public decimal Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        public object Edizm
        {
            get
            {
                return this.edizmField;
            }
            set
            {
                this.edizmField = value;
            }
        }
    }
     
}
