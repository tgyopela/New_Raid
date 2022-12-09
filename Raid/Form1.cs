using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using Newtonsoft.Json;
//using static System.Net.WebRequestMethods;

namespace Raid
{
    public partial class Form1 : Form
    {
        string filesPath;
        string settingsFile;
        string logFile;
        string kicsi;
        string mBody = string.Empty;
        string mSubject = string.Empty;
        string GepNev;
        //bool Megjelenit = false;
        string json;
        //string psAzon;
        //string fileTorles;
        //long mEret;
        string myIP;
        public class Settings
        {//Beállítások
            public string MailServer { get; set; } 
            public string MUID { get; set; } //Küldő
            public string MPDW { get; set; } //Password
            public string MPort { get; set; } //Port
            public string MFrom { get; set; } //Kitől
            public string MTo { get; set; } //Kinek
            public string Ceg { get; set; } //Cég
            public string Raid { get; set; } //Raid típus
            public string DiskParty { get; set; } //Diskpart
            public string Torles { get; set; } //Log fájl törlés
            public string IP { get; set; } //IP
            public string GepNev { get; set; } //Gépnév

        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            filesPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            settingsFile = filesPath + "\\Settings.json";
            GepNev = System.Windows.Forms.SystemInformation.ComputerName;
            myIP = Dns.GetHostByName(GepNev).AddressList[0].ToString();
            if (File.Exists(settingsFile))
            {
                _SettLoad();
            }
            else
            {
               
            }
            logFile = logFile = @filesPath + "\\systeminfo.txt";
            bool gyarto = false;
                if (File.Exists(logFile))
                {
                   ListBox TesztLST = new ListBox();
                   this.Controls.Add(TesztLST);
                   TesztLST.Visible = false;
                   TesztLST.DataSource= File.ReadAllLines(logFile);
                    for (int i = 0; i < TesztLST.Items.Count; ++i)
                    {
                        kicsi = TesztLST.Items[i].ToString();
                        kicsi = kicsi.ToLower();
                        if (kicsi.Contains("system manufacturer") == true)
                        {
                           gyarto= true;
                            this.Text = this.Text + ": " + GepNev + " || " + myIP + " || " + TesztLST.Items[i].ToString() + "\n";
                        }
                    }
                    if (gyarto == false) 
                    {
                       this.Text = this.Text + ": " + GepNev + " || " + myIP + "\n";
                    }
                }
                else
                {
                    this.Text = this.Text + ": " + GepNev + " || " + myIP + "\n";
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbDell.Checked) {_Dell(); }
            if (rbHp.Checked) {_HP(); }
            if (chDiskpart.Checked) {_Diskpart(); }
        }

        private void _Dell()
        {
            logFile = @filesPath + "\\dell.txt";
            if (File.Exists(logFile)) { lstLog.DataSource = File.ReadAllLines(logFile); }
            
        }
        private void _HP()
        {
            logFile = @filesPath + "\\hp.txt";
            if (File.Exists(logFile)) { lstLog.DataSource = File.ReadAllLines(logFile); }
            
        }
        private void _Diskpart()
        {

        }

        private void _SettLoad()
        {
            Settings Settingsed = null;
            using (StreamReader r = new StreamReader(settingsFile))
            {
                json = r.ReadToEnd();
                Settingsed = JsonConvert.DeserializeObject<Settings>(json);
            }
            txtMailServer.Text = Settingsed.MailServer;
            txtPort.Text = Settingsed.MPort;
            txtSender.Text = Settingsed.MUID;
            txtPDW.Text = Settingsed.MPDW;
            txtTo.Text = Settingsed.MTo;
            txtClient.Text = Settingsed.Ceg;
            if (Settingsed.Torles == "igen") { chLgDel.Checked = true; }
            if (Settingsed.Raid == "Dell") { rbDell.Checked = true; }
            if (Settingsed.Raid == "Hp") { rbHp.Checked = true; }
            if (Settingsed.DiskParty == "igen") { chDiskpart.Checked = true; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lstLog.DataSource = null;
            _SettLoad();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lstLog.DataSource = null;
            Settings Adatok = new Settings();
            Adatok.MailServer = txtMailServer.Text;
            Adatok.MUID = txtSender.Text;
            Adatok.MPDW = txtPDW.Text;
            Adatok.MPort = txtPort.Text;
            Adatok.MFrom = txtSender.Text;
            Adatok.MTo = txtTo.Text;
            Adatok.Ceg = txtClient.Text;
            if (rbDell.Checked== true) { Adatok.Raid = "Dell"; }
            if (rbHp.Checked == true) { Adatok.Raid = "Hp";  }
            if (chDiskpart.Checked == true) { Adatok.DiskParty = "igen"; }
            if (chLgDel.Checked== true) { Adatok.Torles = "igen"; }
            Adatok.IP = myIP;
            Adatok.GepNev = GepNev;
            json = JsonConvert.SerializeObject(Adatok);
            using (StreamWriter r = new StreamWriter(settingsFile))
            {
                r.Write(json);
            }
            json = null;
            Adatok = null;
        }

        private void txtPDW_MouseHover(object sender, EventArgs e)
        {
            txtPDW.PasswordChar = '\0';
        }

        private void groupBox2_MouseHover(object sender, EventArgs e)
        {
            txtPDW.PasswordChar = '*';
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            txtPDW.PasswordChar = '*';
        }
        private void MailSender()
        {

        }
    }
}
