namespace Yugioh_Card_Directory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LowestPrice = new System.Windows.Forms.Label();
            this.AveragePrice = new System.Windows.Forms.Label();
            this.HighestPrice = new System.Windows.Forms.Label();
            this.LowestPrice_Num = new System.Windows.Forms.Label();
            this.AveragePrice_Num = new System.Windows.Forms.Label();
            this.HighestPrice_Num = new System.Windows.Forms.Label();
            this.BuyNow_Button = new System.Windows.Forms.Button();
            this.Translate_Button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(2, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(186, 420);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(192, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 418);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LowestPrice
            // 
            this.LowestPrice.AutoSize = true;
            this.LowestPrice.Location = new System.Drawing.Point(2, 448);
            this.LowestPrice.Name = "LowestPrice";
            this.LowestPrice.Size = new System.Drawing.Size(74, 13);
            this.LowestPrice.TabIndex = 4;
            this.LowestPrice.Text = "Lowest Price: ";
            // 
            // AveragePrice
            // 
            this.AveragePrice.AutoSize = true;
            this.AveragePrice.Location = new System.Drawing.Point(2, 465);
            this.AveragePrice.Name = "AveragePrice";
            this.AveragePrice.Size = new System.Drawing.Size(80, 13);
            this.AveragePrice.TabIndex = 5;
            this.AveragePrice.Text = "Average Price: ";
            // 
            // HighestPrice
            // 
            this.HighestPrice.AutoSize = true;
            this.HighestPrice.Location = new System.Drawing.Point(2, 480);
            this.HighestPrice.Name = "HighestPrice";
            this.HighestPrice.Size = new System.Drawing.Size(76, 13);
            this.HighestPrice.TabIndex = 6;
            this.HighestPrice.Text = "Highest Price: ";
            // 
            // LowestPrice_Num
            // 
            this.LowestPrice_Num.AutoSize = true;
            this.LowestPrice_Num.Location = new System.Drawing.Point(92, 448);
            this.LowestPrice_Num.Name = "LowestPrice_Num";
            this.LowestPrice_Num.Size = new System.Drawing.Size(35, 13);
            this.LowestPrice_Num.TabIndex = 7;
            this.LowestPrice_Num.Text = "label1";
            // 
            // AveragePrice_Num
            // 
            this.AveragePrice_Num.AutoSize = true;
            this.AveragePrice_Num.Location = new System.Drawing.Point(92, 465);
            this.AveragePrice_Num.Name = "AveragePrice_Num";
            this.AveragePrice_Num.Size = new System.Drawing.Size(35, 13);
            this.AveragePrice_Num.TabIndex = 8;
            this.AveragePrice_Num.Text = "label2";
            // 
            // HighestPrice_Num
            // 
            this.HighestPrice_Num.AutoSize = true;
            this.HighestPrice_Num.Location = new System.Drawing.Point(92, 480);
            this.HighestPrice_Num.Name = "HighestPrice_Num";
            this.HighestPrice_Num.Size = new System.Drawing.Size(35, 13);
            this.HighestPrice_Num.TabIndex = 9;
            this.HighestPrice_Num.Text = "label3";
            // 
            // BuyNow_Button
            // 
            this.BuyNow_Button.Location = new System.Drawing.Point(192, 452);
            this.BuyNow_Button.Name = "BuyNow_Button";
            this.BuyNow_Button.Size = new System.Drawing.Size(151, 41);
            this.BuyNow_Button.TabIndex = 10;
            this.BuyNow_Button.Text = "Buy Now";
            this.BuyNow_Button.UseVisualStyleBackColor = true;
            this.BuyNow_Button.Click += new System.EventHandler(this.BuyNow_Button_Click);
            // 
            // Translate_Button
            // 
            this.Translate_Button.Location = new System.Drawing.Point(354, 452);
            this.Translate_Button.Name = "Translate_Button";
            this.Translate_Button.Size = new System.Drawing.Size(138, 41);
            this.Translate_Button.TabIndex = 11;
            this.Translate_Button.Text = "Translate";
            this.Translate_Button.UseVisualStyleBackColor = true;
            this.Translate_Button.Click += new System.EventHandler(this.Translate_Button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(499, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 418);
            this.textBox1.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(496, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToolStripMenuItem,
            this.cardInformationToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.imageToolStripMenuItem.Text = "Image";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.imageToolStripMenuItem_Click);
            // 
            // cardInformationToolStripMenuItem
            // 
            this.cardInformationToolStripMenuItem.Name = "cardInformationToolStripMenuItem";
            this.cardInformationToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.cardInformationToolStripMenuItem.Text = "Card Information";
            this.cardInformationToolStripMenuItem.Click += new System.EventHandler(this.cardInformationToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.editToolStripMenuItem.Text = "Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.instructionsToolStripMenuItem.Text = "About";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 502);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Translate_Button);
            this.Controls.Add(this.BuyNow_Button);
            this.Controls.Add(this.HighestPrice_Num);
            this.Controls.Add(this.AveragePrice_Num);
            this.Controls.Add(this.LowestPrice_Num);
            this.Controls.Add(this.HighestPrice);
            this.Controls.Add(this.AveragePrice);
            this.Controls.Add(this.LowestPrice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yugioh Card Directory";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LowestPrice;
        private System.Windows.Forms.Label AveragePrice;
        private System.Windows.Forms.Label HighestPrice;
        private System.Windows.Forms.Label LowestPrice_Num;
        private System.Windows.Forms.Label AveragePrice_Num;
        private System.Windows.Forms.Label HighestPrice_Num;
        private System.Windows.Forms.Button BuyNow_Button;
        private System.Windows.Forms.Button Translate_Button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
    }
}

