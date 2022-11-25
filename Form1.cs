using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaAa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rpta = MessageBox.Show("¿Desea retiraos?", "Salida del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rpta == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Decidite,king", "¿Tenes problemitas en casa?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          

        }

        private void baseDeDatoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Console.Beep();
            string cda = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Space\Desktop\BibliotecaAa\BdBiblioteca.accdb";
            OleDbConnection con = new OleDbConnection(cda);
            try
            {
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    baseDato Basedato = new baseDato();
                    Basedato.ShowDialog();
                    MessageBox.Show("Conexion exitosa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
            con.Close();

        }

        private void entidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.Beep();
            Devolucion devolucion = new Devolucion();
            devolucion.ShowDialog();
        }

        private void queClaseDeLibroUstedOstentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
          
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToString("H:mm:ss");
            label7.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.Beep();
            Prestamo prestamo = new Prestamo();
            prestamo.ShowDialog();
        }

        private void altaDeLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.Beep();
            Alta alta = new Alta();
            alta.ShowDialog();
        }

        private void gestionDeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.Beep();
            Stock stock = new Stock();
            stock.ShowDialog();
        }

        private void bajaDeLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.Beep();
            Baja baja = new Baja();
            baja.ShowDialog();
        }

        private void peticionDeLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.Beep();
            Peticion peticion = new Peticion();
            peticion.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Console.Beep();
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("IExplore", "https://www.unju.edu.ar/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Console.Beep();
        }
    }
}
