using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using static Yugioh_Card_Directory.JsonHandler;

namespace Yugioh_Card_Directory
{
    public partial class Form1 : Form
    {

        #region General variables + webclient
        WebClient webClient = new WebClient();
        public string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public string invalid = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
        #endregion

        #region Main Form / Parse JSON and throw it into listbox
        public Form1()
        {
            InitializeComponent();

            var mainFilePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            var jsonPath = Path.Combine(mainFilePath, "JSON\\cardNames.json");
            string json = File.ReadAllText(@"JSON\\cardNames.json");
            var jsonData = JObject.Parse(json);

            //Throws information into listbox.
            listBox1.DataSource = jsonData["cards"];

        }
        #endregion

        #region Listview Change information on new selected item
        public void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string cardname = listBox1.SelectedItem.ToString();
            JObject cardInfo = JObject.Parse(webClient.DownloadString($"https://www.ygohub.com/api/card_info?name={cardname}"));

            try
            {

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
                    pictureBox1.Image = Image.FromStream(stream);
                }

                // ======================== End Images ====================================

            }
            catch
            {
                MessageBox.Show("There was an error reading from the data variables", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }
        #endregion

        #region Buy card now button.
        private void BuyNow_Button_Click(object sender, EventArgs e)
        {
            string cardname = listBox1.SelectedItem.ToString();
            JObject cardInfo = JObject.Parse(webClient.DownloadString($"https://www.ygohub.com/api/card_info?name={cardname}"));
            string buyUrl = (string)cardInfo["card"]["tcgplayer_link"];
            System.Diagnostics.Process.Start($"{buyUrl}");
        }
        #endregion

        #region Print Information to TextBox
        private void Translate_Button_Click(object sender, EventArgs e)
        {
            if (this.Width == 512)
            {
                this.Width = 810;
                Translate_Button.Text = "Hide Translated Information";
            }
            else
            {
                this.Width = 512;
                Translate_Button.Text = "Translate";
            }
        }
        #endregion

        #region =========================== For Saving Images =========================
        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cardname = listBox1.SelectedItem.ToString();
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Directory.CreateDirectory(desktopPath + "\\Yu-Gi-Oh Cards\\" + "Card Images\\");
            checkforIllegalCharacters(cardname);
        }
        #endregion

        #region Check for illegal characters in image saving
        private void checkforIllegalCharacters(string cardname){
            foreach (char c in invalid)
            {
                cardname = cardname.Replace(c.ToString(), "");
            }
            pictureBox1.Image.Save($"{desktopPath}\\Yu-Gi-Oh Cards\\Card Images\\{cardname}.jpg", ImageFormat.Jpeg);
        }
        #endregion

        #region =========================== Exitting the program ======================
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region =========================== Save Card Information ======================
        private void cardInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cardname = listBox1.SelectedItem.ToString();
            JObject cardInfo = JObject.Parse(webClient.DownloadString($"https://www.ygohub.com/api/card_info?name={cardname}"));

            foreach (char c in invalid)
            {
                cardname = cardname.Replace(c.ToString(), "");
            }

            Directory.CreateDirectory(desktopPath + "\\Yu-Gi-Oh Cards\\" + "Card Information\\");
            TextWriter txt = new StreamWriter($"{desktopPath}\\Yu-Gi-Oh Cards\\Card Information\\{cardname}.txt");
            txt.Write(textBox1.Text);
            txt.Close();
        }
        #endregion


        #region Show About Form
        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }
        #endregion

    }
}
