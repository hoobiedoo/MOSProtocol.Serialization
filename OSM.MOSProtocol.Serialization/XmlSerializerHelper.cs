//------------------------------------------------------------------------------
//     6/20/2009
//     This code was authored by Robb J. Regan 
//     
//     It cotains helper methods for  deserialization and serialization XML. 
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace OSM.MOSProtocol.Serialization
{ 
    public class XmlSerializerHelper
    {

        public static XmlSerializerNamespaces GetBlankNamespace()
        {
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add(string.Empty, string.Empty);
            return ns;
        }

        public static void SerializeToStream(object obj, Stream stream)
        {
            SerializeToStream(obj, stream, null, false);
        }

        public static void SerializeToStream(object obj, Stream stream, XmlSerializerNamespaces namespaces, bool omitXmlDeclaration)
        {
            XmlSerializer serializer = new XmlSerializer(obj.GetType());
            XmlWriterSettings settings = new XmlWriterSettings()
                {
                    OmitXmlDeclaration = omitXmlDeclaration,
                    Indent = true,
                    IndentChars = "\t",
                    Encoding = Encoding.UTF8
                };
            XmlWriter xmlWriter = XmlWriter.Create(stream, settings);

            serializer.Serialize(xmlWriter, obj, namespaces);
        }

        public static string SerializeToString(object obj)
        {
            return SerializeToString(obj, null, false);
        }

		public static string SerializeToString(object obj, XmlSerializerNamespaces namespaces, bool omitXmlDeclaration)
        {
            using (MemoryStream mem = new MemoryStream())
            {
                SerializeToStream(obj, mem, namespaces, omitXmlDeclaration);
                mem.Position = 0;
                return (new StreamReader(mem)).ReadToEnd();
            }
        }

		public static string SerializeToString(object obj, XmlSerializerNamespaces namespaces, bool omitXmlDeclaration, bool StripNamspaces)
		{
			using (MemoryStream mem = new MemoryStream())
			{
				SerializeToStream(obj, mem, namespaces, omitXmlDeclaration);
				mem.Position = 0;
				string Result = (new StreamReader(mem)).ReadToEnd();
				return StripNamespaceAttributes(Result);
			}
		}

		public static void SerializeToFile(object obj, string file, FileMode fileMode)
        {
            SerializeToFile(obj, file, fileMode, null, false);
        }

        public static void SerializeToFile(object obj, string file, FileMode fileMode, XmlSerializerNamespaces namespaces, bool omitXmlDeclaration)
        {
            using (FileStream fileStream = new FileStream(file, fileMode))
            {
                SerializeToStream(obj, fileStream, namespaces, omitXmlDeclaration);
            }
        }

		public static string StripNamespaceAttributes(string InputXML)
		{
			const string XMLNSDeletePattern = "xmlns(.*)=\".*\"";

			string Result = Regex.Replace(
				InputXML,
				XMLNSDeletePattern,
				string.Empty,
				RegexOptions.IgnoreCase | RegexOptions.Multiline
				);

			return (Result);
		}

        public static object DeserializeFromString(Type objType, string xml)
        {
            XmlSerializer serializer = new XmlSerializer(objType);
            using (StringReader reader = new StringReader(xml))
            {
                return serializer.Deserialize(reader);
            }
        }

        public static object DeserializeFromStream(Type objType, Stream stream)
        {
            XmlSerializer serializer = new XmlSerializer(objType);
            using (StreamReader reader = new StreamReader(stream))
            {
                return serializer.Deserialize(reader);
            }
        }

        public static object DeserializeFromFile(Type objType, string file)
        {
            XmlSerializer serializer = new XmlSerializer(objType);
            using (StreamReader reader = new StreamReader(file, Encoding.UTF8))
            {
                return serializer.Deserialize(reader);
            }
        }

    }
}
