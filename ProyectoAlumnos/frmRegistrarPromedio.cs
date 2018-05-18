using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ProyectoAlumnos
{
    public partial class frmRegistrarPromedio : Form
    {
        //Desarrollado por Alvaro Alexander Palacios Carrillo  2018-05-01
        #region Constructor
        List<Alumno> listaAlumnos = new List<Alumno>();
        List<Curso> listaCursos = new List<Curso>();
        public frmRegistrarPromedio()
        {
            InitializeComponent();
        }
        #endregion

        #region btnBuscar_Click
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string _CodAlumno = txtCodAlumno.Text;
            cmbCurso.Items.Clear();
            foreach (var item in listaAlumnos)
            {
                if (item.Codigo == _CodAlumno)
                {
                    cmbCurso.Enabled = true;
                    txtAlumno.Text = item.Nombres;
                    txtNivel.Text = item.Nivel;
                    btnNuevo.Enabled = true;
                    foreach (var c in item.CursosAlumno)
                    {
                        foreach (var x in listaCursos)
                        {
                            if (c.Codigo == x.Codigo)
                            {
                                cmbCurso.Items.Add(x.Nombrecurso);
                            }
                        }
                    }

                }
            }
            if (txtAlumno.Text.Length == 0)
            {
                MessageBox.Show("No se encontró alumno.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion

        #region Load
        private void frmRegistrarPromedio_Load(object sender, EventArgs e)
        {
            //Llenando datos en duro (simulando base de datos)
            Curso cur1 = new Curso();
            cur1.Codigo = "0001";
            cur1.Nombrecurso = "MATEMATICA";

            Curso cur2 = new Curso();
            cur2.Codigo = "0002";
            cur2.Nombrecurso = "COMUNICACION";

            Curso cur3 = new Curso();
            cur3.Codigo = "0003";
            cur3.Nombrecurso = "CIENCIA";

            Curso cur4 = new Curso();
            cur4.Codigo = "0004";
            cur4.Nombrecurso = "PERSONAL SOCIAL";

            Curso cur5 = new Curso();
            cur5.Codigo = "0005";
            cur5.Nombrecurso = "ARITMETICA";

            Curso cur6 = new Curso();
            cur6.Codigo = "0006";
            cur6.Nombrecurso = "GEOMETRIA";

            listaCursos.Add(cur1);
            listaCursos.Add(cur2);
            listaCursos.Add(cur3);
            listaCursos.Add(cur4);
            listaCursos.Add(cur5);
            listaCursos.Add(cur6);



            List<CursoAlumno> listaCursosAlumno1 = new List<CursoAlumno>();
            listaCursosAlumno1.Add(new CursoAlumno() { Codigo = "0001" });
            listaCursosAlumno1.Add(new CursoAlumno() { Codigo = "0002" });

            List<CursoAlumno> listaCursosAlumno2 = new List<CursoAlumno>();
            listaCursosAlumno2.Add(new CursoAlumno() { Codigo = "0002" });
            listaCursosAlumno2.Add(new CursoAlumno() { Codigo = "0004" });


            List<CursoAlumno> listaCursosAlumno3 = new List<CursoAlumno>();
            listaCursosAlumno3.Add(new CursoAlumno() { Codigo = "0005" });
            listaCursosAlumno3.Add(new CursoAlumno() { Codigo = "0006" });

            List<CursoAlumno> listaCursosAlumno4 = new List<CursoAlumno>();
            listaCursosAlumno4.Add(new CursoAlumno() { Codigo = "0003" });
            listaCursosAlumno4.Add(new CursoAlumno() { Codigo = "0004" });


            List<CursoAlumno> listaCursosAlumno5 = new List<CursoAlumno>();
            listaCursosAlumno5.Add(new CursoAlumno() { Codigo = "0001" });
            listaCursosAlumno5.Add(new CursoAlumno() { Codigo = "0005" });


            Alumno alu = new Alumno();
            alu.Nombres = "ALEX HUAMAN";
            alu.Codigo = "12345";
            alu.Nivel = "SECUNDARIA";
            alu.CursosAlumno = listaCursosAlumno1;
            listaAlumnos.Add(alu);

            Alumno alu2 = new Alumno();
            alu2.Nombres = "MIGUEL LUIS";
            alu2.Codigo = "123456";
            alu2.Nivel = "PRIMARIA";
            alu2.CursosAlumno = listaCursosAlumno2;
            listaAlumnos.Add(alu2);

            Alumno alu3 = new Alumno();
            alu3.Nombres = "JUAN PEREZ";
            alu3.Codigo = "1234567";
            alu3.Nivel = "INICIAL";
            alu3.CursosAlumno = listaCursosAlumno3;
            listaAlumnos.Add(alu3);

            Alumno alu4 = new Alumno();
            alu4.Nombres = "JUAN MIGUEL";
            alu4.Codigo = "12345678";
            alu4.Nivel = "INICIAL";
            alu4.CursosAlumno = listaCursosAlumno4;
            listaAlumnos.Add(alu4);


            Alumno alu5 = new Alumno();
            alu5.Nombres = "LUIS HERNANDEZ";
            alu5.Codigo = "123456789";
            alu5.Nivel = "SECUNDARIA";
            alu5.CursosAlumno = listaCursosAlumno5;
            listaAlumnos.Add(alu5);


        }
        #endregion

        #region cmbCurso_SelectedIndexChanged
        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in listaCursos)
            {
                if (item.Nombrecurso == cmbCurso.Text)
                {
                    txtCodCurso.Text = item.Codigo;
                    foreach (var c in listaAlumnos)
                    {
                        foreach (var x in c.CursosAlumno)
                        {
                            if (x.Codigo == item.Codigo && c.Codigo == txtCodAlumno.Text)
                            {
                                txtTri1.Text = Convert.ToString(x.NotaTrimetre1);
                                txtTri2.Text = Convert.ToString(x.Notatrimestre2);
                                txtTri3.Text = Convert.ToString(x.Notatrimestre3);
                                txtPromedio.Text = Convert.ToString(x.Promedio);
                                return;
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region btnNuevo_Click
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            btnGrabar.Enabled = true;
            btnCancelar.Enabled = true;
            txtTri1.Enabled = true;
            txtTri2.Enabled = true;
            txtTri3.Enabled = true;
        }
        #endregion

        #region btnGrabar_Click
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            double tri1 = 0;
            double tri2 = 0;
            double tri3 = 0;
            double promfinal = 0;

            tri1 = Convert.ToDouble(txtTri1.Text);
            tri2 = Convert.ToDouble(txtTri2.Text);
            tri3 = Convert.ToDouble(txtTri3.Text);
            if (tri1 <= 20 && tri1 >= 0 && tri2 <= 20 && tri2 >= 0 && tri3 <= 20 && tri3 >= 0)
            {
                promfinal = (tri1 + tri2 + tri3) / 3;
                txtPromedio.Text = promfinal.ToString();

                foreach (var item in listaAlumnos)
                {
                    if (item.Codigo == txtCodAlumno.Text)
                    {
                        foreach (var c in item.CursosAlumno)
                        {
                            if (c.Codigo == txtCodCurso.Text)
                            {
                                c.NotaTrimetre1 = tri1;
                                c.Notatrimestre2 = tri2;
                                c.Notatrimestre3 = tri3;
                                c.Promedio = promfinal;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Solo se pueden ingresar números entre 1 y 20", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region btnCancelar_Click
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtTri1.Text = "";
            txtTri2.Text = "";
            txtTri3.Text = "";
            txtCodAlumno.Text = "";
            txtCodCurso.Text = "";
            txtNivel.Text = "";
            txtAlumno.Text = "";
            cmbCurso.Text = "";
            cmbCurso.Enabled = false;
            txtTri1.Enabled = false;
            txtTri2.Enabled = false;
            txtTri3.Enabled = false;
            btnGrabar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNuevo.Enabled = false;
            txtPromedio.Text = "";
        }
        #endregion

        #region btnSalir_Click
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region KeyPress
        private void txtTri1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtTri1.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
        }

        private void txtTri2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (txtTri2.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
        }

        private void txtTri3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtTri3.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
        }
        #endregion
    }
}
