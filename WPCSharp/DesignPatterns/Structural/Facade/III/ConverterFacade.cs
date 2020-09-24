using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Facade.III
{
    public class ConverterFacade : IByteArrayConveter, IJsonCoverter, IXmlConverter
    {
        private IByteArrayConveter _byteArrayConveter;
        private IJsonCoverter _jsonCoverter;
        private IXmlConverter _xmlConverter;

        public ConverterFacade(IByteArrayConveter byteArrayConveter, IJsonCoverter jsonCoverter, IXmlConverter xmlConverter)
        {
            _byteArrayConveter = byteArrayConveter;
            _jsonCoverter = jsonCoverter;
            _xmlConverter = xmlConverter;
        }

        public byte[] ToByteArray()
        {
            return _byteArrayConveter.ToByteArray();
        }

        public string ToJson()
        {
            return _jsonCoverter.ToJson();
        }

        public string ToXml()
        {
            return _xmlConverter.ToXml();
        }
    }
}
