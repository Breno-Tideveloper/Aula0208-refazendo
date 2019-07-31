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
               as DataGridViewExample.querysinnerjoinDataSet.UsuariosRow;

            this.usuariosTableAdapter.DeleteQuery1(userselect.Id);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysinnerjoinDataSet.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.querysinnerjoinDataSet.Usuarios);

        }

       
        private void Form2_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysinnerjoinDataSet1.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter1.Fill(this.querysinnerjoinDataSet1.Usuarios);
            // TODO: esta linha de código carrega dados na tabela 'querysinnerjoinDataSet3.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
           // this.usuariosTableAdapter1.Fill(this.querysinnerjoinDataSet3.Usuarios);
            // TODO: esta linha de código carrega dados na tabela 'querysinnerjoinDataSet3.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
           // this.usuariosTableAdapter1.Fill(this.querysinnerjoinDataSet3.Usuarios);

        }
    }
}
