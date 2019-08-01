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
    public partial class Form1JPrincipal : Form
    {
        public Form1JPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysinnerjoinDataSet.Carros'. Você pode movê-la ou removê-la conforme necessário.
            this.carrosTableAdapter.Fill(this.querysinnerjoinDataSet.Carros);

        }

      /*  private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var carSelet = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as FrmCarro.querysinnerjoinDataSet.CarrosRow;
            switch (e.ColumnIndex)
            {
                case 0:
                    {

                    }
                    break;
                case 1: {
                        frmEditaCarro tela = new frmEditaCarro();
                        tela.CarroRow = carSelet;
                        tela.ShowDialog();
                        //gera alteração no banco
                        this.carrosTableAdapter.Update(carSelet);
                            
                    } break;
                    


            }
        }*/

        private void Button1_Click(object sender, EventArgs e)
        {
            Carros tela = new Carros();
            tela.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Marca tela = new Marca();
            tela.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Vendas tela = new Vendas();
            tela.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Usuario tela = new Usuario();
            tela.ShowDialog();
        }
    }
}
