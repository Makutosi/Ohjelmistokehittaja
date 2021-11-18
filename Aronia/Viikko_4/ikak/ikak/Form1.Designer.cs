
namespace ikak
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
            this.ikaDT = new System.Windows.Forms.DateTimePicker();
            this.laskeBT = new System.Windows.Forms.Button();
            this.paivinaLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ikaDT
            // 
            this.ikaDT.Location = new System.Drawing.Point(88, 40);
            this.ikaDT.Name = "ikaDT";
            this.ikaDT.Size = new System.Drawing.Size(366, 31);
            this.ikaDT.TabIndex = 0;
            // 
            // laskeBT
            // 
            this.laskeBT.Location = new System.Drawing.Point(473, 41);
            this.laskeBT.Name = "laskeBT";
            this.laskeBT.Size = new System.Drawing.Size(121, 31);
            this.laskeBT.TabIndex = 1;
            this.laskeBT.Text = "Laske ikä";
            this.laskeBT.UseVisualStyleBackColor = true;
            this.laskeBT.Click += new System.EventHandler(this.laskeBT_Click);
            // 
            // paivinaLB
            // 
            this.paivinaLB.AutoSize = true;
            this.paivinaLB.Location = new System.Drawing.Point(117, 99);
            this.paivinaLB.Name = "paivinaLB";
            this.paivinaLB.Size = new System.Drawing.Size(70, 25);
            this.paivinaLB.TabIndex = 2;
            this.paivinaLB.Text = "label1";
            this.paivinaLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.paivinaLB);
            this.Controls.Add(this.laskeBT);
            this.Controls.Add(this.ikaDT);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker ikaDT;
        private System.Windows.Forms.Button laskeBT;
        private System.Windows.Forms.Label paivinaLB;
    }
}

