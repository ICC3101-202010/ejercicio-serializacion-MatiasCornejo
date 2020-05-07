using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using static ProyectoSerializacion.Persona;

namespace ProyectoSerializacion
{
    class MainClass
    {


        public static void Main(string[] args)
        {


            Persona p1 = new Persona();


            p1.Name = "Some String";
            p1.LastName = "Some String";
            p1.Age = 23;

            int x;
            x = 1;
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            IFormatter formatter = binaryFormatter;
            Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);

            while (x != 7)

            {

                Console.WriteLine("bienvenido");

                Console.WriteLine(" ");

                Console.WriteLine("menu principal: ");

                Console.WriteLine("1) Almacenar Objeto ");
                Console.WriteLine("2) Cargar objeto ");
                Console.WriteLine("3) Salir ");






                x = int.Parse(Console.ReadLine());



                if (x == 1) //opcion crear producto
                {


                    formatter.Serialize(stream, p1);
                    stream.Close();

                }



                if (x == 2) //opcion crear cliente
                {

                    Persona persona = (Persona)formatter.Deserialize(stream);
                    stream.Close();
                    break;

                }

                if (x == 3)
                {
                    break;


                }





            }








            // Here's the proof.  
            Console.WriteLine("n1: {0}", p1.Name);
            Console.WriteLine("n2: {0}", p1.LastName);
            Console.WriteLine("str: {0}", p1.Age);
        }

    }
}
