
namespace UseDatabase {
    partial class Daten {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAuftraege = new System.Windows.Forms.Label();
            this.dataGridViewAuftraege = new System.Windows.Forms.DataGridView();
            this.txtDeleteId = new System.Windows.Forms.TextBox();
            this.lblDeleteId = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuftraege)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.lblAuftraege);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 53);
            this.panel1.TabIndex = 1;
            // 
            // lblAuftraege
            // 
            this.lblAuftraege.AutoSize = true;
            this.lblAuftraege.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuftraege.Location = new System.Drawing.Point(12, 11);
            this.lblAuftraege.Name = "lblAuftraege";
            this.lblAuftraege.Size = new System.Drawing.Size(102, 29);
            this.lblAuftraege.TabIndex = 0;
            this.lblAuftraege.Text = "Aufträge";
            // 
            // dataGridViewAuftraege
            // 
            this.dataGridViewAuftraege.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewAuftraege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuftraege.Location = new System.Drawing.Point(0, 93);
            this.dataGridViewAuftraege.Name = "dataGridViewAuftraege";
            this.dataGridViewAuftraege.Size = new System.Drawing.Size(1201, 552);
            this.dataGridViewAuftraege.TabIndex = 2;
            // 
            // txtDeleteId
            // 
            this.txtDeleteId.Location = new System.Drawing.Point(163, 64);
            this.txtDeleteId.Name = "txtDeleteId";
            this.txtDeleteId.Size = new System.Drawing.Size(130, 20);
            this.txtDeleteId.TabIndex = 19;
            // 
            // lblDeleteId
            // 
            this.lblDeleteId.AutoSize = true;
            this.lblDeleteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteId.Location = new System.Drawing.Point(9, 64);
            this.lblDeleteId.Name = "lblDeleteId";
            this.lblDeleteId.Size = new System.Drawing.Size(128, 20);
            this.lblDeleteId.TabIndex = 18;
            this.lblDeleteId.Text = "Auftragsnummer";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(314, 62);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 25);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Daten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 645);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtDeleteId);
            this.Controls.Add(this.lblDeleteId);
            this.Controls.Add(this.dataGridViewAuftraege);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Daten";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daten";
            this.Load += new System.EventHandler(this.Daten_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuftraege)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAuftraege;
        private System.Windows.Forms.DataGridView dataGridViewAuftraege;
        private System.Windows.Forms.TextBox txtDeleteId;
        private System.Windows.Forms.Label lblDeleteId;
        private System.Windows.Forms.Button btnDelete;
    }
}