using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SimpleToPark
{
    
    public partial class FormPrincipal : Form
    {
        private DataTable bancoDeDados;
        public FormPrincipal()
        {
            InitializeComponent();
            bancoDeDados = new DataTable("Estacionamento");
            bancoDeDados.Columns.Add("Placa", typeof(string));
            bancoDeDados.Columns.Add("Entrada", typeof(string));
            dataGridViewCarrosEstacionados.DataSource = bancoDeDados;

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
      
        }
    }
}
