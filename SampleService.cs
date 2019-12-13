using Models;
using System;
using System.Xml.Linq;
public class SampleService : ISampleService
{
    public string WM_RegistrarTransaccion(xdc_RegistroDocumento xdc_RegistroDocumento)
    {
        tramiteDocumentario entity = new tramiteDocumentario();
        entity = xdc_RegistroDocumento.tramiteDocumentario;
        ClassValidator validator = new ClassValidator(entity);
        bool is_valid = validator.IsValid();
        if (is_valid == true)
        {//validar anexos
            if (xdc_RegistroDocumento.tramiteDocumentario.anexos.Count > 0)
            {
                foreach (var anexo in xdc_RegistroDocumento.tramiteDocumentario.anexos)
                {
                    itemAnexo entityInner = new itemAnexo();
                    entityInner = anexo;
                    ClassValidator validatorInner = new ClassValidator(entityInner);
                    bool flag = validatorInner.IsValid();
                    if (flag == false)
                    {
                        foreach (var error in validatorInner.ValidationErrors)
                        {
                            Console.WriteLine("Error in object: {0}", error.ErrorMessage);
                        }
                        return "Error";
                    }
                }
                //paso todo retornar id
                Console.WriteLine("executed!");
                return "Response form ws !";
            }            
            else{
                //paso todo retornar id
                Console.WriteLine("executed!");
                return "Response form ws !";
            }
        }
        else
        {//mostrar errores
            foreach (var error in validator.ValidationErrors)
            {
                Console.WriteLine("Error in object: {0}", error.ErrorMessage);
            }
            return "Error";
        }
    }
}