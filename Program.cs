using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace encriptacion_PBKDF2
{
    class Program
    {
        static void Main(string[] args)
        {
            Encript encriptar = new Encript();
            CadenaRandom random = new CadenaRandom();

            Console.WriteLine("Ingrese password:");
            string datos = Console.ReadLine();
            string clave = $"{datos}-{random.stringRandom()}+{random.numberRandom()}";
                     
            Console.WriteLine("Clave:");
            Console.WriteLine(clave);
     
            Console.WriteLine("Clave Enciptada:");
            Console.WriteLine(encriptar.Encrypt(datos));

            Console.ReadLine();
        }       
    }
}
