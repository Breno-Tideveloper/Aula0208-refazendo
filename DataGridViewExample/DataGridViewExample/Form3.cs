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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysinnerjoinDataSet.Marcas'. Você pode movê-la ou removê-la conforme necessário.
            this.marcasTableAdapter.Fill(this.querysinnerjoinDataSet.Marcas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Marcaselect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridViewExample.querysinnerjoinDataSet.MarcasRow;

            this.marcasTableAdapter.DeleteQuery(Marcaselect.Id);
            this.marcasTableAdapter.Fill(this.querysinnerjoinDataSet.Marcas);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 tela = new Form3();
            tela.Show();
        }
    }
}
