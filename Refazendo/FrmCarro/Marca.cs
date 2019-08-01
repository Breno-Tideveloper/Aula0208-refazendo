using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmCarro
{
    public partial class Marca : Form
    {
        public Marca()
        {
            InitializeComponent();
        }

        private void Fm2Pesquisar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysinnerjoinDataSet.Marcas'. Você pode movê-la ou removê-la conforme necessário.
            this.marcasTableAdapter.Fill(this.querysinnerjoinDataSet.Marcas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
