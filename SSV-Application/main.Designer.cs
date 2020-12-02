
namespace SSV_Application
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbNeueVerbindung = new System.Windows.Forms.GroupBox();
            this.lblPfeil = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStartUndEnde = new System.Windows.Forms.Button();
            this.btnAb = new System.Windows.Forms.Button();
            this.cbZielort = new System.Windows.Forms.ComboBox();
            this.cbAbfahrtsort = new System.Windows.Forms.ComboBox();
            this.lblAktiverModus = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblZielort = new System.Windows.Forms.Label();
            this.gbSucheEinschraenken = new System.Windows.Forms.GroupBox();
            this.dtpZeit = new System.Windows.Forms.DateTimePicker();
            this.lblAb = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.lblAbfahrtsort = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.btnStationFinden = new System.Windows.Forms.Button();
            this.btnAnzeigen = new System.Windows.Forms.Button();
            this.btnTeilen = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbVerbindungen = new System.Windows.Forms.ComboBox();
            this.dgvAuflisten = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbStationAnzeigen = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbNeueVerbindung.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbSucheEinschraenken.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuflisten)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // gbNeueVerbindung
            // 
            this.gbNeueVerbindung.Controls.Add(this.lblPfeil);
            this.gbNeueVerbindung.Controls.Add(this.groupBox1);
            this.gbNeueVerbindung.Controls.Add(this.cbZielort);
            this.gbNeueVerbindung.Controls.Add(this.cbAbfahrtsort);
            this.gbNeueVerbindung.Controls.Add(this.lblAktiverModus);
            this.gbNeueVerbindung.Controls.Add(this.btnGo);
            this.gbNeueVerbindung.Controls.Add(this.lblZielort);
            this.gbNeueVerbindung.Controls.Add(this.gbSucheEinschraenken);
            this.gbNeueVerbindung.Controls.Add(this.lblAbfahrtsort);
            this.gbNeueVerbindung.Controls.Add(this.lblMode);
            resources.ApplyResources(this.gbNeueVerbindung, "gbNeueVerbindung");
            this.gbNeueVerbindung.Name = "gbNeueVerbindung";
            this.gbNeueVerbindung.TabStop = false;
            // 
            // lblPfeil
            // 
            resources.ApplyResources(this.lblPfeil, "lblPfeil");
            this.lblPfeil.Name = "lblPfeil";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStartUndEnde);
            this.groupBox1.Controls.Add(this.btnAb);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnStartUndEnde
            // 
            resources.ApplyResources(this.btnStartUndEnde, "btnStartUndEnde");
            this.btnStartUndEnde.Name = "btnStartUndEnde";
            this.btnStartUndEnde.UseVisualStyleBackColor = true;
            this.btnStartUndEnde.Click += new System.EventHandler(this.btnStartUndEnde_Click);
            // 
            // btnAb
            // 
            resources.ApplyResources(this.btnAb, "btnAb");
            this.btnAb.Name = "btnAb";
            this.btnAb.UseVisualStyleBackColor = true;
            this.btnAb.Click += new System.EventHandler(this.btnAb_Click);
            // 
            // cbZielort
            // 
            this.cbZielort.FormattingEnabled = true;
            resources.ApplyResources(this.cbZielort, "cbZielort");
            this.cbZielort.Name = "cbZielort";
            this.cbZielort.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Vorschlaege_KeyUp);
            // 
            // cbAbfahrtsort
            // 
            this.cbAbfahrtsort.FormattingEnabled = true;
            resources.ApplyResources(this.cbAbfahrtsort, "cbAbfahrtsort");
            this.cbAbfahrtsort.Name = "cbAbfahrtsort";
            this.cbAbfahrtsort.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Vorschlaege_KeyUp);
            // 
            // lblAktiverModus
            // 
            resources.ApplyResources(this.lblAktiverModus, "lblAktiverModus");
            this.lblAktiverModus.Name = "lblAktiverModus";
            // 
            // btnGo
            // 
            resources.ApplyResources(this.btnGo, "btnGo");
            this.btnGo.Name = "btnGo";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblZielort
            // 
            resources.ApplyResources(this.lblZielort, "lblZielort");
            this.lblZielort.Name = "lblZielort";
            // 
            // gbSucheEinschraenken
            // 
            this.gbSucheEinschraenken.Controls.Add(this.dtpZeit);
            this.gbSucheEinschraenken.Controls.Add(this.lblAb);
            this.gbSucheEinschraenken.Controls.Add(this.dtpDatum);
            resources.ApplyResources(this.gbSucheEinschraenken, "gbSucheEinschraenken");
            this.gbSucheEinschraenken.Name = "gbSucheEinschraenken";
            this.gbSucheEinschraenken.TabStop = false;
            // 
            // dtpZeit
            // 
            resources.ApplyResources(this.dtpZeit, "dtpZeit");
            this.dtpZeit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpZeit.Name = "dtpZeit";
            this.dtpZeit.ShowUpDown = true;
            // 
            // lblAb
            // 
            resources.ApplyResources(this.lblAb, "lblAb");
            this.lblAb.Name = "lblAb";
            // 
            // dtpDatum
            // 
            resources.ApplyResources(this.dtpDatum, "dtpDatum");
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatum.MinDate = new System.DateTime(2020, 12, 1, 0, 0, 0, 0);
            this.dtpDatum.Name = "dtpDatum";
            // 
            // lblAbfahrtsort
            // 
            resources.ApplyResources(this.lblAbfahrtsort, "lblAbfahrtsort");
            this.lblAbfahrtsort.Name = "lblAbfahrtsort";
            // 
            // lblMode
            // 
            resources.ApplyResources(this.lblMode, "lblMode");
            this.lblMode.Name = "lblMode";
            // 
            // btnStationFinden
            // 
            resources.ApplyResources(this.btnStationFinden, "btnStationFinden");
            this.btnStationFinden.Name = "btnStationFinden";
            this.btnStationFinden.UseVisualStyleBackColor = true;
            this.btnStationFinden.Click += new System.EventHandler(this.btnStationFinden_Click);
            // 
            // btnAnzeigen
            // 
            resources.ApplyResources(this.btnAnzeigen, "btnAnzeigen");
            this.btnAnzeigen.Name = "btnAnzeigen";
            this.btnAnzeigen.UseVisualStyleBackColor = true;
            this.btnAnzeigen.Click += new System.EventHandler(this.btnAufKarteAnzeigen_Click);
            // 
            // btnTeilen
            // 
            resources.ApplyResources(this.btnTeilen, "btnTeilen");
            this.btnTeilen.Name = "btnTeilen";
            this.btnTeilen.UseVisualStyleBackColor = true;
            this.btnTeilen.Click += new System.EventHandler(this.btnTeilen_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbVerbindungen);
            this.groupBox2.Controls.Add(this.btnTeilen);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // cbVerbindungen
            // 
            this.cbVerbindungen.FormattingEnabled = true;
            resources.ApplyResources(this.cbVerbindungen, "cbVerbindungen");
            this.cbVerbindungen.Name = "cbVerbindungen";
            // 
            // dgvAuflisten
            // 
            this.dgvAuflisten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuflisten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvAuflisten, "dgvAuflisten");
            this.dgvAuflisten.Name = "dgvAuflisten";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cbStationAnzeigen);
            this.groupBox3.Controls.Add(this.btnAnzeigen);
            this.groupBox3.Controls.Add(this.btnStationFinden);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cbStationAnzeigen
            // 
            this.cbStationAnzeigen.FormattingEnabled = true;
            resources.ApplyResources(this.cbStationAnzeigen, "cbStationAnzeigen");
            this.cbStationAnzeigen.Name = "cbStationAnzeigen";
            this.cbStationAnzeigen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Vorschlaege_KeyUp);
            // 
            // main
            // 
            this.AcceptButton = this.btnGo;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvAuflisten);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbNeueVerbindung);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "main";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbNeueVerbindung.ResumeLayout(false);
            this.gbNeueVerbindung.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbSucheEinschraenken.ResumeLayout(false);
            this.gbSucheEinschraenken.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuflisten)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbNeueVerbindung;
        private System.Windows.Forms.GroupBox gbSucheEinschraenken;
        private System.Windows.Forms.Button btnAnzeigen;
        private System.Windows.Forms.Button btnTeilen;
        private System.Windows.Forms.Button btnAb;
        private System.Windows.Forms.Button btnStartUndEnde;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnStationFinden;
        private System.Windows.Forms.Label lblZielort;
        private System.Windows.Forms.Label lblAbfahrtsort;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblAktiverModus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbVerbindungen;
        private System.Windows.Forms.Label lblAb;
        private System.Windows.Forms.DateTimePicker dtpZeit;
        private System.Windows.Forms.DataGridView dgvAuflisten;
        private System.Windows.Forms.ComboBox cbZielort;
        private System.Windows.Forms.ComboBox cbAbfahrtsort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbStationAnzeigen;
        private System.Windows.Forms.Label lblPfeil;
    }
}

