using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAb_Click(object sender, EventArgs e)
        {
            // Button deaktiveren, um doppeltes ausführen zu verhindern. "Start und Ende" aktivieren (um wieder swtichen zu können).
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
            string Output = "";

            var connections = transport.GetConnections(txbAbfahrtsort.Text, txbZielort.Text);

            if (btnAb.Enabled) //Modus "Start und Ende" ist aktiv
            {
                if (txbAbfahrtsort.Text != "" && txbZielort.Text != "") //Überprüft, ob eingabe vorhanden
                {

                    lbAuflisten.Items.Clear();

                    foreach (Connection connection in connections.ConnectionList)
                    {
                        string Abfahrtszeit = DateTime.Parse(connection.From.Departure).ToString("HH:mm");
                        string Ankunftszeit = DateTime.Parse(connection.To.Arrival).ToString("HH:mm");
                        if(connection.From.Platform == "") //Hier weitermachen
                        {
                            Output = "Von " + connection.From.Station.Name + " nach " + connection.To.Station.Name + "\t\t" + "Abfahrt Gleis " + connection.From.Platform + " um " + Abfahrtszeit + "\t" + "Ankunft um " + Ankunftszeit + " auf Gleis " + connection.To.Platform;
                        }
                        else if
                        {

                        }
                        

                        lbAuflisten.Items.Add(Output);
                    }
                }
                else
                {
                    MessageBox.Show("Bitte Abfahrtsort und Zielort eingeben.");
                }
            }
            else if(btnStartUndEnde.Enabled) //Modus "Ab" ist aktiv (Abfahrtstafel)
            {
                if (txbAbfahrtsort.Text != "") //Überprüft, ob eingabe vorhanden
                {
                    transport.GetStationBoard(txbAbfahrtsort.Text, "0");

                    lbAuflisten.Items.Clear();

                    /*
                    foreach (StationBoardRoot station in stationBoard)
                    {
                        string Output = "";
                        lbAuflisten.Items.Add(Output);
                    }
                    */
                    
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
    }
}
