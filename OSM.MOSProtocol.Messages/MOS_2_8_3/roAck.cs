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
namespace OSM.MOSProtocol.Messages.MOS_2_8_3
{
    using System.Xml.Serialization;

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class roAck
    {

        /// <remarks/>
        public string roID;

        /// <remarks/>
        public string roStatus;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("storyID")]
        public string[] storyID;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("itemID")]
        public string[] itemID;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("objID")]
        public string[] objID;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("itemChannel")]
        public string[] itemChannel;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("status")]
        public string[] status;
    }
}