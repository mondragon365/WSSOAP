using System.ServiceModel;
using System.Xml;
using System.Xml.Linq;

namespace Models
{
    // [XmlSerializerFormat(Style = OperationFormatStyle.Document, Use = OperationFormatUse.Literal)]
    // [ServiceContract]

    [ServiceContract(Namespace = "http://royalsystems.net/"),XmlSerializerFormat(Style = OperationFormatStyle.Document)]
    public interface ISampleService
    {
        [OperationContract(Action = "")]
        string WM_RegistrarTransaccion(xdc_RegistroDocumento xdc_RegistroDocumento);       
    }
}