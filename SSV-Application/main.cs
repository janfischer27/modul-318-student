using SwissTransport;
using System;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace SSV_Application
{
    public partial class main : Form
    {
        Transport transport = new Transport();

        public main()
        {
            InitializeComponent();
            ButtonsStartUp();

        }



        private void btnAb_Click(object sender, EventArgs e)
        {
            // Button deaktiveren, um doppeltes ausführen zu verhindern. Modus umschalten.
            btnStartUndEnde.Enabled = true;
            btnAb.Enabled = false;
            txbZielort.Text = "";
            lblAktiverModus.Text = "Ab (Abfahrtstafel)";

            //Die Zielorte deaktivieren
            lblZielort.Enabled = false;
            txbZielort.Enabled = false;

            //Teilen-Funktion deaktivieren, da diese nur im normalen Modus funktionieren soll.
            cbVerbindungen.Enabled = false; 
            btnTeilen.Enabled = false;
            btnAufKarteAnzeigen.Enabled = false;
            cbVerbindungen.Text = "";

            //Eingabe von Datum und Uhrzeit bei der Abfahrtstabelle verhindern
            dtpDatum.Enabled = false;
            dtpZeit.Enabled = false;
            lblAb.Enabled = false;


        }

        private void btnStartUndEnde_Click(object sender, EventArgs e)
        {
            //Felder für die Standard-Verbindungssuche aktivieren
            btnAb.Enabled = true;
            lblZielort.Enabled = true;
            txbZielort.Enabled = true;

            //Modus umschalten
            btnStartUndEnde.Enabled = false;
            lblAktiverModus.Text = "Start und Ende";

            //Sicherstellen, dass die Teilen-funktion aktiviert ist.
            cbVerbindungen.Enabled = true; 
            btnTeilen.Enabled = true;
            btnAufKarteAnzeigen.Enabled = true;

            //Eingabe von Datum und Uhrzeit ermöglichen
            dtpDatum.Enabled = true;
            dtpZeit.Enabled = true;
            lblAb.Enabled = true;
        }

        private void ButtonsStartUp()
        {
            btnStartUndEnde.Enabled = false;
            lblAktiverModus.Text = "Start und Ende";
        }

        private void btnGo_Click(object sender, EventArgs e)
        {

            var connections = transport.GetConnections(txbAbfahrtsort.Text, txbZielort.Text, dtpDatum.Value, dtpZeit.Value);
            var StationBoard = transport.GetStationBoard(txbAbfahrtsort.Text, "");

            cbVerbindungen.Items.Clear();

            if (btnAb.Enabled) //Modus "Start und Ende" ist aktiv
            {
                
                if (txbAbfahrtsort.Text != string.Empty && txbZielort.Text != string.Empty) //Überprüft, ob eingabe vorhanden
                {

                    dgvList.Rows.Clear();

                    foreach (Connection connection in connections.ConnectionList)
                    {
                        string Abfahrtszeit = DateTime.Parse(connection.From.Departure).ToString("HH:mm");
                        string Ankunftszeit = DateTime.Parse(connection.To.Arrival).ToString("HH:mm");
                        string DatumDerVerbindung = DateTime.Parse(dtpDatum.Text).ToString("dd.MM.yyyy");
                        
                        dgvList.Rows.Add("", connection.From.Station.Name, connection.To.Station.Name, connection.From.Platform, Abfahrtszeit, Ankunftszeit, DatumDerVerbindung);
                        cbVerbindungen.Items.Add(Abfahrtszeit + " ab " + connection.From.Station.Name + " (Gleis " + connection.From.Platform + "). Ankunft in " + connection.To.Station.Name + " um " + Ankunftszeit + " am " + DatumDerVerbindung);
                    }
                    dgvList.Columns[0].Visible = false; //Spalte "Linie" ausblenden (da leer)
                    dgvList.Columns[3].Visible = true;  //Sicherstellen, dass die anderen Spalten aktiv sind
                    dgvList.Columns[5].Visible = true;
                    dgvList.Columns[6].Visible = true;
                }
                else
                {
                    MessageBox.Show("Bitte Abfahrtsort und Zielort eingeben.");
                }
            }
            else if(btnStartUndEnde.Enabled) //Modus "Ab" ist aktiv (Abfahrtstafel)
            {
                
                if (txbAbfahrtsort.Text != string.Empty) //Überprüft, ob eingabe vorhanden
                {
                    transport.GetStationBoard(txbAbfahrtsort.Text, "0");

                    dgvList.Rows.Clear();

                    foreach (StationBoard verbindung in StationBoard.Entries)
                    {
                        string typ = verbindung.Name.Substring(0, 2); //Nur der Typ des Zuges ausgeben (z.B. RE oder S1)
                        string stunde = "";
                        string minute = "";
                        if (verbindung.Stop.Departure.Hour < 10) //Falls einstellig wird vorne eine 0 hinzugefügt
                        {
                            stunde = "0" + Convert.ToString(verbindung.Stop.Departure.Hour);
                        }
                        else
                        {
                            stunde = Convert.ToString(verbindung.Stop.Departure.Hour);
                        }

                        if (verbindung.Stop.Departure.Minute < 10) //Uhrzeit formatieren
                        {
                            minute = "0" + Convert.ToString(verbindung.Stop.Departure.Minute);
                        }
                        else
                        {
                            minute = Convert.ToString(verbindung.Stop.Departure.Minute);
                        }

                        string Abfahrtszeit = stunde + ":" + minute;

                        dgvList.Rows.Add(typ, StationBoard.Station.Name, verbindung.To, "", Abfahrtszeit, "");

                    }

                    dgvList.Columns[0].Visible = true; //Spalte "Linie" einblenden (da der Typ vorhanden ist)
                    dgvList.Columns[3].Visible = false; //Spalte Gleis und Ankunftszeit ausblenden, da dies bei der Abfahrtstafel nicht verwendet wird
                    dgvList.Columns[5].Visible = false;
                    dgvList.Columns[6].Visible = false;

                }
                else
                {
                    MessageBox.Show("Bitte Namen der Station eingeben.");
                }
            }
            else
            {
                MessageBox.Show("Ein Fehler beim generieren der Abfahrten ist aufgetretten.\n ID 500");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAufKarteAnzeigen_Click(object sender, EventArgs e)
        {
            if (cbVerbindungen.SelectedItem != null)
            {
                DialogResult dialogResult = MessageBox.Show("Diese Funktion ist noch in Bearbeitung. Möchtest du inzwischen die Verbindung auf Google Maps suchen?", "Noch in Bearbeitung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://www.google.ch/maps/dir///@47.0512613,8.3053424,15z/data=!4m2!4m1!3e3");
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Bitte zuerst Auswahl deiner Verbindung treffen");
            }

        }

        private void btnTeilen_Click(object sender, EventArgs e)
        {
            if (cbVerbindungen.SelectedItem != null)
            {
                //Email öffnen und mit Auswahl abfüllen
                try
                {
                    System.Diagnostics.Process.Start("mailto:" + "?subject=Meine Verbindung" + "&body= Hallo, folgt sende ich dir meine Verbindung: " + cbVerbindungen.Text);
                }
                catch
                {
                    MessageBox.Show("Ein Fehler beim generieren der Email ist aufgetretten. Hast du eine passende MailingApp installiert?", "Fehler beim Generieren", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bitte zuerst Auswahl deiner Verbindung treffen");
            }
            
        }

        private void btnStationFinden_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
