using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAlumnos
{
    public class Alumno
    {
        private string nombres;
        private string nivel;
        private string codigo;
        private List<CursoAlumno> listCursoAlumno;


        public string Nombres
        {
            get
            {
                return nombres;
            }

            set
            {
                nombres = value;
            }
        }

        public string Nivel
        {
            get
            {
                return nivel;
            }

            set
            {
                nivel = value;
            }
        }

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

        public List<CursoAlumno> CursosAlumno
        {
            get
            {
                return listCursoAlumno;
            }

            set
            {
                listCursoAlumno = value;
            }
        }
    }
}
