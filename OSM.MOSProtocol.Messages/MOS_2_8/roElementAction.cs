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
    public partial class roElementAction
    {

        /// <remarks/>
        public string roID;

        /// <remarks/>
        public element_target element_target;

        /// <remarks/>
        public element_source element_source;


        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public roElementActionOperation operation;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum roElementActionOperation
    {

        /// <remarks/>
        INSERT,

        /// <remarks/>
        REPLACE,

        /// <remarks/>
        MOVE,

        /// <remarks/>
        DELETE,
    }
}