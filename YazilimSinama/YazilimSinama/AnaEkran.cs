using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace YazilimSinama
{
    public partial class AnaEkran : MetroFramework.Forms.MetroForm
    {

        Socket sck;
        EndPoint epLocal, epRemote;    //Socket Programming için tanımlar
        byte[] buffer;
        public int count = 0;
        public AnaEkran()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;    //yasal olmayan thread çağrılarını kontrol etme
        }

        private string GetLocalIp()    //Local ip tanımlamak için 
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();    //internete bağlı olduğumuz zaman
            }
            return "127.0.0.1";
        }

        private void connect()
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            txtLocalIp.Text = GetLocalIp();    //kendi local ip miz 
            txtRemoteIp.Text = GetLocalIp();    //karşı tarafın local ip si
            btnSend.Enabled = false;
            btnConnect.Enabled = true;
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            connect();
            txtKey.Enabled = false;
            txtLocalIp.Enabled = false;
            txtRemoteIp.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if ((cmbLocalPort.SelectedItem != cmbRemotePort.SelectedItem) && (cmbLocalPort.Text != null || cmbRemotePort.Text != null))
            {
                epLocal = new IPEndPoint(IPAddress.Parse(txtLocalIp.Text), Convert.ToInt32(cmbLocalPort.Text));
                sck.Bind(epLocal);    //karşı tarafı dinleme

                epRemote = new IPEndPoint(IPAddress.Parse(txtRemoteIp.Text), Convert.ToInt32(cmbRemotePort.Text));
                sck.Connect(epRemote);    //karşı tarafa bağlanma

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
                btnSend.Enabled = true;
                btnConnect.Enabled = false;    //bağlantı hatalarını engellemek
                cmbLocalPort.Enabled = false;
                cmbRemotePort.Enabled = false;
            }
            else
            {
                MessageBox.Show("Lütfen Port Numaralarını Farklı Giriniz");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Message msg = new Message();
            UTF8Encoding aEncoding = new UTF8Encoding();
            byte[] sendingMessage = new byte[1500];    //gönderilecek olan veriler için byte tanımladık
            byte[] message = new byte[1500];
            byte[] key = new byte[1500];
            if(rdoSPN.Checked)    // spn seçiliyse 
            {
                sendingMessage = aEncoding.GetBytes(msg.SPNEncrypt(txtMessage.Text, txtKey.Text));
                key = aEncoding.GetBytes(msg.sha256Encrypt(txtKey.Text, ""));    //key ve anahtarı byte a çevirir
                if (sck.Connected && txtMessage.Text != "")    // socket bağlı ve mesaj kutusu boş değil ise
                {
                    sck.Send(key);
                    sck.Send(sendingMessage);    //mesajı ve anahtarı karşıya şifreli olarak gönderir
                    lstSifreliMsj.Items.Add("Me:" + msg.SPNEncrypt(txtMessage.Text, txtKey.Text) + "\n");
                    lstSifresizMsj.Items.Add("Me:" + msg.message + "\n");
                    txtMessage.Text = "";
                }
            }
            else    //sha256 seçiliyse
            {
                sendingMessage = aEncoding.GetBytes(msg.sha256Encrypt(txtMessage.Text, txtKey.Text));
                message = aEncoding.GetBytes(msg.message);    // verileri bytelara çevirir
                key = aEncoding.GetBytes(msg.sha256Encrypt(txtKey.Text, ""));
                if (sck.Connected && txtMessage.Text != "")
                {
                    sck.Send(key);
                    sck.Send(sendingMessage);    //mesajı ve anahtarı karşıya şifreli olarak gönderir
                    sck.Send(message);
                    lstSifreliMsj.Items.Add("Me:" + msg.sha256Encrypt(txtMessage.Text, txtKey.Text) + "\n");
                    lstSifresizMsj.Items.Add("Me:" + msg.message + "\n");
                    txtMessage.Text = "";
                }
            }
        }

        private void MessageCallBack(IAsyncResult aResult)    //gönderilen verileri alan fonksiyon
        {
            Message msg = new Message();
            byte[] receivedData = new byte[1500];
            receivedData = (byte[])aResult.AsyncState;    // gelen veri
            UTF8Encoding aEncoding = new UTF8Encoding();
            string messagekey = msg.sha256Encrypt(txtKey.Text, "");
            string receivedMessage = aEncoding.GetString(receivedData);
            if (messagekey == receivedMessage.Replace("\0", string.Empty) && count == 0)    //şifre kontrolü
            {
                count++;
                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            else if (count == 1)    // şifreli verinin listbox a yazdırılması
            {
                if(rdoSPN.Checked)
                {
                    lstSifresizMsj.Items.Add("Friend:" + msg.SPNDecrypt(receivedMessage.Replace("\0", string.Empty), txtKey.Text) + "\n");
                }
                lstSifreliMsj.Items.Add("Friend:" + receivedMessage.Replace("\0", string.Empty) + "\n");
                count++;
                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

            }
            else if (count == 2)    // şifresi çözülmüş verinin listbox a yazdırılamsı
            {
                lstSifresizMsj.Items.Add("Friend:" + receivedMessage.Replace("\0", string.Empty) + "\n");
                count -= 2;
                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            else    // port numaraları aynı ise 
            {
                MessageBox.Show("Bağlantı Sağlanamadı. Lütfen Tekrar Deneyiniz. \n Karşı tarafla şifreleme yönteminiz aynı olmayabilir");
                sck.Close();
                connect();
                cmbLocalPort.Enabled = true;
                cmbRemotePort.Enabled = true;
            }
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            Message msg = new Message();
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "All files (*.*)|*.*";    //dosya seçim işlemi
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                lblFile.Text = theDialog.FileName.ToString();    // seçilen dosyanın yolunu atar
            }

            FileInfo fileToBeGZipped = new FileInfo(lblFile.Text);
            FileInfo gzipFileName = new FileInfo(string.Concat(fileToBeGZipped.FullName, ".gz"));
            msg.Ziple(fileToBeGZipped, gzipFileName);    //seçilen dosyayı sıkıştırır
        }

        private void rdoSHA_CheckedChanged(object sender, EventArgs e)
        {
            rdoSPN.Enabled = false;
        }

        private void rdoSPN_CheckedChanged(object sender, EventArgs e)
        {
            rdoSHA.Enabled = false;
        }

        private void btnDecompress_Click(object sender, EventArgs e)
        {
            Message msg = new Message();
            try
            {
                OpenFileDialog theDialog = new OpenFileDialog();
                theDialog.Title = "Open Text File";
                theDialog.Filter = "All files (*.*)|*.*";    // dosya seçim işlemi
                theDialog.InitialDirectory = @"C:\";
                if (theDialog.ShowDialog() == DialogResult.OK)
                {
                    lblFile.Text = theDialog.FileName.ToString();    // seçilen zip dosyasının yolunu gösterir
                }
            }
            catch(Exception )
            {
                MessageBox.Show("Lütfen dosya seçiniz");
            }

            

            FileInfo fileToBeGZipped = new FileInfo(lblFile.Text);
            FileInfo gzipFileName = new FileInfo(string.Concat(fileToBeGZipped.FullName));
            msg.Cozumle(fileToBeGZipped, gzipFileName);    //zip dosyasını ayıklar

        }
    }
}
