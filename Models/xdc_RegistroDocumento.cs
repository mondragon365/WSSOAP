using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required]
        [StringLength(10, MinimumLength = 1)]
        public string tipoEntidad { get; set; }
        [DataMember]
        [Required]
        [StringLength(11, MinimumLength = 1)]
        public string entidad { get; set; }
        [DataMember]
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string numeroDocumento { get; set; }
        [DataMember]
        [Required]
        [StringLength(10, MinimumLength = 1)]
        public string fechaDocumento { get; set; }
        [DataMember]
        [Required]
        [StringLength(10, MinimumLength = 1)]
        public string dirigidoA { get; set; }
        [DataMember]
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string referencia { get; set; }
        [DataMember]
        [Required]
        [StringLength(200, MinimumLength = 1)]
        public string asunto { get; set; }
        [DataMember]
        [Required]
        [StringLength(2, MinimumLength = 1)]
        public string prioridad { get; set; }
        [DataMember]
        [Required]
        [StringLength(2, MinimumLength = 1)]
        public string indicacion { get; set; }
        [DataMember]
        [Required]
        [Range(0, int.MaxValue)]
        public string plazo { get; set; }
        [DataMember]
        [Required]
        [StringLength(200, MinimumLength = 1)]
        public string otraIndicacion { get; set; }
        [DataMember]
        [Required]
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