﻿namespace EditorDeGrafos
{
    partial class AristasBBA
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
            this.dataGridAristas = new System.Windows.Forms.DataGridView();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aristas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAristas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAristas
            // 
            this.dataGridAristas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridAristas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridAristas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAristas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Color,
            this.Tipo,
            this.Aristas});
            this.dataGridAristas.Location = new System.Drawing.Point(12, 12);
            this.dataGridAristas.Name = "dataGridAristas";
            this.dataGridAristas.ReadOnly = true;
            this.dataGridAristas.RowHeadersVisible = false;
            this.dataGridAristas.Size = new System.Drawing.Size(310, 150);
            this.dataGridAristas.TabIndex = 1;
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.Width = 56;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 53;
            // 
            // Aristas
            // 
            this.Aristas.HeaderText = "Aristas";
            this.Aristas.Name = "Aristas";
            this.Aristas.ReadOnly = true;
            this.Aristas.Width = 63;
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(133, 168);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 2;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // AristasBBA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 201);
            this.ControlBox = false;
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.dataGridAristas);
            this.Name = "AristasBBA";
            this.Text = "AristasBBA";
            this.Load += new System.EventHandler(this.AristasBBA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAristas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAristas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aristas;
        private System.Windows.Forms.Button Cerrar;

    }
}