using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var userselect = ((System.Data.DataRowView)
               this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
               as DataGridViewExample.querysinnerjoinDataSet.;
            switch (e.RowIndex)
            {
                case 0: { this.usuariosTableAdapter.DeleteQuery1(userselect.Id); } break;
                case 1: {
                        frmEditaUser tela = new frmEditaUser();
                        tela.ShowDialog();
                    } break;
            }

            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysinnerjoinDataSet.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter1.Fill(this.querysinnerjoinDataSet.Usuarios);

        }

       
       
    }
}
