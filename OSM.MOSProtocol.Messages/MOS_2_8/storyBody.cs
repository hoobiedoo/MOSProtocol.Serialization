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
namespace OSM.MOSProtocol.Messages.MOS_2_8
{
    using System.Xml.Serialization;

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class storyBody
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("p", typeof(p))]
        [System.Xml.Serialization.XmlElementAttribute("storyItem", typeof(storyItem))]
        [System.Xml.Serialization.XmlElementAttribute("storyPresenter", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("storyPresenterRR", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType3[] ItemsElementName;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text;
    }
}