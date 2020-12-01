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
//using Outlook = Microsoft.Office.Interop.Outlook;
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
            // Button deaktiveren, um doppeltes ausführen zu verhindern. "Start und Ende" aktivieren (um wieder switchen zu können).
            btnStartUndEnde.Enabled = true;
            btnAb.Enabled = false;
            txbZielort.Text = "";
            lblAktiverModus.Text = "Ab (Abfahrtstafel)";

            //Die Zielorte deaktivieren
            lblZielort.Enabled = false;
            txbZielort.Enabled = false;
        }

        private void btnStartUndEnde_Click(object sender, EventArgs e)
        {
            btnAb.Enabled = true;
            lblZielort.Enabled = true;
            txbZielort.Enabled = true;
            btnStartUndEnde.Enabled = false;
            lblAktiverModus.Text = "Start und Ende";
        }

        private void ButtonsStartUp()
        {
            btnStartUndEnde.Enabled = false;
            lblAktiverModus.Text = "Start und Ende";
        }

        private void btnGo_Click(object sender, EventArgs e)
        {

            var connections = transport.GetConnections(txbAbfahrtsort.Text, txbZielort.Text);
            var StationBoard = transport.GetStationBoard(txbAbfahrtsort.Text, "");

            if (btnAb.Enabled) //Modus "Start und Ende" ist aktiv
            {
                if (txbAbfahrtsort.Text != string.Empty && txbZielort.Text != string.Empty) //Überprüft, ob eingabe vorhanden
                {

                    dgvList.Rows.Clear();

                    foreach (Connection connection in connections.ConnectionList)
                    {
                        string Abfahrtszeit = DateTime.Parse(connection.From.Departure).ToString("HH:mm");
                        string Ankunftszeit = DateTime.Parse(connection.To.Arrival).ToString("HH:mm");

                        dgvList.Rows.Add("", connection.From.Station.Name, connection.To.Station.Name, connection.From.Platform, Abfahrtszeit, Ankunftszeit);
                        cbVerbindungen.Items.Add(Abfahrtszeit + " ab " + connection.From.Station.Name + " (Gleis " + connection.From.Platform + "). Ankunft in " + connection.To.Station.Name + " um " + Ankunftszeit);
                    }
                    dgvList.Columns[0].Visible = false; //Spalte "Linie" ausblenden (da leer)
                    dgvList.Columns[3].Visible = true; 
                    dgvList.Columns[5].Visible = true;
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
            
        }

        private void btnTeilen_Click(object sender, EventArgs e)
        {
            if (cbVerbindungen.SelectedItem != null)
            {
                string mailinhalt = cbVerbindungen.Text;

                System.Diagnostics.Process.Start("mailto:" + "?subject=Meine Verbindung" + "&body= Hallo, folgt sende ich dir meine Verbindung: " + cbVerbindungen.Text);

            }
            else
            {
                MessageBox.Show("Bitte Auswahl deiner Verbindung treffen");
            }
            
        }
    }
}
