using Models;
using System;
using System.Xml.Linq;
public class SampleService : ISampleService
{
    public string WM_RegistrarTransaccion(xdc_RegistroDocumento xdc_RegistroDocumento)
    {
        tramiteDocumentario entity = new tramiteDocumentario();
        entity=xdc_RegistroDocumento.tramiteDocumentario;
        ClassValidator validator = new ClassValidator(entity);
        var is_valid=validator.IsValid();
        if(is_valid==true){//retornar id

        }
        else{//mostrar errores
            foreach (var error in validator.ValidationErrors)
            {
                Console.WriteLine("Error in Person object: {0}", error.ErrorMessage);
            }
        }        
        Console.WriteLine("executed!");
        return "Response form ws !";
    }
}