using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Grupo> grupos = new List<Grupo>();

            Grupo matematicas = new Grupo("Matematicas", "MAT5736");
            Grupo historia = new Grupo("Historia", "HST2149");

            grupos.Add(matematicas);
            grupos.Add(historia);

            Alumno juan = new Alumno("Juan", "78924");
            Alumno maria = new Alumno("Maria", "15478");
            Alumno pedro = new Alumno("Pedro", "41544");
            Alumno ana = new Alumno("ana", "52698");
            Alumno pablo = new Alumno("Pablo", "24578");

            historia.Alumno.Add(juan);
            historia.Alumno.Add(ana);
            historia.Alumno.Add(pedro);

            matematicas.Alumno.Add(juan);
            matematicas.Alumno.Add(maria);
            matematicas.Alumno.Add(pedro);
            matematicas.Alumno.Add(ana);
            matematicas.Alumno.Add(pablo);

            foreach(Grupo grupo in grupos)
            {
                Console.WriteLine("Grupos" + grupo.Codigo);
                Console.WriteLine("Materia" + grupo.Materia);
                Console.WriteLine("Lista de alumnos");
                foreach (Alumno alumno in grupo.Alumno)
                {
                    Console.WriteLine("*" + alumno.Nombre);
                }
            }

            Console.Read();
        }  
    }
}
