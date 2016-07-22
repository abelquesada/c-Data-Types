using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types
{
    class Program

    {
        // enum: usado para declarar enumeraciones, se declaran a nivel de clases porque son estaticos
        enum days { Dom, Lun, Mar, Mier, Juev, Vier, Sab };

        static void Main(string[] args)
        {
            // int: tipo entero es un valor numerico que va desde -2000 millones a 2000 millones, de 32 bits
            int age; /*estoy declarando la variable age se pone en verde cuando la tengo declarada y no a uso*/
            age = 18; /*estoy inicializando la variable dandole un valor*/
            int year = 2017; /*declara e inicializa de una vez*/

            // bool: valor tipo booleano, almacena true o false por default es false
            bool active = false;

            // byte: es un numero de 0 a 255 de 8 bits 
            byte position = 1;

            // char: es un caracter alfanumerico que desde U+0000 a U+FFFF, unicode de 16bits
            char type = 'a'; /*la comilla simple se usa para caracteres, la comilla doble para un string*/

            // decimal: va desde -7.9x10 elevado a la 28 a 7.9x10^28, tiene precision de 29 numeros despues del punto (.) 
            decimal pi = 3.14m; /*hay que ponerle la m para decirle que es un decimal lo interpreta como un double*/

            // double: va desde -5x10^-324 a 5x10^308 son de 16 digitos, es altamente preciso; calcula todos los decimales
            double distance = 100.5;

            // float: numero que va desde -3.4x10^38 a 3.4x10^38 7 digitos de largo, contiene decimales, se le pone la f 
            float x = 3.5f;

            // long: va desde -9 000 000 000 000 000 000 a 9 000 000 000 000 000 000 es de 64 bits, se usa mucho para encriptar
            long code = 234253453464534;

            //sbyte: va desde -127 a 127 son 8 bits 
            sbyte status = -127;

            //short: -32000 a 32000 16 bits 
            short pbi = 3456;

            //uint: va del 0 al 4,000,000,000 32 bits unsigned (declara todos los 32 bits de un solo)
            uint myuint = 234234234;

            // ulong: long: va desde -9 000 000 000 000 000 000 a 9 000 000 000 000 000 000 es de 64 bits, se usa mucho para encriptar es unsigned
            ulong code = 234253453464534;

            //ushort: -32000 a 32000 16 bits unsigned. 
            ushort pbi = 3456;






        }


    }

    struct Book /* es una estructura que no tiene comportamiento, es como una tabla */
    {   decimal price;
        string name;
        int code;
    }
}
