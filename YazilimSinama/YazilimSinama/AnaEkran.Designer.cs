
namespace YazilimSinama
{
    partial class AnaEkran
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstSifresizMsj = new System.Windows.Forms.ListBox();
            this.lstSifreliMsj = new System.Windows.Forms.ListBox();
            this.btnConnect = new MetroFramework.Controls.MetroButton();
            this.txtRemoteIp = new MetroFramework.Controls.MetroTextBox();
            this.txtLocalIp = new MetroFramework.Controls.MetroTextBox();
            this.cmbRemotePort = new MetroFramework.Controls.MetroComboBox();
            this.cmbLocalPort = new MetroFramework.Controls.MetroComboBox();
            this.txtMessage = new MetroFramework.Controls.MetroTextBox();
            this.btnSend = new MetroFramework.Controls.MetroButton();
            this.btnCompress = new MetroFramework.Controls.MetroButton();
            this.rdoSHA = new MetroFramework.Controls.MetroRadioButton();
            this.rdoSPN = new MetroFramework.Controls.MetroRadioButton();
            this.txtKey = new MetroFramework.Controls.MetroTextBox();
            this.lblFile = new MetroFramework.Controls.MetroLabel();
            this.lblMe = new MetroFramework.Controls.MetroLabel();
            this.lblFriend = new MetroFramework.Controls.MetroLabel();
            this.btnDecompress = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lstSifresizMsj
            // 
            this.lstSifresizMsj.FormattingEnabled = true;
            this.lstSifresizMsj.ItemHeight = 16;
            this.lstSifresizMsj.Location = new System.Drawing.Point(23, 190);
            this.lstSifresizMsj.Name = "lstSifresizMsj";
            this.lstSifresizMsj.ScrollAlwaysVisible = true;
            this.lstSifresizMsj.Size = new System.Drawing.Size(348, 292);
            this.lstSifresizMsj.TabIndex = 6;
            // 
            // lstSifreliMsj
            // 
            this.lstSifreliMsj.FormattingEnabled = true;
            this.lstSifreliMsj.ItemHeight = 16;
            this.lstSifreliMsj.Location = new System.Drawing.Point(385, 190);
            this.lstSifreliMsj.Name = "lstSifreliMsj";
            this.lstSifreliMsj.ScrollAlwaysVisible = true;
            this.lstSifreliMsj.Size = new System.Drawing.Size(641, 292);
            this.lstSifreliMsj.TabIndex = 12;
            // 
            // btnConnect
            // 
            this.btnConnect.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnConnect.Location = new System.Drawing.Point(684, 63);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 44);
            this.btnConnect.TabIndex = 13;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseSelectable = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtRemoteIp
            // 
            // 
            // 
            // 
            this.txtRemoteIp.CustomButton.Image = null;
            this.txtRemoteIp.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.txtRemoteIp.CustomButton.Name = "";
            this.txtRemoteIp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRemoteIp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRemoteIp.CustomButton.TabIndex = 1;
            this.txtRemoteIp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRemoteIp.CustomButton.UseSelectable = true;
            this.txtRemoteIp.CustomButton.Visible = false;
            this.txtRemoteIp.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtRemoteIp.Lines = new string[0];
            this.txtRemoteIp.Location = new System.Drawing.Point(783, 63);
            this.txtRemoteIp.MaxLength = 32767;
            this.txtRemoteIp.Multiline = true;
            this.txtRemoteIp.Name = "txtRemoteIp";
            this.txtRemoteIp.PasswordChar = '\0';
            this.txtRemoteIp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRemoteIp.SelectedText = "";
            this.txtRemoteIp.SelectionLength = 0;
            this.txtRemoteIp.SelectionStart = 0;
            this.txtRemoteIp.ShortcutsEnabled = true;
            this.txtRemoteIp.Size = new System.Drawing.Size(131, 23);
            this.txtRemoteIp.TabIndex = 14;
            this.txtRemoteIp.UseSelectable = true;
            this.txtRemoteIp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRemoteIp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLocalIp
            // 
            // 
            // 
            // 
            this.txtLocalIp.CustomButton.Image = null;
            this.txtLocalIp.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.txtLocalIp.CustomButton.Name = "";
            this.txtLocalIp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLocalIp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLocalIp.CustomButton.TabIndex = 1;
            this.txtLocalIp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLocalIp.CustomButton.UseSelectable = true;
            this.txtLocalIp.CustomButton.Visible = false;
            this.txtLocalIp.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtLocalIp.Lines = new string[0];
            this.txtLocalIp.Location = new System.Drawing.Point(535, 63);
            this.txtLocalIp.MaxLength = 32767;
            this.txtLocalIp.Multiline = true;
            this.txtLocalIp.Name = "txtLocalIp";
            this.txtLocalIp.PasswordChar = '\0';
            this.txtLocalIp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLocalIp.SelectedText = "";
            this.txtLocalIp.SelectionLength = 0;
            this.txtLocalIp.SelectionStart = 0;
            this.txtLocalIp.ShortcutsEnabled = true;
            this.txtLocalIp.Size = new System.Drawing.Size(131, 23);
            this.txtLocalIp.TabIndex = 15;
            this.txtLocalIp.UseSelectable = true;
            this.txtLocalIp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLocalIp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbRemotePort
            // 
            this.cmbRemotePort.FormattingEnabled = true;
            this.cmbRemotePort.ItemHeight = 24;
            this.cmbRemotePort.Items.AddRange(new object[] {
            "6212",
            "7856"});
            this.cmbRemotePort.Location = new System.Drawing.Point(783, 106);
            this.cmbRemotePort.Name = "cmbRemotePort";
            this.cmbRemotePort.Size = new System.Drawing.Size(131, 30);
            this.cmbRemotePort.TabIndex = 16;
            this.cmbRemotePort.UseSelectable = true;
            // 
            // cmbLocalPort
            // 
            this.cmbLocalPort.FormattingEnabled = true;
            this.cmbLocalPort.ItemHeight = 24;
            this.cmbLocalPort.Items.AddRange(new object[] {
            "6212",
            "7856"});
            this.cmbLocalPort.Location = new System.Drawing.Point(535, 106);
            this.cmbLocalPort.Name = "cmbLocalPort";
            this.cmbLocalPort.Size = new System.Drawing.Size(131, 30);
            this.cmbLocalPort.TabIndex = 17;
            this.cmbLocalPort.UseSelectable = true;
            // 
            // txtMessage
            // 
            // 
            // 
            // 
            this.txtMessage.CustomButton.Image = null;
            this.txtMessage.CustomButton.Location = new System.Drawing.Point(324, 1);
            this.txtMessage.CustomButton.Name = "";
            this.txtMessage.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMessage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMessage.CustomButton.TabIndex = 1;
            this.txtMessage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMessage.CustomButton.UseSelectable = true;
            this.txtMessage.CustomButton.Visible = false;
            this.txtMessage.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtMessage.Lines = new string[0];
            this.txtMessage.Location = new System.Drawing.Point(20, 488);
            this.txtMessage.MaxLength = 32767;
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PasswordChar = '\0';
            this.txtMessage.PromptText = "Send Message";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMessage.SelectedText = "";
            this.txtMessage.SelectionLength = 0;
            this.txtMessage.SelectionStart = 0;
            this.txtMessage.ShortcutsEnabled = true;
            this.txtMessage.Size = new System.Drawing.Size(348, 25);
            this.txtMessage.TabIndex = 18;
            this.txtMessage.UseSelectable = true;
            this.txtMessage.WaterMark = "Send Message";
            this.txtMessage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMessage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            // 
            // btnSend
            // 
            this.btnSend.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSend.Location = new System.Drawing.Point(293, 519);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 19;
            this.btnSend.Text = "Send";
            this.btnSend.UseSelectable = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCompress
            // 
            this.btnCompress.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCompress.Location = new System.Drawing.Point(500, 488);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(129, 32);
            this.btnCompress.TabIndex = 20;
            this.btnCompress.Text = "Compress File";
            this.btnCompress.UseSelectable = true;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // rdoSHA
            // 
            this.rdoSHA.AutoSize = true;
            this.rdoSHA.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rdoSHA.Location = new System.Drawing.Point(267, 68);
            this.rdoSHA.Name = "rdoSHA";
            this.rdoSHA.Size = new System.Drawing.Size(101, 25);
            this.rdoSHA.TabIndex = 21;
            this.rdoSHA.Text = "SHA-256";
            this.rdoSHA.UseSelectable = true;
            // 
            // rdoSPN
            // 
            this.rdoSPN.AutoSize = true;
            this.rdoSPN.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rdoSPN.Location = new System.Drawing.Point(267, 96);
            this.rdoSPN.Name = "rdoSPN";
            this.rdoSPN.Size = new System.Drawing.Size(63, 25);
            this.rdoSPN.TabIndex = 22;
            this.rdoSPN.Text = "SPN";
            this.rdoSPN.UseSelectable = true;
            // 
            // txtKey
            // 
            // 
            // 
            // 
            this.txtKey.CustomButton.Image = null;
            this.txtKey.CustomButton.Location = new System.Drawing.Point(89, 1);
            this.txtKey.CustomButton.Name = "";
            this.txtKey.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKey.CustomButton.TabIndex = 1;
            this.txtKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKey.CustomButton.UseSelectable = true;
            this.txtKey.CustomButton.Visible = false;
            this.txtKey.Lines = new string[] {
        "sifre"};
            this.txtKey.Location = new System.Drawing.Point(101, 540);
            this.txtKey.MaxLength = 32767;
            this.txtKey.Name = "txtKey";
            this.txtKey.PasswordChar = '*';
            this.txtKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKey.SelectedText = "";
            this.txtKey.SelectionLength = 0;
            this.txtKey.SelectionStart = 0;
            this.txtKey.ShortcutsEnabled = true;
            this.txtKey.Size = new System.Drawing.Size(111, 23);
            this.txtKey.TabIndex = 23;
            this.txtKey.Text = "sifre";
            this.txtKey.UseSelectable = true;
            this.txtKey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(540, 540);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(60, 20);
            this.lblFile.TabIndex = 24;
            this.lblFile.Text = "File Path";
            // 
            // lblMe
            // 
            this.lblMe.AutoSize = true;
            this.lblMe.Location = new System.Drawing.Point(500, 87);
            this.lblMe.Name = "lblMe";
            this.lblMe.Size = new System.Drawing.Size(29, 20);
            this.lblMe.TabIndex = 25;
            this.lblMe.Text = "ME";
            // 
            // lblFriend
            // 
            this.lblFriend.AutoSize = true;
            this.lblFriend.Location = new System.Drawing.Point(920, 87);
            this.lblFriend.Name = "lblFriend";
            this.lblFriend.Size = new System.Drawing.Size(56, 20);
            this.lblFriend.TabIndex = 26;
            this.lblFriend.Text = "FRIEND";
            // 
            // btnDecompress
            // 
            this.btnDecompress.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDecompress.Location = new System.Drawing.Point(758, 488);
            this.btnDecompress.Name = "btnDecompress";
            this.btnDecompress.Size = new System.Drawing.Size(140, 32);
            this.btnDecompress.TabIndex = 27;
            this.btnDecompress.Text = "Decompress File";
            this.btnDecompress.UseSelectable = true;
            this.btnDecompress.Click += new System.EventHandler(this.btnDecompress_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 611);
            this.Controls.Add(this.btnDecompress);
            this.Controls.Add(this.lblFriend);
            this.Controls.Add(this.lblMe);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.rdoSPN);
            this.Controls.Add(this.rdoSHA);
            this.Controls.Add(this.btnCompress);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.cmbLocalPort);
            this.Controls.Add(this.cmbRemotePort);
            this.Controls.Add(this.txtLocalIp);
            this.Controls.Add(this.txtRemoteIp);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lstSifreliMsj);
            this.Controls.Add(this.lstSifresizMsj);
            this.MaximizeBox = false;
            this.Name = "AnaEkran";
            this.Text = "AnaEkran";
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSifresizMsj;
        private System.Windows.Forms.ListBox lstSifreliMsj;
        private MetroFramework.Controls.MetroButton btnConnect;
        private MetroFramework.Controls.MetroTextBox txtRemoteIp;
        private MetroFramework.Controls.MetroTextBox txtLocalIp;
        private MetroFramework.Controls.MetroComboBox cmbRemotePort;
        private MetroFramework.Controls.MetroComboBox cmbLocalPort;
        private MetroFramework.Controls.MetroTextBox txtMessage;
        private MetroFramework.Controls.MetroButton btnSend;
        private MetroFramework.Controls.MetroButton btnCompress;
        private MetroFramework.Controls.MetroRadioButton rdoSHA;
        private MetroFramework.Controls.MetroRadioButton rdoSPN;
        private MetroFramework.Controls.MetroTextBox txtKey;
        private MetroFramework.Controls.MetroLabel lblFile;
        private MetroFramework.Controls.MetroLabel lblMe;
        private MetroFramework.Controls.MetroLabel lblFriend;
        private MetroFramework.Controls.MetroButton btnDecompress;
    }
}

