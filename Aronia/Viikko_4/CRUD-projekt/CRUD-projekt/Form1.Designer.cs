
namespace CRUD_projekt
{
    partial class YllapitoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YllapitoForm));
            this.idLB = new System.Windows.Forms.Label();
            this.enimiLB = new System.Windows.Forms.Label();
            this.snimiLB = new System.Windows.Forms.Label();
            this.puhLB = new System.Windows.Forms.Label();
            this.emailLB = new System.Windows.Forms.Label();
            this.oNroLB = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.enimiTB = new System.Windows.Forms.TextBox();
            this.snimiTB = new System.Windows.Forms.TextBox();
            this.puhTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.oNroTB = new System.Windows.Forms.TextBox();
            this.tyhjennaBT = new System.Windows.Forms.Button();
            this.tallennaBT = new System.Windows.Forms.Button();
            this.paivitaBT = new System.Windows.Forms.Button();
            this.poistaBT = new System.Windows.Forms.Button();
            this.TietotauluDG = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).BeginInit();
            this.SuspendLayout();
            // 
            // idLB
            // 
            this.idLB.AutoSize = true;
            this.idLB.Location = new System.Drawing.Point(16, 32);
            this.idLB.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.idLB.Name = "idLB";
            this.idLB.Size = new System.Drawing.Size(41, 25);
            this.idLB.TabIndex = 0;
            this.idLB.Text = "ID:";
            // 
            // enimiLB
            // 
            this.enimiLB.AutoSize = true;
            this.enimiLB.Location = new System.Drawing.Point(16, 75);
            this.enimiLB.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.enimiLB.Name = "enimiLB";
            this.enimiLB.Size = new System.Drawing.Size(111, 25);
            this.enimiLB.TabIndex = 1;
            this.enimiLB.Text = "ETUNIMI:";
            // 
            // snimiLB
            // 
            this.snimiLB.AutoSize = true;
            this.snimiLB.Location = new System.Drawing.Point(16, 118);
            this.snimiLB.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.snimiLB.Name = "snimiLB";
            this.snimiLB.Size = new System.Drawing.Size(128, 25);
            this.snimiLB.TabIndex = 2;
            this.snimiLB.Text = "SUKUNIMI:";
            // 
            // puhLB
            // 
            this.puhLB.AutoSize = true;
            this.puhLB.Location = new System.Drawing.Point(457, 32);
            this.puhLB.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.puhLB.Name = "puhLB";
            this.puhLB.Size = new System.Drawing.Size(116, 25);
            this.puhLB.TabIndex = 3;
            this.puhLB.Text = "PUHELIN:";
            // 
            // emailLB
            // 
            this.emailLB.AutoSize = true;
            this.emailLB.Location = new System.Drawing.Point(457, 72);
            this.emailLB.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.emailLB.Name = "emailLB";
            this.emailLB.Size = new System.Drawing.Size(164, 25);
            this.emailLB.TabIndex = 4;
            this.emailLB.Text = "SÄHKÖPOSTI:";
            this.emailLB.Click += new System.EventHandler(this.emailLB_Click);
            // 
            // oNroLB
            // 
            this.oNroLB.AutoSize = true;
            this.oNroLB.Location = new System.Drawing.Point(457, 109);
            this.oNroLB.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.oNroLB.Name = "oNroLB";
            this.oNroLB.Size = new System.Drawing.Size(197, 25);
            this.oNroLB.TabIndex = 5;
            this.oNroLB.Text = "OPISKELIJANRO:";
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(167, 32);
            this.idTB.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(212, 31);
            this.idTB.TabIndex = 6;
            // 
            // enimiTB
            // 
            this.enimiTB.Location = new System.Drawing.Point(167, 72);
            this.enimiTB.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.enimiTB.Name = "enimiTB";
            this.enimiTB.Size = new System.Drawing.Size(212, 31);
            this.enimiTB.TabIndex = 7;
            // 
            // snimiTB
            // 
            this.snimiTB.Location = new System.Drawing.Point(167, 115);
            this.snimiTB.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.snimiTB.Name = "snimiTB";
            this.snimiTB.Size = new System.Drawing.Size(212, 31);
            this.snimiTB.TabIndex = 8;
            // 
            // puhTB
            // 
            this.puhTB.Location = new System.Drawing.Point(672, 29);
            this.puhTB.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.puhTB.Name = "puhTB";
            this.puhTB.Size = new System.Drawing.Size(212, 31);
            this.puhTB.TabIndex = 9;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(672, 66);
            this.emailTB.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(212, 31);
            this.emailTB.TabIndex = 10;
            // 
            // oNroTB
            // 
            this.oNroTB.Location = new System.Drawing.Point(672, 109);
            this.oNroTB.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.oNroTB.Name = "oNroTB";
            this.oNroTB.Size = new System.Drawing.Size(212, 31);
            this.oNroTB.TabIndex = 11;
            // 
            // tyhjennaBT
            // 
            this.tyhjennaBT.Location = new System.Drawing.Point(16, 149);
            this.tyhjennaBT.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tyhjennaBT.Name = "tyhjennaBT";
            this.tyhjennaBT.Size = new System.Drawing.Size(163, 44);
            this.tyhjennaBT.TabIndex = 12;
            this.tyhjennaBT.Text = "TYHJENNÄ";
            this.tyhjennaBT.UseVisualStyleBackColor = true;
            this.tyhjennaBT.Click += new System.EventHandler(this.tyhjennaBT_Click_1);
            // 
            // tallennaBT
            // 
            this.tallennaBT.Location = new System.Drawing.Point(249, 152);
            this.tallennaBT.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tallennaBT.Name = "tallennaBT";
            this.tallennaBT.Size = new System.Drawing.Size(163, 44);
            this.tallennaBT.TabIndex = 13;
            this.tallennaBT.Text = "TALLENNA";
            this.tallennaBT.UseVisualStyleBackColor = true;
            this.tallennaBT.Click += new System.EventHandler(this.tallennaBT_Click_1);
            // 
            // paivitaBT
            // 
            this.paivitaBT.Location = new System.Drawing.Point(482, 152);
            this.paivitaBT.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.paivitaBT.Name = "paivitaBT";
            this.paivitaBT.Size = new System.Drawing.Size(163, 44);
            this.paivitaBT.TabIndex = 14;
            this.paivitaBT.Text = "PÄIVITÄ";
            this.paivitaBT.UseVisualStyleBackColor = true;
            this.paivitaBT.Click += new System.EventHandler(this.paivitaBT_Click_1);
            // 
            // poistaBT
            // 
            this.poistaBT.Location = new System.Drawing.Point(721, 152);
            this.poistaBT.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.poistaBT.Name = "poistaBT";
            this.poistaBT.Size = new System.Drawing.Size(163, 44);
            this.poistaBT.TabIndex = 15;
            this.poistaBT.Text = "POISTA";
            this.poistaBT.UseVisualStyleBackColor = true;
            this.poistaBT.Click += new System.EventHandler(this.poistaBT_Click_1);
            // 
            // TietotauluDG
            // 
            this.TietotauluDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TietotauluDG.Location = new System.Drawing.Point(16, 208);
            this.TietotauluDG.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TietotauluDG.Name = "TietotauluDG";
            this.TietotauluDG.Size = new System.Drawing.Size(948, 255);
            this.TietotauluDG.TabIndex = 16;
            this.TietotauluDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TietotauluDG_CellClick);
            // 
            // YllapitoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(988, 489);
            this.Controls.Add(this.TietotauluDG);
            this.Controls.Add(this.poistaBT);
            this.Controls.Add(this.paivitaBT);
            this.Controls.Add(this.tallennaBT);
            this.Controls.Add(this.tyhjennaBT);
            this.Controls.Add(this.oNroTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.puhTB);
            this.Controls.Add(this.snimiTB);
            this.Controls.Add(this.enimiTB);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.oNroLB);
            this.Controls.Add(this.emailLB);
            this.Controls.Add(this.puhLB);
            this.Controls.Add(this.snimiLB);
            this.Controls.Add(this.enimiLB);
            this.Controls.Add(this.idLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "YllapitoForm";
            this.Text = "Opiskelijarekisterin ylläpito";
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLB;
        private System.Windows.Forms.Label enimiLB;
        private System.Windows.Forms.Label snimiLB;
        private System.Windows.Forms.Label puhLB;
        private System.Windows.Forms.Label emailLB;
        private System.Windows.Forms.Label oNroLB;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox enimiTB;
        private System.Windows.Forms.TextBox snimiTB;
        private System.Windows.Forms.TextBox puhTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox oNroTB;
        private System.Windows.Forms.Button tyhjennaBT;
        private System.Windows.Forms.Button tallennaBT;
        private System.Windows.Forms.Button paivitaBT;
        private System.Windows.Forms.Button poistaBT;
        private System.Windows.Forms.DataGridView TietotauluDG;
    }
}

