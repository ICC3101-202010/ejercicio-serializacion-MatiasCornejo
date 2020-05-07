
using System;
using System.Runtime.Serialization;

namespace ProyectoSerializacion

{
    [Serializable] //construcctor


    public class Persona
    {
        public int Age = 0;

        public String Name = null;
        public String LastName = null;
    }
}
