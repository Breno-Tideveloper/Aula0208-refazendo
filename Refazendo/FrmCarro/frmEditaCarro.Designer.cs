namespace FrmCarro
{
    partial class frmEditaCarro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txmodelo = new System.Windows.Forms.TextBox();
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.cbbox = new System.Windows.Forms.ComboBox();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.querysinnerjoinDataSet = new FrmCarro.querysinnerjoinDataSet();
            this.marcasTableAdapter = new FrmCarro.querysinnerjoinDataSetTableAdapters.MarcasTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.querysinnerjoinDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ano";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Txmodelo
            // 
            this.Txmodelo.Location = new System.Drawing.Point(94, 42);
            this.Txmodelo.Name = "Txmodelo";
            this.Txmodelo.Size = new System.Drawing.Size(292, 22);
            this.Txmodelo.TabIndex = 3;
            // 
            // dtpicker
            // 
            this.dtpicker.Location = new System.Drawing.Point(94, 83);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(292, 22);
            this.dtpicker.TabIndex = 6;
            // 
            // cbbox
            // 
            this.cbbox.DataSource = this.marcasBindingSource;
            this.cbbox.DisplayMember = "Nome";
            this.cbbox.FormattingEnabled = true;
            this.cbbox.Location = new System.Drawing.Point(94, 122);
            this.cbbox.Name = "cbbox";
            this.cbbox.Size = new System.Drawing.Size(292, 24);
            this.cbbox.TabIndex = 7;
            this.cbbox.ValueMember = "Id";
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "Marcas";
            this.marcasBindingSource.DataSource = this.querysinnerjoinDataSet;
            // 
            // querysinnerjoinDataSet
            // 
            this.querysinnerjoinDataSet.DataSetName = "querysinnerjoinDataSet";
            this.querysinnerjoinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(149, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(517, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 31);
            this.button2.TabIndex = 9;
            this.button2.Text = "Deletar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // frmEditaCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(631, 259);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbbox);
            this.Controls.Add(this.dtpicker);
            this.Controls.Add(this.Txmodelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmEditaCarro";
            this.Text = "Edicao de Carros";
            this.Load += new System.EventHandler(this.FrmEditaCarro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.querysinnerjoinDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txmodelo;
        private System.Windows.Forms.DateTimePicker dtpicker;
        private System.Windows.Forms.ComboBox cbbox;
        private querysinnerjoinDataSet querysinnerjoinDataSet;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private querysinnerjoinDataSetTableAdapters.MarcasTableAdapter marcasTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}