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
            cbZielort.Text = "";
            lblAktiverModus.Text = "Ab (Abfahrtstafel)";

            //Die Zielorte deaktivieren
            lblZielort.Enabled = false;
            cbZielort.Enabled = false;
            lblPfeil.Enabled = false;

            //Teilen-Funktion deaktivieren, da diese nur im normalen Modus funktionieren soll.
            cbVerbindungen.Enabled = false;
            btnTeilen.Enabled = false;
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
            cbZielort.Enabled = true;
            lblPfeil.Enabled = true;

            //Modus umschalten
            btnStartUndEnde.Enabled = false;
            lblAktiverModus.Text = "Start und Ende";

            //Sicherstellen, dass die Teilen-funktion aktiviert ist.
            cbVerbindungen.Enabled = true;
            btnTeilen.Enabled = true;

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
            try
            {
                var connections = transport.GetConnections(cbAbfahrtsort.Text, cbZielort.Text, dtpDatum.Value.ToString("yyyy-MM-dd"), dtpZeit.Text);
                var StationBoard = transport.GetStationBoard(cbAbfahrtsort.Text, "");

                cbVerbindungen.Items.Clear();
                cbAbfahrtsort.Items.Clear();
                cbZielort.Items.Clear();


                if (btnAb.Enabled) //Modus "Start und Ende" ist aktiv
                {
                    clearDGV();

                    DataTable verbindungen = new DataTable();
                    verbindungen.Columns.Add("Von");
                    verbindungen.Columns.Add("Abfahrt");
                    verbindungen.Columns.Add("Gleis");
                    verbindungen.Columns.Add("Nach");
                    verbindungen.Columns.Add("Ankunft");
                    verbindungen.Columns.Add("Datum");

                    if (cbAbfahrtsort.Text != string.Empty && cbZielort.Text != string.Empty) //Überprüft, ob eingabe vorhanden
                    {

                        foreach (Connection connection in connections.ConnectionList)
                        {
                            string Abfahrtszeit = DateTime.Parse(connection.From.Departure).ToString("HH:mm");
                            string Ankunftszeit = DateTime.Parse(connection.To.Arrival).ToString("HH:mm");
                            string DatumDerVerbindung = DateTime.Parse(dtpDatum.Text).ToString("dd.MM.yyyy");

                            verbindungen.Rows.Add(connection.From.Station.Name, Abfahrtszeit, connection.From.Platform, connection.To.Station.Name, Ankunftszeit, DatumDerVerbindung);

                            cbVerbindungen.Items.Add(Abfahrtszeit + " ab " + connection.From.Station.Name + " (Gleis " + connection.From.Platform + "). Ankunft in " + connection.To.Station.Name + " um " + Ankunftszeit + " am " + DatumDerVerbindung);
                        }
                        dgvAuflisten.DataSource = verbindungen;
                    }
                    else
                    {
                        MessageBox.Show("Bitte Abfahrtsort und Zielort eingeben.");
                    }
                }
                else if (btnStartUndEnde.Enabled) //Modus "Ab" ist aktiv (Abfahrtstafel)
                {
                    clearDGV();

                    DataTable abfahrplan = new DataTable();
                    abfahrplan.Columns.Add("Typ");
                    abfahrplan.Columns.Add("Von");
                    abfahrplan.Columns.Add("Nach");
                    abfahrplan.Columns.Add("Abfahrt");


                    if (cbAbfahrtsort.Text != string.Empty) //Überprüft, ob eingabe vorhanden
                    {
                        transport.GetStationBoard(cbAbfahrtsort.Text, "0");

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

                            abfahrplan.Rows.Add(typ, StationBoard.Station.Name, verbindung.To, Abfahrtszeit);

                        }

                        dgvAuflisten.DataSource = abfahrplan;
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
            catch
            {
                MessageBox.Show("Ein Fehler ist aufgetretten! \nHast du alle nötigen Eingaben ausgefüllt?", "Fehler beim Generieren", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Create_GmapStation(string x, string y) //Link aus den Koordinaten zusammensetzen und auf Google Maps öffnen
        {
            string url = "https://www.google.ch/maps/place/" + x + "," + y;
            System.Diagnostics.Process.Start(url);
        }

        private void btnAufKarteAnzeigen_Click(object sender, EventArgs e)
        {
            cbStationAnzeigen.Items.Clear();

            if (cbStationAnzeigen.Text != string.Empty)
            {
                Stations stations = transport.GetStations(cbStationAnzeigen.Text);
                Station station = stations.StationList[0];
                /*
                Create_GmapStation(Convert.ToString(station.Coordinate.XCoordinate).Replace(',', '.'), Convert.ToString(station.Coordinate.YCoordinate).Replace(',', '.'));
                */

                Map map = new Map(station.Coordinate.XCoordinate, station.Coordinate.YCoordinate);
                map.Show();
            }
            else
            {
                MessageBox.Show("Bitte zuerst eine Verbindung eingeben.");
            }

        }

        private void btnTeilen_Click(object sender, EventArgs e)
        {
            if (cbVerbindungen.SelectedItem != null)
            {
                try //Email öffnen und abfüllen
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
            DialogResult dialogResult = MessageBox.Show("Diese Funktion ist noch in Bearbeitung. Möchtest du inzwischen die nächste Station auf Google Maps suchen?", "Noch in Bearbeitung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.google.ch/maps/dir///@47.0512613,8.3053424,15z/data=!4m2!4m1!3e3");
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void clearDGV()
        {
            dgvAuflisten.DataSource = null;
            dgvAuflisten.Columns.Clear();
            dgvAuflisten.Rows.Clear();
        }

        private void Get_Stations_Abfahrt(string eingabe)
        {
            if (eingabe.Length >= 2)
            {
                cbAbfahrtsort.Items.Clear();
                Stations stations = transport.GetStations(eingabe);
                foreach (Station station in stations.StationList)
                {
                    cbAbfahrtsort.Items.Add(station.Name);
                    cbAbfahrtsort.BringToFront();
                }
            }
        }

        public List<Station> Vorschlaege(string texteingabe) //Vorschläge laden mit GetStations, welche folgend mit "vorschlaege" aufgerufen werden können
        {
            var stationsobjekte = transport.GetStations(query: texteingabe);

            List<Station> stationenvorschlaege = stationsobjekte.StationList;

            return stationenvorschlaege;
        }

        private void Vorschlaege_KeyUp(object sender, KeyEventArgs e) //Intelisense für cbZielort
        {
            EingabeVorschlag intelisense = new EingabeVorschlag();
            if (((ComboBox)sender).Text.Length >= 3)
            {
                if (e.KeyCode != Keys.Escape)
                {
                    if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up && e.KeyCode != Keys.Enter && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right)
                    {
                        intelisense.AutoCompletion((ComboBox)sender);
                    }
                }
                else
                {
                    ((ComboBox)sender).DroppedDown = false;
                }
            }
        }

        public class EingabeVorschlag
        {
            Transport transport = new Transport();
            public void AutoCompletion(ComboBox sender)
            {
                while (sender.Items.Count > 0)
                {
                    sender.Items.RemoveAt(0);
                }

                Cursor.Current = Cursors.WaitCursor;

                List<string> stations = GetSuggestions(sender.Text);

                Cursor.Current = Cursors.WaitCursor;

                foreach (String station in stations)
                {
                    if (station != null)
                    {
                        sender.Items.Add(station);
                    }
                }
                sender.DroppedDown = true;
            }

            public List<string> GetSuggestions(string query)
            {
                List<string> stationsList = new List<string>(); //alle stationen, welche dem string entsprechen
                var stations = transport.GetStations(query);

                foreach (Station station in stations.StationList)
                {
                    stationsList.Add(station.Name); //station wird zur combobox hinzugefügt
                }
                if (stationsList.Count == 0)
                {
                    stationsList.Add("Kein Resultat");
                }
                return stationsList;
            }
        }
    }
}