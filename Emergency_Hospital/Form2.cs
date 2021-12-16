using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Emergency_Hospital
{
    public partial class ConsultasForm : Form
    {

        
        public ConsultasForm()
        {
            InitializeComponent();
        }

        private void FormConsulta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro Guardado Exitosamente");

           
        }
    }
    }
