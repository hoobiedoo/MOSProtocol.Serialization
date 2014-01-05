//------------------------------------------------------------------------------
//     2/25/2011
//     This code was authored by Robb J. Regan 
//     
//     It asserts the deserialization and serialization of ALL the current MOS 
//     Profiles.  It is split up by NCS and MOS generated messages and relies on 
//     the messages found in the TestMessages directory.
//------------------------------------------------------------------------------
using OSM.MOSProtocol.Serialization;
using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using OSM.MOSProtocol.Messages;

namespace OSM.MOSProtocol.Serialization.Nunit
{
    
    
    /// <summary>
    ///This is a test class for MOSMessageReaderTest and is intended
    ///to contain all MOSMessageReaderTest Unit Tests
    ///</summary>
     [TestClass]
    public class MOSMessageReaderTest
    {
        /// <summary>
        ///A test for Deserialize From Ncs Inbound Messages
        ///</summary>
        [TestMethod]
        public void DeserializeFromNcsInboundMessagesTest()
        {
            string xml = String.Empty;
            Stream stream = null; // TODO: Initialize to an appropriate value
             
            object mos = null;

            #region mosReqObjList

            //*********************
            //mosReqObjList 2.8.1
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_1\mosReqObjList.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            mosReqObjListAsserts((Messages.MOS_2_8_1.mos)mos);


           

            //*********************
            //mosReqObjList 2.8.2
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_2\mosReqObjList.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            mosReqObjListAsserts((Messages.MOS_2_8_2.mos)mos);


           


            //*********************
            //mosReqObjList 2.8.3
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_3\mosReqObjList.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos),  stream);

            Console.Write(mos.GetType().ToString());
            mosReqObjListAsserts((Messages.MOS_2_8_3.mos)mos);


           
            #endregion 

