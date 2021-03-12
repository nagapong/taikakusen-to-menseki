
using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.go = new System.Windows.Forms.Button();
            this.edge = new System.Windows.Forms.MaskedTextBox();
            this.diagonal = new System.Windows.Forms.MaskedTextBox();
            this.area = new System.Windows.Forms.MaskedTextBox();
            this.hen = new System.Windows.Forms.Label();
            this.taikakusen = new System.Windows.Forms.Label();
            this.menseki = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // go
            // 
            this.go.CausesValidation = false;
            this.go.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.go.FlatAppearance.BorderSize = 3;
            this.go.Location = new System.Drawing.Point(378, 113);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(75, 23);
            this.go.TabIndex = 0;
            this.go.Text = "計算する";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // edge
            // 
            this.edge.Location = new System.Drawing.Point(41, 31);
            this.edge.Name = "edge";
            this.edge.Size = new System.Drawing.Size(100, 23);
            this.edge.TabIndex = 1;
            this.edge.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.edge_MaskInputRejected);
            // 
            // diagonal
            // 
            this.diagonal.Location = new System.Drawing.Point(198, 31);
            this.diagonal.Name = "diagonal";
            this.diagonal.Size = new System.Drawing.Size(100, 23);
            this.diagonal.TabIndex = 1;
            this.diagonal.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.diagonal_MaskInputRejected);
            // 
            // area
            // 
            this.area.Location = new System.Drawing.Point(353, 31);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(100, 23);
            this.area.TabIndex = 1;
            // 
            // hen
            // 
            this.hen.AutoSize = true;
            this.hen.Location = new System.Drawing.Point(66, 66);
            this.hen.Name = "hen";
            this.hen.Size = new System.Drawing.Size(49, 15);
            this.hen.TabIndex = 2;
            this.hen.Text = "辺の長さ";
            // 
            // taikakusen
            // 
            this.taikakusen.AutoSize = true;
            this.taikakusen.Location = new System.Drawing.Point(211, 66);
            this.taikakusen.Name = "taikakusen";
            this.taikakusen.Size = new System.Drawing.Size(73, 15);
            this.taikakusen.TabIndex = 2;
            this.taikakusen.Text = "対角線の長さ";
            // 
            // menseki
            // 
            this.menseki.AutoSize = true;
            this.menseki.Location = new System.Drawing.Point(383, 66);
            this.menseki.Name = "menseki";
            this.menseki.Size = new System.Drawing.Size(31, 15);
            this.menseki.TabIndex = 2;
            this.menseki.Text = "面積";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(276, 113);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 3;
            this.clear.Text = "入力をクリア";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(178, 113);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 3;
            this.exit.Text = "終了";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.go;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clear;
            this.ClientSize = new System.Drawing.Size(477, 177);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.menseki);
            this.Controls.Add(this.taikakusen);
            this.Controls.Add(this.hen);
            this.Controls.Add(this.area);
            this.Controls.Add(this.diagonal);
            this.Controls.Add(this.edge);
            this.Controls.Add(this.go);
            this.Name = "Form1";
            this.Text = "正方形";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void diagonal_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button go;
        private System.Windows.Forms.MaskedTextBox edge;
        private System.Windows.Forms.MaskedTextBox diagonal;
        private System.Windows.Forms.MaskedTextBox area;
        private System.Windows.Forms.Label hen;
        private System.Windows.Forms.Label taikakusen;
        private System.Windows.Forms.Label menseki;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button exit;
    }
}

