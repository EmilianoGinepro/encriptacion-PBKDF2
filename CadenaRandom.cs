using System;
using System.Collections.Generic;
using System.Text;

namespace encriptacion_PBKDF2
{
    class CadenaRandom
    {
        //generar string de letras random
        public string stringRandom()
        { 
        var charactersString = "abcdefghijklmnopqrstuvwxyz";
        var CharsarrString = new char[5];
        var random = new Random();

            for (int i = 0; i<CharsarrString.Length; i++)
            {
                CharsarrString[i] = charactersString[random.Next(charactersString.Length)];
            }

        return new String(CharsarrString);
        }

        //generar string de numeros random
        public string numberRandom()
        { 
        var charactersNumber = "0123456789";
        var CharsarrNumber = new char[5];
        var random = new Random();

            for (int i = 0; i<CharsarrNumber.Length; i++)
            {
                CharsarrNumber[i] = charactersNumber[random.Next(charactersNumber.Length)];
            }
            return new String(CharsarrNumber);
        }
    }
}
