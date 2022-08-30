using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Proyecto_Login_BdD
{
    public partial class Form1 : Form
    {

        string Correo;
        string Contraseña;
        OleDbConnection BaseDeDatosProyecto;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            BaseDeDatosProyecto = new OleDbConnection();
            BaseDeDatosProyecto.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BdD-Access.accdb;";
            BaseDeDatosProyecto.Open();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (TxtCorreo.Text == "" || TxtContra.Text == "")
            {
                MessageBox.Show("Dale, completá todos los campos");
            }

            {
                Correo = TxtCorreo.Text;
                Contraseña = TxtContra.Text;

                string sql = "SELECT Correo, Contra FROM Tabla WHERE Correo = '" + Correo + "' and Contra = '" + Contraseña + "'";
                OleDbCommand info = new OleDbCommand(sql, BaseDeDatosProyecto);
                DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(info);
                da.Fill(ds, "Tabla");



            }

        }

        public static string funcionMaestra(int id, string objID, string path)
        {
            id = 1;
            objID = "Meir";
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BdD-Access.accdb;");
            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Usuarios WHERE id = " + id, con);
            OleDbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string result = reader[objID].ToString();
            con.Close();
            return result;
            MessageBox.Show(result);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
