
namespace tokaGraafinen
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
            this.OhjetekstiLB = new System.Windows.Forms.Label();
            this.tekstiTB = new System.Windows.Forms.TextBox();
            this.OtsikkoLB = new System.Windows.Forms.Label();
            this.painikeBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OhjetekstiLB
            // 
            this.OhjetekstiLB.AutoSize = true;
            this.OhjetekstiLB.Location = new System.Drawing.Point(58, 25);
            this.OhjetekstiLB.Name = "OhjetekstiLB";
            this.OhjetekstiLB.Size = new System.Drawing.Size(77, 15);
            this.OhjetekstiLB.TabIndex = 0;
            this.OhjetekstiLB.Text = "Kirjoita jotain";
            // 
            // tekstiTB
            // 
            this.tekstiTB.Location = new System.Drawing.Point(161, 17);
            this.tekstiTB.Name = "tekstiTB";
            this.tekstiTB.Size = new System.Drawing.Size(161, 23);
            this.tekstiTB.TabIndex = 1;
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Location = new System.Drawing.Point(58, 131);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(38, 15);
            this.OtsikkoLB.TabIndex = 2;
            this.OtsikkoLB.Text = "label2";
            this.OtsikkoLB.Visible = false;
            // 
            // painikeBT
            // 
            this.painikeBT.Location = new System.Drawing.Point(68, 77);
            this.painikeBT.Name = "painikeBT";
            this.painikeBT.Size = new System.Drawing.Size(254, 23);
            this.painikeBT.TabIndex = 3;
            this.painikeBT.Text = "vaihda teksti";
            this.painikeBT.UseVisualStyleBackColor = true;
            this.painikeBT.Click += new System.EventHandler(this.painikeBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 233);
            this.Controls.Add(this.painikeBT);
            this.Controls.Add(this.OtsikkoLB);
            this.Controls.Add(this.tekstiTB);
            this.Controls.Add(this.OhjetekstiLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OhjetekstiLB;
        private System.Windows.Forms.TextBox tekstiTB;
        private System.Windows.Forms.Label OtsikkoLB;
        private System.Windows.Forms.Button painikeBT;
    }
}

