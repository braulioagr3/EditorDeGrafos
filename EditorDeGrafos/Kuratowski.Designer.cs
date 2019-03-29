﻿namespace EditorDeGrafos
{
    partial class Kuratowski
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kuratowski));
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.EliminaNodo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.EliminarArista = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.HomeomorfoK5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.HomeomorfoK33 = new System.Windows.Forms.ToolStripButton();
            this.ToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolBar
            // 
            this.ToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EliminaNodo,
            this.toolStripSeparator2,
            this.EliminarArista,
            this.toolStripSeparator1,
            this.HomeomorfoK5,
            this.toolStripSeparator3,
            this.HomeomorfoK33});
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(847, 25);
            this.ToolBar.TabIndex = 0;
            this.ToolBar.Text = "ToolBar";
            this.ToolBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Clicked_Kuratowski);
            // 
            // EliminaNodo
            // 
            this.EliminaNodo.AccessibleName = "EliminaNodo";
            this.EliminaNodo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EliminaNodo.Image = ((System.Drawing.Image)(resources.GetObject("EliminaNodo.Image")));
            this.EliminaNodo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EliminaNodo.Name = "EliminaNodo";
            this.EliminaNodo.Size = new System.Drawing.Size(23, 22);
            this.EliminaNodo.Text = "Elimina Nodo";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // EliminarArista
            // 
            this.EliminarArista.AccessibleName = "EliminarArista";
            this.EliminarArista.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EliminarArista.Image = ((System.Drawing.Image)(resources.GetObject("EliminarArista.Image")));
            this.EliminarArista.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EliminarArista.Name = "EliminarArista";
            this.EliminarArista.Size = new System.Drawing.Size(23, 22);
            this.EliminarArista.Text = "Eliminar Arista";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // HomeomorfoK5
            // 
            this.HomeomorfoK5.AccessibleName = "HomeomorfoK5";
            this.HomeomorfoK5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HomeomorfoK5.Image = ((System.Drawing.Image)(resources.GetObject("HomeomorfoK5.Image")));
            this.HomeomorfoK5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HomeomorfoK5.Name = "HomeomorfoK5";
            this.HomeomorfoK5.Size = new System.Drawing.Size(23, 22);
            this.HomeomorfoK5.Text = "Kuratowski K5";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // HomeomorfoK33
            // 
            this.HomeomorfoK33.AccessibleName = "HomeomorfoK33";
            this.HomeomorfoK33.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HomeomorfoK33.Image = ((System.Drawing.Image)(resources.GetObject("HomeomorfoK33.Image")));
            this.HomeomorfoK33.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HomeomorfoK33.Name = "HomeomorfoK33";
            this.HomeomorfoK33.Size = new System.Drawing.Size(23, 22);
            this.HomeomorfoK33.Text = "Kuratowski K33";
            // 
            // Kuratowski
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 444);
            this.Controls.Add(this.ToolBar);
            this.Name = "Kuratowski";
            this.Text = "Kuratowski";
            this.Load += new System.EventHandler(this.Kuratowski_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Kuratowski_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Kuratowski_MouseDown);
            this.Resize += new System.EventHandler(this.Kuratowski_Resize);
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolBar;
        private System.Windows.Forms.ToolStripButton EliminaNodo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton EliminarArista;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton HomeomorfoK5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton HomeomorfoK33;
    }
}