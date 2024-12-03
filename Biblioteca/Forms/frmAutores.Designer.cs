
namespace Biblioteca.Forms
{
    partial class frmAutores
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
            this.dtGridAutor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnNovoAutor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAutor)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridAutor
            // 
            this.dtGridAutor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridAutor.Location = new System.Drawing.Point(12, 154);
            this.dtGridAutor.Name = "dtGridAutor";
            this.dtGridAutor.Size = new System.Drawing.Size(723, 284);
            this.dtGridAutor.TabIndex = 0;
            this.dtGridAutor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridAutor_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(12, 128);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(288, 20);
            this.txtPesquisar.TabIndex = 2;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // btnNovoAutor
            // 
            this.btnNovoAutor.Location = new System.Drawing.Point(341, 125);
            this.btnNovoAutor.Name = "btnNovoAutor";
            this.btnNovoAutor.Size = new System.Drawing.Size(151, 23);
            this.btnNovoAutor.TabIndex = 3;
            this.btnNovoAutor.Text = "Adicionar novo Autor(a)";
            this.btnNovoAutor.UseVisualStyleBackColor = true;
            this.btnNovoAutor.Click += new System.EventHandler(this.btnNovoAutor_Click);
            // 
            // frmAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNovoAutor);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGridAutor);
            this.Name = "frmAutores";
            this.Text = "frmAutores";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAutor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnNovoAutor;
    }
}