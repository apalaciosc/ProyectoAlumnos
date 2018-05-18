using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAlumnos
{
    public class Curso
    {
        private string codigo;
        private string nombrecurso;

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Nombrecurso
        {
            get
            {
                return nombrecurso;
            }

            set
            {
                nombrecurso = value;
            }
        }

    }
}
