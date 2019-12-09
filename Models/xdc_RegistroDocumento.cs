using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
namespace Models
{    
    [DataContract]
    public class xdc_RegistroDocumento
    {
        [DataMember]
        public tramiteDocumentario tramiteDocumentario { get; set; }
    }
    public class tramiteDocumentario
    {
        [DataMember]
        public string tipoEntidad { get; set; }
        [DataMember]
        public string entidad { get; set; }
        [DataMember]
        public string numeroDocumento { get; set; }
        [DataMember]
        public string fechaDocumento { get; set; }
        [DataMember]
        public string dirigidoA { get; set; }
        [DataMember]
        public string referencia { get; set; }
        [DataMember]
        public string asunto { get; set; }
        [DataMember]
        public string prioridad { get; set; }
        [DataMember]
        public string plazo { get; set; }
        [DataMember]
        public string indicacion { get; set; }
        [DataMember]
        public string otraIndicacion { get; set; }
        [DataMember]
        public anexos anexos { get; set; }        
    }
    public class anexos
    {        
        [DataMember]
        public itemAnexo itemAnexo { get; set; }
    }
    public class itemAnexo
    {        
        [DataMember]
        public string almacenArchivo { get; set; }
        [DataMember]
        public string descripcion { get; set; }
        [DataMember]
        public string nombreFisico { get; set; }
    }
}