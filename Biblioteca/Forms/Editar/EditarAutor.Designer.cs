
namespace Biblioteca.Forms.Editar
{
    partial class EditarAutor
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
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.lblNomeAutor = new System.Windows.Forms.Label();
            this.btnSalvarAutor = new System.Windows.Forms.Button();
            this.btnExcluirAutor = new System.Windows.Forms.Button();
            this.txtIdAutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Location = new System.Drawing.Point(55, 153);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(95, 20);
            this.txtNomeAutor.TabIndex = 0;
            // 
            // lblNomeAutor
            // 
            this.lblNomeAutor.AutoSize = true;
            this.lblNomeAutor.Location = new System.Drawing.Point(52, 137);
            this.lblNomeAutor.Name = "lblNomeAutor";
            this.lblNomeAutor.Size = new System.Drawing.Size(77, 13);
            this.lblNomeAutor.TabIndex = 1;
            this.lblNomeAutor.Text = "Nome do autor";
            // 
            // btnSalvarAutor
            // 
            this.btnSalvarAutor.Location = new System.Drawing.Point(56, 190);
            this.btnSalvarAutor.Name = "btnSalvarAutor";
            this.btnSalvarAutor.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarAutor.TabIndex = 2;
            this.btnSalvarAutor.Text = "Salvar";
            this.btnSalvarAutor.UseVisualStyleBackColor = true;
            this.btnSalvarAutor.Click += new System.EventHandler(this.btnSalvarAutor_Click);
            // 
            // btnExcluirAutor
            // 
            this.btnExcluirAutor.Location = new System.Drawing.Point(56, 219);
            this.btnExcluirAutor.Name = "btnExcluirAutor";
            this.btnExcluirAutor.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirAutor.TabIndex = 5;
            this.btnExcluirAutor.Text = "Excluir";
            this.btnExcluirAutor.UseVisualStyleBackColor = true;
            this.btnExcluirAutor.Click += new System.EventHandler(this.btnExcluirAutor_Click);
            // 
            // txtIdAutor
            // 
            this.txtIdAutor.Enabled = false;
            this.txtIdAutor.Location = new System.Drawing.Point(56, 114);
            this.txtIdAutor.Name = "txtIdAutor";
            this.txtIdAutor.Size = new System.Drawing.Size(94, 20);
            this.txtIdAutor.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id";
            // 
            // EditarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdAutor);
            this.Controls.Add(this.btnExcluirAutor);
            this.Controls.Add(this.btnSalvarAutor);
            this.Controls.Add(this.lblNomeAutor);
            this.Controls.Add(this.txtNomeAutor);
            this.Name = "EditarAutor";
            this.Text = "EditarAutor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.Label lblNomeAutor;
        private System.Windows.Forms.Button btnSalvarAutor;
        private System.Windows.Forms.Button btnExcluirAutor;
        private System.Windows.Forms.TextBox txtIdAutor;
        private System.Windows.Forms.Label label1;
    }
}