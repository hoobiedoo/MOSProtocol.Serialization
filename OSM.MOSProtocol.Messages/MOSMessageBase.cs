using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using OSM.Core.Common;

namespace OSM.MOSProtocol.Messages
{
    public abstract class MOSMessageBase
    {
        #region Serialize MOS object to XML
        public void Serialize(string file, FileMode mode)
        {
            XmlSerializerHelper.SerializeToFile(this, file, mode);
        }

        public string Serialize()
        {
           return XmlSerializerHelper.SerializeToString(this);
        }

        public void Serialize(Stream stream)
        {
            XmlSerializerHelper.SerializeToStream(this, stream);
        }
        #endregion
    }
}
