﻿
namespace dotnet_library
{
    partial class TelaLivrosEmprestados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLivrosEmprestados));
            this.dgvLivrosEmprestados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivrosEmprestados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLivrosEmprestados
            // 
            this.dgvLivrosEmprestados.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLivrosEmprestados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivrosEmprestados.Location = new System.Drawing.Point(34, 69);
            this.dgvLivrosEmprestados.Name = "dgvLivrosEmprestados";
            this.dgvLivrosEmprestados.RowTemplate.Height = 25;
            this.dgvLivrosEmprestados.Size = new System.Drawing.Size(422, 281);
            this.dgvLivrosEmprestados.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(156, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "LISTA DE LIVROS ALUGADOS";
            // 
            // TelaLivrosEmprestados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(493, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLivrosEmprestados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaLivrosEmprestados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Livros Emprestados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaLivrosEmprestados_FormClosed);
            this.Load += new System.EventHandler(this.TelaLivrosEmprestados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivrosEmprestados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLivrosEmprestados;
        private System.Windows.Forms.Label label1;
    }
}