using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4_Progra3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }       
        
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {            
            txtnombre.Enabled = true;
            txtedad.Enabled = true;
            txtedad.Text = "";
            txtnombre.Text = "";
            btnagregar.Enabled = true;
        }
        
        private void btnagregar_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (string.IsNullOrEmpty(txtnombre.Text) || string.IsNullOrEmpty(txtedad.Text)) {
                MessageBox.Show("Valores incompletos");

            }
            else
            {
                
                string[] edades = new string[100];
                string[] nombres = new string[100];
                edades [n] = txtedad.Text;
                nombres [n] = txtnombre.Text;
                cmbsalida.Items.Add( nombres [n] + " " + edades[n]);
                btnagregar.Enabled = false;
                txtnombre.Enabled = false;
                txtedad.Enabled = false;
                n = n++;
            }            
        }

        private void Form1_Load(object sender, EventArgs e)
        {    
            string[] edades = new string[100];
            string[] nombres = new string[100];
            int n = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
