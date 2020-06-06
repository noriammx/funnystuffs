using System;
using System.Collections.Generic;
using System.Text;

namespace ImageToASCCIConverter
{
    /// <summary>
    /// Clase de prueba de servicios
    /// </summary>
    class TestService
    {
        static void Main(string[] args)
        {
            //ConvertService service = new ConvertService();
            ////Console.WindowWidth = 600;
            //Console.WriteLine(service.ConvertImage());

            ServiceLogoNetCode27 service = new ServiceLogoNetCode27();
            service.PrintLogo();

        }
    }
}
