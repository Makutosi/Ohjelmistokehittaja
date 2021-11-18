
namespace Laskin1
{
    partial class Laskin
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
            this.lukuYksiTB = new System.Windows.Forms.TextBox();
            this.LaskutoimitusCB = new System.Windows.Forms.ComboBox();
            this.lukuKaksiTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.LaskeBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lukuYksiTB
            // 
            this.lukuYksiTB.Location = new System.Drawing.Point(54, 34);
            this.lukuYksiTB.Name = "lukuYksiTB";
            this.lukuYksiTB.Size = new System.Drawing.Size(100, 31);
            this.lukuYksiTB.TabIndex = 0;
            // 
            // LaskutoimitusCB
            // 
            this.LaskutoimitusCB.FormattingEnabled = true;
            this.LaskutoimitusCB.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.LaskutoimitusCB.Location = new System.Drawing.Point(160, 34);
            this.LaskutoimitusCB.Name = "LaskutoimitusCB";
            this.LaskutoimitusCB.Size = new System.Drawing.Size(95, 33);
            this.LaskutoimitusCB.TabIndex = 1;
            // 
            // lukuKaksiTB
            // 
            this.lukuKaksiTB.Location = new System.Drawing.Point(261, 34);
            this.lukuKaksiTB.Name = "lukuKaksiTB";
            this.lukuKaksiTB.Size = new System.Drawing.Size(100, 31);
            this.lukuKaksiTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(428, 40);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(26, 25);
            this.VastausLB.TabIndex = 4;
            this.VastausLB.Text = "X";
            this.VastausLB.Visible = false;
            // 
            // LaskeBT
            // 
            this.LaskeBT.Location = new System.Drawing.Point(54, 71);
            this.LaskeBT.Name = "LaskeBT";
            this.LaskeBT.Size = new System.Drawing.Size(307, 36);
            this.LaskeBT.TabIndex = 5;
            this.LaskeBT.Text = "Laske";
            this.LaskeBT.UseVisualStyleBackColor = true;
            this.LaskeBT.Click += new System.EventHandler(this.LaskeBT_Click);
            // 
            // Laskin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 120);
            this.Controls.Add(this.LaskeBT);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lukuKaksiTB);
            this.Controls.Add(this.LaskutoimitusCB);
            this.Controls.Add(this.lukuYksiTB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Laskin";
            this.Text = "Yksinkertainen nelilaskin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lukuYksiTB;
        private System.Windows.Forms.ComboBox LaskutoimitusCB;
        private System.Windows.Forms.TextBox lukuKaksiTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.Button LaskeBT;
    }
}