            #region roListAll
            //*********************
            //roListAll - 2.5
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_5\roListAll.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);
           

            Console.Write(mos.GetType().ToString());
            roListAllAsserts((Messages.MOS_2_5.mos)mos);


            //*********************
            //roListAll 2.6
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_6\roListAll.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roListAllAsserts((Messages.MOS_2_6.mos)mos);

           

            //*********************
            //roListAll 2.8
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8\roListAll.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roListAllAsserts((Messages.MOS_2_8.mos)mos);


           

            //*********************
            //roListAll 2.8.1
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_1\roListAll.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roListAllAsserts((Messages.MOS_2_8_1.mos)mos);


           

            //*********************
            //roListAll 2.8.2
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_2\roListAll.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roListAllAsserts((Messages.MOS_2_8_2.mos)mos);


           


            //*********************
            //roListAll 2.8.3
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_3\roListAll.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roListAllAsserts((Messages.MOS_2_8_3.mos)mos);


           
            #endregion

            #region roList
            //*********************
            //roList - 2.5
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_5\roList.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

           

            Console.Write(mos.GetType().ToString());
            roListAsserts((Messages.MOS_2_5.mos)mos);


            //*********************
            //roList 2.6
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_6\roList.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roListAsserts((Messages.MOS_2_6.mos)mos);

           

            //*********************
            //roList 2.8
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8\roList.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roListAsserts((Messages.MOS_2_8.mos)mos);


           

            //*********************
            //roList 2.8.1
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_1\roList.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roListAsserts((Messages.MOS_2_8_1.mos)mos);


           

            //*********************
            //roList 2.8.2
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_2\roList.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roListAsserts((Messages.MOS_2_8_2.mos)mos);


           


            //*********************
            //roList 2.8.3
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_3\roList.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roListAsserts((Messages.MOS_2_8_3.mos)mos);


           
            #endregion

            #region roCreates
            //*********************
            //roCreate - 2.5
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_5\roCreate.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roCreateAsserts((Messages.MOS_2_5.mos)mos);

            
           

            //*********************
            //roCreate 2.6
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_6\roCreate.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roCreateAsserts((Messages.MOS_2_6.mos)mos);

            
           

            //*********************
            //roCreate 2.8
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8\roCreate.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roCreateAsserts((Messages.MOS_2_8.mos)mos);

            
           

            //*********************
            //roCreate 2.8.1
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_1\roCreate.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roCreateAsserts((Messages.MOS_2_8_1.mos)mos);

            
           

            //*********************
            //roCreate 2.8.2
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_2\roCreate.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roCreateAsserts((Messages.MOS_2_8_2.mos)mos);

            
           


            //*********************
            //roCreate 2.8.3
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_3\roCreate.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roCreateAsserts((Messages.MOS_2_8_3.mos)mos);

            
           
            #endregion

            #region roStorySends

            //*********************
            //roStorySend 2.5
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_5\roStorySend.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roStorySendAsserts((Messages.MOS_2_5.mos)mos);

            
           

            //*********************
            //roStorySend 2.6
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_6\roStorySend.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roStorySendAsserts((Messages.MOS_2_6.mos)mos);

            
           

            //*********************
            //roStorySend 2.8
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8\roStorySend.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roStorySendAsserts((Messages.MOS_2_8.mos)mos);

            
           

            //*********************
            //roStorySend 2.8.1
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_1\roStorySend.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roStorySendAsserts((Messages.MOS_2_8_1.mos)mos);

            
           

            //*********************
            //roStorySend 2.8.2
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_2\roStorySend.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roStorySendAsserts((Messages.MOS_2_8_2.mos)mos);

            
           


            //*********************
            //roStorySend 2.8.3
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_3\roStorySend.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roStorySendAsserts((Messages.MOS_2_8_3.mos)mos);

            
           
            #endregion

            #region roStoryReplace
            //*********************
            //roStoryReplace 2.5
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_5\roStoryReplace.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roStoryReplaceAsserts((Messages.MOS_2_5.mos)mos);

            
           


            //*********************
            //roStoryReplace 2.6
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_6\roStoryReplace.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roStoryReplaceAsserts((Messages.MOS_2_6.mos)mos);

            
           

            //*********************
            //roElementAction-Replace 2.8
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8\roElementAction-Replace.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roStoryReplaceAsserts((Messages.MOS_2_8.mos)mos);

            
           

            //*********************
            //roElementAction-Replace 2.8.1
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_1\roElementAction-Replace.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roElementActionReplaceAsserts((Messages.MOS_2_8_1.mos)mos);

            
           

            //*********************
            //roElementAction-Replace 2.8.2
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_2\roElementAction-Replace.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roElementActionReplaceAsserts((Messages.MOS_2_8_2.mos)mos);

            
           


            //*********************
            //roElementAction-Replace 2.8.3
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_3\roElementAction-Replace.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roElementActionReplaceAsserts((Messages.MOS_2_8_3.mos)mos);

            
           
            #endregion

            #region roStoryAppend
            //*********************
            //roStoryAppend 2.5
            //*********************
              xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_5\roStoryAppend.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roStoryAppendAsserts((Messages.MOS_2_5.mos)mos);
 
           

            //*********************
            //roStoryAppend 2.6
            //*********************
             xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_6\roStoryAppend.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roStoryAppendAsserts((Messages.MOS_2_6.mos)mos);
 
           

            //*********************
            //roElementActionInsert-Append 2.8
            //*********************
              xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8\roElementAction-Insert-Append.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roElementActionInsertAppendAsserts((Messages.MOS_2_8.mos)mos);
 
           

            //*********************
            //roElementActionInsert-Append 2.8.1
            //*********************
             xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_1\roElementAction-Insert-Append.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roElementActionInsertAppendAsserts((Messages.MOS_2_8_1.mos)mos);
 
           

            //*********************
            //roElementActionInsert-Append 2.8.2
            //*********************
              xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_2\roElementAction-Insert-Append.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roElementActionInsertAppendAsserts((Messages.MOS_2_8_2.mos)mos);
 
           


            //*********************
            //roElementActionInsert-Append 2.8.3
            //*********************
              xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_3\roElementAction-Insert-Append.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roElementActionInsertAppendAsserts((Messages.MOS_2_8_3.mos)mos);
 
           
            #endregion

            #region roStoryDelete
            //*********************
            //roStoryDelete 2.5
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_5\roStoryDelete.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roStoryDeleteAsserts((Messages.MOS_2_5.mos)mos);

            
           

            //*********************
            //roStoryDelete 2.6
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_6\roStoryDelete.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roStoryDeleteAsserts((Messages.MOS_2_6.mos)mos);

            
           

            //*********************
            //ElementAction-Delete 2.8
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8\roElementAction-Delete.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            ElementActionDeleteAsserts((Messages.MOS_2_8.mos)mos);

            
           

            //*********************
            //ElementAction-Delete 2.8.1
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_1\roElementAction-Delete.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            ElementActionDeleteAsserts((Messages.MOS_2_8_1.mos)mos);

            
           

            //*********************
            //ElementAction-Delete 2.8.2
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_2\roElementAction-Delete.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            ElementActionDeleteAsserts((Messages.MOS_2_8_2.mos)mos);

            
           


            //*********************
            //ElementAction-Delete 2.8.3
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_3\roElementAction-Delete.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            ElementActionDeleteAsserts((Messages.MOS_2_8_3.mos)mos);

            
           
            #endregion

            #region roStoryInsert
            //*********************
            //roStoryInsert 2.5
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_5\roStoryInsert.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roStoryInsertAsserts((Messages.MOS_2_5.mos)mos);

            
           

            //*********************
            //roStoryInsert 2.6
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_6\roStoryInsert.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roStoryInsertAsserts((Messages.MOS_2_6.mos)mos);

            
           

            //*********************
            //roElementAction-Move.xml 2.8
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8\roElementAction-Move.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roElementActionMoveAssert((Messages.MOS_2_8.mos)mos);

            
           

            //*********************
            //roElementAction-Move.xml 2.8.1
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_1\roElementAction-Move.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roElementActionMoveAssert((Messages.MOS_2_8_1.mos)mos);

            
           

            //*********************
            //roElementAction-Move.xml 2.8.2
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_2\roElementAction-Move.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roElementActionMoveAssert((Messages.MOS_2_8_2.mos)mos);

            
           


            //*********************
            //roElementAction-Move.xml 2.8.3
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_3\roElementAction-Move.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roElementActionMoveAssert((Messages.MOS_2_8_3.mos)mos);

            
           
            #endregion

            #region roMetadataReplace
            //*********************
            //roReplace 2.5
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_5\roReplace.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roReplaceAsserts((Messages.MOS_2_5.mos)mos);

            
           

            //*********************
            //roMetadataReplace 2.6
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_6\roMetadataReplace.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roMetadataReplaceAsserts((Messages.MOS_2_6.mos)mos);

            
           

            //*********************
            //roMetadataReplace 2.8
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8\roMetadataReplace.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roMetadataReplaceAsserts((Messages.MOS_2_8.mos)mos);

            
           

            //*********************
            //roMetadataReplace 2.8.1
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_1\roMetadataReplace.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roMetadataReplaceAsserts((Messages.MOS_2_8_1.mos)mos);

            
           

            //*********************
            //roMetadataReplace 2.8.2
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_2\roMetadataReplace.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roMetadataReplaceAsserts((Messages.MOS_2_8_2.mos)mos);

            
           


            //*********************
            //roMetadataReplace 2.8.3
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_3\roMetadataReplace.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roMetadataReplaceAsserts((Messages.MOS_2_8_3.mos)mos);

            
           
            #endregion

            #region roReadyToAir
            //*********************
            //roReadyToAir - 2.5
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_5\roReadyToAir.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roReadyToAirAsserts((Messages.MOS_2_5.mos)mos);


           

            //*********************
            //roReadyToAir 2.6
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_6\roReadyToAir.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roReadyToAirAsserts((Messages.MOS_2_6.mos)mos);


           

            //*********************
            //roReadyToAir 2.8
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8\roReadyToAir.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roReadyToAirAsserts((Messages.MOS_2_8.mos)mos);


           

            //*********************
            //roReadyToAir 2.8.1
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_1\roReadyToAir.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roReadyToAirAsserts((Messages.MOS_2_8_1.mos)mos);


           

            //*********************
            //roReadyToAir 2.8.2
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_2\roReadyToAir.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roReadyToAirAsserts((Messages.MOS_2_8_2.mos)mos);


           


            //*********************
            //roReadyToAir 2.8.3
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_3\roReadyToAir.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roReadyToAirAsserts((Messages.MOS_2_8_3.mos)mos);


           
            #endregion
        }

        /// <summary>
        ///A test for Deserialize MOS Inbound Messages
        ///</summary>
        [TestMethod]
        public void DeserializeFromMosInboundMessagesTest()
        {
            string xml = String.Empty;
            Stream stream = null; // TODO: Initialize to an appropriate value
            object mos = null;

            #region mosReqObjList

            //*********************
            //mosReqObjList 2.8.1
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_1\mosReqObjList.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8_1.mos), stream);

            Console.Write(mos.GetType().ToString());
            mosReqObjListAsserts((Messages.MOS_2_8_1.mos)mos);


           

            //*********************
            //mosReqObjList 2.8.2
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_2\mosReqObjList.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8_2.mos), stream);

            Console.Write(mos.GetType().ToString());
            mosReqObjListAsserts((Messages.MOS_2_8_2.mos)mos);


           


            //*********************
            //mosReqObjList 2.8.3
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_3\mosReqObjList.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8_3.mos), stream);

            Console.Write(mos.GetType().ToString());
            mosReqObjListAsserts((Messages.MOS_2_8_3.mos)mos);


           
            #endregion

            #region roListAll
            //*********************
            //roListAll - 2.5
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_5\roListAll.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);
           

            Console.Write(mos.GetType().ToString());
            roListAllAsserts((Messages.MOS_2_5.mos)mos);


            //*********************
            //roListAll 2.6
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_6\roListAll.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_6.mos), stream);

            Console.Write(mos.GetType().ToString());
            roListAllAsserts((Messages.MOS_2_6.mos)mos);

           

            //*********************
            //roListAll 2.8
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8\roListAll.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8.mos), stream);

            Console.Write(mos.GetType().ToString());
            roListAllAsserts((Messages.MOS_2_8.mos)mos);


           

            //*********************
            //roListAll 2.8.1
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_1\roListAll.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8_1.mos), stream);

            Console.Write(mos.GetType().ToString());
            roListAllAsserts((Messages.MOS_2_8_1.mos)mos);


           

            //*********************
            //roListAll 2.8.2
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_2\roListAll.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8_2.mos), stream);

            Console.Write(mos.GetType().ToString());
            roListAllAsserts((Messages.MOS_2_8_2.mos)mos);


           


            //*********************
            //roListAll 2.8.3
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_3\roListAll.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8_3.mos), stream);

            Console.Write(mos.GetType().ToString());
            roListAllAsserts((Messages.MOS_2_8_3.mos)mos);


           
            #endregion

            #region roList
            //*********************
            //roList - 2.5
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_5\roList.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            Console.WriteLine(xml);
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

           

            Console.Write(mos.GetType().ToString());
            roListAsserts((Messages.MOS_2_5.mos)mos);


            //*********************
            //roList 2.6
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_6\roList.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_6.mos), stream);

            Console.Write(mos.GetType().ToString());
            roListAsserts((Messages.MOS_2_6.mos)mos);

           

            //*********************
            //roList 2.8
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8\roList.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8.mos), stream);

            Console.Write(mos.GetType().ToString());
            roListAsserts((Messages.MOS_2_8.mos)mos);


           

            //*********************
            //roList 2.8.1
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_1\roList.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8_1.mos), stream);

            Console.Write(mos.GetType().ToString());
            roListAsserts((Messages.MOS_2_8_1.mos)mos);


           

            //*********************
            //roList 2.8.2
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_2\roList.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8_2.mos), stream);

            Console.Write(mos.GetType().ToString());
            roListAsserts((Messages.MOS_2_8_2.mos)mos);


           


            //*********************
            //roList 2.8.3
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_3\roList.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8_3.mos), stream);

            Console.Write(mos.GetType().ToString());
            roListAsserts((Messages.MOS_2_8_3.mos)mos);


           
            #endregion

            #region roCreates
            //*********************
            //roCreate - 2.5
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_5\roCreate.xml");
           
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roCreateAsserts((Messages.MOS_2_5.mos)mos);

           

            //*********************
            //roCreate 2.6
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_6\roCreate.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_6.mos), stream);

            Console.Write(mos.GetType().ToString());
            roCreateAsserts((Messages.MOS_2_6.mos)mos);

            
           

            //*********************
            //roCreate 2.8
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8\roCreate.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8.mos), stream);

            Console.Write(mos.GetType().ToString());
            roCreateAsserts((Messages.MOS_2_8.mos)mos);

            
           

            //*********************
            //roCreate 2.8.1
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_1\roCreate.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8_1.mos), stream);

            Console.Write(mos.GetType().ToString());
            roCreateAsserts((Messages.MOS_2_8_1.mos)mos);

            
           

            //*********************
            //roCreate 2.8.2
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_2\roCreate.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8_2.mos), stream);

            Console.Write(mos.GetType().ToString());
            roCreateAsserts((Messages.MOS_2_8_2.mos)mos);

            
           


            //*********************
            //roCreate 2.8.3
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_3\roCreate.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8_3.mos), stream);

            Console.Write(mos.GetType().ToString());
            roCreateAsserts((Messages.MOS_2_8_3.mos)mos);

            
           
            #endregion

            #region roStorySends

            //*********************
            //roStorySend 2.5
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_5\roStorySend.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roStorySendAsserts((Messages.MOS_2_5.mos)mos);

            
           

            //*********************
            //roStorySend 2.6
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_6\roStorySend.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_6.mos), stream);

            Console.Write(mos.GetType().ToString());
            roStorySendAsserts((Messages.MOS_2_6.mos)mos);

            
           

            //*********************
            //roStorySend 2.8
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8\roStorySend.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8.mos), stream);

            Console.Write(mos.GetType().ToString());
            roStorySendAsserts((Messages.MOS_2_8.mos)mos);

            
           

            //*********************
            //roStorySend 2.8.1
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_1\roStorySend.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8_1.mos), stream);

            Console.Write(mos.GetType().ToString());
            roStorySendAsserts((Messages.MOS_2_8_1.mos)mos);

            
           

            //*********************
            //roStorySend 2.8.2
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_2\roStorySend.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8_2.mos), stream);

            Console.Write(mos.GetType().ToString());
            roStorySendAsserts((Messages.MOS_2_8_2.mos)mos);

            
           


            //*********************
            //roStorySend 2.8.3
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_3\roStorySend.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8_3.mos), stream);

            Console.Write(mos.GetType().ToString());
            roStorySendAsserts((Messages.MOS_2_8_3.mos)mos);

            
           
            #endregion

            #region roStoryReplace
            //*********************
            //roStoryReplace 2.5
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_5\roStoryReplace.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roStoryReplaceAsserts((Messages.MOS_2_5.mos)mos);

            
           


            //*********************
            //roStoryReplace 2.6
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_6\roStoryReplace.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_6.mos), stream);

            Console.Write(mos.GetType().ToString());
            roStoryReplaceAsserts((Messages.MOS_2_6.mos)mos);

            
           

            //*********************
            //roElementAction-Replace 2.8
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8\roElementAction-Replace.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8.mos), stream);

            Console.Write(mos.GetType().ToString());
            roStoryReplaceAsserts((Messages.MOS_2_8.mos)mos);

            
           

            //*********************
            //roElementAction-Replace 2.8.1
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_1\roElementAction-Replace.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8_1.mos), stream);

            Console.Write(mos.GetType().ToString());
            roElementActionReplaceAsserts((Messages.MOS_2_8_1.mos)mos);

            
           

            //*********************
            //roElementAction-Replace 2.8.2
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_2\roElementAction-Replace.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8_2.mos), stream);

            Console.Write(mos.GetType().ToString());
            roElementActionReplaceAsserts((Messages.MOS_2_8_2.mos)mos);

            
           


            //*********************
            //roElementAction-Replace 2.8.3
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_3\roElementAction-Replace.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8_3.mos), stream);

            Console.Write(mos.GetType().ToString());
            roElementActionReplaceAsserts((Messages.MOS_2_8_3.mos)mos);

            
           
            #endregion

            #region roStoryAppend
            //*********************
            //roStoryAppend 2.5
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_5\roStoryAppend.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roStoryAppendAsserts((Messages.MOS_2_5.mos)mos);

            
           

            //*********************
            //roStoryAppend 2.6
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_6\roStoryAppend.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_6.mos), stream);

            Console.Write(mos.GetType().ToString());
            roStoryAppendAsserts((Messages.MOS_2_6.mos)mos);

            
           

            //*********************
            //roElementActionInsert-Append 2.8
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8\roElementAction-Insert-Append.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8.mos), stream);

            Console.Write(mos.GetType().ToString());
            roElementActionInsertAppendAsserts((Messages.MOS_2_8.mos)mos);

            
           

            //*********************
            //roElementActionInsert-Append 2.8.1
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_1\roElementAction-Insert-Append.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8_1.mos), stream);

            Console.Write(mos.GetType().ToString());
            roElementActionInsertAppendAsserts((Messages.MOS_2_8_1.mos)mos);

            
           

            //*********************
            //roElementActionInsert-Append 2.8.2
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_2\roElementAction-Insert-Append.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8_2.mos), stream);

            Console.Write(mos.GetType().ToString());
            roElementActionInsertAppendAsserts((Messages.MOS_2_8_2.mos)mos);

            
           


            //*********************
            //roElementActionInsert-Append 2.8.3
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_3\roElementAction-Insert-Append.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8_3.mos), stream);

            Console.Write(mos.GetType().ToString());
            roElementActionInsertAppendAsserts((Messages.MOS_2_8_3.mos)mos);

            
           
            #endregion

            #region roStoryDelete
            //*********************
            //roStoryDelete 2.5
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_5\roStoryDelete.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roStoryDeleteAsserts((Messages.MOS_2_5.mos)mos);

            
           

            //*********************
            //roStoryDelete 2.6
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_6\roStoryDelete.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_6.mos), stream);

            Console.Write(mos.GetType().ToString());
            roStoryDeleteAsserts((Messages.MOS_2_6.mos)mos);

            
           

            //*********************
            //ElementAction-Delete 2.8
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8\roElementAction-Delete.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8.mos), stream);

            Console.Write(mos.GetType().ToString());
            ElementActionDeleteAsserts((Messages.MOS_2_8.mos)mos);

            
           

            //*********************
            //ElementAction-Delete 2.8.1
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_1\roElementAction-Delete.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8_1.mos), stream);

            Console.Write(mos.GetType().ToString());
            ElementActionDeleteAsserts((Messages.MOS_2_8_1.mos)mos);

            
           

            //*********************
            //ElementAction-Delete 2.8.2
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_2\roElementAction-Delete.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8_2.mos), stream);

            Console.Write(mos.GetType().ToString());
            ElementActionDeleteAsserts((Messages.MOS_2_8_2.mos)mos);

            
           


            //*********************
            //ElementAction-Delete 2.8.3
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_3\roElementAction-Delete.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8_3.mos), stream);

            Console.Write(mos.GetType().ToString());
            ElementActionDeleteAsserts((Messages.MOS_2_8_3.mos)mos);

            
           
            #endregion

            #region roStoryInsert
            //*********************
            //roStoryInsert 2.5
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_5\roStoryInsert.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roStoryInsertAsserts((Messages.MOS_2_5.mos)mos);

            
           

            //*********************
            //roStoryInsert 2.6
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_6\roStoryInsert.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_6.mos), stream);

            Console.Write(mos.GetType().ToString());
            roStoryInsertAsserts((Messages.MOS_2_6.mos)mos);

            
           

            //*********************
            //roElementAction-Move.xml 2.8
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8\roElementAction-Move.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8.mos), stream);

            Console.Write(mos.GetType().ToString());
            roElementActionMoveAssert((Messages.MOS_2_8.mos)mos);

            
           

            //*********************
            //roElementAction-Move.xml 2.8.1
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_1\roElementAction-Move.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8_1.mos), stream);

            Console.Write(mos.GetType().ToString());
            roElementActionMoveAssert((Messages.MOS_2_8_1.mos)mos);

            
           

            //*********************
            //roElementAction-Move.xml 2.8.2
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_2\roElementAction-Move.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8_2.mos), stream);

            Console.Write(mos.GetType().ToString());
            roElementActionMoveAssert((Messages.MOS_2_8_2.mos)mos);

            
           


            //*********************
            //roElementAction-Move.xml 2.8.3
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_3\roElementAction-Move.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8_3.mos), stream);

            Console.Write(mos.GetType().ToString());
            roElementActionMoveAssert((Messages.MOS_2_8_3.mos)mos);

            
           
            #endregion

            #region roMetadataReplace
            //*********************
            //roReplace 2.5
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_5\roReplace.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roReplaceAsserts((Messages.MOS_2_5.mos)mos);

            
           

            //*********************
            //roMetadataReplace 2.6
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_6\roMetadataReplace.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_6.mos), stream);

            Console.Write(mos.GetType().ToString());
            roMetadataReplaceAsserts((Messages.MOS_2_6.mos)mos);

            
           

            //*********************
            //roMetadataReplace 2.8
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8\roMetadataReplace.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8.mos), stream);

            Console.Write(mos.GetType().ToString());
            roMetadataReplaceAsserts((Messages.MOS_2_8.mos)mos);

            
           

            //*********************
            //roMetadataReplace 2.8.1
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_1\roMetadataReplace.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8_1.mos), stream);

            Console.Write(mos.GetType().ToString());
            roMetadataReplaceAsserts((Messages.MOS_2_8_1.mos)mos);

            
           

            //*********************
            //roMetadataReplace 2.8.2
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_2\roMetadataReplace.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8_2.mos), stream);

            Console.Write(mos.GetType().ToString());
            roMetadataReplaceAsserts((Messages.MOS_2_8_2.mos)mos);

            
           


            //*********************
            //roMetadataReplace 2.8.3
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_3\roMetadataReplace.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8_3.mos), stream);

            Console.Write(mos.GetType().ToString());
            roMetadataReplaceAsserts((Messages.MOS_2_8_3.mos)mos);

            
           
            #endregion

            #region roReadyToAir
            //*********************
            //roReadyToAir - 2.5
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_5\roReadyToAir.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_5.mos), stream);

            Console.Write(mos.GetType().ToString());
            roReadyToAirAsserts((Messages.MOS_2_5.mos)mos);

           

            //*********************
            //roReadyToAir 2.6
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_6\roReadyToAir.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_6.mos), stream);

            Console.Write(mos.GetType().ToString());
            roReadyToAirAsserts((Messages.MOS_2_6.mos)mos);


           

            //*********************
            //roReadyToAir 2.8
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8\roReadyToAir.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8.mos), stream);

            Console.Write(mos.GetType().ToString());
            roReadyToAirAsserts((Messages.MOS_2_8.mos)mos);


           

            //*********************
            //roReadyToAir 2.8.1
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_1\roReadyToAir.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8_1.mos), stream);

            Console.Write(mos.GetType().ToString());
            roReadyToAirAsserts((Messages.MOS_2_8_1.mos)mos);


           

            //*********************
            //roReadyToAir 2.8.2
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_2\roReadyToAir.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8_2.mos), stream);

            Console.Write(mos.GetType().ToString());
            roReadyToAirAsserts((Messages.MOS_2_8_2.mos)mos);


           


            //*********************
            //roReadyToAir 2.8.3
            //*********************
            xml = File.ReadAllText(@"..\..\..\TestMessages\MOS_2_8_3\roReadyToAir.xml");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            mos = XmlSerializerHelper.DeserializeFromStream(typeof(OSM.MOSProtocol.Messages.MOS_2_8_3.mos), stream);

            Console.Write(mos.GetType().ToString());
            roReadyToAirAsserts((Messages.MOS_2_8_3.mos)mos);


           
            #endregion
        }
       
        #region Asserts
        #region All MOS versions use these messages
        private void roCreateAsserts(object mos)
        {
            int i = 0;
            #region properties to match
            //mosID
            string mosID_2_5 = "MOS25.MOS";
            string mosID_2_6 = "MOS26.MOS";
            string mosID_2_8 = "MOS28.MOS";
            string mosID_2_8_1 = "MOS281.MOS";
            string mosID_2_8_2 = "MOS282.MOS";
            string mosID_2_8_3 = "MOS283.MOS";
            string ncsID_2_8 = "MOS28.NCS";
            //ncsID
            string ncsID_2_5 = "MOS25.NCS";
            string ncsID_2_6 = "MOS26.NCS";
            string ncsID_2_8_1 = "MOS281.NCS";
            string ncsID_2_8_2 = "MOS282.NCS";
            string ncsID_2_8_3 = "MOS283.NCS";
            //messageID
            int messageID = 0;
            //roID
            string roID = @"DEMOENPS50VPC;P_OSM\W;AADC7235-007A-4317-BE112095DF74356A";
            string roSlug = "OSM Dev";
            string roEdStart = "2037-05-16T14:00:00";
            string roEdDur = "00:30:00";
            //roMEM
            string mosSchema = "http://DEMOENPS50VPC/schema/enpsro.dtd";
            string mosScope = "PLAYLIST";
            XmlElement mosPayload = new XmlDocument().CreateElement("mosPayload");
            mosPayload.InnerXml = "<EndTime>2037-05-16T14:30:00</EndTime>" +
                                "<RundownDuration>30:00</RundownDuration>" +
                                "<StartTime>2037-05-16T14:00:00</StartTime>" +
                                "<osmRODistribution DisplayValue='OSMIP'>2</osmRODistribution>" +
                                "<MOSroBlock>MOS.Server.rdm1.bnc.ap.mos;SNAPFEED.SNAPFEEDDEMO314VPC.MOS</MOSroBlock>" +
                                "<MOSroStorySend>MOS25.MOS;MOS26.MOS;MOS28.MOS;MOS281.MOS</MOSroStorySend>" +
                                "<ENPSItemType>2</ENPSItemType>" +
                                "<roLayout>PageNum_450|RowStatus_150|Slug_1200|SegStatus_210|Segment_915|MOSSlugs_1215|MOSStatus_1035|MOSIDs_1845|Break_600|Presenter_1005|Approved_600|Estimated_840|Actual_720|FrontTime_1005|BackTime_1005|CumeTime_1005|ModBy_1200</roLayout>";
            //storyIDs
            Dictionary<string, string> storyID = new Dictionary<string, string>();
            storyID.Add(@"DEMOENPS50VPC;P_OSM\W\R_AADC7235-007A-4317-BE112095DF74356A;B703C725-10F6-4883-805BAD0C93B54D03", "MOS Server Master Countdown");
            storyID.Add(@"DEMOENPS50VPC;P_OSM\W\R_AADC7235-007A-4317-BE112095DF74356A;79549DCB-1F32-485D-8E65C4FED9F1D007", "MOS Server Countdowns");
            storyID.Add(@"DEMOENPS50VPC;P_OSM\W\R_AADC7235-007A-4317-BE112095DF74356A;6AB5CE80-6EF9-41F0-AB08AF0D02643A13", "MOS Server Master Countdown");
            storyID.Add(@"DEMOENPS50VPC;P_OSM\W\R_AADC7235-007A-4317-BE112095DF74356A;60F2610C-6006-47C3-88026D4871B87B15", "MOS Server Countdowns");
            storyID.Add(@"DEMOENPS50VPC;P_OSM\W\R_AADC7235-007A-4317-BE112095DF74356A;EB56E7FD-EE58-48D3-AC1C498325868AB4", "MOS Server Master Countdown");
            storyID.Add(@"DEMOENPS50VPC;P_OSM\W\R_AADC7235-007A-4317-BE112095DF74356A;997CBDAC-B0ED-4935-AA7A574AF3899E5E", "MOS Server Master Countdown");
            storyID.Add(@"DEMOENPS50VPC;P_OSM\W\R_AADC7235-007A-4317-BE112095DF74356A;ECA0B141-AAD1-45D0-93790CE45094D4A7", "MOS Server Master Countdown");
            storyID.Add(@"DEMOENPS50VPC;P_OSM\W\R_AADC7235-007A-4317-BE112095DF74356A;7ABF108E-CF47-4CAB-8759DA3F4E6A48F0", "MOS Server Countdowns");
            storyID.Add(@"DEMOENPS50VPC;P_OSM\W\R_AADC7235-007A-4317-BE112095DF74356A;A4A58DB8-2CC9-4A60-AA34781A568A28BC", "MOS Server Countdowns");
            storyID.Add(@"DEMOENPS50VPC;P_OSM\W\R_AADC7235-007A-4317-BE112095DF74356A;FA72A68D-6DC8-4AB2-864FD28014F227EF", "MOS Server Countdowns");
            storyID.Add(@"DEMOENPS50VPC;P_OSM\W\R_AADC7235-007A-4317-BE112095DF74356A;F821D307-2E07-4280-A81DABABF6E1365F", "MOS Server Countdowns");
            storyID.Add(@"DEMOENPS50VPC;P_OSM\W\R_AADC7235-007A-4317-BE112095DF74356A;5F24658C-27A9-424B-AA1CEFFC38E94ACB", "MOS Server Countdowns");
            storyID.Add(@"DEMOENPS50VPC;P_OSM\W\R_AADC7235-007A-4317-BE112095DF74356A;D57574BF-0F40-461F-9825D3F96F775758", "MOS Server Master Countdown");
            storyID.Add(@"DEMOENPS50VPC;P_OSM\W\R_AADC7235-007A-4317-BE112095DF74356A;C0533E34-0993-4383-BCB2FF083F97BBAD", "MOS Server Master Countdown");

            #endregion

            switch (mos.GetType().ToString())
            {
                case "OSM.MOSProtocol.Messages.MOS_2_5.mos":
                    
                    Messages.MOS_2_5.mos mos_2_5 = (Messages.MOS_2_5.mos)mos;
                    Assert.AreEqual(mosID_2_5, mos_2_5.mosID );
                    Assert.AreEqual(ncsID_2_5, mos_2_5.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_5.roCreate", mos_2_5.Item.GetType().ToString());
                    Messages.MOS_2_5.roCreate mos_2_5_roCreate = (Messages.MOS_2_5.roCreate)mos_2_5.Item;
                    Assert.AreEqual(roID, mos_2_5_roCreate.roID);
                    Assert.AreEqual(roSlug, mos_2_5_roCreate.roSlug);
                    Assert.AreEqual(roEdDur, mos_2_5_roCreate.roEdDur);
                    Assert.AreEqual(roEdStart, mos_2_5_roCreate.roEdStart);
                    i = 0;
                    foreach( KeyValuePair<string, string> kvp in storyID )
                    {
                         Assert.AreEqual(kvp.Key, mos_2_5_roCreate.story[i].storyID);
                         Assert.AreEqual(kvp.Value, mos_2_5_roCreate.story[i].storySlug);
                         ++i;
                    }
                    
                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_6.mos":
                     
                    Messages.MOS_2_6.mos mos_2_6 = (Messages.MOS_2_6.mos)mos;
                    Assert.AreEqual(mosID_2_6, mos_2_6.mosID);
                    Assert.AreEqual( ncsID_2_6, mos_2_6.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_6.roCreate", mos_2_6.Item.GetType().ToString());
                    Messages.MOS_2_6.roCreate mos_2_6_roCreate = (Messages.MOS_2_6.roCreate)mos_2_6.Item;
                    Assert.AreEqual(roID, mos_2_6_roCreate.roID);
                    Assert.AreEqual(roEdDur, mos_2_6_roCreate.roEdDur);
                    Assert.AreEqual(roEdStart, mos_2_6_roCreate.roEdStart);
                    i = 0; 
                    foreach (KeyValuePair<string, string> kvp in storyID)
                    {
                        Assert.AreEqual(kvp.Key, mos_2_6_roCreate.story[i].storyID);
                        Assert.AreEqual(kvp.Value, mos_2_6_roCreate.story[i].storySlug);
                         ++i;
                     }
                    foreach (Messages.MOS_2_6.mosExternalMetadata mem in mos_2_6_roCreate.mosExternalMetadata)
                    {
                        Assert.AreEqual(mosScope, mem.mosScope);
                        Assert.AreEqual( mosSchema, mem.mosSchema);
                        Assert.AreEqual( mosPayload.InnerXml, mem.mosPayload.InnerXml);
                    }
                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8.mos":
                    
                    Messages.MOS_2_8.mos mos_2_8 = (Messages.MOS_2_8.mos)mos;
                    Assert.AreEqual(mosID_2_8, mos_2_8.mosID);
                    Assert.AreEqual( ncsID_2_8, mos_2_8.ncsID);
                    Assert.AreEqual( "OSM.MOSProtocol.Messages.MOS_2_8.roCreate",mos_2_8.Item.GetType().ToString());
                    Messages.MOS_2_8.roCreate mos_2_8_roCreate = (Messages.MOS_2_8.roCreate)mos_2_8.Item;
                    Assert.AreEqual(roID, mos_2_8_roCreate.roID);
                    Assert.AreEqual(roEdDur, mos_2_8_roCreate.roEdDur);
                    Assert.AreEqual(roEdStart, mos_2_8_roCreate.roEdStart);
                    i = 0;
                    foreach( KeyValuePair<string, string> kvp in storyID )
                    {
                         Assert.AreEqual(kvp.Key, mos_2_8_roCreate.story[i].storyID);
                         Assert.AreEqual(kvp.Value, mos_2_8_roCreate.story[i].storySlug);
                         ++i;
                    }
                    foreach (Messages.MOS_2_8.mosExternalMetadata mem in mos_2_8_roCreate.mosExternalMetadata)
                    {
                        Assert.AreEqual(mosScope, mem.mosScope);
                        Assert.AreEqual(mosSchema, mem.mosSchema);
                        Assert.AreEqual(mosPayload.InnerXml, mem.mosPayload.InnerXml);
                    }
                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8_1.mos":
                     
                    Messages.MOS_2_8_1.mos mos_2_8_1  = (Messages.MOS_2_8_1.mos)mos;
                    Assert.AreEqual(mosID_2_8_1, mos_2_8_1.mosID);
                    Assert.AreEqual(ncsID_2_8_1, mos_2_8_1.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8_1.roCreate",mos_2_8_1.Item.GetType().ToString() );
                    Messages.MOS_2_8_1.roCreate mos_2_8_1_roCreate = (Messages.MOS_2_8_1.roCreate)mos_2_8_1.Item;
                    Assert.AreEqual(roID, mos_2_8_1_roCreate.roID);
                    Assert.AreEqual(roEdDur, mos_2_8_1_roCreate.roEdDur);
                    Assert.AreEqual(roEdStart, mos_2_8_1_roCreate.roEdStart);
                    i = 0;
                    foreach( KeyValuePair<string, string> kvp in storyID )
                    {
                         Assert.AreEqual(kvp.Key,  mos_2_8_1_roCreate.story[i].storyID);
                         Assert.AreEqual(kvp.Value, mos_2_8_1_roCreate.story[i].storySlug);
                         ++i;
                    }
                    foreach (Messages.MOS_2_8_1.mosExternalMetadata mem in mos_2_8_1_roCreate.mosExternalMetadata)
                    {
                        Assert.AreEqual(mosScope, mem.mosScope);
                        Assert.AreEqual(mosSchema, mem.mosSchema);
                        Assert.AreEqual(mosPayload.InnerXml, mem.mosPayload.InnerXml);
                    }
                    
                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8_2.mos":
                    
                    Messages.MOS_2_8_2.mos mos_2_8_2 = (Messages.MOS_2_8_2.mos)mos;
                    Assert.AreEqual(mosID_2_8_2, mos_2_8_2.mosID);
                    Assert.AreEqual(ncsID_2_8_2, mos_2_8_2.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8_2.roCreate",mos_2_8_2.Item.GetType().ToString());
                    Messages.MOS_2_8_2.roCreate mos_2_8_2_roCreate = (Messages.MOS_2_8_2.roCreate)mos_2_8_2.Item;
                    Assert.AreEqual(roID, mos_2_8_2_roCreate.roID);
                    Assert.AreEqual(roEdDur, mos_2_8_2_roCreate.roEdDur);
                    Assert.AreEqual(roEdStart, mos_2_8_2_roCreate.roEdStart);
                    i = 0;
                    foreach( KeyValuePair<string, string> kvp in storyID )
                    {
                         Assert.AreEqual(kvp.Key, mos_2_8_2_roCreate.story[i].storyID);
                         Assert.AreEqual(kvp.Value, mos_2_8_2_roCreate.story[i].storySlug);
                         ++i;
                    }
                    foreach (Messages.MOS_2_8_2.mosExternalMetadata mem in mos_2_8_2_roCreate.mosExternalMetadata)
                    {
                        Assert.AreEqual(mosScope, mem.mosScope);
                        Assert.AreEqual(mosSchema, mem.mosSchema);
                        Assert.AreEqual(mosPayload.InnerXml, mem.mosPayload.InnerXml);
                    }
                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8_3.mos":
                    
                    Messages.MOS_2_8_3.mos mos_2_8_3 =  (Messages.MOS_2_8_3.mos)mos;
                    Assert.AreEqual(mosID_2_8_3, mos_2_8_3.mosID);
                    Assert.AreEqual(ncsID_2_8_3, mos_2_8_3.ncsID);
                    Assert.AreEqual( "OSM.MOSProtocol.Messages.MOS_2_8_3.roCreate",mos_2_8_3.Item.GetType().ToString());
                    Messages.MOS_2_8_3.roCreate mos_2_8_3_roCreate = (Messages.MOS_2_8_3.roCreate)mos_2_8_3.Item;
                    Assert.AreEqual(roID, mos_2_8_3_roCreate.roID);
                    Assert.AreEqual(mos_2_8_3_roCreate.roEdDur, roEdDur);
                    Assert.AreEqual(roEdStart, mos_2_8_3_roCreate.roEdStart);
                    i = 0;
                    foreach( KeyValuePair<string, string> kvp in storyID )
                    {
                        Assert.AreEqual(kvp.Key, mos_2_8_3_roCreate.story[i].storyID);
                        Assert.AreEqual(kvp.Value, mos_2_8_3_roCreate.story[i].storySlug);
                         ++i;
                    }
                    foreach (Messages.MOS_2_8_3.mosExternalMetadata mem in mos_2_8_3_roCreate.mosExternalMetadata)
                    {
                        Assert.AreEqual(mosScope, mem.mosScope);
                        Assert.AreEqual(mosSchema, mem.mosSchema);
                        Assert.AreEqual(mosPayload.InnerXml, mem.mosPayload.InnerXml);
                    }
                    break;
            }
           
        }
        private void roStorySendAsserts(object mos)
        {
            //mosID
            string mosID_2_5 = "MOS25.MOS";
            string mosID_2_6 = "MOS26.MOS";
            string mosID_2_8 = "MOS28.MOS";
            string mosID_2_8_1 = "MOS281.MOS";
            string mosID_2_8_2 = "MOS282.MOS";
            string mosID_2_8_3 = "MOS283.MOS";
            string ncsID_2_8 = "MOS28.NCS";
            //ncsID
            string ncsID_2_5 = "MOS25.NCS";
            string ncsID_2_6 = "MOS26.NCS";
            string ncsID_2_8_1 = "MOS281.NCS";
            string ncsID_2_8_2 = "MOS282.NCS";
            string ncsID_2_8_3 = "MOS283.NCS";
            string storyBody_2_5 = getElement(@"..\..\..\TestMessages\MOS_2_5\roStorySend.xml", "mos/roStorySend/storyBody");
            string storyBody_2_6 = getElement(@"..\..\..\TestMessages\MOS_2_6\roStorySend.xml", "mos/roStorySend/storyBody");
            string storyBody_2_8 = getElement(@"..\..\..\TestMessages\MOS_2_8\roStorySend.xml", "mos/roStorySend/storyBody");
            string storyBody_2_8_1 = getElement(@"..\..\..\TestMessages\MOS_2_8_1\roStorySend.xml", "mos/roStorySend/storyBody");
            string storyBody_2_8_2 = getElement(@"..\..\..\TestMessages\MOS_2_8_2\roStorySend.xml", "mos/roStorySend/storyBody");
            string storyBody_2_8_3 = getElement(@"..\..\..\TestMessages\MOS_2_8_3\roStorySend.xml", "mos/roStorySend/storyBody");
            
            //roID
            string roID = @"DEMOENPS50VPC;P_OSM\W;AADC7235-007A-4317-BE112095DF74356A";
            //storyID
            string storyID = @"DEMOENPS50VPC;P_OSM\W\R_AADC7235-007A-4317-BE112095DF74356A;7ABF108E-CF47-4CAB-8759DA3F4E6A48F0";
            //storySLug
            string storySlug = "MOS Server Countdowns";
            //StoryBody
            //storyItem
            //storyItemMEM
            //storyItemPaths
            //storyMEM
            string mosSchema = "http://DEMOENPS50VPC/schema/enps.dtd";
            string mosScope = "PLAYLIST";
            XmlElement mosPayload = new XmlDocument().CreateElement("mosPayload");
            mosPayload.InnerXml = "<SourceMediaTime>0</SourceMediaTime>" +
                                "<SourceModBy>RREGAN</SourceModBy>" +
                                "<SourceModTime>20070518151101</SourceModTime>" +
                                "<SourceTextTime>0</SourceTextTime>" +
                                "<Approved>0</Approved>" +
                                "<ModBy>ADMINISTRATOR</ModBy>" +
                                "<ModTime>20080516145604</ModTime>" +
                                "<Owner>ADMINISTRATOR</Owner>" +
                                "<Creator>RREGAN</Creator>" +
                                "<TextTime>279</TextTime>" +
                                "<MediaTime>0</MediaTime>" +
                                "<ENPSItemType>3</ENPSItemType>";
            

            switch (mos.GetType().ToString())
            {
                case "OSM.MOSProtocol.Messages.MOS_2_5.mos":
                    Messages.MOS_2_5.mos mos_2_5 = (Messages.MOS_2_5.mos)mos;
                    Assert.AreEqual(mosID_2_5, mos_2_5.mosID);
                    Assert.AreEqual(ncsID_2_5, mos_2_5.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_5.roStorySend", mos_2_5.Item.GetType().ToString());
                    Messages.MOS_2_5.roStorySend mos_2_5_roStorySend = (Messages.MOS_2_5.roStorySend)mos_2_5.Item;
                    Assert.AreEqual(roID, mos_2_5_roStorySend.roID);
                    Assert.AreEqual(storySlug, mos_2_5_roStorySend.storySlug);
                    Assert.AreEqual(storyID, mos_2_5_roStorySend.storyID);
                    //storyBody
                    object objbody = XmlSerializerHelper.DeserializeFromString( typeof(OSM.MOSProtocol.Messages.MOS_2_5.storyBody), storyBody_2_5);
                    Messages.MOS_2_5.storyBody body = (OSM.MOSProtocol.Messages.MOS_2_5.storyBody)objbody;
                    int i = 0;
                    //ToDo:
#if false
                    #region Check Each object in the storyBody
                    foreach (object obj in mos_2_5_roStorySend.storyBody.Items)
                    {
                        switch (obj.GetType().ToString())
                        {
                            case "OSM.MOSProtocol.Messages.MOS_2_5.p":
                                Messages.MOS_2_5.p pA = (OSM.MOSProtocol.Messages.MOS_2_5.p)obj;
                                Messages.MOS_2_5.p pE = (OSM.MOSProtocol.Messages.MOS_2_5.p)body.Items[i];
                                Assert.AreEqual(pE.Text, pA.Text);
                                int iItems = 0;
                                if (pA.Items != null)
                                {
                                    foreach (object objItems in pA.Items)
                                    {
                                        switch (objItems.GetType().ToString())
                                        {
                                            case "OSM.MOSProtocol.Messages.MOS_2_5.b":
                                                Messages.MOS_2_5.b bA = (OSM.MOSProtocol.Messages.MOS_2_5.b)obj;
                                                Messages.MOS_2_5.b bE = (OSM.MOSProtocol.Messages.MOS_2_5.b)pE.Items[iItems];
                                                Assert.AreEqual(bE.Text, bA.Text);
                                                break;
                                            case "OSM.MOSProtocol.Messages.MOS_2_5.u":
                                                Messages.MOS_2_5.u uA = (OSM.MOSProtocol.Messages.MOS_2_5.u)obj;
                                                Messages.MOS_2_5.u uE = (OSM.MOSProtocol.Messages.MOS_2_5.u)pE.Items[iItems];
                                                Assert.AreEqual(uE.Text, uA.Text);
                                                break;
                                            case "OSM.MOSProtocol.Messages.MOS_2_5.pi":
                                                Messages.MOS_2_5.pi piA = (OSM.MOSProtocol.Messages.MOS_2_5.pi)obj;
                                                Messages.MOS_2_5.pi piE = (OSM.MOSProtocol.Messages.MOS_2_5.pi)pE.Items[iItems];
                                                Assert.AreEqual(piE.Text, piA.Text);
                                                break;
                                            case "OSM.MOSProtocol.Messages.MOS_2_5.pkg":
                                                Messages.MOS_2_5.pkg pkgA = (OSM.MOSProtocol.Messages.MOS_2_5.pkg)obj;
                                                Messages.MOS_2_5.pkg pkgE = (OSM.MOSProtocol.Messages.MOS_2_5.pkg)pE.Items[iItems];
                                                Assert.AreEqual(pkgE.Text, pkgA.Text);
                                                break;
                                            case "OSM.MOSProtocol.Messages.MOS_2_5.i":
                                                Messages.MOS_2_5.i iA = (OSM.MOSProtocol.Messages.MOS_2_5.i)obj;
                                                Messages.MOS_2_5.i iE = (OSM.MOSProtocol.Messages.MOS_2_5.i)pE.Items[iItems];
                                                Assert.AreEqual(iE.Text, iA.Text);
                                                break;
                                        }
                                        ++iItems;
                                    }
                                }//check for objects within the p object
                                Assert.AreEqual(pE.Text, pA.Text);
                                break;
                            case "OSM.MOSProtocol.Messages.MOS_2_5.storyItem":
                                Messages.MOS_2_5.storyItem siA = (OSM.MOSProtocol.Messages.MOS_2_5.storyItem)obj;
                                Messages.MOS_2_5.storyItem siE = (OSM.MOSProtocol.Messages.MOS_2_5.storyItem)body.Items[i];
                                Assert.AreEqual(siE.itemID, siA.itemID);
                                Assert.AreEqual(siE.itemChannel, siA.itemChannel);
                                Assert.AreEqual(siE.itemEdDur, siA.itemEdDur);
                                Assert.AreEqual(siE.itemEdStart, siA.itemEdStart);
                                Assert.AreEqual(siE.itemSlug, siA.itemSlug);
                                Assert.AreEqual(siE.itemTrigger, siA.itemTrigger);
                                Assert.AreEqual(siE.itemUserTimingDur, siA.itemUserTimingDur);
                                Assert.AreEqual(siE.macroIn, siA.macroIn);
                                Assert.AreEqual(siE.macroOut, siA.macroOut);
                                Assert.AreEqual(siE.mosAbstract.InnerXml, siA.mosAbstract.InnerXml);
                                Assert.AreEqual(siE.mosID, siA.mosID);
                                Assert.AreEqual(siE.objID, siA.objID);
                                break;
                            default:
                                Console.WriteLine("UNKNOWN TYPE: " + obj.GetType().ToString());
                                break;    
                        }
                        //Assert.AreEqual(body.Items[i], obj);
                        ++i;
                    }
                    #endregion - each object in the storybody
#endif
                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_6.mos":
                    Messages.MOS_2_6.mos mos_2_6 = (Messages.MOS_2_6.mos)mos;
                    Assert.AreEqual(mosID_2_6, mos_2_6.mosID);
                    Assert.AreEqual(ncsID_2_6, mos_2_6.ncsID);
                   Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_6.roStorySend", mos_2_6.Item.GetType().ToString());
                    Messages.MOS_2_6.roStorySend mos_2_6_roStorySend = (Messages.MOS_2_6.roStorySend)mos_2_6.Item;
                    Assert.AreEqual(roID, mos_2_6_roStorySend.roID);
                    Assert.AreEqual(storySlug, mos_2_6_roStorySend.storySlug);
                    Assert.AreEqual(storyID, mos_2_6_roStorySend.storyID);
                    //storyBody
                    object objbody_2_6 = XmlSerializerHelper.DeserializeFromString(typeof(OSM.MOSProtocol.Messages.MOS_2_6.storyBody), storyBody_2_6);
                    Messages.MOS_2_6.storyBody body_2_6 = (OSM.MOSProtocol.Messages.MOS_2_6.storyBody)objbody_2_6;
                     i = 0;
#if false //TODO:Check Each object in the storyBody
                #region Check Each object in the storyBody
                    foreach (object obj in mos_2_6_roStorySend.storyBody.Items)
                    {
                        switch (obj.GetType().ToString())
                        {
                            case "OSM.MOSProtocol.Messages.MOS_2_6.p":
                                Messages.MOS_2_6.p pA = (OSM.MOSProtocol.Messages.MOS_2_6.p)obj;
                                Messages.MOS_2_6.p pE = (OSM.MOSProtocol.Messages.MOS_2_6.p)body_2_6.Items[i];
                                Assert.AreEqual(pE.Text, pA.Text);
                                int iItems = 0;
                                if (pA.Items != null)
                                {
                                    foreach (object objItems in pA.Items)
                                    {
                                        switch (objItems.GetType().ToString())
                                        {
                                            case "OSM.MOSProtocol.Messages.MOS_2_6.b":
                                                Messages.MOS_2_6.b bA = (OSM.MOSProtocol.Messages.MOS_2_6.b)obj;
                                                Messages.MOS_2_6.b bE = (OSM.MOSProtocol.Messages.MOS_2_6.b)pE.Items[iItems];
                                                Assert.AreEqual(bE.Text, bA.Text);
                                                break;
                                            case "OSM.MOSProtocol.Messages.MOS_2_6.u":
                                                Messages.MOS_2_6.u uA = (OSM.MOSProtocol.Messages.MOS_2_6.u)obj;
                                                Messages.MOS_2_6.u uE = (OSM.MOSProtocol.Messages.MOS_2_6.u)pE.Items[iItems];
                                                Assert.AreEqual(uE.Text, uA.Text);
                                                break;
                                            case "OSM.MOSProtocol.Messages.MOS_2_6.pi":
                                                Messages.MOS_2_6.pi piA = (OSM.MOSProtocol.Messages.MOS_2_6.pi)obj;
                                                Messages.MOS_2_6.pi piE = (OSM.MOSProtocol.Messages.MOS_2_6.pi)pE.Items[iItems];
                                                Assert.AreEqual(piE.Text, piA.Text);
                                                break;
                                            case "OSM.MOSProtocol.Messages.MOS_2_6.pkg":
                                                Messages.MOS_2_6.pkg pkgA = (OSM.MOSProtocol.Messages.MOS_2_6.pkg)obj;
                                                Messages.MOS_2_6.pkg pkgE = (OSM.MOSProtocol.Messages.MOS_2_6.pkg)pE.Items[iItems];
                                                Assert.AreEqual(pkgE.Text, pkgA.Text);
                                                break;
                                            case "OSM.MOSProtocol.Messages.MOS_2_6.i":
                                                Messages.MOS_2_6.i iA = (OSM.MOSProtocol.Messages.MOS_2_6.i)obj;
                                                Messages.MOS_2_6.i iE = (OSM.MOSProtocol.Messages.MOS_2_6.i)pE.Items[iItems];
                                                Assert.AreEqual(iE.Text, iA.Text);
                                                break;
                                        }
                                        ++iItems;
                                    }
                                }//check for objects within the p object
                                Assert.AreEqual(pE.Text, pA.Text);
                                break;
                            case "OSM.MOSProtocol.Messages.MOS_2_6.storyItem":
                                Messages.MOS_2_6.storyItem siA = (OSM.MOSProtocol.Messages.MOS_2_6.storyItem)obj;
                                Messages.MOS_2_6.storyItem siE = (OSM.MOSProtocol.Messages.MOS_2_6.storyItem)body_2_6.Items[i];
                                Assert.AreEqual(siE.itemID, siA.itemID);
                                Assert.AreEqual(siE.itemChannel, siA.itemChannel);
                                Assert.AreEqual(siE.itemEdDur, siA.itemEdDur);
                                Assert.AreEqual(siE.itemEdStart, siA.itemEdStart);
                                Assert.AreEqual(siE.itemSlug, siA.itemSlug);
                                Assert.AreEqual(siE.itemTrigger, siA.itemTrigger);
                                Assert.AreEqual(siE.itemUserTimingDur, siA.itemUserTimingDur);
                                Assert.AreEqual(siE.macroIn, siA.macroIn);
                                Assert.AreEqual(siE.macroOut, siA.macroOut);
                                Assert.AreEqual(siE.mosAbstract.InnerXml, siA.mosAbstract.InnerXml);
                                Assert.AreEqual(siE.mosID, siA.mosID);
                                Assert.AreEqual(siE.objID, siA.objID);
                                int iMEM = 0;
                                foreach (Messages.MOS_2_6.mosExternalMetadata mem in siA.mosExternalMetadata)
                                {
                                    Assert.AreEqual(siE.mosExternalMetadata[iMEM].mosScope, mem.mosScope);
                                    Assert.AreEqual(siE.mosExternalMetadata[iMEM].mosSchema, mem.mosSchema);
                                    Assert.AreEqual(siE.mosExternalMetadata[iMEM].mosPayload.InnerXml, mem.mosPayload.InnerXml);
                                    ++iMEM;
                                }
                                break;
                            default:
                                Console.WriteLine("UNKNOWN TYPE: " + obj.GetType().ToString());
                                break;    
                        }
                        //Assert.AreEqual(body.Items[i], obj);
                        ++i;
                    }
                    #endregion - each object in the storybody
#endif
                    foreach (Messages.MOS_2_6.mosExternalMetadata mem in mos_2_6_roStorySend.mosExternalMetadata)
                    {
                        Assert.AreEqual(mosScope, mem.mosScope);
                        Assert.AreEqual(mosSchema, mem.mosSchema);
                        Assert.AreEqual(mosPayload.InnerXml, mem.mosPayload.InnerXml);
                    }
                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8.mos":
                    Messages.MOS_2_8.mos mos_2_8 = (Messages.MOS_2_8.mos)mos;
                    Assert.AreEqual(mosID_2_8, mos_2_8.mosID);
                    Assert.AreEqual(ncsID_2_8, mos_2_8.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8.roStorySend", mos_2_8.Item.GetType().ToString());
                    Messages.MOS_2_8.roStorySend mos_2_8_roStorySend = (Messages.MOS_2_8.roStorySend)mos_2_8.Item;
                    Assert.AreEqual(roID, mos_2_8_roStorySend.roID);
                    Assert.AreEqual(storySlug, mos_2_8_roStorySend.storySlug);
                    Assert.AreEqual(storyID, mos_2_8_roStorySend.storyID);
                    //storyBody
                    object objbody_2_8 = XmlSerializerHelper.DeserializeFromString(typeof(OSM.MOSProtocol.Messages.MOS_2_8.storyBody), storyBody_2_8);
                    Messages.MOS_2_8.storyBody body_2_8 = (OSM.MOSProtocol.Messages.MOS_2_8.storyBody)objbody_2_8;
                     i = 0;
#if false //TODO:Check Each object in the storyBody
                    #region Check Each object in the storyBody
                    foreach (object obj in mos_2_8_roStorySend.storyBody.Items)
                    {
                        switch (obj.GetType().ToString())
                        {
                            case "OSM.MOSProtocol.Messages.MOS_2_8.p":
                                Messages.MOS_2_8.p pA = (OSM.MOSProtocol.Messages.MOS_2_8.p)obj;
                                Messages.MOS_2_8.p pE = (OSM.MOSProtocol.Messages.MOS_2_8.p)body_2_8.Items[i];
                                Assert.AreEqual(pE.Text, pA.Text);
                                int iItems = 0;
                                if (pA.Items != null)
                                {
                                    foreach (object objItems in pA.Items)
                                    {
                                        switch (objItems.GetType().ToString())
                                        {
                                            case "OSM.MOSProtocol.Messages.MOS_2_8.b":
                                                Messages.MOS_2_8.b bA = (OSM.MOSProtocol.Messages.MOS_2_8.b)obj;
                                                Messages.MOS_2_8.b bE = (OSM.MOSProtocol.Messages.MOS_2_8.b)pE.Items[iItems];
                                                Assert.AreEqual(bE.Text, bA.Text);
                                                break;
                                            case "OSM.MOSProtocol.Messages.MOS_2_8.u":
                                                Messages.MOS_2_8.u uA = (OSM.MOSProtocol.Messages.MOS_2_8.u)obj;
                                                Messages.MOS_2_8.u uE = (OSM.MOSProtocol.Messages.MOS_2_8.u)pE.Items[iItems];
                                                Assert.AreEqual(uE.Text, uA.Text);
                                                break;
                                            case "OSM.MOSProtocol.Messages.MOS_2_8.pi":
                                                Messages.MOS_2_8.pi piA = (OSM.MOSProtocol.Messages.MOS_2_8.pi)obj;
                                                Messages.MOS_2_8.pi piE = (OSM.MOSProtocol.Messages.MOS_2_8.pi)pE.Items[iItems];
                                                Assert.AreEqual(piE.Text, piA.Text);
                                                break;
                                            case "OSM.MOSProtocol.Messages.MOS_2_8.pkg":
                                                Messages.MOS_2_8.pkg pkgA = (OSM.MOSProtocol.Messages.MOS_2_8.pkg)obj;
                                                Messages.MOS_2_8.pkg pkgE = (OSM.MOSProtocol.Messages.MOS_2_8.pkg)pE.Items[iItems];
                                                Assert.AreEqual(pkgE.Text, pkgA.Text);
                                                break;
                                            case "OSM.MOSProtocol.Messages.MOS_2_8.i":
                                                Messages.MOS_2_8.i iA = (OSM.MOSProtocol.Messages.MOS_2_8.i)obj;
                                                Messages.MOS_2_8.i iE = (OSM.MOSProtocol.Messages.MOS_2_8.i)pE.Items[iItems];
                                                Assert.AreEqual(iE.Text, iA.Text);
                                                break;
                                        }
                                        ++iItems;
                                    }
                                }//check for objects within the p object
                                Assert.AreEqual(pE.Text, pA.Text);
                                break;
                            case "OSM.MOSProtocol.Messages.MOS_2_8.storyItem":
                                Messages.MOS_2_8.storyItem siA = (OSM.MOSProtocol.Messages.MOS_2_8.storyItem)obj;
                                Messages.MOS_2_8.storyItem siE = (OSM.MOSProtocol.Messages.MOS_2_8.storyItem)body_2_8.Items[i];
                                Assert.AreEqual(siE.itemID, siA.itemID);
                                Assert.AreEqual(siE.itemChannel, siA.itemChannel);
                                Assert.AreEqual(siE.itemEdDur, siA.itemEdDur);
                                Assert.AreEqual(siE.itemEdStart, siA.itemEdStart);
                                Assert.AreEqual(siE.itemSlug, siA.itemSlug);
                                Assert.AreEqual(siE.itemTrigger, siA.itemTrigger);
                                Assert.AreEqual(siE.itemUserTimingDur, siA.itemUserTimingDur);
                                Assert.AreEqual(siE.macroIn, siA.macroIn);
                                Assert.AreEqual(siE.macroOut, siA.macroOut);
                                Assert.AreEqual(siE.mosAbstract.InnerXml, siA.mosAbstract.InnerXml);
                                Assert.AreEqual(siE.mosID, siA.mosID);
                                Assert.AreEqual(siE.objID, siA.objID);
                                int iMEM = 0;
                                foreach (Messages.MOS_2_8.mosExternalMetadata mem in siA.mosExternalMetadata)
                                {
                                    Assert.AreEqual(siE.mosExternalMetadata[iMEM].mosScope, mem.mosScope);
                                    Assert.AreEqual(siE.mosExternalMetadata[iMEM].mosSchema, mem.mosSchema);
                                    Assert.AreEqual(siE.mosExternalMetadata[iMEM].mosPayload.InnerXml, mem.mosPayload.InnerXml);
                                    ++iMEM;
                                }
                                break;
                            default:
                                Console.WriteLine("UNKNOWN TYPE: " + obj.GetType().ToString());
                                break;
                        }
                        //Assert.AreEqual(body.Items[i], obj);
                        ++i;
                    }
                    #endregion - each object in the storybody
#endif
                    foreach (Messages.MOS_2_8.mosExternalMetadata mem in mos_2_8_roStorySend.mosExternalMetadata)
                    {
                        Assert.AreEqual(mosScope, mem.mosScope);
                        Assert.AreEqual(mosSchema, mem.mosSchema);
                        Assert.AreEqual(mosPayload.InnerXml, mem.mosPayload.InnerXml);
                    }
                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8_1.mos":
                    Messages.MOS_2_8_1.mos mos_2_8_1 = (Messages.MOS_2_8_1.mos)mos;
                    Assert.AreEqual(mosID_2_8_1, mos_2_8_1.mosID);
                    Assert.AreEqual(ncsID_2_8_1, mos_2_8_1.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8_1.roStorySend", mos_2_8_1.Item.GetType().ToString());
                    Messages.MOS_2_8_1.roStorySend mos_2_8_1_roStorySend = (Messages.MOS_2_8_1.roStorySend)mos_2_8_1.Item;
                    Assert.AreEqual(roID, mos_2_8_1_roStorySend.roID);
                    Assert.AreEqual(storySlug, mos_2_8_1_roStorySend.storySlug);
                    Assert.AreEqual(storyID, mos_2_8_1_roStorySend.storyID);
                    //storyBody
                    object objbody_2_8_1 = XmlSerializerHelper.DeserializeFromString(typeof(OSM.MOSProtocol.Messages.MOS_2_8_1.storyBody), storyBody_2_8_1);
                    Messages.MOS_2_8_1.storyBody body_2_8_1 = (OSM.MOSProtocol.Messages.MOS_2_8_1.storyBody)objbody_2_8_1;
                     i = 0;
#if false //TODO:Check Each object in the storyBody
                    #region Check Each object in the storyBody
                    foreach (object obj in mos_2_8_1_roStorySend.storyBody.Items)
                    {
                        switch (obj.GetType().ToString())
                        {
                            case "OSM.MOSProtocol.Messages.MOS_2_8_1.p":
                                Messages.MOS_2_8_1.p pA = (OSM.MOSProtocol.Messages.MOS_2_8_1.p)obj;
                                Messages.MOS_2_8_1.p pE = (OSM.MOSProtocol.Messages.MOS_2_8_1.p)body_2_8_1.Items[i];
                                Assert.AreEqual(pE.Text, pA.Text);
                                int iItems = 0;
                                if (pA.Items != null)
                                {
                                    foreach (object objItems in pA.Items)
                                    {
                                        switch (objItems.GetType().ToString())
                                        {
                                            case "OSM.MOSProtocol.Messages.MOS_2_8_1.b":
                                                Messages.MOS_2_8_1.b bA = (OSM.MOSProtocol.Messages.MOS_2_8_1.b)obj;
                                                Messages.MOS_2_8_1.b bE = (OSM.MOSProtocol.Messages.MOS_2_8_1.b)pE.Items[iItems];
                                                Assert.AreEqual(bE.Text, bA.Text);
                                                break;
                                            case "OSM.MOSProtocol.Messages.MOS_2_8_1.u":
                                                Messages.MOS_2_8_1.u uA = (OSM.MOSProtocol.Messages.MOS_2_8_1.u)obj;
                                                Messages.MOS_2_8_1.u uE = (OSM.MOSProtocol.Messages.MOS_2_8_1.u)pE.Items[iItems];
                                                Assert.AreEqual(uE.Text, uA.Text);
                                                break;
                                            case "OSM.MOSProtocol.Messages.MOS_2_8_1.pi":
                                                Messages.MOS_2_8_1.pi piA = (OSM.MOSProtocol.Messages.MOS_2_8_1.pi)obj;
                                                Messages.MOS_2_8_1.pi piE = (OSM.MOSProtocol.Messages.MOS_2_8_1.pi)pE.Items[iItems];
                                                Assert.AreEqual(piE.Text, piA.Text);
                                                break;
                                            case "OSM.MOSProtocol.Messages.MOS_2_8_1.pkg":
                                                Messages.MOS_2_8_1.pkg pkgA = (OSM.MOSProtocol.Messages.MOS_2_8_1.pkg)obj;
                                                Messages.MOS_2_8_1.pkg pkgE = (OSM.MOSProtocol.Messages.MOS_2_8_1.pkg)pE.Items[iItems];
                                                Assert.AreEqual(pkgE.Text, pkgA.Text);
                                                break;
                                            case "OSM.MOSProtocol.Messages.MOS_2_8_1.i":
                                                Messages.MOS_2_8_1.i iA = (OSM.MOSProtocol.Messages.MOS_2_8_1.i)obj;
                                                Messages.MOS_2_8_1.i iE = (OSM.MOSProtocol.Messages.MOS_2_8_1.i)pE.Items[iItems];
                                                Assert.AreEqual(iE.Text, iA.Text);
                                                break;
                                        }
                                        ++iItems;
                                    }
                                }//check for objects within the p object
                                Assert.AreEqual(pE.Text, pA.Text);
                                break;
                            case "OSM.MOSProtocol.Messages.MOS_2_8_1.storyItem":
                                Messages.MOS_2_8_1.storyItem siA = (OSM.MOSProtocol.Messages.MOS_2_8_1.storyItem)obj;
                                Messages.MOS_2_8_1.storyItem siE = (OSM.MOSProtocol.Messages.MOS_2_8_1.storyItem)body_2_8_1.Items[i];
                                Assert.AreEqual(siE.itemID, siA.itemID);
                                Assert.AreEqual(siE.itemChannel, siA.itemChannel);
                                Assert.AreEqual(siE.itemEdDur, siA.itemEdDur);
                                Assert.AreEqual(siE.itemEdStart, siA.itemEdStart);
                                Assert.AreEqual(siE.itemSlug, siA.itemSlug);
                                Assert.AreEqual(siE.itemTrigger, siA.itemTrigger);
                                Assert.AreEqual(siE.itemUserTimingDur, siA.itemUserTimingDur);
                                Assert.AreEqual(siE.macroIn, siA.macroIn);
                                Assert.AreEqual(siE.macroOut, siA.macroOut);
                                Assert.AreEqual(siE.mosAbstract.InnerXml, siA.mosAbstract.InnerXml);
                                Assert.AreEqual(siE.mosID, siA.mosID);
                                Assert.AreEqual(siE.objID, siA.objID);
                                int iMEM = 0;
                                foreach (Messages.MOS_2_8_1.mosExternalMetadata mem in siA.mosExternalMetadata)
                                {
                                    Assert.AreEqual(siE.mosExternalMetadata[iMEM].mosScope, mem.mosScope);
                                    Assert.AreEqual(siE.mosExternalMetadata[iMEM].mosSchema, mem.mosSchema);
                                    Assert.AreEqual(siE.mosExternalMetadata[iMEM].mosPayload.InnerXml, mem.mosPayload.InnerXml);
                                    ++iMEM;
                                }
                                break;
                            default:
                                Console.WriteLine("UNKNOWN TYPE: " + obj.GetType().ToString());
                                break;
                        }
                        //Assert.AreEqual(body.Items[i], obj);
                        ++i;
                    }
                    #endregion - each object in the storybody
#endif
                    foreach (Messages.MOS_2_8_1.mosExternalMetadata mem in mos_2_8_1_roStorySend.mosExternalMetadata)
                    {
                        Assert.AreEqual(mosScope, mem.mosScope);
                        Assert.AreEqual(mosSchema, mem.mosSchema);
                        Assert.AreEqual(mosPayload.InnerXml, mem.mosPayload.InnerXml);
                    }
                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8_2.mos":
                    Messages.MOS_2_8_2.mos mos_2_8_2 = (Messages.MOS_2_8_2.mos)mos;
                    Assert.AreEqual(mosID_2_8_2, mos_2_8_2.mosID);
                    Assert.AreEqual(ncsID_2_8_2, mos_2_8_2.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8_2.roStorySend", mos_2_8_2.Item.GetType().ToString());
                    Messages.MOS_2_8_2.roStorySend mos_2_8_2_roStorySend = (Messages.MOS_2_8_2.roStorySend)mos_2_8_2.Item;
                    Assert.AreEqual(roID, mos_2_8_2_roStorySend.roID);
                    Assert.AreEqual(storySlug, mos_2_8_2_roStorySend.storySlug);
                    Assert.AreEqual(storyID, mos_2_8_2_roStorySend.storyID);
                    //storyBody
                    object objbody_2_8_2 = XmlSerializerHelper.DeserializeFromString(typeof(OSM.MOSProtocol.Messages.MOS_2_8_2.storyBody), storyBody_2_8_2);
                    Messages.MOS_2_8_2.storyBody body_2_8_2 = (OSM.MOSProtocol.Messages.MOS_2_8_2.storyBody)objbody_2_8_2;
                     i = 0;
#if false //TODO:Check Each object in the storyBody
                    #region Check Each object in the storyBody
                    foreach (object obj in mos_2_8_2_roStorySend.storyBody.Items)
                    {
                        switch (obj.GetType().ToString())
                        {
                            case "OSM.MOSProtocol.Messages.MOS_2_8_2.p":
                                Messages.MOS_2_8_2.p pA = (OSM.MOSProtocol.Messages.MOS_2_8_2.p)obj;
                                Messages.MOS_2_8_2.p pE = (OSM.MOSProtocol.Messages.MOS_2_8_2.p)body_2_8_2.Items[i];
                                Assert.AreEqual(pE.Text, pA.Text);
                                int iItems = 0;
                                if (pA.Items != null)
                                {
                                    foreach (object objItems in pA.Items)
                                    {
                                        switch (objItems.GetType().ToString())
                                        {
                                            case "OSM.MOSProtocol.Messages.MOS_2_8_2.b":
                                                Messages.MOS_2_8_2.b bA = (OSM.MOSProtocol.Messages.MOS_2_8_2.b)obj;
                                                Messages.MOS_2_8_2.b bE = (OSM.MOSProtocol.Messages.MOS_2_8_2.b)pE.Items[iItems];
                                                Assert.AreEqual(bE.Text, bA.Text);
                                                break;
                                            case "OSM.MOSProtocol.Messages.MOS_2_8_2.u":
                                                Messages.MOS_2_8_2.u uA = (OSM.MOSProtocol.Messages.MOS_2_8_2.u)obj;
                                                Messages.MOS_2_8_2.u uE = (OSM.MOSProtocol.Messages.MOS_2_8_2.u)pE.Items[iItems];
                                                Assert.AreEqual(uE.Text, uA.Text);
                                                break;
                                            case "OSM.MOSProtocol.Messages.MOS_2_8_2.pi":
                                                Messages.MOS_2_8_2.pi piA = (OSM.MOSProtocol.Messages.MOS_2_8_2.pi)obj;
                                                Messages.MOS_2_8_2.pi piE = (OSM.MOSProtocol.Messages.MOS_2_8_2.pi)pE.Items[iItems];
                                                Assert.AreEqual(piE.Text, piA.Text);
                                                break;
                                            case "OSM.MOSProtocol.Messages.MOS_2_8_2.pkg":
                                                Messages.MOS_2_8_2.pkg pkgA = (OSM.MOSProtocol.Messages.MOS_2_8_2.pkg)obj;
                                                Messages.MOS_2_8_2.pkg pkgE = (OSM.MOSProtocol.Messages.MOS_2_8_2.pkg)pE.Items[iItems];
                                                Assert.AreEqual(pkgE.Text, pkgA.Text);
                                                break;
                                            case "OSM.MOSProtocol.Messages.MOS_2_8_2.i":
                                                Messages.MOS_2_8_2.i iA = (OSM.MOSProtocol.Messages.MOS_2_8_2.i)obj;
                                                Messages.MOS_2_8_2.i iE = (OSM.MOSProtocol.Messages.MOS_2_8_2.i)pE.Items[iItems];
                                                Assert.AreEqual(iE.Text, iA.Text);
                                                break;
                                        }
                                        ++iItems;
                                    }
                                }//check for objects within the p object
                                Assert.AreEqual(pE.Text, pA.Text);
                                break;
                            case "OSM.MOSProtocol.Messages.MOS_2_8_2.storyItem":
                                Messages.MOS_2_8_2.storyItem siA = (OSM.MOSProtocol.Messages.MOS_2_8_2.storyItem)obj;
                                Messages.MOS_2_8_2.storyItem siE = (OSM.MOSProtocol.Messages.MOS_2_8_2.storyItem)body_2_8_2.Items[i];
                                Assert.AreEqual(siE.itemID, siA.itemID);
                                Assert.AreEqual(siE.itemChannel, siA.itemChannel);
                                Assert.AreEqual(siE.itemEdDur, siA.itemEdDur);
                                Assert.AreEqual(siE.itemEdStart, siA.itemEdStart);
                                Assert.AreEqual(siE.itemSlug, siA.itemSlug);
                                Assert.AreEqual(siE.itemTrigger, siA.itemTrigger);
                                Assert.AreEqual(siE.itemUserTimingDur, siA.itemUserTimingDur);
                                Assert.AreEqual(siE.macroIn, siA.macroIn);
                                Assert.AreEqual(siE.macroOut, siA.macroOut);
                                Assert.AreEqual(siE.mosAbstract.InnerXml, siA.mosAbstract.InnerXml);
                                Assert.AreEqual(siE.mosID, siA.mosID);
                                Assert.AreEqual(siE.objID, siA.objID);
                                int iMEM = 0;
                                foreach (Messages.MOS_2_8_2.mosExternalMetadata mem in siA.mosExternalMetadata)
                                {
                                    Assert.AreEqual(siE.mosExternalMetadata[iMEM].mosScope, mem.mosScope);
                                    Assert.AreEqual(siE.mosExternalMetadata[iMEM].mosSchema, mem.mosSchema);
                                    Assert.AreEqual(siE.mosExternalMetadata[iMEM].mosPayload.InnerXml, mem.mosPayload.InnerXml);
                                    ++iMEM;
                                }
                                break;
                            default:
                                Console.WriteLine("UNKNOWN TYPE: " + obj.GetType().ToString());
                                break;
                        }
                        //Assert.AreEqual(body.Items[i], obj);
                        ++i;
                    }
                    #endregion - each object in the storybody
#endif
                    foreach (Messages.MOS_2_8_2.mosExternalMetadata mem in mos_2_8_2_roStorySend.mosExternalMetadata)
                    {
                        Assert.AreEqual(mosScope, mem.mosScope);
                        Assert.AreEqual(mosSchema, mem.mosSchema);
                        Assert.AreEqual(mosPayload.InnerXml, mem.mosPayload.InnerXml);
                    }
                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8_3.mos":
                    Messages.MOS_2_8_3.mos mos_2_8_3 = (Messages.MOS_2_8_3.mos)mos;
                    Assert.AreEqual(mosID_2_8_3, mos_2_8_3.mosID);
                    Assert.AreEqual(ncsID_2_8_3, mos_2_8_3.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8_3.roStorySend", mos_2_8_3.Item.GetType().ToString());
                    Messages.MOS_2_8_3.roStorySend mos_2_8_3_roStorySend = (Messages.MOS_2_8_3.roStorySend)mos_2_8_3.Item;
                    Assert.AreEqual(roID, mos_2_8_3_roStorySend.roID);
                    Assert.AreEqual(storySlug, mos_2_8_3_roStorySend.storySlug);
                    Assert.AreEqual(storyID, mos_2_8_3_roStorySend.storyID);
                    //storyBody
                    object objbody_2_8_3 = XmlSerializerHelper.DeserializeFromString(typeof(OSM.MOSProtocol.Messages.MOS_2_8_3.storyBody), storyBody_2_8_3);
                    Messages.MOS_2_8_3.storyBody body_2_8_3 = (OSM.MOSProtocol.Messages.MOS_2_8_3.storyBody)objbody_2_8_3;
                     i = 0;
#if false //TODO:Check Each object in the storyBody
                    #region Check Each object in the storyBody
                    foreach (object obj in mos_2_8_3_roStorySend.storyBody.Items)
                    {
                        switch (obj.GetType().ToString())
                        {
                            case "OSM.MOSProtocol.Messages.MOS_2_8_3.p":
                                Messages.MOS_2_8_3.p pA = (OSM.MOSProtocol.Messages.MOS_2_8_3.p)obj;
                                Messages.MOS_2_8_3.p pE = (OSM.MOSProtocol.Messages.MOS_2_8_3.p)body_2_8_3.Items[i];
                                Assert.AreEqual(pE.Text, pA.Text);
                                int iItems = 0;
                                if (pA.Items != null)
                                {
                                    foreach (object objItems in pA.Items)
                                    {
                                        switch (objItems.GetType().ToString())
                                        {
                                            case "OSM.MOSProtocol.Messages.MOS_2_8_3.b":
                                                Messages.MOS_2_8_3.b bA = (OSM.MOSProtocol.Messages.MOS_2_8_3.b)obj;
                                                Messages.MOS_2_8_3.b bE = (OSM.MOSProtocol.Messages.MOS_2_8_3.b)pE.Items[iItems];
                                                Assert.AreEqual(bE.Text, bA.Text);
                                                break;
                                            case "OSM.MOSProtocol.Messages.MOS_2_8_3.u":
                                                Messages.MOS_2_8_3.u uA = (OSM.MOSProtocol.Messages.MOS_2_8_3.u)obj;
                                                Messages.MOS_2_8_3.u uE = (OSM.MOSProtocol.Messages.MOS_2_8_3.u)pE.Items[iItems];
                                                Assert.AreEqual(uE.Text, uA.Text);
                                                break;
                                            case "OSM.MOSProtocol.Messages.MOS_2_8_3.pi":
                                                Messages.MOS_2_8_3.pi piA = (OSM.MOSProtocol.Messages.MOS_2_8_3.pi)obj;
                                                Messages.MOS_2_8_3.pi piE = (OSM.MOSProtocol.Messages.MOS_2_8_3.pi)pE.Items[iItems];
                                                Assert.AreEqual(piE.Text, piA.Text);
                                                break;
                                            case "OSM.MOSProtocol.Messages.MOS_2_8_3.pkg":
                                                Messages.MOS_2_8_3.pkg pkgA = (OSM.MOSProtocol.Messages.MOS_2_8_3.pkg)obj;
                                                Messages.MOS_2_8_3.pkg pkgE = (OSM.MOSProtocol.Messages.MOS_2_8_3.pkg)pE.Items[iItems];
                                                Assert.AreEqual(pkgE.Text, pkgA.Text);
                                                break;
                                            case "OSM.MOSProtocol.Messages.MOS_2_8_3.i":
                                                Messages.MOS_2_8_3.i iA = (OSM.MOSProtocol.Messages.MOS_2_8_3.i)obj;
                                                Messages.MOS_2_8_3.i iE = (OSM.MOSProtocol.Messages.MOS_2_8_3.i)pE.Items[iItems];
                                                Assert.AreEqual(iE.Text, iA.Text);
                                                break;
                                        }
                                        ++iItems;
                                    }
                                }//check for objects within the p object
                                Assert.AreEqual(pE.Text, pA.Text);
                                break;
                            case "OSM.MOSProtocol.Messages.MOS_2_8_3.storyItem":
                                Messages.MOS_2_8_3.storyItem siA = (OSM.MOSProtocol.Messages.MOS_2_8_3.storyItem)obj;
                                Messages.MOS_2_8_3.storyItem siE = (OSM.MOSProtocol.Messages.MOS_2_8_3.storyItem)body_2_8_3.Items[i];
                                Assert.AreEqual(siE.itemID, siA.itemID);
                                Assert.AreEqual(siE.itemChannel, siA.itemChannel);
                                Assert.AreEqual(siE.itemEdDur, siA.itemEdDur);
                                Assert.AreEqual(siE.itemEdStart, siA.itemEdStart);
                                Assert.AreEqual(siE.itemSlug, siA.itemSlug);
                                Assert.AreEqual(siE.itemTrigger, siA.itemTrigger);
                                Assert.AreEqual(siE.itemUserTimingDur, siA.itemUserTimingDur);
                                Assert.AreEqual(siE.macroIn, siA.macroIn);
                                Assert.AreEqual(siE.macroOut, siA.macroOut);
                                Assert.AreEqual(siE.mosAbstract.InnerXml, siA.mosAbstract.InnerXml);
                                Assert.AreEqual(siE.mosID, siA.mosID);
                                Assert.AreEqual(siE.objID, siA.objID);
                                int iMEM = 0;
                                foreach (Messages.MOS_2_8_3.mosExternalMetadata mem in siA.mosExternalMetadata)
                                {
                                    Assert.AreEqual(siE.mosExternalMetadata[iMEM].mosScope, mem.mosScope);
                                    Assert.AreEqual(siE.mosExternalMetadata[iMEM].mosSchema, mem.mosSchema);
                                    Assert.AreEqual(siE.mosExternalMetadata[iMEM].mosPayload.InnerXml, mem.mosPayload.InnerXml);
                                    ++iMEM;
                                }
                                break;
                            default:
                                Console.WriteLine("UNKNOWN TYPE: " + obj.GetType().ToString());
                                break;
                        }
                        //Assert.AreEqual(body.Items[i], obj);
                        ++i;
                    }
                    #endregion - each object in the storybody
#endif
                    foreach (Messages.MOS_2_8_3.mosExternalMetadata mem in mos_2_8_3_roStorySend.mosExternalMetadata)
                    {
                        Assert.AreEqual(mosScope, mem.mosScope);
                        Assert.AreEqual(mosSchema, mem.mosSchema);
                        Assert.AreEqual(mosPayload.InnerXml, mem.mosPayload.InnerXml);
                    }
                    break;
            }

        }
        private void roMetadataReplaceAsserts(object mos)
        {
            #region properties to match
            //mosID
            string mosID_2_5 = "MOS25.MOS";
            string mosID_2_6 = "MOS26.MOS";
            string mosID_2_8 = "MOS28.MOS";
            string mosID_2_8_1 = "MOS281.MOS";
            string mosID_2_8_2 = "MOS282.MOS";
            string mosID_2_8_3 = "MOS283.MOS";
            string ncsID_2_8 = "MOS28.NCS";
            //ncsID
            string ncsID_2_5 = "MOS25.NCS";
            string ncsID_2_6 = "MOS26.NCS";
            string ncsID_2_8_1 = "MOS281.NCS";
            string ncsID_2_8_2 = "MOS282.NCS";
            string ncsID_2_8_3 = "MOS283.NCS";
            //messageID
            int messageID = 0;
            //roID
            string roID = @"DEMOENPS50VPC;P_OSM\W;AADC7235-007A-4317-BE112095DF74356A";
            string roSlug = "OSM Dev";
            string roEdStart = "2037-05-16T14:00:00";
            string roEdDur = "00:30:00";
            //roMEM
            string mosSchema = "http://DEMOENPS50VPC/schema/enpsro.dtd";
            string mosScope = "PLAYLIST";
            XmlElement mosPayload = new XmlDocument().CreateElement("mosPayload");
            mosPayload.InnerXml = "<EndTime>2037-05-16T14:30:00</EndTime>" +
                                "<RundownDuration>30:00</RundownDuration>" +
                                "<StartTime>2037-05-16T14:00:00</StartTime>" +
                                "<osmRODistribution DisplayValue='OSMIP;OSMClient'>2;21</osmRODistribution>" +
                                "<MOSroBlock>MOS.Server.rdm1.bnc.ap.mos;SNAPFEED.SNAPFEEDDEMO314VPC.MOS</MOSroBlock>" +
                                "<MOSroStorySend>MOS25.MOS;MOS26.MOS;MOS28.MOS;MOS281.MOS</MOSroStorySend>" +
                                "<ENPSItemType>2</ENPSItemType>" +
                                "<roLayout>PageNum_450|RowStatus_150|Slug_1200|SegStatus_210|Segment_915|MOSSlugs_1215|MOSStatus_1035|MOSIDs_1845|Break_600|Presenter_1005|Approved_600|Estimated_840|Actual_720|FrontTime_1005|BackTime_1005|CumeTime_1005|ModBy_1200</roLayout>";

            #endregion
            switch (mos.GetType().ToString())
            {
                case "OSM.MOSProtocol.Messages.MOS_2_6.mos":

                    Messages.MOS_2_6.mos mos_2_6 = (Messages.MOS_2_6.mos)mos;
                    Assert.AreEqual(mosID_2_6, mos_2_6.mosID);
                    Assert.AreEqual(ncsID_2_6, mos_2_6.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_6.roMetadataReplace", mos_2_6.Item.GetType().ToString());
                    Messages.MOS_2_6.roMetadataReplace mos_2_6_roMetadataReplace = (Messages.MOS_2_6.roMetadataReplace)mos_2_6.Item;
                    Assert.AreEqual(roID, mos_2_6_roMetadataReplace.roID);
                    Assert.AreEqual(roEdDur, mos_2_6_roMetadataReplace.roEdDur);
                    Assert.AreEqual(roEdStart, mos_2_6_roMetadataReplace.roEdStart);

                    Assert.AreEqual(mosScope, mos_2_6_roMetadataReplace.mosExternalMetadata.mosScope);
                    Assert.AreEqual(mosSchema, mos_2_6_roMetadataReplace.mosExternalMetadata.mosSchema);
                    Assert.AreEqual(mosPayload.InnerXml, mos_2_6_roMetadataReplace.mosExternalMetadata.mosPayload.InnerXml);

                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8.mos":

                    Messages.MOS_2_8.mos mos_2_8 = (Messages.MOS_2_8.mos)mos;
                    Assert.AreEqual(mosID_2_8, mos_2_8.mosID);
                    Assert.AreEqual(ncsID_2_8, mos_2_8.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8.roMetadataReplace", mos_2_8.Item.GetType().ToString());
                    Messages.MOS_2_8.roMetadataReplace mos_2_8_roMetadataReplace = (Messages.MOS_2_8.roMetadataReplace)mos_2_8.Item;
                    Assert.AreEqual(roID, mos_2_8_roMetadataReplace.roID);
                    Assert.AreEqual(roEdDur, mos_2_8_roMetadataReplace.roEdDur);
                    Assert.AreEqual(roEdStart, mos_2_8_roMetadataReplace.roEdStart);


                    Assert.AreEqual(mosScope, mos_2_8_roMetadataReplace.mosExternalMetadata.mosScope);
                    Assert.AreEqual(mosSchema, mos_2_8_roMetadataReplace.mosExternalMetadata.mosSchema);
                    Assert.AreEqual(mosPayload.InnerXml, mos_2_8_roMetadataReplace.mosExternalMetadata.mosPayload.InnerXml);

                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8_1.mos":

                    Messages.MOS_2_8_1.mos mos_2_8_1 = (Messages.MOS_2_8_1.mos)mos;
                    Assert.AreEqual(mosID_2_8_1, mos_2_8_1.mosID);
                    Assert.AreEqual(ncsID_2_8_1, mos_2_8_1.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8_1.roMetadataReplace", mos_2_8_1.Item.GetType().ToString());
                    Messages.MOS_2_8_1.roMetadataReplace mos_2_8_1_roMetadataReplace = (Messages.MOS_2_8_1.roMetadataReplace)mos_2_8_1.Item;
                    Assert.AreEqual(roID, mos_2_8_1_roMetadataReplace.roID);
                    Assert.AreEqual(roEdDur, mos_2_8_1_roMetadataReplace.roEdDur);
                    Assert.AreEqual(roEdStart, mos_2_8_1_roMetadataReplace.roEdStart);


                    Assert.AreEqual(mosScope, mos_2_8_1_roMetadataReplace.mosExternalMetadata.mosScope);
                    Assert.AreEqual(mosSchema, mos_2_8_1_roMetadataReplace.mosExternalMetadata.mosSchema);
                    Assert.AreEqual(mosPayload.InnerXml, mos_2_8_1_roMetadataReplace.mosExternalMetadata.mosPayload.InnerXml);


                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8_2.mos":

                    Messages.MOS_2_8_2.mos mos_2_8_2 = (Messages.MOS_2_8_2.mos)mos;
                    Assert.AreEqual(mosID_2_8_2, mos_2_8_2.mosID);
                    Assert.AreEqual(ncsID_2_8_2, mos_2_8_2.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8_2.roMetadataReplace", mos_2_8_2.Item.GetType().ToString());
                    Messages.MOS_2_8_2.roMetadataReplace mos_2_8_2_roMetadataReplace = (Messages.MOS_2_8_2.roMetadataReplace)mos_2_8_2.Item;
                    Assert.AreEqual(roID, mos_2_8_2_roMetadataReplace.roID);
                    Assert.AreEqual(roEdDur, mos_2_8_2_roMetadataReplace.roEdDur);
                    Assert.AreEqual(roEdStart, mos_2_8_2_roMetadataReplace.roEdStart);


                    Assert.AreEqual(mosScope, mos_2_8_2_roMetadataReplace.mosExternalMetadata.mosScope);
                    Assert.AreEqual(mosSchema, mos_2_8_2_roMetadataReplace.mosExternalMetadata.mosSchema);
                    Assert.AreEqual(mosPayload.InnerXml, mos_2_8_2_roMetadataReplace.mosExternalMetadata.mosPayload.InnerXml);

                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8_3.mos":

                    Messages.MOS_2_8_3.mos mos_2_8_3 = (Messages.MOS_2_8_3.mos)mos;
                    Assert.AreEqual(mosID_2_8_3, mos_2_8_3.mosID);
                    Assert.AreEqual(ncsID_2_8_3, mos_2_8_3.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8_3.roMetadataReplace", mos_2_8_3.Item.GetType().ToString());
                    Messages.MOS_2_8_3.roMetadataReplace mos_2_8_3_roMetadataReplace = (Messages.MOS_2_8_3.roMetadataReplace)mos_2_8_3.Item;
                    Assert.AreEqual(roID, mos_2_8_3_roMetadataReplace.roID);
                    Assert.AreEqual(mos_2_8_3_roMetadataReplace.roEdDur, roEdDur);
                    Assert.AreEqual(roEdStart, mos_2_8_3_roMetadataReplace.roEdStart);

                    Assert.AreEqual(mosScope, mos_2_8_3_roMetadataReplace.mosExternalMetadata.mosScope);
                    Assert.AreEqual(mosSchema, mos_2_8_3_roMetadataReplace.mosExternalMetadata.mosSchema);
                    Assert.AreEqual(mosPayload.InnerXml, mos_2_8_3_roMetadataReplace.mosExternalMetadata.mosPayload.InnerXml);

                    break;
            }

        }
        private void roReadyToAirAsserts(object mos)
        {
            //mosID
            //ncsID
            //messageID
            //roID
            //Air
        }
        private void roListAsserts(object mos)
        {
            int i = 0;
            #region properties to match
            //mosID
            string mosID_2_5 = "MOS25.MOS";
            string mosID_2_6 = "MOS26.MOS";
            string mosID_2_8 = "MOS28.MOS";
            string mosID_2_8_1 = "MOS281.MOS";
            string mosID_2_8_2 = "MOS282.MOS";
            string mosID_2_8_3 = "MOS283.MOS";
            string ncsID_2_8 = "MOS28.NCS";
            //ncsID
            string ncsID_2_5 = "MOS25.NCS";
            string ncsID_2_6 = "MOS26.NCS";
            string ncsID_2_8_1 = "MOS281.NCS";
            string ncsID_2_8_2 = "MOS282.NCS";
            string ncsID_2_8_3 = "MOS283.NCS";
            //messageID
            int messageID = 0;
            //roID
            string roID = @"DEMOENPS50VPC;P_OSM\W;6EEF52CC-59E2-4B8E-BABB7544CD07D7F1";
            string roSlug = "OSM Dev 2";
            string roEdStart = "2037-05-16T14:00:00";
            string roEdDur = "00:30:00";
            //roMEM
            string mosSchema = "http://DEMOENPS50VPC/schema/enpsro.dtd";
            string mosScope = "PLAYLIST";
            XmlElement mosPayload = new XmlDocument().CreateElement("mosPayload");
            mosPayload.InnerXml = "<EndTime>2037-05-16T14:30:00</EndTime>" +
                                "<RundownDuration>30:00</RundownDuration>" +
                                "<StartTime>2037-05-16T14:00:00</StartTime>" +
                                "<osmRODistribution DisplayValue='OSMIP;OSMClient'>2;21</osmRODistribution>" +
                                "<MOSroBlock>MOS.Server.rdm1.bnc.ap.mos;SNAPFEED.SNAPFEEDDEMO314VPC.MOS</MOSroBlock>" +
                                "<MOSroStorySend>MOS25.MOS;MOS26.MOS;MOS28.MOS;MOS281.MOS</MOSroStorySend>" +
                                "<ENPSItemType>2</ENPSItemType>" +
                                "<roLayout>PageNum_450|RowStatus_150|Slug_1200|SegStatus_210|Segment_915|MOSSlugs_1215|MOSStatus_1035|MOSIDs_1845|Break_600|Presenter_1005|Approved_600|Estimated_840|Actual_720|FrontTime_1005|BackTime_1005|CumeTime_1005|ModBy_1200</roLayout>";
            //storyIDs
            Dictionary<string, string> storyID = new Dictionary<string, string>();
            storyID.Add(@"DEMOENPS50VPC;P_OSM\W\R_6EEF52CC-59E2-4B8E-BABB7544CD07D7F1;35F282FD-0027-4375-A24C6243C6830E0F", "Rename story slug");
            storyID.Add(@"DEMOENPS50VPC;P_OSM\W\R_6EEF52CC-59E2-4B8E-BABB7544CD07D7F1;AA4CAA3F-F045-4D8A-8DF0296673E91618", "MOS Server Countdowns");
            storyID.Add(@"DEMOENPS50VPC;P_OSM\W\R_6EEF52CC-59E2-4B8E-BABB7544CD07D7F1;40DAD89F-C5F2-4615-8203898DFA65D3EB", "MOS Server Countdowns");
            storyID.Add(@"DEMOENPS50VPC;P_OSM\W\R_6EEF52CC-59E2-4B8E-BABB7544CD07D7F1;179DF44E-BDAA-4500-981F17C9FD63B049", "MOS Server Countdowns");
            storyID.Add(@"DEMOENPS50VPC;P_OSM\W\R_6EEF52CC-59E2-4B8E-BABB7544CD07D7F1;87BA93AE-A5F0-4A45-B50772617AA46B61", "MOS Server Master Countdown");
            storyID.Add(@"DEMOENPS50VPC;P_OSM\W\R_6EEF52CC-59E2-4B8E-BABB7544CD07D7F1;FC3D4E16-D4D4-4C28-83D5033F838A9E3C", "MOS Server Master Countdown");
            storyID.Add(@"DEMOENPS50VPC;P_OSM\W\R_6EEF52CC-59E2-4B8E-BABB7544CD07D7F1;FC4FCB85-33FB-4E19-BC9183FF5358AEDE", "MOS Server Master Countdown");
            storyID.Add(@"DEMOENPS50VPC;P_OSM\W\R_6EEF52CC-59E2-4B8E-BABB7544CD07D7F1;5E88F12C-CAE5-4BA9-94480C53E18350B3", "MOS Server Master Countdown");
            storyID.Add(@"DEMOENPS50VPC;P_OSM\W\R_6EEF52CC-59E2-4B8E-BABB7544CD07D7F1;5442DA0C-6681-4E61-8FDAB53B311A5708", "MOS Server Master Countdown");
            storyID.Add(@"DEMOENPS50VPC;P_OSM\W\R_6EEF52CC-59E2-4B8E-BABB7544CD07D7F1;203C6710-A8F5-455E-963BB43E650FE58B", "MOS Server Master Countdown");
 
            #endregion

            switch (mos.GetType().ToString())
            {
                case "OSM.MOSProtocol.Messages.MOS_2_5.mos":

                    Messages.MOS_2_5.mos mos_2_5 = (Messages.MOS_2_5.mos)mos;
                    Assert.AreEqual(mosID_2_5, mos_2_5.mosID);
                    Assert.AreEqual(ncsID_2_5, mos_2_5.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_5.roList", mos_2_5.Item.GetType().ToString());
                    Messages.MOS_2_5.roList mos_2_5_roList = (Messages.MOS_2_5.roList)mos_2_5.Item;
                    Assert.AreEqual(roID, mos_2_5_roList.roID);
                    Assert.AreEqual(roSlug, mos_2_5_roList.roSlug);
                    Assert.AreEqual(roEdDur, mos_2_5_roList.roEdDur);
                    Assert.AreEqual(roEdStart, mos_2_5_roList.roEdStart);
                    i = 0;
                    foreach (KeyValuePair<string, string> kvp in storyID)
                    {
                        Assert.AreEqual(kvp.Key, mos_2_5_roList.story[i].storyID);
                        Assert.AreEqual(kvp.Value, mos_2_5_roList.story[i].storySlug);
                        ++i;
                    }

                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_6.mos":

                    Messages.MOS_2_6.mos mos_2_6 = (Messages.MOS_2_6.mos)mos;
                    Assert.AreEqual(mosID_2_6, mos_2_6.mosID);
                    Assert.AreEqual(ncsID_2_6, mos_2_6.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_6.roList", mos_2_6.Item.GetType().ToString());
                    Messages.MOS_2_6.roList mos_2_6_roList = (Messages.MOS_2_6.roList)mos_2_6.Item;
                    Assert.AreEqual(roID, mos_2_6_roList.roID);
                    Assert.AreEqual(roEdDur, mos_2_6_roList.roEdDur);
                    Assert.AreEqual(roEdStart, mos_2_6_roList.roEdStart);
                    i = 0;
                    foreach (KeyValuePair<string, string> kvp in storyID)
                    {
                        Assert.AreEqual(kvp.Key, mos_2_6_roList.story[i].storyID);
                        Assert.AreEqual(kvp.Value, mos_2_6_roList.story[i].storySlug);
                        ++i;
                    }
                    foreach (Messages.MOS_2_6.mosExternalMetadata mem in mos_2_6_roList.mosExternalMetadata)
                    {
                        Assert.AreEqual(mosScope, mem.mosScope);
                        Assert.AreEqual(mosSchema, mem.mosSchema);
                        Assert.AreEqual(mosPayload.InnerXml, mem.mosPayload.InnerXml);
                    }
                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8.mos":

                    Messages.MOS_2_8.mos mos_2_8 = (Messages.MOS_2_8.mos)mos;
                    Assert.AreEqual(mosID_2_8, mos_2_8.mosID);
                    Assert.AreEqual(ncsID_2_8, mos_2_8.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8.roList", mos_2_8.Item.GetType().ToString());
                    Messages.MOS_2_8.roList mos_2_8_roList = (Messages.MOS_2_8.roList)mos_2_8.Item;
                    Assert.AreEqual(roID, mos_2_8_roList.roID);
                    Assert.AreEqual(roEdDur, mos_2_8_roList.roEdDur);
                    Assert.AreEqual(roEdStart, mos_2_8_roList.roEdStart);
                    i = 0;
                    foreach (KeyValuePair<string, string> kvp in storyID)
                    {
                        Assert.AreEqual(kvp.Key, mos_2_8_roList.story[i].storyID);
                        Assert.AreEqual(kvp.Value, mos_2_8_roList.story[i].storySlug);
                        ++i;
                    }
                    foreach (Messages.MOS_2_8.mosExternalMetadata mem in mos_2_8_roList.mosExternalMetadata)
                    {
                        Assert.AreEqual(mosScope, mem.mosScope);
                        Assert.AreEqual(mosSchema, mem.mosSchema);
                        Assert.AreEqual(mosPayload.InnerXml, mem.mosPayload.InnerXml);
                    }
                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8_1.mos":

                    Messages.MOS_2_8_1.mos mos_2_8_1 = (Messages.MOS_2_8_1.mos)mos;
                    Assert.AreEqual(mosID_2_8_1, mos_2_8_1.mosID);
                    Assert.AreEqual(ncsID_2_8_1, mos_2_8_1.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8_1.roList", mos_2_8_1.Item.GetType().ToString());
                    Messages.MOS_2_8_1.roList mos_2_8_1_roList = (Messages.MOS_2_8_1.roList)mos_2_8_1.Item;
                    Assert.AreEqual(roID, mos_2_8_1_roList.roID);
                    Assert.AreEqual(roEdDur, mos_2_8_1_roList.roEdDur);
                    Assert.AreEqual(roEdStart, mos_2_8_1_roList.roEdStart);
                    i = 0;
                    foreach (KeyValuePair<string, string> kvp in storyID)
                    {
                        Assert.AreEqual(kvp.Key, mos_2_8_1_roList.story[i].storyID);
                        Assert.AreEqual(kvp.Value, mos_2_8_1_roList.story[i].storySlug);
                        ++i;
                    }
                    foreach (Messages.MOS_2_8_1.mosExternalMetadata mem in mos_2_8_1_roList.mosExternalMetadata)
                    {
                        Assert.AreEqual(mosScope, mem.mosScope);
                        Assert.AreEqual(mosSchema, mem.mosSchema);
                        Assert.AreEqual(mosPayload.InnerXml, mem.mosPayload.InnerXml);
                    }

                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8_2.mos":

                    Messages.MOS_2_8_2.mos mos_2_8_2 = (Messages.MOS_2_8_2.mos)mos;
                    Assert.AreEqual(mosID_2_8_2, mos_2_8_2.mosID);
                    Assert.AreEqual(ncsID_2_8_2, mos_2_8_2.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8_2.roList", mos_2_8_2.Item.GetType().ToString());
                    Messages.MOS_2_8_2.roList mos_2_8_2_roList = (Messages.MOS_2_8_2.roList)mos_2_8_2.Item;
                    Assert.AreEqual(roID, mos_2_8_2_roList.roID);
                    Assert.AreEqual(roEdDur, mos_2_8_2_roList.roEdDur);
                    Assert.AreEqual(roEdStart, mos_2_8_2_roList.roEdStart);
                    i = 0;
                    foreach (KeyValuePair<string, string> kvp in storyID)
                    {
                        Assert.AreEqual(kvp.Key, mos_2_8_2_roList.story[i].storyID);
                        Assert.AreEqual(kvp.Value, mos_2_8_2_roList.story[i].storySlug);
                        ++i;
                    }
                    foreach (Messages.MOS_2_8_2.mosExternalMetadata mem in mos_2_8_2_roList.mosExternalMetadata)
                    {
                        Assert.AreEqual(mosScope, mem.mosScope);
                        Assert.AreEqual(mosSchema, mem.mosSchema);
                        Assert.AreEqual(mosPayload.InnerXml, mem.mosPayload.InnerXml);
                    }
                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8_3.mos":

                    Messages.MOS_2_8_3.mos mos_2_8_3 = (Messages.MOS_2_8_3.mos)mos;
                    Assert.AreEqual(mosID_2_8_3, mos_2_8_3.mosID);
                    Assert.AreEqual(ncsID_2_8_3, mos_2_8_3.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8_3.roList", mos_2_8_3.Item.GetType().ToString());
                    Messages.MOS_2_8_3.roList mos_2_8_3_roList = (Messages.MOS_2_8_3.roList)mos_2_8_3.Item;
                    Assert.AreEqual(roID, mos_2_8_3_roList.roID);
                    Assert.AreEqual(mos_2_8_3_roList.roEdDur, roEdDur);
                    Assert.AreEqual(roEdStart, mos_2_8_3_roList.roEdStart);
                    i = 0;
                    foreach (KeyValuePair<string, string> kvp in storyID)
                    {
                        Assert.AreEqual(kvp.Key, mos_2_8_3_roList.story[i].storyID);
                        Assert.AreEqual(kvp.Value, mos_2_8_3_roList.story[i].storySlug);
                        ++i;
                    }
                    foreach (Messages.MOS_2_8_3.mosExternalMetadata mem in mos_2_8_3_roList.mosExternalMetadata)
                    {
                        Assert.AreEqual(mosScope, mem.mosScope);
                        Assert.AreEqual(mosSchema, mem.mosSchema);
                        Assert.AreEqual(mosPayload.InnerXml, mem.mosPayload.InnerXml);
                    }
                    break;
            }

        }

        private void roListAllAsserts(object mos)
        {
            int i = 0;
            #region properties to match
            //mosID
            string mosID_2_5 = "MOS25.MOS";
            string mosID_2_6 = "MOS26.MOS";
            string mosID_2_8 = "MOS28.MOS";
            string mosID_2_8_1 = "MOS281.MOS";
            string mosID_2_8_2 = "MOS282.MOS";
            string mosID_2_8_3 = "MOS283.MOS";
            string ncsID_2_8 = "MOS28.NCS";
            //ncsID
            string ncsID_2_5 = "MOS25.NCS";
            string ncsID_2_6 = "MOS26.NCS";
            string ncsID_2_8_1 = "MOS281.NCS";
            string ncsID_2_8_2 = "MOS282.NCS";
            string ncsID_2_8_3 = "MOS283.NCS";
            //messageID
            int messageID = 0;

            string roEdStart = "2037-05-16T14:00:00";
            string roEdDur = "00:30:00";
            //roMEM
            string mosSchema = "http://DEMOENPS50VPC/schema/enpsro.dtd";
            string mosScope = "PLAYLIST";
            XmlElement mosPayload = new XmlDocument().CreateElement("mosPayload");
            mosPayload.InnerXml = "<roMOSIDList>\n" +
                                    "MOS25.MOS;MOS26.MOS;MOS28.MOS;MOS281.MOS</roMOSIDList>";
            //storyIDs
            Dictionary<string, string> roID = new Dictionary<string, string>();
            roID.Add(@"DEMOENPS50VPC;P_OSM\W;AADC7235-007A-4317-BE112095DF74356A", "OSM Dev change");
            roID.Add(@"DEMOENPS50VPC;P_OSM\W;6EEF52CC-59E2-4B8E-BABB7544CD07D7F1", "OSM Dev 2");

            #endregion

            switch (mos.GetType().ToString())
            {
                case "OSM.MOSProtocol.Messages.MOS_2_5.mos":

                    Messages.MOS_2_5.mos mos_2_5 = (Messages.MOS_2_5.mos)mos;
                    Assert.AreEqual(mosID_2_5, mos_2_5.mosID);
                    Assert.AreEqual(ncsID_2_5, mos_2_5.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_5.roListAll", mos_2_5.Item.GetType().ToString());
                    Messages.MOS_2_5.roListAll mos_2_5_roListAll = (Messages.MOS_2_5.roListAll)mos_2_5.Item;
                    Console.WriteLine("roList " + mos_2_5_roListAll.roID.Length);
                    i = 0;
                    foreach (KeyValuePair<string, string> kvp in roID)
                    {

                        Assert.AreEqual(kvp.Key, mos_2_5_roListAll.roID[i]);
                        Assert.AreEqual(kvp.Value, mos_2_5_roListAll.roSlug[i]);
                        ++i;
                    }

                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_6.mos":

                    Messages.MOS_2_6.mos mos_2_6 = (Messages.MOS_2_6.mos)mos;
                    Assert.AreEqual(mosID_2_6, mos_2_6.mosID);
                    Assert.AreEqual(ncsID_2_6, mos_2_6.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_6.roListAll", mos_2_6.Item.GetType().ToString());
                    Messages.MOS_2_6.roListAll mos_2_6_roListAll = (Messages.MOS_2_6.roListAll)mos_2_6.Item;
                    i = 0;
                    foreach (KeyValuePair<string, string> kvp in roID)
                    {
                        Assert.AreEqual(kvp.Key, mos_2_6_roListAll.roID[i]);
                        Assert.AreEqual(kvp.Value, mos_2_6_roListAll.roSlug[i]);
                        ++i;
                    }
                    foreach (Messages.MOS_2_6.mosExternalMetadata mem in mos_2_6_roListAll.mosExternalMetadata)
                    {
                        Assert.AreEqual(mosScope, mem.mosScope);
                        Assert.AreEqual(mosSchema, mem.mosSchema);
                        Assert.AreEqual(mosPayload.InnerXml, mem.mosPayload.InnerXml);
                    }
                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8.mos":

                    Messages.MOS_2_8.mos mos_2_8 = (Messages.MOS_2_8.mos)mos;
                    Assert.AreEqual(mosID_2_8, mos_2_8.mosID);
                    Assert.AreEqual(ncsID_2_8, mos_2_8.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8.roListAll", mos_2_8.Item.GetType().ToString());
                    Messages.MOS_2_8.roListAll mos_2_8_roListAll = (Messages.MOS_2_8.roListAll)mos_2_8.Item;
          
                    i = 0;
                    foreach (KeyValuePair<string, string> kvp in roID)
                    {
                        Assert.AreEqual(kvp.Key, mos_2_8_roListAll.ro[i].roID);
                        Assert.AreEqual(kvp.Value, mos_2_8_roListAll.ro[i].roSlug);
                         
                        foreach (Messages.MOS_2_8.mosExternalMetadata mem in mos_2_8_roListAll.ro[i].mosExternalMetadata)
                        {
                            Assert.AreEqual(mosScope, mem.mosScope);
                            Assert.AreEqual(mosSchema, mem.mosSchema);
                            Assert.AreEqual(mosPayload.InnerXml, mem.mosPayload.InnerXml);
                        }
                        ++i;
                    }
                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8_1.mos":

                    Messages.MOS_2_8_1.mos mos_2_8_1 = (Messages.MOS_2_8_1.mos)mos;
                    Assert.AreEqual(mosID_2_8_1, mos_2_8_1.mosID);
                    Assert.AreEqual(ncsID_2_8_1, mos_2_8_1.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8_1.roListAll", mos_2_8_1.Item.GetType().ToString());
                    Messages.MOS_2_8_1.roListAll mos_2_8_1_roListAll = (Messages.MOS_2_8_1.roListAll)mos_2_8_1.Item;
                    
                    i = 0;
                    foreach (KeyValuePair<string, string> kvp in roID)
                    {
                        Assert.AreEqual(kvp.Key, mos_2_8_1_roListAll.ro[i].roID);
                        Assert.AreEqual(kvp.Value, mos_2_8_1_roListAll.ro[i].roSlug);
                        foreach (Messages.MOS_2_8_1.mosExternalMetadata mem in mos_2_8_1_roListAll.ro[i].mosExternalMetadata)
                        {
                            Assert.AreEqual(mosScope, mem.mosScope);
                            Assert.AreEqual(mosSchema, mem.mosSchema);
                            Assert.AreEqual(mosPayload.InnerXml, mem.mosPayload.InnerXml);
                        }

                        ++i;
                    }
                    
                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8_2.mos":

                    Messages.MOS_2_8_2.mos mos_2_8_2 = (Messages.MOS_2_8_2.mos)mos;
                    Assert.AreEqual(mosID_2_8_2, mos_2_8_2.mosID);
                    Assert.AreEqual(ncsID_2_8_2, mos_2_8_2.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8_2.roListAll", mos_2_8_2.Item.GetType().ToString());
                    Messages.MOS_2_8_2.roListAll mos_2_8_2_roListAll = (Messages.MOS_2_8_2.roListAll)mos_2_8_2.Item;
                   
                    i = 0;
                    foreach (KeyValuePair<string, string> kvp in roID)
                    {
                        Assert.AreEqual(kvp.Key, mos_2_8_2_roListAll.ro[i].roID);
                        Assert.AreEqual(kvp.Value, mos_2_8_2_roListAll.ro[i].roSlug);

                        foreach (Messages.MOS_2_8_2.mosExternalMetadata mem in mos_2_8_2_roListAll.ro[i].mosExternalMetadata)
                        {
                            Assert.AreEqual(mosScope, mem.mosScope);
                            Assert.AreEqual(mosSchema, mem.mosSchema);
                            Assert.AreEqual(mosPayload.InnerXml, mem.mosPayload.InnerXml);
                        }
                        ++i;
                    }
                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8_3.mos":

                    Messages.MOS_2_8_3.mos mos_2_8_3 = (Messages.MOS_2_8_3.mos)mos;
                    Assert.AreEqual(mosID_2_8_3, mos_2_8_3.mosID);
                    Assert.AreEqual(ncsID_2_8_3, mos_2_8_3.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8_3.roListAll", mos_2_8_3.Item.GetType().ToString());
                    Messages.MOS_2_8_3.roListAll mos_2_8_3_roListAll = (Messages.MOS_2_8_3.roListAll)mos_2_8_3.Item;
                
                    i = 0;
                    foreach (KeyValuePair<string, string> kvp in roID)
                    {
                        Assert.AreEqual(kvp.Key, mos_2_8_3_roListAll.ro[i].roID);
                        Assert.AreEqual(kvp.Value, mos_2_8_3_roListAll.ro[i].roSlug);


                        foreach (Messages.MOS_2_8_3.mosExternalMetadata mem in mos_2_8_3_roListAll.ro[i].mosExternalMetadata)
                        {
                            Assert.AreEqual(mosScope, mem.mosScope);
                            Assert.AreEqual(mosSchema, mem.mosSchema);
                            Assert.AreEqual(mosPayload.InnerXml, mem.mosPayload.InnerXml);
                        }
                        ++i;
                    }
                    break;
            }

        }
        #endregion ALL

        #region MOS 2.5+2.6 RO Messages
        private void roStoryReplaceAsserts(object mos)
        {
            //mosID
            //ncsID
            //messageID
            //roID
            //storyID
        }
        private void roStoryAppendAsserts(object mos)
        {
            //mosID
            //ncsID
            //messageID
            //roID
            //storyID
        }
        private void roStoryDeleteAsserts(object mos)
        {
            //mosID
            //ncsID
            //messageID
            //roID
            //storyID
        }
        private void roStoryInsertAsserts(object mos)
        {
            //mosID
            //ncsID
            //messageID
            //roID
            //storyID
        }
        private void roReplaceAsserts(object mos)
        {
            //mosID
            //ncsID
            //roID
        }
        
        #endregion

        #region MOS 2.8+ roElement Messages
        private void roElementActionInsertAppendAsserts(object mos)
        {
            #region properties to match
            //mosID
            string mosID_2_8 = "MOS28.MOS";
            string mosID_2_8_1 = "MOS281.MOS";
            string mosID_2_8_2 = "MOS282.MOS";
            string mosID_2_8_3 = "MOS283.MOS";
            string ncsID_2_8 = "MOS28.NCS";
            //ncsID
            string ncsID_2_8_1 = "MOS281.NCS";
            string ncsID_2_8_2 = "MOS282.NCS";
            string ncsID_2_8_3 = "MOS283.NCS";
            //messageID
            int messageID = 0;
            //roID
            string roID = @"DEMOENPS50VPC;P_OSM\W;AADC7235-007A-4317-BE112095DF74356A";
            string storyID = @"DEMOENPS50VPC;P_OSM\W\R_AADC7235-007A-4317-BE112095DF74356A;12340810-B60C-4801-BE6657A420EEC4EF";
            string targetStoryID = @"";
            string storySlug = @"Append";
            string storyNum = @"";
            Messages.MOS_2_8.roElementActionOperation enumOperation_2_8 = OSM.MOSProtocol.Messages.MOS_2_8.roElementActionOperation.INSERT;
            Messages.MOS_2_8_1.roElementActionOperation enumOperation_2_8_1 = OSM.MOSProtocol.Messages.MOS_2_8_1.roElementActionOperation.INSERT;
            Messages.MOS_2_8_2.roElementActionOperation enumOperation_2_8_2 = OSM.MOSProtocol.Messages.MOS_2_8_2.roElementActionOperation.INSERT;
            Messages.MOS_2_8_3.roElementActionOperation enumOperation_2_8_3 = OSM.MOSProtocol.Messages.MOS_2_8_3.roElementActionOperation.INSERT;
            #endregion
            switch (mos.GetType().ToString())
            {
                case "OSM.MOSProtocol.Messages.MOS_2_8.mos":

                    Messages.MOS_2_8.mos mos_2_8 = (Messages.MOS_2_8.mos)mos;
                    Assert.AreEqual(mosID_2_8, mos_2_8.mosID);
                    Assert.AreEqual(ncsID_2_8, mos_2_8.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8.roElementAction", mos_2_8.Item.GetType().ToString());
                    Messages.MOS_2_8.roElementAction mos_2_8_roElementAction = (Messages.MOS_2_8.roElementAction)mos_2_8.Item;
                    Assert.AreEqual(roID, mos_2_8_roElementAction.roID);
                    Assert.AreEqual(enumOperation_2_8, mos_2_8_roElementAction.operation);
                    int i = 0;
                    foreach (Messages.MOS_2_8.ItemsChoiceType2 sourceType in mos_2_8_roElementAction.element_source.ItemsElementName)
                    {
                        switch (sourceType)
                        {
                            case Messages.MOS_2_8.ItemsChoiceType2.storyID:
                                Assert.AreEqual(storyID, (string)mos_2_8_roElementAction.element_source.Items[i]);
                                break;
                            case Messages.MOS_2_8.ItemsChoiceType2.story:
                                OSM.MOSProtocol.Messages.MOS_2_8.story sourceStory = (OSM.MOSProtocol.Messages.MOS_2_8.story)mos_2_8_roElementAction.element_source.Items[i];
                                Assert.AreEqual(storyID, sourceStory.storyID);
                                Assert.AreEqual(storySlug, sourceStory.storySlug);
                                Assert.AreEqual(storyNum, sourceStory.storyNum);
                                break;
                        }
                        ++i;
                    }
                    Assert.AreEqual(targetStoryID, mos_2_8_roElementAction.element_target.storyID);
                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8_1.mos":

                    Messages.MOS_2_8_1.mos mos_2_8_1 = (Messages.MOS_2_8_1.mos)mos;
                    Assert.AreEqual(mosID_2_8_1, mos_2_8_1.mosID);
                    Assert.AreEqual(ncsID_2_8_1, mos_2_8_1.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8_1.roElementAction", mos_2_8_1.Item.GetType().ToString());
                    Messages.MOS_2_8_1.roElementAction mos_2_8_1_roElementAction = (Messages.MOS_2_8_1.roElementAction)mos_2_8_1.Item;
                    Assert.AreEqual(roID, mos_2_8_1_roElementAction.roID);
                    Assert.AreEqual(enumOperation_2_8_1, mos_2_8_1_roElementAction.operation);
                    i = 0;
                    foreach (Messages.MOS_2_8_1.ItemsChoiceType2 sourceType in mos_2_8_1_roElementAction.element_source.ItemsElementName)
                    {
                        switch (sourceType)
                        {
                            case Messages.MOS_2_8_1.ItemsChoiceType2.storyID:
                                Assert.AreEqual(storyID, (string)mos_2_8_1_roElementAction.element_source.Items[i]);
                                break;
                            case Messages.MOS_2_8_1.ItemsChoiceType2.story:
                                OSM.MOSProtocol.Messages.MOS_2_8_1.story sourceStory = (OSM.MOSProtocol.Messages.MOS_2_8_1.story)mos_2_8_1_roElementAction.element_source.Items[i];
                                Assert.AreEqual(storyID, sourceStory.storyID);
                                Assert.AreEqual(storySlug, sourceStory.storySlug);
                                Assert.AreEqual(storyNum, sourceStory.storyNum);
                                break;
                        }
                        ++i;
                    }
                    Assert.AreEqual(targetStoryID, mos_2_8_1_roElementAction.element_target.storyID);
                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8_2.mos":

                    Messages.MOS_2_8_2.mos mos_2_8_2 = (Messages.MOS_2_8_2.mos)mos;
                    Assert.AreEqual(mosID_2_8_2, mos_2_8_2.mosID);
                    Assert.AreEqual(ncsID_2_8_2, mos_2_8_2.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8_2.roElementAction", mos_2_8_2.Item.GetType().ToString());
                    Messages.MOS_2_8_2.roElementAction mos_2_8_2_roElementAction = (Messages.MOS_2_8_2.roElementAction)mos_2_8_2.Item;
                    Assert.AreEqual(roID, mos_2_8_2_roElementAction.roID);
                    Assert.AreEqual(enumOperation_2_8_2, mos_2_8_2_roElementAction.operation);
                    i = 0;
                    foreach (Messages.MOS_2_8_2.ItemsChoiceType2 sourceType in mos_2_8_2_roElementAction.element_source.ItemsElementName)
                    {
                        switch (sourceType)
                        {
                            case Messages.MOS_2_8_2.ItemsChoiceType2.storyID:
                                Assert.AreEqual(storyID, (string)mos_2_8_2_roElementAction.element_source.Items[i]);
                                break;
                            case Messages.MOS_2_8_2.ItemsChoiceType2.story:
                                OSM.MOSProtocol.Messages.MOS_2_8_2.story sourceStory = (OSM.MOSProtocol.Messages.MOS_2_8_2.story)mos_2_8_2_roElementAction.element_source.Items[i];
                                Assert.AreEqual(storyID, sourceStory.storyID);
                                Assert.AreEqual(storySlug, sourceStory.storySlug);
                                Assert.AreEqual(storyNum, sourceStory.storyNum);
                                break;
                        }
                        ++i;
                    }
                    Assert.AreEqual(targetStoryID, mos_2_8_2_roElementAction.element_target.storyID);
                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8_3.mos":
                    Messages.MOS_2_8_3.mos mos_2_8_3 = (Messages.MOS_2_8_3.mos)mos;
                    Assert.AreEqual(mosID_2_8_3, mos_2_8_3.mosID);
                    Assert.AreEqual(ncsID_2_8_3, mos_2_8_3.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8_3.roElementAction", mos_2_8_3.Item.GetType().ToString());
                    Messages.MOS_2_8_3.roElementAction mos_2_8_3_roElementAction = (Messages.MOS_2_8_3.roElementAction)mos_2_8_3.Item;
                    Assert.AreEqual(roID, mos_2_8_3_roElementAction.roID);
                    Assert.AreEqual(enumOperation_2_8_3, mos_2_8_3_roElementAction.operation);
                    i = 0;
                    foreach (Messages.MOS_2_8_3.ItemsChoiceType2 sourceType in mos_2_8_3_roElementAction.element_source.ItemsElementName)
                    {
                        switch (sourceType)
                        {
                            case Messages.MOS_2_8_3.ItemsChoiceType2.storyID:
                                Assert.AreEqual(storyID, (string)mos_2_8_3_roElementAction.element_source.Items[i]);
                                break;
                            case Messages.MOS_2_8_3.ItemsChoiceType2.story:
                                OSM.MOSProtocol.Messages.MOS_2_8_3.story sourceStory = (OSM.MOSProtocol.Messages.MOS_2_8_3.story)mos_2_8_3_roElementAction.element_source.Items[i];
                                Assert.AreEqual(storyID, sourceStory.storyID);
                                Assert.AreEqual(storySlug, sourceStory.storySlug);
                                Assert.AreEqual(storyNum, sourceStory.storyNum);
                                break;
                        }
                        ++i;
                    }
                    Assert.AreEqual(targetStoryID, mos_2_8_3_roElementAction.element_target.storyID);
                    break;
            }
        }
        private void ElementActionDeleteAsserts(object mos)
        {
            #region properties to match
            //mosID
            string mosID_2_8 = "MOS28.MOS";
            string mosID_2_8_1 = "MOS281.MOS";
            string mosID_2_8_2 = "MOS282.MOS";
            string mosID_2_8_3 = "MOS283.MOS";
            string ncsID_2_8 = "MOS28.NCS";
            //ncsID
            string ncsID_2_8_1 = "MOS281.NCS";
            string ncsID_2_8_2 = "MOS282.NCS";
            string ncsID_2_8_3 = "MOS283.NCS";
            //messageID
            int messageID = 0;
            //roID
            string roID = @"DEMOENPS50VPC;P_OSM\W;AADC7235-007A-4317-BE112095DF74356A";
            string storyID = @"DEMOENPS50VPC;P_OSM\W\R_AADC7235-007A-4317-BE112095DF74356A;12340810-B60C-4801-BE6657A420EEC4EF";
            string targetStoryID = null;
            string storySlug = @"Append";
            string storyNum = @"";
            Messages.MOS_2_8.roElementActionOperation enumOperation_2_8 = OSM.MOSProtocol.Messages.MOS_2_8.roElementActionOperation.DELETE;
            Messages.MOS_2_8_1.roElementActionOperation enumOperation_2_8_1 = OSM.MOSProtocol.Messages.MOS_2_8_1.roElementActionOperation.DELETE;
            Messages.MOS_2_8_2.roElementActionOperation enumOperation_2_8_2 = OSM.MOSProtocol.Messages.MOS_2_8_2.roElementActionOperation.DELETE;
            Messages.MOS_2_8_3.roElementActionOperation enumOperation_2_8_3 = OSM.MOSProtocol.Messages.MOS_2_8_3.roElementActionOperation.DELETE;
            #endregion
            switch (mos.GetType().ToString())
            {
                case "OSM.MOSProtocol.Messages.MOS_2_8.mos":

                    Messages.MOS_2_8.mos mos_2_8 = (Messages.MOS_2_8.mos)mos;
                    Assert.AreEqual(mosID_2_8, mos_2_8.mosID);
                    Assert.AreEqual(ncsID_2_8, mos_2_8.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8.roElementAction", mos_2_8.Item.GetType().ToString());
                    Messages.MOS_2_8.roElementAction mos_2_8_roElementAction = (Messages.MOS_2_8.roElementAction)mos_2_8.Item;
                    Assert.AreEqual(roID, mos_2_8_roElementAction.roID);
                    Assert.AreEqual(enumOperation_2_8, mos_2_8_roElementAction.operation);
                    int i = 0;
                    foreach (Messages.MOS_2_8.ItemsChoiceType2 sourceType in mos_2_8_roElementAction.element_source.ItemsElementName)
                    {
                        switch (sourceType)
                        {
                            case Messages.MOS_2_8.ItemsChoiceType2.storyID:
                                Assert.AreEqual(storyID, ( string )mos_2_8_roElementAction.element_source.Items[i]);
                                break;
                            case Messages.MOS_2_8.ItemsChoiceType2.story:
                                OSM.MOSProtocol.Messages.MOS_2_8.story sourceStory = (OSM.MOSProtocol.Messages.MOS_2_8.story)mos_2_8_roElementAction.element_source.Items[i];
                                Assert.AreEqual(storyID, sourceStory.storyID);
                                Assert.AreEqual(storySlug, sourceStory.storySlug);
                                Assert.AreEqual(storyNum, sourceStory.storyNum);
                                break;
                        }
                        ++i;
                    }
                    Assert.AreEqual(targetStoryID, mos_2_8_roElementAction.element_target.storyID);
                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8_1.mos":

                    Messages.MOS_2_8_1.mos mos_2_8_1 = (Messages.MOS_2_8_1.mos)mos;
                    Assert.AreEqual(mosID_2_8_1, mos_2_8_1.mosID);
                    Assert.AreEqual(ncsID_2_8_1, mos_2_8_1.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8_1.roElementAction", mos_2_8_1.Item.GetType().ToString());
                    Messages.MOS_2_8_1.roElementAction mos_2_8_1_roElementAction = (Messages.MOS_2_8_1.roElementAction)mos_2_8_1.Item;
                    Assert.AreEqual(roID, mos_2_8_1_roElementAction.roID);
                    Assert.AreEqual(enumOperation_2_8_1, mos_2_8_1_roElementAction.operation);
                    i = 0;
                    foreach (Messages.MOS_2_8_1.ItemsChoiceType2 sourceType in mos_2_8_1_roElementAction.element_source.ItemsElementName)
                    {
                        switch (sourceType)
                        {
                            case Messages.MOS_2_8_1.ItemsChoiceType2.storyID:
                                Assert.AreEqual(storyID, ( string )mos_2_8_1_roElementAction.element_source.Items[i]);
                                break;
                            case Messages.MOS_2_8_1.ItemsChoiceType2.story:
                                OSM.MOSProtocol.Messages.MOS_2_8_1.story sourceStory = (OSM.MOSProtocol.Messages.MOS_2_8_1.story)mos_2_8_1_roElementAction.element_source.Items[i];
                                Assert.AreEqual(storyID, sourceStory.storyID);
                                Assert.AreEqual(storySlug, sourceStory.storySlug);
                                Assert.AreEqual(storyNum, sourceStory.storyNum);
                                break;
                        }
                        ++i;
                    }
                    Assert.AreEqual(targetStoryID, mos_2_8_1_roElementAction.element_target.storyID);
                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8_2.mos":

                    Messages.MOS_2_8_2.mos mos_2_8_2 = (Messages.MOS_2_8_2.mos)mos;
                    Assert.AreEqual(mosID_2_8_2, mos_2_8_2.mosID);
                    Assert.AreEqual(ncsID_2_8_2, mos_2_8_2.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8_2.roElementAction", mos_2_8_2.Item.GetType().ToString());
                    Messages.MOS_2_8_2.roElementAction mos_2_8_2_roElementAction = (Messages.MOS_2_8_2.roElementAction)mos_2_8_2.Item;
                    Assert.AreEqual(roID, mos_2_8_2_roElementAction.roID);
                    Assert.AreEqual(enumOperation_2_8_2, mos_2_8_2_roElementAction.operation);
                      i = 0;
                      foreach (Messages.MOS_2_8_2.ItemsChoiceType2 sourceType in mos_2_8_2_roElementAction.element_source.ItemsElementName)
                    {
                        switch (sourceType)
                        {
                            case Messages.MOS_2_8_2.ItemsChoiceType2.storyID:
                                Assert.AreEqual(storyID, ( string )mos_2_8_2_roElementAction.element_source.Items[i]);
                                break;
                            case Messages.MOS_2_8_2.ItemsChoiceType2.story:
                                OSM.MOSProtocol.Messages.MOS_2_8_2.story sourceStory = (OSM.MOSProtocol.Messages.MOS_2_8_2.story)mos_2_8_2_roElementAction.element_source.Items[i];
                                Assert.AreEqual(storyID, sourceStory.storyID);
                                Assert.AreEqual(storySlug, sourceStory.storySlug);
                                Assert.AreEqual(storyNum, sourceStory.storyNum);
                                break;
                        }
                        ++i;
                    }
                    Assert.AreEqual(targetStoryID, mos_2_8_2_roElementAction.element_target.storyID);
                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8_3.mos":
                    Messages.MOS_2_8_3.mos mos_2_8_3 = (Messages.MOS_2_8_3.mos)mos;
                    Assert.AreEqual(mosID_2_8_3, mos_2_8_3.mosID);
                    Assert.AreEqual(ncsID_2_8_3, mos_2_8_3.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8_3.roElementAction", mos_2_8_3.Item.GetType().ToString());
                    Messages.MOS_2_8_3.roElementAction mos_2_8_3_roElementAction = (Messages.MOS_2_8_3.roElementAction)mos_2_8_3.Item;
                    Assert.AreEqual(roID, mos_2_8_3_roElementAction.roID);
                    Assert.AreEqual(enumOperation_2_8_3, mos_2_8_3_roElementAction.operation);
                      i = 0;
                    foreach (Messages.MOS_2_8_3.ItemsChoiceType2 sourceType in mos_2_8_3_roElementAction.element_source.ItemsElementName)
                    {
                        switch (sourceType)
                        {
                            case Messages.MOS_2_8_3.ItemsChoiceType2.storyID:
                                Assert.AreEqual(storyID, ( string )mos_2_8_3_roElementAction.element_source.Items[i]);
                                break;
                            case Messages.MOS_2_8_3.ItemsChoiceType2.story:
                                OSM.MOSProtocol.Messages.MOS_2_8_3.story sourceStory = (OSM.MOSProtocol.Messages.MOS_2_8_3.story)mos_2_8_3_roElementAction.element_source.Items[i];
                                Assert.AreEqual(storyID, sourceStory.storyID);
                                Assert.AreEqual(storySlug, sourceStory.storySlug);
                                Assert.AreEqual(storyNum, sourceStory.storyNum);
                                break;
                        }
                        ++i;
                    }
                    Assert.AreEqual(targetStoryID, mos_2_8_3_roElementAction.element_target.storyID);
                    break;
            }
        }
        private void roElementActionMoveAssert(object mos)
        {
            #region properties to match
            //mosID
            string mosID_2_8 = "MOS28.MOS";
            string mosID_2_8_1 = "MOS281.MOS";
            string mosID_2_8_2 = "MOS282.MOS";
            string mosID_2_8_3 = "MOS283.MOS";
            string ncsID_2_8 = "MOS28.NCS";
            //ncsID
            string ncsID_2_8_1 = "MOS281.NCS";
            string ncsID_2_8_2 = "MOS282.NCS";
            string ncsID_2_8_3 = "MOS283.NCS";
            //messageID
            int messageID = 0;
            //roID
            string roID = @"DEMOENPS50VPC;P_OSM\W;AADC7235-007A-4317-BE112095DF74356A";
            string storyID = @"DEMOENPS50VPC;P_OSM\W\R_AADC7235-007A-4317-BE112095DF74356A;60F2610C-6006-47C3-88026D4871B87B15";
            string targetStoryID = @"DEMOENPS50VPC;P_OSM\W\R_AADC7235-007A-4317-BE112095DF74356A;6AB5CE80-6EF9-41F0-AB08AF0D02643A13";
            string storySlug = @"Append";
            string storyNum = @"";
            Messages.MOS_2_8.roElementActionOperation enumOperation_2_8 = OSM.MOSProtocol.Messages.MOS_2_8.roElementActionOperation.MOVE;
            Messages.MOS_2_8_1.roElementActionOperation enumOperation_2_8_1 = OSM.MOSProtocol.Messages.MOS_2_8_1.roElementActionOperation.MOVE;
            Messages.MOS_2_8_2.roElementActionOperation enumOperation_2_8_2 = OSM.MOSProtocol.Messages.MOS_2_8_2.roElementActionOperation.MOVE;
            Messages.MOS_2_8_3.roElementActionOperation enumOperation_2_8_3 = OSM.MOSProtocol.Messages.MOS_2_8_3.roElementActionOperation.MOVE;
            #endregion
            switch (mos.GetType().ToString())
            {
                case "OSM.MOSProtocol.Messages.MOS_2_8.mos":

                    Messages.MOS_2_8.mos mos_2_8 = (Messages.MOS_2_8.mos)mos;
                    Assert.AreEqual(mosID_2_8, mos_2_8.mosID);
                    Assert.AreEqual(ncsID_2_8, mos_2_8.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8.roElementAction", mos_2_8.Item.GetType().ToString());
                    Messages.MOS_2_8.roElementAction mos_2_8_roElementAction = (Messages.MOS_2_8.roElementAction)mos_2_8.Item;
                    Assert.AreEqual(roID, mos_2_8_roElementAction.roID);
                    Assert.AreEqual(enumOperation_2_8, mos_2_8_roElementAction.operation);
                    int i = 0;
                    foreach (Messages.MOS_2_8.ItemsChoiceType2 sourceType in mos_2_8_roElementAction.element_source.ItemsElementName)
                    {
                        switch (sourceType)
                        {
                            case Messages.MOS_2_8.ItemsChoiceType2.storyID:
                                Assert.AreEqual(storyID, (string)mos_2_8_roElementAction.element_source.Items[i]);
                                break;
                            case Messages.MOS_2_8.ItemsChoiceType2.story:
                                OSM.MOSProtocol.Messages.MOS_2_8.story sourceStory = (OSM.MOSProtocol.Messages.MOS_2_8.story)mos_2_8_roElementAction.element_source.Items[i];
                                Assert.AreEqual(storyID, sourceStory.storyID);
                                Assert.AreEqual(storySlug, sourceStory.storySlug);
                                Assert.AreEqual(storyNum, sourceStory.storyNum);
                                break;
                        }
                        ++i;
                    }
                    Assert.AreEqual(targetStoryID, mos_2_8_roElementAction.element_target.storyID);
                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8_1.mos":

                    Messages.MOS_2_8_1.mos mos_2_8_1 = (Messages.MOS_2_8_1.mos)mos;
                    Assert.AreEqual(mosID_2_8_1, mos_2_8_1.mosID);
                    Assert.AreEqual(ncsID_2_8_1, mos_2_8_1.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8_1.roElementAction", mos_2_8_1.Item.GetType().ToString());
                    Messages.MOS_2_8_1.roElementAction mos_2_8_1_roElementAction = (Messages.MOS_2_8_1.roElementAction)mos_2_8_1.Item;
                    Assert.AreEqual(roID, mos_2_8_1_roElementAction.roID);
                    Assert.AreEqual(enumOperation_2_8_1, mos_2_8_1_roElementAction.operation);
                    i = 0;
                    foreach (Messages.MOS_2_8_1.ItemsChoiceType2 sourceType in mos_2_8_1_roElementAction.element_source.ItemsElementName)
                    {
                        switch (sourceType)
                        {
                            case Messages.MOS_2_8_1.ItemsChoiceType2.storyID:
                                Assert.AreEqual(storyID, (string)mos_2_8_1_roElementAction.element_source.Items[i]);
                                break;
                            case Messages.MOS_2_8_1.ItemsChoiceType2.story:
                                OSM.MOSProtocol.Messages.MOS_2_8_1.story sourceStory = (OSM.MOSProtocol.Messages.MOS_2_8_1.story)mos_2_8_1_roElementAction.element_source.Items[i];
                                Assert.AreEqual(storyID, sourceStory.storyID);
                                Assert.AreEqual(storySlug, sourceStory.storySlug);
                                Assert.AreEqual(storyNum, sourceStory.storyNum);
                                break;
                        }
                        ++i;
                    }
                    Assert.AreEqual(targetStoryID, mos_2_8_1_roElementAction.element_target.storyID);
                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8_2.mos":

                    Messages.MOS_2_8_2.mos mos_2_8_2 = (Messages.MOS_2_8_2.mos)mos;
                    Assert.AreEqual(mosID_2_8_2, mos_2_8_2.mosID);
                    Assert.AreEqual(ncsID_2_8_2, mos_2_8_2.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8_2.roElementAction", mos_2_8_2.Item.GetType().ToString());
                    Messages.MOS_2_8_2.roElementAction mos_2_8_2_roElementAction = (Messages.MOS_2_8_2.roElementAction)mos_2_8_2.Item;
                    Assert.AreEqual(roID, mos_2_8_2_roElementAction.roID);
                    Assert.AreEqual(enumOperation_2_8_2, mos_2_8_2_roElementAction.operation);
                    i = 0;
                    foreach (Messages.MOS_2_8_2.ItemsChoiceType2 sourceType in mos_2_8_2_roElementAction.element_source.ItemsElementName)
                    {
                        switch (sourceType)
                        {
                            case Messages.MOS_2_8_2.ItemsChoiceType2.storyID:
                                Assert.AreEqual(storyID, (string)mos_2_8_2_roElementAction.element_source.Items[i]);
                                break;
                            case Messages.MOS_2_8_2.ItemsChoiceType2.story:
                                OSM.MOSProtocol.Messages.MOS_2_8_2.story sourceStory = (OSM.MOSProtocol.Messages.MOS_2_8_2.story)mos_2_8_2_roElementAction.element_source.Items[i];
                                Assert.AreEqual(storyID, sourceStory.storyID);
                                Assert.AreEqual(storySlug, sourceStory.storySlug);
                                Assert.AreEqual(storyNum, sourceStory.storyNum);
                                break;
                        }
                        ++i;
                    }
                    Assert.AreEqual(targetStoryID, mos_2_8_2_roElementAction.element_target.storyID);
                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8_3.mos":
                    Messages.MOS_2_8_3.mos mos_2_8_3 = (Messages.MOS_2_8_3.mos)mos;
                    Assert.AreEqual(mosID_2_8_3, mos_2_8_3.mosID);
                    Assert.AreEqual(ncsID_2_8_3, mos_2_8_3.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8_3.roElementAction", mos_2_8_3.Item.GetType().ToString());
                    Messages.MOS_2_8_3.roElementAction mos_2_8_3_roElementAction = (Messages.MOS_2_8_3.roElementAction)mos_2_8_3.Item;
                    Assert.AreEqual(roID, mos_2_8_3_roElementAction.roID);
                    Assert.AreEqual(enumOperation_2_8_3, mos_2_8_3_roElementAction.operation);
                    i = 0;
                    foreach (Messages.MOS_2_8_3.ItemsChoiceType2 sourceType in mos_2_8_3_roElementAction.element_source.ItemsElementName)
                    {
                        switch (sourceType)
                        {
                            case Messages.MOS_2_8_3.ItemsChoiceType2.storyID:
                                Assert.AreEqual(storyID, (string)mos_2_8_3_roElementAction.element_source.Items[i]);
                                break;
                            case Messages.MOS_2_8_3.ItemsChoiceType2.story:
                                OSM.MOSProtocol.Messages.MOS_2_8_3.story sourceStory = (OSM.MOSProtocol.Messages.MOS_2_8_3.story)mos_2_8_3_roElementAction.element_source.Items[i];
                                Assert.AreEqual(storyID, sourceStory.storyID);
                                Assert.AreEqual(storySlug, sourceStory.storySlug);
                                Assert.AreEqual(storyNum, sourceStory.storyNum);
                                break;
                        }
                        ++i;
                    }
                    Assert.AreEqual(targetStoryID, mos_2_8_3_roElementAction.element_target.storyID);
                    break;
            }
        }
        private void roElementActionReplaceAsserts(object mos)
        {
            #region properties to match
            //mosID
            string mosID_2_8 = "MOS28.MOS";
            string mosID_2_8_1 = "MOS281.MOS";
            string mosID_2_8_2 = "MOS282.MOS";
            string mosID_2_8_3 = "MOS283.MOS";
            string ncsID_2_8 = "MOS28.NCS";
            //ncsID
            string ncsID_2_8_1 = "MOS281.NCS";
            string ncsID_2_8_2 = "MOS282.NCS";
            string ncsID_2_8_3 = "MOS283.NCS";
            //messageID
            int messageID = 0;
            //roID
            string roID = @"DEMOENPS50VPC;P_OSM\W;AADC7235-007A-4317-BE112095DF74356A";
            string storyID = @"DEMOENPS50VPC;P_OSM\W\R_AADC7235-007A-4317-BE112095DF74356A;B703C725-10F6-4883-805BAD0C93B54D03";
            string targetStoryID = @"DEMOENPS50VPC;P_OSM\W\R_AADC7235-007A-4317-BE112095DF74356A;B703C725-10F6-4883-805BAD0C93B54D03";
            string storySlug = @"Rename story slug";
            string storyNum = @"";
            Messages.MOS_2_8.roElementActionOperation enumOperation_2_8 = OSM.MOSProtocol.Messages.MOS_2_8.roElementActionOperation.REPLACE;
            Messages.MOS_2_8_1.roElementActionOperation enumOperation_2_8_1 = OSM.MOSProtocol.Messages.MOS_2_8_1.roElementActionOperation.REPLACE;
            Messages.MOS_2_8_2.roElementActionOperation enumOperation_2_8_2 = OSM.MOSProtocol.Messages.MOS_2_8_2.roElementActionOperation.REPLACE;
            Messages.MOS_2_8_3.roElementActionOperation enumOperation_2_8_3 = OSM.MOSProtocol.Messages.MOS_2_8_3.roElementActionOperation.REPLACE;
            #endregion
            switch (mos.GetType().ToString())
            {
                case "OSM.MOSProtocol.Messages.MOS_2_8.mos":

                    Messages.MOS_2_8.mos mos_2_8 = (Messages.MOS_2_8.mos)mos;
                    Assert.AreEqual(mosID_2_8, mos_2_8.mosID);
                    Assert.AreEqual(ncsID_2_8, mos_2_8.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8.roElementAction", mos_2_8.Item.GetType().ToString());
                    Messages.MOS_2_8.roElementAction mos_2_8_roElementAction = (Messages.MOS_2_8.roElementAction)mos_2_8.Item;
                    Assert.AreEqual(roID, mos_2_8_roElementAction.roID);
                    Assert.AreEqual(enumOperation_2_8, mos_2_8_roElementAction.operation);
                    int i = 0;
                    foreach (Messages.MOS_2_8.ItemsChoiceType2 sourceType in mos_2_8_roElementAction.element_source.ItemsElementName)
                    {
                        switch (sourceType)
                        {
                            case Messages.MOS_2_8.ItemsChoiceType2.storyID:
                                Assert.AreEqual(storyID, (string)mos_2_8_roElementAction.element_source.Items[i]);
                                break;
                            case Messages.MOS_2_8.ItemsChoiceType2.story:
                                OSM.MOSProtocol.Messages.MOS_2_8.story sourceStory = (OSM.MOSProtocol.Messages.MOS_2_8.story)mos_2_8_roElementAction.element_source.Items[i];
                                Assert.AreEqual(storyID, sourceStory.storyID);
                                Assert.AreEqual(storySlug, sourceStory.storySlug);
                                Assert.AreEqual(storyNum, sourceStory.storyNum);
                                break;
                        }
                        ++i;
                    }
                    Assert.AreEqual(targetStoryID, mos_2_8_roElementAction.element_target.storyID);
                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8_1.mos":

                    Messages.MOS_2_8_1.mos mos_2_8_1 = (Messages.MOS_2_8_1.mos)mos;
                    Assert.AreEqual(mosID_2_8_1, mos_2_8_1.mosID);
                    Assert.AreEqual(ncsID_2_8_1, mos_2_8_1.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8_1.roElementAction", mos_2_8_1.Item.GetType().ToString());
                    Messages.MOS_2_8_1.roElementAction mos_2_8_1_roElementAction = (Messages.MOS_2_8_1.roElementAction)mos_2_8_1.Item;
                    Assert.AreEqual(roID, mos_2_8_1_roElementAction.roID);
                    Assert.AreEqual(enumOperation_2_8_1, mos_2_8_1_roElementAction.operation);
                    i = 0;
                    foreach (Messages.MOS_2_8_1.ItemsChoiceType2 sourceType in mos_2_8_1_roElementAction.element_source.ItemsElementName)
                    {
                        switch (sourceType)
                        {
                            case Messages.MOS_2_8_1.ItemsChoiceType2.storyID:
                                Assert.AreEqual(storyID, (string)mos_2_8_1_roElementAction.element_source.Items[i]);
                                break;
                            case Messages.MOS_2_8_1.ItemsChoiceType2.story:
                                OSM.MOSProtocol.Messages.MOS_2_8_1.story sourceStory = (OSM.MOSProtocol.Messages.MOS_2_8_1.story)mos_2_8_1_roElementAction.element_source.Items[i];
                                Assert.AreEqual(storyID, sourceStory.storyID);
                                Assert.AreEqual(storySlug, sourceStory.storySlug);
                                Assert.AreEqual(storyNum, sourceStory.storyNum);
                                break;
                        }
                        ++i;
                    }
                    Assert.AreEqual(targetStoryID, mos_2_8_1_roElementAction.element_target.storyID);
                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8_2.mos":

                    Messages.MOS_2_8_2.mos mos_2_8_2 = (Messages.MOS_2_8_2.mos)mos;
                    Assert.AreEqual(mosID_2_8_2, mos_2_8_2.mosID);
                    Assert.AreEqual(ncsID_2_8_2, mos_2_8_2.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8_2.roElementAction", mos_2_8_2.Item.GetType().ToString());
                    Messages.MOS_2_8_2.roElementAction mos_2_8_2_roElementAction = (Messages.MOS_2_8_2.roElementAction)mos_2_8_2.Item;
                    Assert.AreEqual(roID, mos_2_8_2_roElementAction.roID);
                    Assert.AreEqual(enumOperation_2_8_2, mos_2_8_2_roElementAction.operation);
                    i = 0;
                    foreach (Messages.MOS_2_8_2.ItemsChoiceType2 sourceType in mos_2_8_2_roElementAction.element_source.ItemsElementName)
                    {
                        switch (sourceType)
                        {
                            case Messages.MOS_2_8_2.ItemsChoiceType2.storyID:
                                Assert.AreEqual(storyID, (string)mos_2_8_2_roElementAction.element_source.Items[i]);
                                break;
                            case Messages.MOS_2_8_2.ItemsChoiceType2.story:
                                OSM.MOSProtocol.Messages.MOS_2_8_2.story sourceStory = (OSM.MOSProtocol.Messages.MOS_2_8_2.story)mos_2_8_2_roElementAction.element_source.Items[i];
                                Assert.AreEqual(storyID, sourceStory.storyID);
                                Assert.AreEqual(storySlug, sourceStory.storySlug);
                                Assert.AreEqual(storyNum, sourceStory.storyNum);
                                break;
                        }
                        ++i;
                    }
                    Assert.AreEqual(targetStoryID, mos_2_8_2_roElementAction.element_target.storyID);
                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8_3.mos":
                    Messages.MOS_2_8_3.mos mos_2_8_3 = (Messages.MOS_2_8_3.mos)mos;
                    Assert.AreEqual(mosID_2_8_3, mos_2_8_3.mosID);
                    Assert.AreEqual(ncsID_2_8_3, mos_2_8_3.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8_3.roElementAction", mos_2_8_3.Item.GetType().ToString());
                    Messages.MOS_2_8_3.roElementAction mos_2_8_3_roElementAction = (Messages.MOS_2_8_3.roElementAction)mos_2_8_3.Item;
                    Assert.AreEqual(roID, mos_2_8_3_roElementAction.roID);
                    Assert.AreEqual(enumOperation_2_8_3, mos_2_8_3_roElementAction.operation);
                    i = 0;
                    foreach (Messages.MOS_2_8_3.ItemsChoiceType2 sourceType in mos_2_8_3_roElementAction.element_source.ItemsElementName)
                    {
                        switch (sourceType)
                        {
                            case Messages.MOS_2_8_3.ItemsChoiceType2.storyID:
                                Assert.AreEqual(storyID, (string)mos_2_8_3_roElementAction.element_source.Items[i]);
                                break;
                            case Messages.MOS_2_8_3.ItemsChoiceType2.story:
                                OSM.MOSProtocol.Messages.MOS_2_8_3.story sourceStory = (OSM.MOSProtocol.Messages.MOS_2_8_3.story)mos_2_8_3_roElementAction.element_source.Items[i];
                                Assert.AreEqual(storyID, sourceStory.storyID);
                                Assert.AreEqual(storySlug, sourceStory.storySlug);
                                Assert.AreEqual(storyNum, sourceStory.storyNum);
                                break;
                        }
                        ++i;
                    }
                    Assert.AreEqual(targetStoryID, mos_2_8_3_roElementAction.element_target.storyID);
                    break;
            }
        }

        private void mosReqObjListAsserts(object mos)
        {
            #region properties to match
            //mosID
            string mosID_2_8_1 = "MOS281.MOS";
            string mosID_2_8_2 = "MOS282.MOS";
            string mosID_2_8_3 = "MOS283.MOS";

            //ncsID
            string ncsID_2_8_1 = "MOS281.NCS";
            string ncsID_2_8_2 = "MOS282.NCS";
            string ncsID_2_8_3 = "MOS283.NCS";
            //messageID
            int messageID = 00000008;
            string generalSearch = "mySearch";
            string queryID = "8CB73A63A2D94607A0118AE179213AC0";
            string mosSchema = "http://MOSA4.com/mos/supported_schemas/MOSAXML2.08";
            int listStart = 1;
            int listEnd = 29;
            string XPath = "";
            string sortType = "";
            string sortByOrder = "";

            #endregion
            switch (mos.GetType().ToString())
            {
                case "OSM.MOSProtocol.Messages.MOS_2_8_1.mos":

                    Messages.MOS_2_8_1.mos mos_2_8_1 = (Messages.MOS_2_8_1.mos)mos;
                    Assert.AreEqual(mosID_2_8_1, mos_2_8_1.mosID);
                    Assert.AreEqual(ncsID_2_8_1, mos_2_8_1.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8_1.mosReqObjList", mos_2_8_1.Item.GetType().ToString());
                    Messages.MOS_2_8_1.mosReqObjList mos_2_8_1_mosReqObjList = (Messages.MOS_2_8_1.mosReqObjList)mos_2_8_1.Item;
                    Assert.AreEqual(generalSearch, mos_2_8_1_mosReqObjList.generalSearch);
                    Assert.AreEqual(queryID, mos_2_8_1_mosReqObjList.queryID);
                    Assert.AreEqual(mosSchema, mos_2_8_1_mosReqObjList.mosSchema);
                    Assert.AreEqual(listStart, mos_2_8_1_mosReqObjList.listReturnStart);
                    Assert.AreEqual(listEnd, mos_2_8_1_mosReqObjList.listReturnEnd);
                    if (mos_2_8_1_mosReqObjList.searchGroup != null)
                    {
                        foreach (Messages.MOS_2_8_1.searchField[] Group in mos_2_8_1_mosReqObjList.searchGroup)
                        {
                            foreach (Messages.MOS_2_8_1.searchField sf in Group)
                            {
                                Assert.AreEqual(XPath, sf.XPath);
                                Assert.AreEqual(sortType, sf.sortType);
                                Assert.AreEqual(sortByOrder, sf.sortByOrder);
                            }
                        }
                    }
                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8_2.mos":

                    Messages.MOS_2_8_2.mos mos_2_8_2 = (Messages.MOS_2_8_2.mos)mos;
                    Assert.AreEqual(mosID_2_8_2, mos_2_8_2.mosID);
                    Assert.AreEqual(ncsID_2_8_2, mos_2_8_2.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8_2.mosReqObjList", mos_2_8_2.Item.GetType().ToString());
                    Messages.MOS_2_8_2.mosReqObjList mos_2_8_2_mosReqObjList = (Messages.MOS_2_8_2.mosReqObjList)mos_2_8_2.Item;
                    Assert.AreEqual(generalSearch, mos_2_8_2_mosReqObjList.generalSearch);
                    Assert.AreEqual(queryID, mos_2_8_2_mosReqObjList.queryID);
                    Assert.AreEqual(mosSchema, mos_2_8_2_mosReqObjList.mosSchema);
                    Assert.AreEqual(listStart, mos_2_8_2_mosReqObjList.listReturnStart);
                    Assert.AreEqual(listEnd, mos_2_8_2_mosReqObjList.listReturnEnd);
                    if (mos_2_8_2_mosReqObjList.searchGroup != null)
                    {
                        foreach (Messages.MOS_2_8_2.searchField[] Group in mos_2_8_2_mosReqObjList.searchGroup)
                        {
                            foreach (Messages.MOS_2_8_2.searchField sf in Group)
                            {
                                Assert.AreEqual(XPath, sf.XPath);
                                Assert.AreEqual(sortType, sf.sortType);
                                Assert.AreEqual(sortByOrder, sf.sortByOrder);
                            }
                        }
                    }
                    break;
                case "OSM.MOSProtocol.Messages.MOS_2_8_3.mos":
                    Messages.MOS_2_8_3.mos mos_2_8_3 = (Messages.MOS_2_8_3.mos)mos;
                    Assert.AreEqual(mosID_2_8_3, mos_2_8_3.mosID);
                    Assert.AreEqual(ncsID_2_8_3, mos_2_8_3.ncsID);
                    Assert.AreEqual("OSM.MOSProtocol.Messages.MOS_2_8_3.mosReqObjList", mos_2_8_3.Item.GetType().ToString());
                    Messages.MOS_2_8_3.mosReqObjList mos_2_8_3_mosReqObjList = (Messages.MOS_2_8_3.mosReqObjList)mos_2_8_3.Item;
                    Assert.AreEqual(generalSearch, mos_2_8_3_mosReqObjList.generalSearch);
                    Assert.AreEqual(queryID, mos_2_8_3_mosReqObjList.queryID);
                    Assert.AreEqual(mosSchema, mos_2_8_3_mosReqObjList.mosSchema);
                    Assert.AreEqual(listStart, mos_2_8_3_mosReqObjList.listReturnStart);
                    Assert.AreEqual(listEnd, mos_2_8_3_mosReqObjList.listReturnEnd);
                    if (mos_2_8_3_mosReqObjList.searchGroup != null)
                    {
                        foreach (Messages.MOS_2_8_3.searchField[] Group in mos_2_8_3_mosReqObjList.searchGroup)
                        {
                            foreach (Messages.MOS_2_8_3.searchField sf in Group)
                            {
                                Assert.AreEqual(XPath, sf.XPath);
                                Assert.AreEqual(sortType, sf.sortType);
                                Assert.AreEqual(sortByOrder, sf.sortByOrder);
                            }
                        }
                    }
                    break;
            }
        }

        #endregion = roElement Messages

        #endregion

        private string getElement(string path, string xPath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            return doc.SelectSingleNode(xPath).OuterXml;


        }
    }
}
