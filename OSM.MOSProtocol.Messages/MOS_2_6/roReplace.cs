﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=2.0.50727.1432.
// 
namespace OSM.MOSProtocol.Messages.MOS_2_6
{
    using System.Xml.Serialization;
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class roReplace
    {

        /// <remarks/>
        public string roID;

        /// <remarks/>
        public string roSlug;

        /// <remarks/>
        public string roChannel;

        /// <remarks/>
        public System.String roEdStart;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool roEdStartSpecified;

        /// <remarks/>
         
        public string roEdDur;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool roEdDurSpecified;

        /// <remarks/>
        public string roTrigger;

        /// <remarks/>
        public string macroIn;

        /// <remarks/>
        public string macroOut;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mosExternalMetadata")]
        public mosExternalMetadata[] mosExternalMetadata;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("story")]
        public story[] story;
    }
}