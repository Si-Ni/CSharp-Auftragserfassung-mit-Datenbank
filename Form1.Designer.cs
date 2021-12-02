
namespace UseDatabase {
    partial class Form1 {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAuftragserfassung = new System.Windows.Forms.Label();
            this.lblAuftragsnummer = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblStartFirmaName = new System.Windows.Forms.Label();
            this.lblStartAnsprechpartner = new System.Windows.Forms.Label();
            this.lblStartStraße = new System.Windows.Forms.Label();
            this.lblStartHausnummer = new System.Windows.Forms.Label();
            this.lblZiel = new System.Windows.Forms.Label();
            this.lblZielFirmaName = new System.Windows.Forms.Label();
            this.lblZielAnsprechpartner = new System.Windows.Forms.Label();
            this.lblZielStraße = new System.Windows.Forms.Label();
            this.lblZielHausnummer = new System.Windows.Forms.Label();
            this.lblAllgemeineInformationen = new System.Windows.Forms.Label();
            this.lblAuftragsverguetung = new System.Windows.Forms.Label();
            this.lblTransportgut = new System.Windows.Forms.Label();
            this.lblGrenzen = new System.Windows.Forms.Label();
            this.txtAuftragsnummer = new System.Windows.Forms.TextBox();
            this.txtStartFirmaName = new System.Windows.Forms.TextBox();
            this.txtStartAnsprechpartner = new System.Windows.Forms.TextBox();
            this.txtStartStraße = new System.Windows.Forms.TextBox();
            this.txtStartHausnummer = new System.Windows.Forms.TextBox();
            this.txtZielFirmaName = new System.Windows.Forms.TextBox();
            this.txtZielAnsprechpartner = new System.Windows.Forms.TextBox();
            this.txtZielStraße = new System.Windows.Forms.TextBox();
            this.txtZielHausnummer = new System.Windows.Forms.TextBox();
            this.txtAuftragsverguetung = new System.Windows.Forms.TextBox();
            this.txtTransportgut = new System.Windows.Forms.TextBox();
            this.txtGewicht = new System.Windows.Forms.TextBox();
            this.lblGewicht = new System.Windows.Forms.Label();
            this.radioButtonGrenzenJa = new System.Windows.Forms.RadioButton();
            this.radioButtonGrenzenNein = new System.Windows.Forms.RadioButton();
            this.lblStartStadt = new System.Windows.Forms.Label();
            this.txtStartStadt = new System.Windows.Forms.TextBox();
            this.txtZielStadt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblKG = new System.Windows.Forms.Label();
            this.lblAusgabe = new System.Windows.Forms.Label();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.btnShowData = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.lblAuftragserfassung);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 53);
            this.panel1.TabIndex = 0;
            // 
            // lblAuftragserfassung
            // 
            this.lblAuftragserfassung.AutoSize = true;
            this.lblAuftragserfassung.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuftragserfassung.Location = new System.Drawing.Point(12, 11);
            this.lblAuftragserfassung.Name = "lblAuftragserfassung";
            this.lblAuftragserfassung.Size = new System.Drawing.Size(205, 29);
            this.lblAuftragserfassung.TabIndex = 0;
            this.lblAuftragserfassung.Text = "Auftragserfassung";
            // 
            // lblAuftragsnummer
            // 
            this.lblAuftragsnummer.AutoSize = true;
            this.lblAuftragsnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuftragsnummer.Location = new System.Drawing.Point(14, 79);
            this.lblAuftragsnummer.Name = "lblAuftragsnummer";
            this.lblAuftragsnummer.Size = new System.Drawing.Size(132, 20);
            this.lblAuftragsnummer.TabIndex = 1;
            this.lblAuftragsnummer.Text = "Auftragsnummer:";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(14, 158);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(48, 20);
            this.lblStart.TabIndex = 2;
            this.lblStart.Text = "Start:";
            // 
            // lblStartFirmaName
            // 
            this.lblStartFirmaName.AutoSize = true;
            this.lblStartFirmaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartFirmaName.Location = new System.Drawing.Point(14, 203);
            this.lblStartFirmaName.Name = "lblStartFirmaName";
            this.lblStartFirmaName.Size = new System.Drawing.Size(95, 20);
            this.lblStartFirmaName.TabIndex = 3;
            this.lblStartFirmaName.Text = "Firma Name";
            // 
            // lblStartAnsprechpartner
            // 
            this.lblStartAnsprechpartner.AutoSize = true;
            this.lblStartAnsprechpartner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartAnsprechpartner.Location = new System.Drawing.Point(14, 226);
            this.lblStartAnsprechpartner.Name = "lblStartAnsprechpartner";
            this.lblStartAnsprechpartner.Size = new System.Drawing.Size(128, 20);
            this.lblStartAnsprechpartner.TabIndex = 4;
            this.lblStartAnsprechpartner.Text = "Ansprechpartner";
            // 
            // lblStartStraße
            // 
            this.lblStartStraße.AutoSize = true;
            this.lblStartStraße.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartStraße.Location = new System.Drawing.Point(14, 249);
            this.lblStartStraße.Name = "lblStartStraße";
            this.lblStartStraße.Size = new System.Drawing.Size(58, 20);
            this.lblStartStraße.TabIndex = 5;
            this.lblStartStraße.Text = "Straße";
            // 
            // lblStartHausnummer
            // 
            this.lblStartHausnummer.AutoSize = true;
            this.lblStartHausnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartHausnummer.Location = new System.Drawing.Point(14, 271);
            this.lblStartHausnummer.Name = "lblStartHausnummer";
            this.lblStartHausnummer.Size = new System.Drawing.Size(105, 20);
            this.lblStartHausnummer.TabIndex = 6;
            this.lblStartHausnummer.Text = "Hausnummer";
            // 
            // lblZiel
            // 
            this.lblZiel.AutoSize = true;
            this.lblZiel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZiel.Location = new System.Drawing.Point(491, 158);
            this.lblZiel.Name = "lblZiel";
            this.lblZiel.Size = new System.Drawing.Size(38, 20);
            this.lblZiel.TabIndex = 7;
            this.lblZiel.Text = "Ziel:";
            // 
            // lblZielFirmaName
            // 
            this.lblZielFirmaName.AutoSize = true;
            this.lblZielFirmaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZielFirmaName.Location = new System.Drawing.Point(491, 203);
            this.lblZielFirmaName.Name = "lblZielFirmaName";
            this.lblZielFirmaName.Size = new System.Drawing.Size(95, 20);
            this.lblZielFirmaName.TabIndex = 8;
            this.lblZielFirmaName.Text = "Firma Name";
            // 
            // lblZielAnsprechpartner
            // 
            this.lblZielAnsprechpartner.AutoSize = true;
            this.lblZielAnsprechpartner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZielAnsprechpartner.Location = new System.Drawing.Point(491, 226);
            this.lblZielAnsprechpartner.Name = "lblZielAnsprechpartner";
            this.lblZielAnsprechpartner.Size = new System.Drawing.Size(128, 20);
            this.lblZielAnsprechpartner.TabIndex = 9;
            this.lblZielAnsprechpartner.Text = "Ansprechpartner";
            // 
            // lblZielStraße
            // 
            this.lblZielStraße.AutoSize = true;
            this.lblZielStraße.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZielStraße.Location = new System.Drawing.Point(491, 249);
            this.lblZielStraße.Name = "lblZielStraße";
            this.lblZielStraße.Size = new System.Drawing.Size(58, 20);
            this.lblZielStraße.TabIndex = 10;
            this.lblZielStraße.Text = "Straße";
            // 
            // lblZielHausnummer
            // 
            this.lblZielHausnummer.AutoSize = true;
            this.lblZielHausnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZielHausnummer.Location = new System.Drawing.Point(491, 271);
            this.lblZielHausnummer.Name = "lblZielHausnummer";
            this.lblZielHausnummer.Size = new System.Drawing.Size(105, 20);
            this.lblZielHausnummer.TabIndex = 11;
            this.lblZielHausnummer.Text = "Hausnummer";
            // 
            // lblAllgemeineInformationen
            // 
            this.lblAllgemeineInformationen.AutoSize = true;
            this.lblAllgemeineInformationen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllgemeineInformationen.Location = new System.Drawing.Point(13, 352);
            this.lblAllgemeineInformationen.Name = "lblAllgemeineInformationen";
            this.lblAllgemeineInformationen.Size = new System.Drawing.Size(194, 20);
            this.lblAllgemeineInformationen.TabIndex = 12;
            this.lblAllgemeineInformationen.Text = "Allgemeine Informationen:";
            // 
            // lblAuftragsverguetung
            // 
            this.lblAuftragsverguetung.AutoSize = true;
            this.lblAuftragsverguetung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuftragsverguetung.Location = new System.Drawing.Point(14, 387);
            this.lblAuftragsverguetung.Name = "lblAuftragsverguetung";
            this.lblAuftragsverguetung.Size = new System.Drawing.Size(141, 20);
            this.lblAuftragsverguetung.TabIndex = 13;
            this.lblAuftragsverguetung.Text = "Auftragsvergütung";
            // 
            // lblTransportgut
            // 
            this.lblTransportgut.AutoSize = true;
            this.lblTransportgut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransportgut.Location = new System.Drawing.Point(14, 411);
            this.lblTransportgut.Name = "lblTransportgut";
            this.lblTransportgut.Size = new System.Drawing.Size(100, 20);
            this.lblTransportgut.TabIndex = 14;
            this.lblTransportgut.Text = "Transportgut";
            // 
            // lblGrenzen
            // 
            this.lblGrenzen.AutoSize = true;
            this.lblGrenzen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrenzen.Location = new System.Drawing.Point(14, 457);
            this.lblGrenzen.Name = "lblGrenzen";
            this.lblGrenzen.Size = new System.Drawing.Size(199, 20);
            this.lblGrenzen.TabIndex = 15;
            this.lblGrenzen.Text = "Ländergrenzen überfahren";
            // 
            // txtAuftragsnummer
            // 
            this.txtAuftragsnummer.Enabled = false;
            this.txtAuftragsnummer.Location = new System.Drawing.Point(17, 103);
            this.txtAuftragsnummer.Name = "txtAuftragsnummer";
            this.txtAuftragsnummer.Size = new System.Drawing.Size(92, 20);
            this.txtAuftragsnummer.TabIndex = 16;
            // 
            // txtStartFirmaName
            // 
            this.txtStartFirmaName.Location = new System.Drawing.Point(168, 203);
            this.txtStartFirmaName.Name = "txtStartFirmaName";
            this.txtStartFirmaName.Size = new System.Drawing.Size(199, 20);
            this.txtStartFirmaName.TabIndex = 17;
            // 
            // txtStartAnsprechpartner
            // 
            this.txtStartAnsprechpartner.Location = new System.Drawing.Point(168, 226);
            this.txtStartAnsprechpartner.Name = "txtStartAnsprechpartner";
            this.txtStartAnsprechpartner.Size = new System.Drawing.Size(199, 20);
            this.txtStartAnsprechpartner.TabIndex = 18;
            // 
            // txtStartStraße
            // 
            this.txtStartStraße.Location = new System.Drawing.Point(168, 249);
            this.txtStartStraße.Name = "txtStartStraße";
            this.txtStartStraße.Size = new System.Drawing.Size(199, 20);
            this.txtStartStraße.TabIndex = 19;
            // 
            // txtStartHausnummer
            // 
            this.txtStartHausnummer.Location = new System.Drawing.Point(168, 271);
            this.txtStartHausnummer.Name = "txtStartHausnummer";
            this.txtStartHausnummer.Size = new System.Drawing.Size(199, 20);
            this.txtStartHausnummer.TabIndex = 20;
            // 
            // txtZielFirmaName
            // 
            this.txtZielFirmaName.Location = new System.Drawing.Point(643, 203);
            this.txtZielFirmaName.Name = "txtZielFirmaName";
            this.txtZielFirmaName.Size = new System.Drawing.Size(199, 20);
            this.txtZielFirmaName.TabIndex = 22;
            // 
            // txtZielAnsprechpartner
            // 
            this.txtZielAnsprechpartner.Location = new System.Drawing.Point(643, 226);
            this.txtZielAnsprechpartner.Name = "txtZielAnsprechpartner";
            this.txtZielAnsprechpartner.Size = new System.Drawing.Size(199, 20);
            this.txtZielAnsprechpartner.TabIndex = 23;
            // 
            // txtZielStraße
            // 
            this.txtZielStraße.Location = new System.Drawing.Point(643, 249);
            this.txtZielStraße.Name = "txtZielStraße";
            this.txtZielStraße.Size = new System.Drawing.Size(199, 20);
            this.txtZielStraße.TabIndex = 24;
            // 
            // txtZielHausnummer
            // 
            this.txtZielHausnummer.Location = new System.Drawing.Point(643, 271);
            this.txtZielHausnummer.Name = "txtZielHausnummer";
            this.txtZielHausnummer.Size = new System.Drawing.Size(199, 20);
            this.txtZielHausnummer.TabIndex = 25;
            // 
            // txtAuftragsverguetung
            // 
            this.txtAuftragsverguetung.Location = new System.Drawing.Point(258, 387);
            this.txtAuftragsverguetung.Name = "txtAuftragsverguetung";
            this.txtAuftragsverguetung.Size = new System.Drawing.Size(109, 20);
            this.txtAuftragsverguetung.TabIndex = 27;
            // 
            // txtTransportgut
            // 
            this.txtTransportgut.Location = new System.Drawing.Point(258, 411);
            this.txtTransportgut.Name = "txtTransportgut";
            this.txtTransportgut.Size = new System.Drawing.Size(211, 20);
            this.txtTransportgut.TabIndex = 28;
            // 
            // txtGewicht
            // 
            this.txtGewicht.Location = new System.Drawing.Point(258, 435);
            this.txtGewicht.Name = "txtGewicht";
            this.txtGewicht.Size = new System.Drawing.Size(211, 20);
            this.txtGewicht.TabIndex = 29;
            // 
            // lblGewicht
            // 
            this.lblGewicht.AutoSize = true;
            this.lblGewicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGewicht.Location = new System.Drawing.Point(14, 434);
            this.lblGewicht.Name = "lblGewicht";
            this.lblGewicht.Size = new System.Drawing.Size(110, 20);
            this.lblGewicht.TabIndex = 28;
            this.lblGewicht.Text = "Warengewicht";
            // 
            // radioButtonGrenzenJa
            // 
            this.radioButtonGrenzenJa.AutoSize = true;
            this.radioButtonGrenzenJa.Checked = true;
            this.radioButtonGrenzenJa.Location = new System.Drawing.Point(258, 460);
            this.radioButtonGrenzenJa.Name = "radioButtonGrenzenJa";
            this.radioButtonGrenzenJa.Size = new System.Drawing.Size(36, 17);
            this.radioButtonGrenzenJa.TabIndex = 30;
            this.radioButtonGrenzenJa.TabStop = true;
            this.radioButtonGrenzenJa.Text = "Ja";
            this.radioButtonGrenzenJa.UseVisualStyleBackColor = true;
            // 
            // radioButtonGrenzenNein
            // 
            this.radioButtonGrenzenNein.AutoSize = true;
            this.radioButtonGrenzenNein.Location = new System.Drawing.Point(320, 461);
            this.radioButtonGrenzenNein.Name = "radioButtonGrenzenNein";
            this.radioButtonGrenzenNein.Size = new System.Drawing.Size(47, 17);
            this.radioButtonGrenzenNein.TabIndex = 30;
            this.radioButtonGrenzenNein.Text = "Nein";
            this.radioButtonGrenzenNein.UseVisualStyleBackColor = true;
            // 
            // lblStartStadt
            // 
            this.lblStartStadt.AutoSize = true;
            this.lblStartStadt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartStadt.Location = new System.Drawing.Point(14, 293);
            this.lblStartStadt.Name = "lblStartStadt";
            this.lblStartStadt.Size = new System.Drawing.Size(48, 20);
            this.lblStartStadt.TabIndex = 31;
            this.lblStartStadt.Text = "Stadt";
            // 
            // txtStartStadt
            // 
            this.txtStartStadt.Location = new System.Drawing.Point(168, 293);
            this.txtStartStadt.Name = "txtStartStadt";
            this.txtStartStadt.Size = new System.Drawing.Size(199, 20);
            this.txtStartStadt.TabIndex = 21;
            // 
            // txtZielStadt
            // 
            this.txtZielStadt.Location = new System.Drawing.Point(643, 294);
            this.txtZielStadt.Name = "txtZielStadt";
            this.txtZielStadt.Size = new System.Drawing.Size(199, 20);
            this.txtZielStadt.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(491, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Stadt";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro.Location = new System.Drawing.Point(371, 387);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(20, 21);
            this.lblEuro.TabIndex = 35;
            this.lblEuro.Text = "€";
            // 
            // lblKG
            // 
            this.lblKG.AutoSize = true;
            this.lblKG.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKG.Location = new System.Drawing.Point(475, 435);
            this.lblKG.Name = "lblKG";
            this.lblKG.Size = new System.Drawing.Size(29, 21);
            this.lblKG.TabIndex = 36;
            this.lblKG.Text = "kg";
            // 
            // lblAusgabe
            // 
            this.lblAusgabe.AutoSize = true;
            this.lblAusgabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAusgabe.Location = new System.Drawing.Point(12, 498);
            this.lblAusgabe.Name = "lblAusgabe";
            this.lblAusgabe.Size = new System.Drawing.Size(73, 20);
            this.lblAusgabe.TabIndex = 37;
            this.lblAusgabe.Text = "Ausgabe";
            this.lblAusgabe.Visible = false;
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnSpeichern.Location = new System.Drawing.Point(828, 498);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(146, 38);
            this.btnSpeichern.TabIndex = 38;
            this.btnSpeichern.Text = "Auftrag speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnAbbrechen.Location = new System.Drawing.Point(683, 498);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(139, 38);
            this.btnAbbrechen.TabIndex = 39;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // btnShowData
            // 
            this.btnShowData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnShowData.Location = new System.Drawing.Point(538, 498);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(139, 38);
            this.btnShowData.TabIndex = 40;
            this.btnShowData.Text = "Aufträge anzeigen";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 546);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.lblAusgabe);
            this.Controls.Add(this.lblKG);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.txtZielStadt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStartStadt);
            this.Controls.Add(this.lblStartStadt);
            this.Controls.Add(this.radioButtonGrenzenNein);
            this.Controls.Add(this.radioButtonGrenzenJa);
            this.Controls.Add(this.lblGewicht);
            this.Controls.Add(this.txtGewicht);
            this.Controls.Add(this.txtTransportgut);
            this.Controls.Add(this.txtAuftragsverguetung);
            this.Controls.Add(this.txtZielHausnummer);
            this.Controls.Add(this.txtZielStraße);
            this.Controls.Add(this.txtZielAnsprechpartner);
            this.Controls.Add(this.txtZielFirmaName);
            this.Controls.Add(this.txtStartHausnummer);
            this.Controls.Add(this.txtStartStraße);
            this.Controls.Add(this.txtStartAnsprechpartner);
            this.Controls.Add(this.txtStartFirmaName);
            this.Controls.Add(this.txtAuftragsnummer);
            this.Controls.Add(this.lblGrenzen);
            this.Controls.Add(this.lblTransportgut);
            this.Controls.Add(this.lblAuftragsverguetung);
            this.Controls.Add(this.lblAllgemeineInformationen);
            this.Controls.Add(this.lblZielHausnummer);
            this.Controls.Add(this.lblZielStraße);
            this.Controls.Add(this.lblZielAnsprechpartner);
            this.Controls.Add(this.lblZielFirmaName);
            this.Controls.Add(this.lblZiel);
            this.Controls.Add(this.lblStartHausnummer);
            this.Controls.Add(this.lblStartStraße);
            this.Controls.Add(this.lblStartAnsprechpartner);
            this.Controls.Add(this.lblStartFirmaName);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblAuftragsnummer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAuftragserfassung;
        private System.Windows.Forms.Label lblAuftragsnummer;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblStartFirmaName;
        private System.Windows.Forms.Label lblStartAnsprechpartner;
        private System.Windows.Forms.Label lblStartStraße;
        private System.Windows.Forms.Label lblStartHausnummer;
        private System.Windows.Forms.Label lblZiel;
        private System.Windows.Forms.Label lblZielFirmaName;
        private System.Windows.Forms.Label lblZielAnsprechpartner;
        private System.Windows.Forms.Label lblZielStraße;
        private System.Windows.Forms.Label lblZielHausnummer;
        private System.Windows.Forms.Label lblAllgemeineInformationen;
        private System.Windows.Forms.Label lblAuftragsverguetung;
        private System.Windows.Forms.Label lblTransportgut;
        private System.Windows.Forms.Label lblGrenzen;
        private System.Windows.Forms.TextBox txtAuftragsnummer;
        private System.Windows.Forms.TextBox txtStartFirmaName;
        private System.Windows.Forms.TextBox txtStartAnsprechpartner;
        private System.Windows.Forms.TextBox txtStartStraße;
        private System.Windows.Forms.TextBox txtStartHausnummer;
        private System.Windows.Forms.TextBox txtZielFirmaName;
        private System.Windows.Forms.TextBox txtZielAnsprechpartner;
        private System.Windows.Forms.TextBox txtZielStraße;
        private System.Windows.Forms.TextBox txtZielHausnummer;
        private System.Windows.Forms.TextBox txtAuftragsverguetung;
        private System.Windows.Forms.TextBox txtTransportgut;
        private System.Windows.Forms.TextBox txtGewicht;
        private System.Windows.Forms.Label lblGewicht;
        private System.Windows.Forms.RadioButton radioButtonGrenzenJa;
        private System.Windows.Forms.RadioButton radioButtonGrenzenNein;
        private System.Windows.Forms.Label lblStartStadt;
        private System.Windows.Forms.TextBox txtStartStadt;
        private System.Windows.Forms.TextBox txtZielStadt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblKG;
        private System.Windows.Forms.Label lblAusgabe;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.Button btnShowData;
    }
}

