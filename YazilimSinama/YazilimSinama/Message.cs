using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimSinama
{
    class Message
    {
        public string message { get; private set; }
        public string key { get; private set; }

        public string SPNEncrypt(string TextToEncrypt,string key) //Şifreleme işlemi
        {
            this.key = key;
            this.message = TextToEncrypt;
            byte[] MyEncryptedArray = UTF8Encoding.UTF8.GetBytes(TextToEncrypt);    //Girilen mesajı byte a dönüştürme

            MD5CryptoServiceProvider MyMD5CryptoService = new MD5CryptoServiceProvider();

            byte[] KeyArray = MyMD5CryptoService.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));   // şifre md5 algoritması ile şifrelendi

            MyMD5CryptoService.Clear();

            var MyTripleDESCryptoService = new TripleDESCryptoServiceProvider();

            MyTripleDESCryptoService.Key = KeyArray;    //Key tanımlaması yapıldı

            MyTripleDESCryptoService.Mode = CipherMode.ECB;

            MyTripleDESCryptoService.Padding = PaddingMode.PKCS7;

            var MyCrytpoTransform = MyTripleDESCryptoService.CreateEncryptor();

            byte[] MyresultArray = MyCrytpoTransform.TransformFinalBlock(MyEncryptedArray, 0,MyEncryptedArray.Length);

            MyTripleDESCryptoService.Clear();

            return Convert.ToBase64String(MyresultArray, 0,MyresultArray.Length); //şifrelenen veri stringe dönüştürülüyor
        }



        public string SPNDecrypt(string TextToDecrypt,string key)    // Şifre çözme 
        {
            this.key = key;
            this.message = TextToDecrypt;
            byte[] MyDecryptArray = Convert.FromBase64String(TextToDecrypt);    //şifrelenmiş veriyi byte a çeviriyor

            MD5CryptoServiceProvider MyMD5CryptoService = new MD5CryptoServiceProvider();

            byte[] KeyArray = MyMD5CryptoService.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));    // Key i şifreleyip byte a çeviriyoruz

            MyMD5CryptoService.Clear();

            var MyTripleDESCryptoService = new TripleDESCryptoServiceProvider();

            MyTripleDESCryptoService.Key = KeyArray;    // Key tanımlaması yapıldı

            MyTripleDESCryptoService.Mode = CipherMode.ECB;

            MyTripleDESCryptoService.Padding = PaddingMode.PKCS7;

            var MyCrytpoTransform = MyTripleDESCryptoService.CreateDecryptor();

            byte[] MyresultArray = MyCrytpoTransform.TransformFinalBlock(MyDecryptArray, 0,MyDecryptArray.Length);

            MyTripleDESCryptoService.Clear();

            return UTF8Encoding.UTF8.GetString(MyresultArray);    //şifresi çözülmüş bytelı mesaj string e dönüştürülüyor.
        }

        public string sha256Encrypt(string Msg, string Key)
        {
            this.message = Msg;
            this.key = key;
            if (String.IsNullOrEmpty(Msg))    // Girilen değerin boş olup olmadığı kontrol ediliyor
            {
                return String.Empty;
            }

            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textBytes = System.Text.Encoding.UTF8.GetBytes(Msg + Key);
                byte[] hashBytes = sha.ComputeHash(textBytes);    // Mesaj ile key şifreleniyor

                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty).ToLower();    //Byte şeklinde olan veri string e dönüştürülüyor

                return hash;
            }
        }

        /*public string SHA256CheckSum(string filePath)    //dosya şifreleme
        {
            using (SHA256 SHA256 = SHA256Managed.Create())
            {
                using (FileStream fileStream = File.OpenRead(filePath))
                    return Convert.ToBase64String(SHA256.ComputeHash(fileStream));
            }
        }*/

        public string Ziple(FileInfo fileToBeGZipped, FileInfo gzipFileName)    //seçilen dosyayı sıkıştırma
        {
            using (FileStream fileToBeZippedAsStream = fileToBeGZipped.OpenRead())    //dosyayı açma ve okuma işlemi
            {
                using (FileStream gzipTargetAsStream = gzipFileName.Create())    //sıkıştırılacak dosyayı oluşturma
                {
                    using (GZipStream gzipStream = new GZipStream(gzipTargetAsStream, CompressionMode.Compress))    // dosyayı sıkıştırma
                    {
                        try
                        {
                            fileToBeZippedAsStream.CopyTo(gzipStream);
                        }
                        catch (Exception ex)                            //Sıkıştırmada hata çıkarsa 
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
            return gzipFileName.FullName;
        }

        public string Cozumle(FileInfo fileToBeGZipped, FileInfo gzipFileName)    // zip halindeki dosyayı açma
        {
            using (FileStream fileToDecompressAsStream = gzipFileName.OpenRead())
            {
                string decompressedFileName = @"c:\\Users\\Public\\Desktop\\compressed.txt";    //dosyayı masaüstüne çıkarma
                using (FileStream decompressedStream = File.Create(decompressedFileName))    //Dosya oluşturma
                {
                    File.SetAttributes(decompressedFileName, FileAttributes.Normal);
                    using (GZipStream decompressionStream = new GZipStream(fileToDecompressAsStream, CompressionMode.Decompress))    //dosyayı zipten çıkarma
                    {
                        try
                        {
                            decompressionStream.CopyTo(decompressedStream);
                        }
                        catch (Exception ex)                                //Ayıklarken sorun çıkarsa
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
            return gzipFileName.FullName;
        }
    }
}
