using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Yugioh_Card_Directory
{
    public partial class Form1 : Form
    {

        [Serializable]
        public class RootObject
        {
            public string status { get; set; }
            public List<string> cards { get; set; }
        }

        //Public setters / getters
        public string name { get; set; }
        public string image_path { get; set; }
        public string thumbnail_path { get; set; }
        public string text { get; set; }
        public string type { get; set; }
        public string number { get; set; }
        public string price_low { get; set; }
        public string price_avg { get; set; }
        public string price_high { get; set; }
        public string tcgplayer_link { get; set; }
        public bool is_monster { get; set; }
        public bool is_spell { get; set; }
        public bool is_illegal { get; set; }
        public bool is_trap { get; set; }
        public bool has_name_condition { get; set; }
        public string property { get; set; }

        public Form1()
        {
            InitializeComponent();

            //File Directory
            var mainFilePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            var jsonPath = Path.Combine(mainFilePath, "JSON\\cardNames.json");

            //Read text from json file.
            string json = File.ReadAllText(@"JSON\\cardNames.json");

            //Deserialize JSON
            var jsonData = JObject.Parse(json);

            //Throws information into listbox.
            listBox1.DataSource = jsonData["cards"];

        }

        public void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string cardname = listBox1.SelectedItem.ToString();

            string testing = cardname;
            WebClient webClient = new WebClient();

            //Download json file to variable and parse.
            JObject cardInfo = JObject.Parse(webClient.DownloadString($"https://www.ygohub.com/api/card_info?name={cardname}"));

            try  {

                // ======================== Variables ====================================
                string imagepath = (string)cardInfo["card"]["image_path"];
                string lowestitemprice = (string)cardInfo["card"]["price_low"];
                string averageitemprice = (string)cardInfo["card"]["price_avg"];
                string highestitemprice = (string)cardInfo["card"]["price_high"];

                string cardName = (string)cardInfo["card"]["name"];
                string cardText = (string)cardInfo["card"]["text"];
                string cardType = (string)cardInfo["card"]["type"];
                string cardIsIllegal = (string)cardInfo["card"]["is_illegal"];
                string cardNameCondition = (string)cardInfo["card"]["has_name_condition"];

                // ======================== End Variables =================================

                // ======================== Translated Content ============================
                if (cardIsIllegal == "true")
                {
                    textBox1.Text = $"Card Name: {cardName}" + Environment.NewLine + Environment.NewLine +
                                    $"Card Text: {cardText}" + Environment.NewLine + Environment.NewLine +
                                    $"Card Type: {cardType}" + Environment.NewLine + Environment.NewLine +
                                    $"Illegal card?: Yes" + Environment.NewLine + Environment.NewLine +
                                    $"Does card have a name condition: {cardNameCondition}";
                }
                else
                {
                    textBox1.Text = $"Card Name: {cardName}" + Environment.NewLine + Environment.NewLine +
                                    $"Card Text: {cardText}" + Environment.NewLine + Environment.NewLine +
                                    $"Card Type: {cardType}" + Environment.NewLine + Environment.NewLine +
                                    $"Illegal card?: No" + Environment.NewLine + Environment.NewLine +
                                    $"Does card have a name condition: {cardNameCondition}";
                }

                // =================== End Translated Content =============================

                // ======================== Gets Pricing ==================================
                if (lowestitemprice != null && averageitemprice != null && highestitemprice != null)
                {
                    LowestPrice_Num.Text = "$" + lowestitemprice;
                    AveragePrice_Num.Text = "$" + averageitemprice;
                    HighestPrice_Num.Text = "$" + highestitemprice;
                }
                else
                {
                    LowestPrice_Num.Text = "Price not Avaliable.";
                    AveragePrice_Num.Text = "Price not Avaliable.";
                    HighestPrice_Num.Text = "Price not Avaliable.";
                }

                // ======================== End Pricing ===================================

                // ======================== Gets Images ===================================
                var request = WebRequest.Create($"{imagepath}");

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    pictureBox1.Image = Bitmap.FromStream(stream);
                }

                // ======================== End Images ====================================

            }
            catch {

            }   
        }

        private void BuyNow_Button_Click(object sender, EventArgs e)
        {

            WebClient webClient = new WebClient();
            string cardname = listBox1.SelectedItem.ToString();
            JObject cardInfo = JObject.Parse(webClient.DownloadString($"https://www.ygohub.com/api/card_info?name={cardname}"));

            string buyUrl = (string)cardInfo["card"]["tcgplayer_link"];
            
            System.Diagnostics.Process.Start($"{buyUrl}");
        }

        private void Translate_Button_Click(object sender, EventArgs e)
        {

            if (this.Width == 512)
            {
                this.Width = 810;
                Translate_Button.Text = "Hide Translated Information";
            } else
            {
                this.Width = 512;
                Translate_Button.Text = "Translate";
            }

       
        }

        // =========================== For Saving Images =========================
        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cardname = listBox1.SelectedItem.ToString();
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Directory.CreateDirectory(desktopPath+"\\Yu-Gi-Oh Cards\\" + "Card Images\\");

            string invalid = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());

            foreach (char c in invalid)
            {
                cardname = cardname.Replace(c.ToString(), "");
            }
            pictureBox1.Image.Save($"{desktopPath}\\Yu-Gi-Oh Cards\\Card Images\\{cardname}.jpg", ImageFormat.Jpeg);
        }
        // =========================== End Saving Images =========================

        // =========================== Exitting the program ======================
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        // =========================== Exit Application ==========================

        private void cardInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cardname = listBox1.SelectedItem.ToString();
            WebClient webClient = new WebClient();
            JObject cardInfo = JObject.Parse(webClient.DownloadString($"https://www.ygohub.com/api/card_info?name={cardname}"));

            string invalid = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            
            foreach (char c in invalid)
            {
                cardname = cardname.Replace(c.ToString(), "");
            }

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Directory.CreateDirectory(desktopPath + "\\Yu-Gi-Oh Cards\\" + "Card Information\\");
            TextWriter txt = new StreamWriter($"{desktopPath}\\Yu-Gi-Oh Cards\\Card Information\\{cardname}.txt");
            txt.Write(textBox1.Text);
            txt.Close();
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }
    }
}
