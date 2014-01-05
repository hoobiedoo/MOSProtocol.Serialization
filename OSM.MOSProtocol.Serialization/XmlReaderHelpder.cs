using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Diagnostics;

namespace OSM.MOSProtocol.Serialization
{
     
    public class XmlReaderHelper
    {
        /// <summary>
        /// Reads the xml until it finds a matching Element Name.
        /// Once found it will return the value.
        /// This is only good for peeking for the first element name in the document 
        /// and will not be useful for documents that contain child elements with the same name.
        /// </summary>
        /// <param name="xml"></param>
        /// <param name="ElementName"></param>
        /// <returns>value of the element</returns>
        public static string GetElementValueFromXml(string xml, string ElementName)
        {
            string result = string.Empty;
            MemoryStream ms = new MemoryStream(new System.Text.UTF8Encoding().GetBytes(xml));
            return GetElementValueFromXml(ms, ElementName);
        }

        /// <summary>
        /// Reads the xml until it finds a matching Element Name.
        /// Once found it will return the value.
        /// This is only good for peeking for the first element name in the document 
        /// and will not be useful for documents that contain child elements with the same name.
        /// </summary>
        /// <param name="xml"></param>
        /// <param name="ElementName"></param>
        /// <returns>value of the element</returns>
        public static string GetElementValueFromXml(Stream stream, string ElementName)
        {
            string result = string.Empty;
            bool boolFound = false;
            XmlReader reader = XmlReader.Create(stream);
            while (reader.Read() && result == string.Empty)
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        //Debug.WriteLine("Name:" + reader.Name);
                        if (reader.Name == ElementName)
                        {
                            boolFound = true;
                        }
                        break;
                    case XmlNodeType.Text:
                        if (boolFound)
                        {
                            result = reader.Value;
                        }
                        break;
                }
            }
            //reset stream position.
            stream.Position = 0;
            return result;
        }

        public static XmlNode GetXmlNodeFromXml(string Xml, string xPath)
        {
            XmlNode n = null;
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(Xml);
            n = doc.SelectSingleNode(xPath);

            return n;
        }

        public static string GetStringValueFromXml(string Xml, string xPath)
        {
            string s = string.Empty;
            if (!string.IsNullOrEmpty(Xml) && !string.IsNullOrEmpty(xPath))
            {
                XmlNode n = GetXmlNodeFromXml(Xml, xPath);
                if (n != null)
                    s = n.InnerText;
            }
            return  s;
        }

        public static void SetValueForXPath(ref string Xml, string xPath, string NewValue)
        {
                XmlNode n = null;
                XmlDocument doc = new XmlDocument();

            if (!string.IsNullOrEmpty(Xml) && !string.IsNullOrEmpty(xPath))
            {
                doc = new XmlDocument();
                doc.LoadXml(Xml);
                n = doc.SelectSingleNode(xPath);
                if (n != null)
                    n.InnerText = NewValue;
            }

            if (doc != null)
                Xml = doc.OuterXml;
            
        }

        /// <summary>
        /// Formats the provided XML so it's indented and humanly-readable.
        /// </summary>
        /// <param name="inputXml">The input XML to format.</param>
        /// <returns></returns>
        public static string FormatXml(string inputXml)
        {
            StringBuilder builder = new StringBuilder();            
            try
            {
                XmlDocument document = new XmlDocument();
                document.Load(new StringReader(inputXml));

                using (XmlTextWriter writer = new XmlTextWriter(new StringWriter(builder)))
                {
                    writer.Formatting = Formatting.Indented;
                    document.Save(writer);
                }
            }
            catch
            {
                builder.Append(inputXml);
            }

            return builder.ToString();
        }

    }
}
