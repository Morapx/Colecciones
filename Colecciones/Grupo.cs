using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Grupo
    {
        public string Materia { get; set; }
        public string Codigo { get; set; }
        public List<Alumno> Alumno { get; set; }

        public Grupo(string materia, string codigo)
            {
            Materia = materia;
            Codigo = codigo;
            Alumno = new List<Alumno>();
        }
    }
}
