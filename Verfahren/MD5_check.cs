using Sharper2._0;
using Sharper2._0.Controller;
using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Sharper2._0.Verfahren
{
    public class MD5_check
    {
        public static string hash;
        public static string GetMD5FromFile(string filePath)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    hash = BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty).ToLower();
                    return hash;
                }
            }
        }
        public static void scan(Label lab)
        {
            try
            {
                var MD5_Signatures = File.ReadAllText("MD5Base.txt");
                if (MD5_Signatures.Contains(hash))
                {
                    lab.ForeColor = Color.Red;
                    lab.Text = "Risiko erkannt!";
                    Scanner.infected = true;
                }
                else
                {
                    lab.ForeColor = Color.LightGreen;
                    lab.Text = "Keine Bedrohung erkannt!";
                    Scanner.infected = false;
                }
            }
            catch
            {
                MessageBox.Show("Du hast keine Datei ausgewählt!");
                Scanner.report = false;
            }
        }
    }
}
