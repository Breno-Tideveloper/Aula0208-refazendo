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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysinnerjoinDataSet.Vendas'. Você pode movê-la ou removê-la conforme necessário.
            this.vendasTableAdapter.Fill(this.querysinnerjoinDataSet.Vendas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var vendaselect = ((System.Windows.Forms.DataGridViewRow)
                this.dataGridView1.Rows[e.RowIndex]).DataBoundItem
                as DataGridViewExample.querysinnerjoinDataSet.VendasRow;

            this.vendasTableAdapter.DeleteQuery(vendaselect.Id);
            this.vendasTableAdapter.Fill(this.querysinnerjoinDataSet.Vendas);
        }
    }
}
