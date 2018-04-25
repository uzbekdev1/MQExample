
namespace UzEx.TMQ.Models
{

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false, ElementName = "Result")]
    public partial class TResult
    {

        private string info_Result_DateField;

        private ResultResult_ImportData[] result_ImportDataField;

        /// <remarks/>
        public string Info_Result_Date
        {
            get
            {
                return this.info_Result_DateField;
            }
            set
            {
                this.info_Result_DateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Result_ImportData")]
        public ResultResult_ImportData[] Result_ImportData
        {
            get
            {
                return this.result_ImportDataField;
            }
            set
            {
                this.result_ImportDataField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResultResult_ImportData
    {

        private string idField;

        private string receive_timeField;

        private ushort docNumberField;

        private ushort custCodeField;

        private System.DateTime docDateField;

        private string errorField;

        /// <remarks/>
        public string ID
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

        /// <remarks/>
        public string Receive_time
        {
            get
            {
                return this.receive_timeField;
            }
            set
            {
                this.receive_timeField = value;
            }
        }

        /// <remarks/>
        public ushort DocNumber
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
        public string Error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }
    }


}
