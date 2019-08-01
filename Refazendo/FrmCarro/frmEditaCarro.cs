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
    
    public partial class frmEditaCarro : Form
    {
        public FrmCarro.querysinnerjoinDataSet.CarrosRow CarroRow;
        public frmEditaCarro()
        {
            InitializeComponent();
        }

        private void FrmEditaCarro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysinnerjoinDataSet.Marcas'. Você pode movê-la ou removê-la conforme necessário.
            this.marcasTableAdapter.Fill(this.querysinnerjoinDataSet.Marcas);
            Txmodelo.Text = CarroRow.Modelo;
            dtpicker.Value = CarroRow.Ano;
            cbbox.SelectedValue = CarroRow.Marca;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CarroRow.Modelo = Txmodelo.Text;
            CarroRow.Ano = dtpicker.Value;
            CarroRow.Marca = (int)cbbox.SelectedValue;
            this.Close();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
