
namespace OSM.MOSProtocol.Messages.MOS_2_8_2
{
    using System.Xml.Serialization;
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum runContext
    {

        /// <remarks/>
        BROWSE,

        /// <remarks/>
        EDIT,

        /// <remarks/>
        CREATE,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum mode
    {

        /// <remarks/>
        MODALDIALOG,

        /// <remarks/>
        MODELESS,

        /// <remarks/>
        CONTAINED,

        /// <remarks/>
        TOOLBAR,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ncsAppInfo
    {

        /// <remarks/>
        public mosObj mosObj;

        /// <remarks/>
        public string roID;

        /// <remarks/>
        public string storyID;

        /// <remarks/>
        public item item;

        /// <remarks/>
        public ncsInformation ncsInformation;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ncsInformation
    {

        /// <remarks/>
        public string userID;

        /// <remarks/>
        public runContext runContext;

        /// <remarks/>
        public software software;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UImetric")]
        public UImetric[] UImetric;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class UImetric
    {

        /// <remarks/>
        public int startx;

        /// <remarks/>
        public int starty;

        /// <remarks/>
        public string endx;

        /// <remarks/>
        public string endy;

        /// <remarks/>
        public mode mode;

        /// <remarks/>
        public bool canClose;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool canCloseSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string num;
    }
}
