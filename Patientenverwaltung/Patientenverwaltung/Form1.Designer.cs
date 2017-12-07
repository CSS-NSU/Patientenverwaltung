namespace Patientenverwaltung
{
    partial class Patientenverwaltung
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Searchfield = new System.Windows.Forms.TextBox();
            this.grid_Patienten = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Patienten)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(12, 379);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(143, 23);
            this.btn_create.TabIndex = 0;
            this.btn_create.Text = "Neuen Patient anlegen";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(557, 379);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Suchen";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // txt_Searchfield
            // 
            this.txt_Searchfield.Location = new System.Drawing.Point(220, 381);
            this.txt_Searchfield.Name = "txt_Searchfield";
            this.txt_Searchfield.Size = new System.Drawing.Size(331, 20);
            this.txt_Searchfield.TabIndex = 2;
            // 
            // grid_Patienten
            // 
            this.grid_Patienten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Patienten.Location = new System.Drawing.Point(12, 12);
            this.grid_Patienten.Name = "grid_Patienten";
            this.grid_Patienten.Size = new System.Drawing.Size(691, 351);
            this.grid_Patienten.TabIndex = 3;
            // 
            // Patientenverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 414);
            this.Controls.Add(this.grid_Patienten);
            this.Controls.Add(this.txt_Searchfield);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_create);
            this.Name = "Patientenverwaltung";
            this.Text = "Patientenverwaltung ♥";
            ((System.ComponentModel.ISupportInitialize)(this.grid_Patienten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Searchfield;
        private System.Windows.Forms.DataGridView grid_Patienten;
    }
}

