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




namespace Proyecto_Formulario_BdD
{
    public partial class Form1 : Form

    {

        string Nombre;
        string Apellido;
        string Correo;
        string Contraseña;
        OleDbConnection BaseDeDatosProyecto;

        public Form1()

        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (TxtApellido.Text == "" || TxtNombre.Text == "" || TxtCorreo.Text == "" || TxtContra.Text == "")
            {
                MessageBox.Show("Dale, completá todos los campos");
            }

            { 
            Nombre = TxtNombre.Text;
            Apellido = TxtApellido.Text;
            Correo = TxtCorreo.Text;
            Contraseña = TxtContra.Text;
            BaseDeDatosProyecto.Open();
            OleDbCommand info;
            info = new OleDbCommand("INSERT INTO Tabla (Nombre, Apellido, Correo, Contra) VALUES ('" + Nombre + "' , '" + Apellido + "' , '" + Correo + "' , '" +  Contraseña + "')");
            info.Connection = BaseDeDatosProyecto;
            info.ExecuteNonQuery();
            BaseDeDatosProyecto.Close();
            MessageBox.Show("Listo");
            }

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
            BaseDeDatosProyecto = new OleDbConnection();
            BaseDeDatosProyecto.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BdD-Access.accdb;";


        }

        private void Label4_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void Label5_Click_1(object sender, EventArgs e)
        {
            label5.Visible = false;
        }
    }
}
