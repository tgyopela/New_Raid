namespace Raid
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbHp = new System.Windows.Forms.RadioButton();
            this.rbDell = new System.Windows.Forms.RadioButton();
            this.chDiskpart = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtPDW = new System.Windows.Forms.TextBox();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtMailServer = new System.Windows.Forms.TextBox();
            this.chLgDel = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1261, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 83);
            this.button1.TabIndex = 1;
            this.button1.Text = "Betölt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbHp);
            this.groupBox1.Controls.Add(this.rbDell);
            this.groupBox1.Controls.Add(this.chDiskpart);
            this.groupBox1.Location = new System.Drawing.Point(34, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 106);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Raid Típus ";
            // 
            // rbHp
            // 
            this.rbHp.AutoSize = true;
            this.rbHp.Location = new System.Drawing.Point(7, 49);
            this.rbHp.Name = "rbHp";
            this.rbHp.Size = new System.Drawing.Size(46, 20);
            this.rbHp.TabIndex = 4;
            this.rbHp.TabStop = true;
            this.rbHp.Text = "Hp";
            this.rbHp.UseVisualStyleBackColor = true;
            // 
            // rbDell
            // 
            this.rbDell.AutoSize = true;
            this.rbDell.Location = new System.Drawing.Point(7, 22);
            this.rbDell.Name = "rbDell";
            this.rbDell.Size = new System.Drawing.Size(52, 20);
            this.rbDell.TabIndex = 3;
            this.rbDell.TabStop = true;
            this.rbDell.Text = "Dell";
            this.rbDell.UseVisualStyleBackColor = true;
            // 
            // chDiskpart
            // 
            this.chDiskpart.AutoSize = true;
            this.chDiskpart.Location = new System.Drawing.Point(7, 76);
            this.chDiskpart.Name = "chDiskpart";
            this.chDiskpart.Size = new System.Drawing.Size(151, 20);
            this.chDiskpart.TabIndex = 2;
            this.chDiskpart.Text = " Windows (Diskpart) ";
            this.chDiskpart.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 346);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(948, 100);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(86, 668);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(948, 100);
            this.listBox2.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.txtClient);
            this.groupBox2.Controls.Add(this.txtTo);
            this.groupBox2.Controls.Add(this.txtPDW);
            this.groupBox2.Controls.Add(this.txtSender);
            this.groupBox2.Controls.Add(this.txtPort);
            this.groupBox2.Controls.Add(this.txtMailServer);
            this.groupBox2.Controls.Add(this.chLgDel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(251, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 261);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Küldési beállítások ";
            this.groupBox2.MouseHover += new System.EventHandler(this.groupBox2_MouseHover);
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(98, 220);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(258, 22);
            this.txtClient.TabIndex = 12;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(98, 180);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(258, 22);
            this.txtTo.TabIndex = 11;
            // 
            // txtPDW
            // 
            this.txtPDW.Location = new System.Drawing.Point(98, 140);
            this.txtPDW.Name = "txtPDW";
            this.txtPDW.PasswordChar = '*';
            this.txtPDW.Size = new System.Drawing.Size(258, 22);
            this.txtPDW.TabIndex = 10;
            this.txtPDW.MouseHover += new System.EventHandler(this.txtPDW_MouseHover);
            // 
            // txtSender
            // 
            this.txtSender.Location = new System.Drawing.Point(98, 100);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(258, 22);
            this.txtSender.TabIndex = 9;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(98, 60);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 22);
            this.txtPort.TabIndex = 8;
            // 
            // txtMailServer
            // 
            this.txtMailServer.Location = new System.Drawing.Point(98, 20);
            this.txtMailServer.Name = "txtMailServer";
            this.txtMailServer.Size = new System.Drawing.Size(258, 22);
            this.txtMailServer.TabIndex = 7;
            // 
            // chLgDel
            // 
            this.chLgDel.AutoSize = true;
            this.chLgDel.Location = new System.Drawing.Point(393, 19);
            this.chLgDel.Name = "chLgDel";
            this.chLgDel.Size = new System.Drawing.Size(131, 20);
            this.chLgDel.TabIndex = 6;
            this.chLgDel.Text = "Log fájlok törlése";
            this.chLgDel.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cég:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Címzett:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mail szerver:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jelszó:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail küldő:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(393, 76);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 46);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Mentes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(393, 149);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 47);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Mégsem";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1616, 1146);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Raid";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chDiskpart;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.RadioButton rbHp;
        private System.Windows.Forms.RadioButton rbDell;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chLgDel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtMailServer;
        private System.Windows.Forms.TextBox txtPDW;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}

