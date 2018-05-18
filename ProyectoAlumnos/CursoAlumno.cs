using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAlumnos
{
    public class CursoAlumno
    {
        private string codigo;
        private double notatrimestre1;
        private double notatrimestre2;
        private double notatrimestre3;
        private double promedio;

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

        public double NotaTrimetre1
        {
            get
            {
                return notatrimestre1;
            }

            set
            {
                notatrimestre1 = value;
            }
        }

        public double Notatrimestre2
        {
            get
            {
                return notatrimestre2;
            }

            set
            {
                notatrimestre2 = value;
            }
        }

        public double Notatrimestre3
        {
            get
            {
                return notatrimestre3;
            }

            set
            {
                notatrimestre3 = value;
            }
        }

        public double Promedio
        {
            get
            {
                return promedio;
            }

            set
            {
                promedio = value;
            }
        }
    }
}
