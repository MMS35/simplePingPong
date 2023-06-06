
namespace PingPong_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblSol = new System.Windows.Forms.Label();
            this.lblSag = new System.Windows.Forms.Label();
            this.lblAlt = new System.Windows.Forms.Label();
            this.lblUst = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.lblOyuncu2 = new System.Windows.Forms.Label();
            this.lblOyuncu1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSol
            // 
            this.lblSol.BackColor = System.Drawing.Color.Red;
            this.lblSol.Location = new System.Drawing.Point(0, 1);
            this.lblSol.Name = "lblSol";
            this.lblSol.Size = new System.Drawing.Size(18, 719);
            this.lblSol.TabIndex = 0;
            // 
            // lblSag
            // 
            this.lblSag.BackColor = System.Drawing.Color.Red;
            this.lblSag.Location = new System.Drawing.Point(1065, 1);
            this.lblSag.Name = "lblSag";
            this.lblSag.Size = new System.Drawing.Size(14, 720);
            this.lblSag.TabIndex = 0;
            // 
            // lblAlt
            // 
            this.lblAlt.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblAlt.Location = new System.Drawing.Point(17, 704);
            this.lblAlt.Name = "lblAlt";
            this.lblAlt.Size = new System.Drawing.Size(1062, 16);
            this.lblAlt.TabIndex = 1;
            // 
            // lblUst
            // 
            this.lblUst.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblUst.Location = new System.Drawing.Point(17, 1);
            this.lblUst.Name = "lblUst";
            this.lblUst.Size = new System.Drawing.Size(1047, 16);
            this.lblUst.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // lblOyuncu2
            // 
            this.lblOyuncu2.BackColor = System.Drawing.Color.Lavender;
            this.lblOyuncu2.Location = new System.Drawing.Point(992, 228);
            this.lblOyuncu2.Name = "lblOyuncu2";
            this.lblOyuncu2.Size = new System.Drawing.Size(28, 182);
            this.lblOyuncu2.TabIndex = 2;
            // 
            // lblOyuncu1
            // 
            this.lblOyuncu1.BackColor = System.Drawing.Color.Lavender;
            this.lblOyuncu1.Location = new System.Drawing.Point(40, 228);
            this.lblOyuncu1.Name = "lblOyuncu1";
            this.lblOyuncu1.Size = new System.Drawing.Size(28, 182);
            this.lblOyuncu1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(112, 294);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1081, 719);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblOyuncu1);
            this.Controls.Add(this.lblOyuncu2);
            this.Controls.Add(this.lblUst);
            this.Controls.Add(this.lblAlt);
            this.Controls.Add(this.lblSag);
            this.Controls.Add(this.lblSol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSol;
        private System.Windows.Forms.Label lblSag;
        private System.Windows.Forms.Label lblAlt;
        private System.Windows.Forms.Label lblUst;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Label lblOyuncu2;
        private System.Windows.Forms.Label lblOyuncu1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

