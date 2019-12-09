using Models;
using System;
using System.Xml.Linq;
public class SampleService : ISampleService
{
    public string WM_RegistrarTransaccion(xdc_RegistroDocumento xdc_RegistroDocumento)
    {
        Console.WriteLine("executed!");
        return "Response form ws !";
    }
}