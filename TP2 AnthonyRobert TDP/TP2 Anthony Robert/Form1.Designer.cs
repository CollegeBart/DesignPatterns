using System;
using System.Windows.Forms;

namespace Tp2_Anthony_Robert
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this._lblHeart = new System.Windows.Forms.Label();
            this._lblStar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lblHeart
            // 
            this._lblHeart.AutoSize = true;
            this._lblHeart.Location = new System.Drawing.Point(157, 24);
            this._lblHeart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._lblHeart.Name = "_lblHeart";
            this._lblHeart.Size = new System.Drawing.Size(13, 13);
            this._lblHeart.TabIndex = 0;
            this._lblHeart.Text = "0";
            // 
            // _lblStar
            // 
            this._lblStar.AutoSize = true;
            this._lblStar.Location = new System.Drawing.Point(157, 460);
            this._lblStar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._lblStar.Name = "_lblStar";
            this._lblStar.Size = new System.Drawing.Size(13, 13);
            this._lblStar.TabIndex = 1;
            this._lblStar.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "How many heart : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "How many star : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 504);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._lblStar);
            this.Controls.Add(this._lblHeart);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label _lblHeart;
        public System.Windows.Forms.Label _lblStar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

