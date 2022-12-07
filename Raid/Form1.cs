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
        bool Megjelenit = false;
        string json;
        string psAzon;
        string fileTorles;
        long mEret;
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
            this.Text = this.Text + ": " + GepNev+ "\n";
        }

        private void DataLoading()
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (rbDell.Checked) {_Dell(); }
            if (rbHp.Checked) {_HP(); }
            if (chDiskpart.Checked) {_Diskpart(); }
        }

        private void _Dell()
        {

        }
        private void _HP()
        {

        }
        private void _Diskpart()
        {

        }

        
    }
}
