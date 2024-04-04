using System;
using System.Windows.Forms;

namespace AlexFormsPlus
{
    partial class Form4
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
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.Location = new System.Drawing.Point(274, 435);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(124, 53);
            this.btnAddPoint.TabIndex = 0;
            this.btnAddPoint.Text = "Adaugă punctul pe intersecție";
            this.btnAddPoint.UseVisualStyleBackColor = true;
            this.btnAddPoint.Click += new System.EventHandler(this.btnAddPoint_Click);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(12, 435);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(256, 20);
            this.txtX.TabIndex = 1;
            this.txtX.Text = "Valoarea lui x (șterge tot apoi scrie valoarea)";
            this.txtX.TextChanged += new System.EventHandler(this.txtX_TextChanged);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(12, 468);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(256, 20);
            this.txtY.TabIndex = 2;
            this.txtY.Text = "Valoarea lui y (șterge tot apoi scrie valoarea)";
            this.txtY.TextChanged += new System.EventHandler(this.txtY_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(523, 500);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 500);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.btnAddPoint);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.Text = "Intersecțiea axelor de coordonate ”x0y”";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void txtY_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtX_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}