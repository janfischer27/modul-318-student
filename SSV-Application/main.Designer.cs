﻿
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
            this.lblAktiverModus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnStationFinden = new System.Windows.Forms.Button();
            this.txbZielort = new System.Windows.Forms.TextBox();
            this.txbAbfahrtsort = new System.Windows.Forms.TextBox();
            this.lblZielort = new System.Windows.Forms.Label();
            this.lblAbfahrtsort = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.btnAb = new System.Windows.Forms.Button();
            this.btnStartUndEnde = new System.Windows.Forms.Button();
            this.gbSucheEinschraenken = new System.Windows.Forms.GroupBox();
            this.btnAufKarteAnzeigen = new System.Windows.Forms.Button();
            this.btnTeilen = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.dtpZeit = new System.Windows.Forms.DateTimePicker();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbVerbindungen = new System.Windows.Forms.ComboBox();
            this.lblAb = new System.Windows.Forms.Label();
            this.linie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.von = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abfahrtszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ankunftszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbNeueVerbindung.SuspendLayout();
            this.gbSucheEinschraenken.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.gbNeueVerbindung.Controls.Add(this.lblAktiverModus);
            this.gbNeueVerbindung.Controls.Add(this.label2);
            this.gbNeueVerbindung.Controls.Add(this.btnGo);
            this.gbNeueVerbindung.Controls.Add(this.btnStationFinden);
            this.gbNeueVerbindung.Controls.Add(this.txbZielort);
            this.gbNeueVerbindung.Controls.Add(this.txbAbfahrtsort);
            this.gbNeueVerbindung.Controls.Add(this.lblZielort);
            this.gbNeueVerbindung.Controls.Add(this.lblAbfahrtsort);
            this.gbNeueVerbindung.Controls.Add(this.lblMode);
            this.gbNeueVerbindung.Controls.Add(this.btnAb);
            this.gbNeueVerbindung.Controls.Add(this.btnStartUndEnde);
            resources.ApplyResources(this.gbNeueVerbindung, "gbNeueVerbindung");
            this.gbNeueVerbindung.Name = "gbNeueVerbindung";
            this.gbNeueVerbindung.TabStop = false;
            // 
            // lblAktiverModus
            // 
            resources.ApplyResources(this.lblAktiverModus, "lblAktiverModus");
            this.lblAktiverModus.Name = "lblAktiverModus";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnGo
            // 
            resources.ApplyResources(this.btnGo, "btnGo");
            this.btnGo.Name = "btnGo";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnStationFinden
            // 
            resources.ApplyResources(this.btnStationFinden, "btnStationFinden");
            this.btnStationFinden.Name = "btnStationFinden";
            this.btnStationFinden.UseVisualStyleBackColor = true;
            this.btnStationFinden.Click += new System.EventHandler(this.btnStationFinden_Click);
            // 
            // txbZielort
            // 
            resources.ApplyResources(this.txbZielort, "txbZielort");
            this.txbZielort.Name = "txbZielort";
            // 
            // txbAbfahrtsort
            // 
            resources.ApplyResources(this.txbAbfahrtsort, "txbAbfahrtsort");
            this.txbAbfahrtsort.Name = "txbAbfahrtsort";
            // 
            // lblZielort
            // 
            resources.ApplyResources(this.lblZielort, "lblZielort");
            this.lblZielort.Name = "lblZielort";
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
            // btnAb
            // 
            resources.ApplyResources(this.btnAb, "btnAb");
            this.btnAb.Name = "btnAb";
            this.btnAb.UseVisualStyleBackColor = true;
            this.btnAb.Click += new System.EventHandler(this.btnAb_Click);
            // 
            // btnStartUndEnde
            // 
            resources.ApplyResources(this.btnStartUndEnde, "btnStartUndEnde");
            this.btnStartUndEnde.Name = "btnStartUndEnde";
            this.btnStartUndEnde.UseVisualStyleBackColor = true;
            this.btnStartUndEnde.Click += new System.EventHandler(this.btnStartUndEnde_Click);
            // 
            // gbSucheEinschraenken
            // 
            this.gbSucheEinschraenken.Controls.Add(this.lblAb);
            this.gbSucheEinschraenken.Controls.Add(this.dtpDatum);
            this.gbSucheEinschraenken.Controls.Add(this.dtpZeit);
            resources.ApplyResources(this.gbSucheEinschraenken, "gbSucheEinschraenken");
            this.gbSucheEinschraenken.Name = "gbSucheEinschraenken";
            this.gbSucheEinschraenken.TabStop = false;
            // 
            // btnAufKarteAnzeigen
            // 
            resources.ApplyResources(this.btnAufKarteAnzeigen, "btnAufKarteAnzeigen");
            this.btnAufKarteAnzeigen.Name = "btnAufKarteAnzeigen";
            this.btnAufKarteAnzeigen.UseVisualStyleBackColor = true;
            this.btnAufKarteAnzeigen.Click += new System.EventHandler(this.btnAufKarteAnzeigen_Click);
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
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgvList
            // 
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.linie,
            this.von,
            this.nach,
            this.gleis,
            this.abfahrtszeit,
            this.ankunftszeit,
            this.datum});
            resources.ApplyResources(this.dgvList, "dgvList");
            this.dgvList.Name = "dgvList";
            // 
            // dtpZeit
            // 
            resources.ApplyResources(this.dtpZeit, "dtpZeit");
            this.dtpZeit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpZeit.MinDate = new System.DateTime(2020, 12, 1, 0, 0, 0, 0);
            this.dtpZeit.Name = "dtpZeit";
            this.dtpZeit.Value = new System.DateTime(2020, 12, 1, 15, 11, 0, 0);
            this.dtpZeit.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpDatum
            // 
            resources.ApplyResources(this.dtpDatum, "dtpDatum");
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatum.MinDate = new System.DateTime(2020, 12, 1, 0, 0, 0, 0);
            this.dtpDatum.Name = "dtpDatum";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAufKarteAnzeigen);
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
            // lblAb
            // 
            resources.ApplyResources(this.lblAb, "lblAb");
            this.lblAb.Name = "lblAb";
            this.lblAb.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // linie
            // 
            resources.ApplyResources(this.linie, "linie");
            this.linie.Name = "linie";
            // 
            // von
            // 
            resources.ApplyResources(this.von, "von");
            this.von.Name = "von";
            // 
            // nach
            // 
            resources.ApplyResources(this.nach, "nach");
            this.nach.Name = "nach";
            // 
            // gleis
            // 
            resources.ApplyResources(this.gleis, "gleis");
            this.gleis.Name = "gleis";
            // 
            // abfahrtszeit
            // 
            resources.ApplyResources(this.abfahrtszeit, "abfahrtszeit");
            this.abfahrtszeit.Name = "abfahrtszeit";
            // 
            // ankunftszeit
            // 
            resources.ApplyResources(this.ankunftszeit, "ankunftszeit");
            this.ankunftszeit.Name = "ankunftszeit";
            // 
            // datum
            // 
            resources.ApplyResources(this.datum, "datum");
            this.datum.Name = "datum";
            // 
            // main
            // 
            this.AcceptButton = this.btnGo;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbSucheEinschraenken);
            this.Controls.Add(this.gbNeueVerbindung);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "main";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbNeueVerbindung.ResumeLayout(false);
            this.gbNeueVerbindung.PerformLayout();
            this.gbSucheEinschraenken.ResumeLayout(false);
            this.gbSucheEinschraenken.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbNeueVerbindung;
        private System.Windows.Forms.GroupBox gbSucheEinschraenken;
        private System.Windows.Forms.Button btnAufKarteAnzeigen;
        private System.Windows.Forms.Button btnTeilen;
        private System.Windows.Forms.Button btnAb;
        private System.Windows.Forms.Button btnStartUndEnde;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnStationFinden;
        private System.Windows.Forms.TextBox txbZielort;
        private System.Windows.Forms.TextBox txbAbfahrtsort;
        private System.Windows.Forms.Label lblZielort;
        private System.Windows.Forms.Label lblAbfahrtsort;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblAktiverModus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DateTimePicker dtpZeit;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbVerbindungen;
        private System.Windows.Forms.Label lblAb;
        private System.Windows.Forms.DataGridViewTextBoxColumn linie;
        private System.Windows.Forms.DataGridViewTextBoxColumn von;
        private System.Windows.Forms.DataGridViewTextBoxColumn nach;
        private System.Windows.Forms.DataGridViewTextBoxColumn gleis;
        private System.Windows.Forms.DataGridViewTextBoxColumn abfahrtszeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ankunftszeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum;
    }
}

