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
        string mBody = string.Empty; //Üzenet törzs
        string mSubject = string.Empty;
        string GepNev;
        bool RaidError = false;
        string json;
        string DasAuto;
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
            public string DasAuto { get; set; } //Gépnév

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
            string Gyarto = null;
            string PhyMem = null;
            string AvaMem = null;
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
                        if (kicsi.Contains("system manufacturer") == true) // || kicsi.Contains("total physical memory") == true || kicsi.Contains("available physical memory") == true)
                        {
                           gyarto= true;
                           this.Text = this.Text + ": " + GepNev + " || " + myIP + " || " + TesztLST.Items[i].ToString() + "\n";
                           mSubject = "Cég: "+ txtClient.Text + " || Dátum: " + DateTime.Now + " ||  Gépnév: " + GepNev + " || Gyártó: " + TesztLST.Items[i].ToString() + " || IP: " +myIP ;
                           Gyarto = TesztLST.Items[i].ToString();

                        }
                        if (kicsi.Contains("total physical memory") == true)
                        {
                           PhyMem = TesztLST.Items[i].ToString();
                        }
                        if (kicsi.Contains("available physical memory") == true)
                        {
                           AvaMem = TesztLST.Items[i].ToString();
                        }
                }
                    if (gyarto == false) 
                    {
                       this.Text = this.Text + ": " + GepNev + " || " + myIP + "\n";
                       mSubject = "Cég: " + txtClient.Text + "Dátum:" + DateTime.Now + " || Gépnév: " + GepNev + " || IP: " + myIP;
                    Gyarto = "Nem azonosítható...";
                    }
                }
                else
                {
                    this.Text = this.Text + ": " + GepNev + " || " + myIP + "\n";
                    mSubject = "Dátum:" + DateTime.Now + " || Gépnév: " + GepNev + " || IP: " + myIP;
                }
            mBody += "<font color = #97492A; size = 4px;> <ins> <strong> Alap információk : " + "</strong> </ins> </font> <br> </br>";
            mBody += "";
            mBody += "<font color = #97492A; size = 2px;> <ins> <strong> Gép név: " + GepNev + "</strong> </ins> </font> <br> </br>";
            mBody += "<font color = #97492A; size = 2px;> <ins> <strong> Gyártó: " + Gyarto + "</strong> </ins> </font> <br> </br>";
            mBody += "<font color = #97492A; size = 2px;> <ins> <strong> Fizikai memória: " + PhyMem + "</strong> </ins> </font> <br> </br>";
            mBody += "<font color = #97492A; size = 2px;> <ins> <strong> Elérhető memória: " + AvaMem + "</strong> </ins> </font> <br> </br>";
            mBody += "<font color = #97492A; size = 2px;> <ins> <strong> IP: " + myIP + "</strong> </ins> </font> <br> </br>";
            mBody += "";
            if (DasAuto == "0")
            {
                if (rbDell.Checked) { _Dell(); }
                if (rbHp.Checked) { _HP(); }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbDell.Checked) {_Dell(); }
            if (rbHp.Checked) {_HP(); }
        }

        private void _Dell()
        {
            mBody += "<font color = #97492A; size = 4px;> <ins> <strong> Raid állapot információk : "  + "</strong> </ins> </font> <br> </br>";
            mBody += "";
            logFile = @filesPath + "\\dell.txt";
            if (File.Exists(logFile))
            {
                mBody += "<font color = #97492A; size = 3px;> <ins> <strong> " + "Dell Raid" + "</strong> </ins> </font> <br> </br>";
                mBody += "";
                lstLog.DataSource = File.ReadAllLines(logFile);
                for (int i = 0; i < lstLog.Items.Count; ++i)
                {
                    kicsi = lstLog.Items[i].ToString();
                    kicsi = kicsi.ToLower();
                    if (kicsi.Contains("frgn") == true || kicsi.Contains("dgrd") == true || kicsi.Contains("ugood") == true || kicsi.Contains("rbld") == true || kicsi.Contains("ubad") == true || kicsi.Contains("msng") == true)
                    {
                        if (kicsi.Contains("did") == true || kicsi.Contains("pdc") == true || kicsi.Contains("cac") == true || kicsi.Contains("dhs") == true || kicsi.Contains("fspace") || kicsi.Contains("interface"))
                        {
                        }
                        else
                        {
                            RaidError = true;
                            mBody += "<font color = #97492A; size = 2px;> <ins> <strong> " + kicsi  + "</strong> </ins> </font> <br> </br>";
                        }
                    }
                }/*
                if (RaidError == true)
                { 
                }*/
                mBody += "";
            }
            if (chDiskpart.Checked) { _Diskpart(); }  else { MailSender(); }
        }
        private void _HP()
        {
            mBody += "<font color = #97492A; size = 4px;> <ins> <strong>Raid állapot információk : " + "</strong> </ins> </font> <br> </br>";
            mBody += "";
            logFile = @filesPath + "\\hp.txt";
            if (File.Exists(logFile))
            {
                mBody += "<font color = #97492A; size = 3px;> <ins> <strong> " + "HP Raid" + "</strong> </ins> </font> <br> </br>";
                mBody += "";
                lstLog.DataSource = File.ReadAllLines(logFile);
                //*
                for (int i = 0; i < lstLog.Items.Count; ++i)
                {
                    kicsi = lstLog.Items[i].ToString();
                    kicsi = kicsi.ToLower();
                    if (kicsi.Contains("failed") == true)
                    {
                        RaidError = true;
                        mBody += "<font color = #97492A; size = 2px;> <ins> <strong> " + kicsi + "</strong> </ins> </font> <br> </br>";
                    }
                }/*
                if (RaidError == true)
                {
                }*/
                mBody += "";
            }
            if (chDiskpart.Checked) { _Diskpart(); } else { MailSender(); }
        }
        private void _Diskpart()
        {
            mBody += "<font color = #97492A; size = 3px;> <ins> <strong> " + "Diskpart Raid" + "</strong> </ins> </font> <br> </br>";
            mBody += "";
            logFile = @filesPath + "\\diskpart.txt";
            if (File.Exists(logFile))
            {
                lstLog.DataSource = File.ReadAllLines(logFile);
                for (int i = 0; i < lstLog.Items.Count; ++i)
                {
                    kicsi = lstLog.Items[i].ToString();
                    kicsi = kicsi.ToLower();
                    if (kicsi.Contains("foreign") == true || kicsi.Contains("missing") == true )
                    {
                        RaidError = true;
                        mBody += "<font color = #97492A; size = 2px;> <ins> <strong> " + kicsi + "</strong> </ins> </font> <br> </br>";
                    }
                }
                MailSender();
            }
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
            DasAuto = Settingsed.DasAuto;
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
            Adatok.DasAuto = DasAuto;
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
          //  if (RaidError == true)
          //  {
                //****
                Settings Settingsed = null;
                using (StreamReader r = new StreamReader(settingsFile))
                {
                    json = r.ReadToEnd();
                    Settingsed = JsonConvert.DeserializeObject<Settings>(json);
                }
                try
                {
                    SmtpClient mySmtpClient = new SmtpClient(Settingsed.MailServer);
                    mySmtpClient.Port = Int32.Parse(Settingsed.MPort);
                    // set smtp-client with basicAuthentication
                    mySmtpClient.UseDefaultCredentials = false;
                    System.Net.NetworkCredential basicAuthenticationInfo = new
                    System.Net.NetworkCredential(Settingsed.MUID, Settingsed.MPDW);
                    mySmtpClient.Credentials = basicAuthenticationInfo;

                    // add from,to mailaddresses
                    MailAddress from = new MailAddress(Settingsed.MFrom, "Jelentes");
                    //MailAddress to = new MailAddress("gyongyosi.peter@digitalgroup.hu", "Jelentes");
                    MailMessage myMail = new System.Net.Mail.MailMessage(Settingsed.MFrom, Settingsed.MTo);

                    // add ReplyTo


                    MailAddress replyTo = new MailAddress(Settingsed.MFrom);
                    myMail.ReplyToList.Add(replyTo);
                    // set subject and encoding
                    myMail.Subject = mSubject;
                    myMail.SubjectEncoding = System.Text.Encoding.UTF8;
                    // set body-message and encoding
                    myMail.Body = mBody;
                    myMail.BodyEncoding = System.Text.Encoding.UTF8;
                    // text or html
                    myMail.IsBodyHtml = true;
                    mySmtpClient.Send(myMail);
                }
                catch
                {

                }
                //****
          //  }
            Application.Exit();
        }
    }
}
