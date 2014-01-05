using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml;
using OSM.Core;

namespace OSM.Core.MOS.Protocol
{
    class MOSDerserializeHelper
    {
        #region determine which version to derserailze the xml to

        /// <summary>
        /// When a MOS server is communicating with our application we will need
        /// to know the version that mosID is configured for inorder to load the correct version
        /// </summary>
        public static string GetMosIDFromMOSMsg(string xml)
        {
            XmlReader reader = new XmlReader(xml);
            while (reader.Read())
            {
                // Move to fist element
                reader.MoveToElement();
                // Read this element's properties and display them on console
                Console.WriteLine("Name:" + reader.Name);
                if (reader.Name == "mosID")
                {
                    return reader.Value;
                }
            }
        }

        /// <summary>
        /// When a NCS server is communicating with our application we will need
        /// to know the version that ncsID is configured for inorder to load the correct version
        /// </summary>
        public static string GetNcsIDFromMOSMsg(string xml)
        {
            string result = string.Empty;
            XmlReader reader = new XmlReader(xml);
            while (reader.Read())
            {
                // Move to fist element
                reader.MoveToElement();
                // Read this element's properties and display them on console
                Console.WriteLine("Name:" + reader.Name);
                if (reader.Name == "ncsID")
                {
                    result = reader.Value;
                    break;
                }
            }
            return result;
        }

        /// <summary>
        /// When a MOS server is communicating with our application we will need
        /// to know the version that mosID is configured for inorder to load the correct version
        /// </summary>
        public static string GetMosIDFromMOSMsg(Stream stream)
        {
            string result = string.Empty;
            XmlReader reader = new XmlReader(stream);
            while (reader.Read())
            {
                // Move to fist element
                reader.MoveToElement();
                // Read this element's properties and display them on console
                Console.WriteLine("Name:" + reader.Name);
                if (reader.Name == "mosID")
                {
                    result = reader.Value;
                    break;
                }
            }
            return result;
        }

        /// <summary>
        /// When a NCS server is communicating with our application we will need
        /// to know the version that ncsID is configured for inorder to load the correct version
        /// </summary>
        public static string GetNcsIDFromMOSMsg(Stream stream)
        {
            string result = string.Empty;
            XmlReader reader = new XmlReader(stream);
            while (reader.Read())
            {
                // Move to fist element
                reader.MoveToElement();
                // Read this element's properties and display them on console
                Console.WriteLine("Name:" + reader.Name);
                if (reader.Name == "ncsID")
                {
                    result = reader.Value;
                    break;
                }
            }
            return result;
        }

        /// <summary>
        /// When a MOS server is communicating with our application we will need
        /// to know the version that mosID is configured for inorder to load the correct version
        /// </summary>
        public static object DeserializeFromMosID(Stream stream, out Type type)
        {
            string mosID = GetMosIDFromMOSMsg(stream);
            type = GetMOSObjectTypeByMosID(mosID);
            XmlSerializerHelper.DeserializeFromStream(type, stream);

        }

        /// <summary>
        /// When a NCS server is communicating with our application we will need
        /// to know the version that ncsID is configured for inorder to load the correct version
        /// </summary>
        public static object DeserializeFromFromNcsID(Stream stream, out Type type)
        {
            string ncsID = GetNcsIDFromMOSMsg(stream);
            type = GetMOSObjectTypeByNcsID(ncsID);
            XmlSerializerHelper.DeserializeFromStream(type, stream);
        }

        /// <summary>
        /// When a MOS server is communicating with our application we will need
        /// to know the version that mosID is configured for inorder to return the correct MOS Object Type
        /// </summary>
        public static Type GetMOSObjectTypeByMosID(string mosID)
        {
            Type type = null;
            //lookup the MOS version for this mosID in the DB
            //here we will mock something up
            switch (mosID)
            {
                case "DEV.OSM.01.MOS":
                    type = typeof(OSM.MOSProtocol.Messages.MOS_2_5);
                    break;
                case "DEV.OSM.02.MOS":
                    type = typeof(OSM.MOSProtocol.Messages.MOS_2_6);
                    break;
                case "DEV.OSM.03.MOS":
                    type = typeof(OSM.MOSProtocol.Messages.MOS_2_8);
                    break;
                case "DEV.OSM.04.MOS":
                    type = typeof(OSM.MOSProtocol.Messages.MOS_2_8_1);
                    break;
                case "DEV.OSM.05.MOS":
                    type = typeof(OSM.MOSProtocol.Messages.MOS_2_8_2);
                    break;
                case "DEV.OSM.06.MOS":
                    type = typeof(OSM.MOSProtocol.Messages.MOS_2_8_3);
                    break;
            }

            return type;
        }

        /// <summary>
        /// When a NCS server is communicating with our application we will need
        /// to know the version that ncsID is configured for inorder to load the correct MOS Object Type
        /// </summary>
        public static Type GetMOSObjectTypeByNcsID(string ncsID)
        {
            Type type = null;
            //lookup the MOS version for this ncsID in the DB
            //here we will mock something up
            switch (ncsID)
            {
                case "DEV.OSM.01.NCS":
                    type = typeof(OSM.MOSProtocol.Messages.MOS_2_5);
                    break;
                case "DEV.OSM.02.NCS":
                    type = typeof(OSM.MOSProtocol.Messages.MOS_2_6);
                    break;
                case "DEV.OSM.03.NCS":
                    type = typeof(OSM.MOSProtocol.Messages.MOS_2_8);
                    break;
                case "DEV.OSM.04.NCS":
                    type = typeof(OSM.MOSProtocol.Messages.MOS_2_8_1);
                    break;
                case "DEV.OSM.05.NCS":
                    type = typeof(OSM.MOSProtocol.Messages.MOS_2_8_2);
                    break;
                case "DEV.OSM.06.NCS":
                    type = typeof(OSM.MOSProtocol.Messages.MOS_2_8_3);
                    break;
            }

            return type;
        }

    #endregion
    
        #region Deserialize MOS xml to object 
        public void Deserialize(Type type, string xml)
        {
            XmlSerializerHelper.DeserializeFromString(type, xml);
        }
        
        public void Deserialize(Type type, Stream stream)
        {
            XmlSerializerHelper.DeserializeFromStream(type, stream);
        }

    #endregion

    }
}
