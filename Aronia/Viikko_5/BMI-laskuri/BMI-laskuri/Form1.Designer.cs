
namespace BMI_laskuri
{
    partial class BMIForm
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
            this.PainoLB = new System.Windows.Forms.Label();
            this.PituusLB = new System.Windows.Forms.Label();
            this.PainoTB = new System.Windows.Forms.TextBox();
            this.PituusTB = new System.Windows.Forms.TextBox();
            this.LaskeBT = new System.Windows.Forms.Button();
            this.VastausLB = new System.Windows.Forms.Label();
            this.KuvausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PainoLB
            // 
            this.PainoLB.AutoSize = true;
            this.PainoLB.Location = new System.Drawing.Point(35, 34);
            this.PainoLB.Name = "PainoLB";
            this.PainoLB.Size = new System.Drawing.Size(113, 25);
            this.PainoLB.TabIndex = 0;
            this.PainoLB.Text = "Anna paino:";
            // 
            // PituusLB
            // 
            this.PituusLB.AutoSize = true;
            this.PituusLB.Location = new System.Drawing.Point(35, 87);
            this.PituusLB.Name = "PituusLB";
            this.PituusLB.Size = new System.Drawing.Size(145, 25);
            this.PituusLB.TabIndex = 1;
            this.PituusLB.Text = "Anna pituus(m):";
            // 
            // PainoTB
            // 
            this.PainoTB.Location = new System.Drawing.Point(174, 26);
            this.PainoTB.Name = "PainoTB";
            this.PainoTB.Size = new System.Drawing.Size(100, 33);
            this.PainoTB.TabIndex = 2;
            // 
            // PituusTB
            // 
            this.PituusTB.Location = new System.Drawing.Point(174, 84);
            this.PituusTB.Name = "PituusTB";
            this.PituusTB.Size = new System.Drawing.Size(100, 33);
            this.PituusTB.TabIndex = 3;
            // 
            // LaskeBT
            // 
            this.LaskeBT.Location = new System.Drawing.Point(40, 140);
            this.LaskeBT.Name = "LaskeBT";
            this.LaskeBT.Size = new System.Drawing.Size(234, 44);
            this.LaskeBT.TabIndex = 4;
            this.LaskeBT.Text = "Laske painoindeksi";
            this.LaskeBT.UseVisualStyleBackColor = true;
            this.LaskeBT.Click += new System.EventHandler(this.LaskeBT_Click);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.ForeColor = System.Drawing.Color.Black;
            this.VastausLB.Location = new System.Drawing.Point(35, 211);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(76, 25);
            this.VastausLB.TabIndex = 5;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // KuvausLB
            // 
            this.KuvausLB.AutoSize = true;
            this.KuvausLB.ForeColor = System.Drawing.Color.Black;
            this.KuvausLB.Location = new System.Drawing.Point(40, 255);
            this.KuvausLB.Name = "KuvausLB";
            this.KuvausLB.Size = new System.Drawing.Size(72, 25);
            this.KuvausLB.TabIndex = 6;
            this.KuvausLB.Text = "Kuvaus";
            this.KuvausLB.Visible = false;
            // 
            // BMIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(298, 337);
            this.Controls.Add(this.KuvausLB);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.LaskeBT);
            this.Controls.Add(this.PituusTB);
            this.Controls.Add(this.PainoTB);
            this.Controls.Add(this.PituusLB);
            this.Controls.Add(this.PainoLB);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "BMIForm";
            this.Text = "Painoindeksilaskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PainoLB;
        private System.Windows.Forms.Label PituusLB;
        private System.Windows.Forms.TextBox PainoTB;
        private System.Windows.Forms.TextBox PituusTB;
        private System.Windows.Forms.Button LaskeBT;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.Label KuvausLB;
    }
}

