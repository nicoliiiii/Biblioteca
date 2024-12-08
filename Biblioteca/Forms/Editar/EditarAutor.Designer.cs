
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarAutor));
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.lblNomeAutor = new System.Windows.Forms.Label();
            this.btnSalvarAutor = new System.Windows.Forms.Button();
            this.btnExcluirAutor = new System.Windows.Forms.Button();
            this.txtIdAutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtNomeAutor.Location = new System.Drawing.Point(82, 242);
            this.txtNomeAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(140, 26);
            this.txtNomeAutor.TabIndex = 0;
            // 
            // lblNomeAutor
            // 
            this.lblNomeAutor.AutoSize = true;
            this.lblNomeAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(203)))), ((int)(((byte)(211)))));
            this.lblNomeAutor.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblNomeAutor.Location = new System.Drawing.Point(78, 212);
            this.lblNomeAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeAutor.Name = "lblNomeAutor";
            this.lblNomeAutor.Size = new System.Drawing.Size(142, 29);
            this.lblNomeAutor.TabIndex = 1;
            this.lblNomeAutor.Text = "Nome do autor";
            // 
            // btnSalvarAutor
            // 
            this.btnSalvarAutor.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSalvarAutor.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnSalvarAutor.Location = new System.Drawing.Point(84, 299);
            this.btnSalvarAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalvarAutor.Name = "btnSalvarAutor";
            this.btnSalvarAutor.Size = new System.Drawing.Size(112, 35);
            this.btnSalvarAutor.TabIndex = 2;
            this.btnSalvarAutor.Text = "Salvar";
            this.btnSalvarAutor.UseVisualStyleBackColor = false;
            this.btnSalvarAutor.Click += new System.EventHandler(this.btnSalvarAutor_Click);
            // 
            // btnExcluirAutor
            // 
            this.btnExcluirAutor.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnExcluirAutor.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnExcluirAutor.Location = new System.Drawing.Point(84, 344);
            this.btnExcluirAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcluirAutor.Name = "btnExcluirAutor";
            this.btnExcluirAutor.Size = new System.Drawing.Size(112, 35);
            this.btnExcluirAutor.TabIndex = 5;
            this.btnExcluirAutor.Text = "Excluir";
            this.btnExcluirAutor.UseVisualStyleBackColor = false;
            this.btnExcluirAutor.Click += new System.EventHandler(this.btnExcluirAutor_Click);
            // 
            // txtIdAutor
            // 
            this.txtIdAutor.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtIdAutor.Enabled = false;
            this.txtIdAutor.Location = new System.Drawing.Point(84, 175);
            this.txtIdAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdAutor.Name = "txtIdAutor";
            this.txtIdAutor.Size = new System.Drawing.Size(139, 26);
            this.txtIdAutor.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(203)))), ((int)(((byte)(211)))));
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label1.Location = new System.Drawing.Point(78, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(203)))), ((int)(((byte)(211)))));
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 39);
            this.label4.TabIndex = 9;
            this.label4.Text = "Editar";
            // 
            // EditarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(297, 396);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdAutor);
            this.Controls.Add(this.btnExcluirAutor);
            this.Controls.Add(this.btnSalvarAutor);
            this.Controls.Add(this.lblNomeAutor);
            this.Controls.Add(this.txtNomeAutor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditarAutor";
            this.Text = "EditarAutor";
            this.Load += new System.EventHandler(this.EditarAutor_Load);
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
        private System.Windows.Forms.Label label4;
    }
}