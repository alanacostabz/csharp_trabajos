using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sicac
{
    class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;

        public Conexion()
        {
            try
            {
                cn = new SqlConnection(@"server = (localdb)\ProjectsV13; integrated security = true; database = Sicac");
                cn.Open();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos: " + ex.ToString());
            }
        }

        public string insertar(int id, string name, string pat, String mat, string email)
        {
            string salida = "Se se inserto";
            try
            {
                cmd = new SqlCommand("Insert into Alumno(id_alum,name,ape_pat, ape_mat, email) values(" + id + ",'" + name + "','" + pat + "','" + mat + "', '" + email + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }



        public int alumnoregistrado(int id)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from Alumno where id_alum=" + id + "", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                    MessageBox.Show("El Alumno ya existe");
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        public void cargaralumnos(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from Alumno", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        }

        public string eliminar(int id)
        {
            string salida = "Se elimino correctamente";
            try
            {
                cmd = new SqlCommand("Delete from Alumno where id_alum = " + id + "", cn);
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                salida = "No se pudo eliminar" + ex.ToString();
            }
            return salida;

        }

        public string modificar(int id, string name, string pat, String mat, string email)
        {
            string salida = "Se se modifico correctamente";
            try
            {
                cmd = new SqlCommand("Update Alumno set name = '" + name + "',ape_pat = '" + pat + "',ape_mat = '" + mat + "' where id_alum = " + id + "", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se puedo modificar: " + ex.ToString();
            }
            return salida;
        }

        public string eliminarmaestro(int id)
        {
            string salida = "Se elimino Correctamente";
            try
            {
                cmd = new SqlCommand("Delete from Maestro where id_mat =" + id + "", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se pudo eliminar" + ex.ToString();
            }
            return salida;
        }

        public string insertarmaestro(int id, string name, string pat, String mat, string email)
        {
            string salida = "Se agrego Correctamente";
            try
            {
                cmd = new SqlCommand("Insert into Maestro(id_mat,name,ape_pat, ape_mat, email) values(" + id + ",'" + name + "','" + pat + "','" + mat + "', '" + email + "')", cn);
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        public string actualizarmaestro(int id, string name, string pat, String mat, string emai)
        {
            string salida = "Se actualizo Correctamente";
            try
            {
                cmd = new SqlCommand("Update Maestro set name = '" + name + "',ape_pat = '" + pat + "',ape_mat = '" + mat + "' where id_mat = " + id + "", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se puedo modificar: " + ex.ToString();
            }

            return salida;
        }
        public void cargarmaestros(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from Maestro", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }

        }
        public int maestroregistrado(int id)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from Maestro where id_mat=" + id + "", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                    MessageBox.Show("El Maestro ya existe");
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }
        public void llenarmaestro(ComboBox cmb)
        {
            try
            {
                cmd = new SqlCommand("Select name from Maestro ", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmb.Items.Add(dr["name"].ToString());

                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno el Combox por: " + ex.ToString());
            }
        }
        public void llenarmaterias(ComboBox cmb)

        {
            try
            {
                cmd = new SqlCommand("Select name from Maestro ", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmb.Items.Add(dr["name"].ToString());

                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno el Combox por: " + ex.ToString());
            }

        }

        public void cargarmaterias(DataGridView dgv) {
            try
            {
                da = new SqlDataAdapter("Select * from Materia", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }

        }
        public string insertarmateria(int id, string Materia, string Maestro)
        {
            string salida = "Se inserto correctamente";
            try
            {
                cmd = new SqlCommand("Insert into Materia(id_mat,Materia, Maestro) values(" + id + ",'" + Materia + "','" + Maestro +"')",cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
    }
}