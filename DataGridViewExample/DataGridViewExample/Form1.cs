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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysinnerjoinDataSet.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.querysinnerjoinDataSet.Usuarios);
            // TODO: esta linha de código carrega dados na tabela 'querysinnerjoinDataSet1.Carros'. Você pode movê-la ou removê-la conforme necessário.
            //    this.carrosTableAdapter.Fill(this.querysinnerjoinDataSet1.Carros);
            // TODO: esta linha de código carrega dados na tabela 'querysinnerjoinDataSet.Carros'. Você pode movê-la ou removê-la conforme necessário.
            //   this.carrosTableAdapter.CustomQuery(this.querysinnerjoinDataSet.Carros);

        }

        private void CarrosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //var ususelect = ((System.Windows.Forms.DataGridViewRow)
            //    this.dataGridView1.Rows[e.RowIndex]).DataBoundItem
            //    as DataGridViewExample.querysinnerjoinDataSet.UsuariosRow;

            //this.usuariosTableAdapter.DeleteQuery1(ususelect.Id);
            //this.usuariosTableAdapter.Fill(this.querysinnerjoinDataSet.Usuarios);          

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 tela = new Form2();
            tela.Show();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 tela = new Form3();
            tela.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form4 tela = new Form4();
            tela.Show();
        }
    }
}
