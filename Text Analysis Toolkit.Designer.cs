using System;

namespace Text
{
    partial class TextAnalysisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextAnalysisForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textOptionTab = new System.Windows.Forms.TabControl();
            this.originalTextPage = new System.Windows.Forms.TabPage();
            this.originalTextBox = new System.Windows.Forms.RichTextBox();
            this.tokensPage = new System.Windows.Forms.TabPage();
            this.tokensBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.distinctWordsPage = new System.Windows.Forms.TabPage();
            this.wordsBox = new System.Windows.Forms.ListBox();
            this.labelOccurance = new System.Windows.Forms.Label();
            this.labelToken = new System.Windows.Forms.Label();
            this.sentencesPage = new System.Windows.Forms.TabPage();
            this.sentenceUpDown = new System.Windows.Forms.NumericUpDown();
            this.sentencesNextButton = new System.Windows.Forms.Button();
            this.sentencesPreviousButton = new System.Windows.Forms.Button();
            this.avgWordLengthTextBox = new System.Windows.Forms.TextBox();
            this.numOfWordsTextBox = new System.Windows.Forms.TextBox();
            this.avgWordLengthLabel = new System.Windows.Forms.Label();
            this.numOfWordsLabel = new System.Windows.Forms.Label();
            this.displayLabel = new System.Windows.Forms.Label();
            this.sentenceTextBox = new System.Windows.Forms.RichTextBox();
            this.paragraphPage = new System.Windows.Forms.TabPage();
            this.numSentenceTextBox = new System.Windows.Forms.TextBox();
            this.numSentencesLabel = new System.Windows.Forms.Label();
            this.paragraphUpDown = new System.Windows.Forms.NumericUpDown();
            this.paragraphNextButton = new System.Windows.Forms.Button();
            this.paragraphPreviousButton = new System.Windows.Forms.Button();
            this.avgWordsTextBox = new System.Windows.Forms.TextBox();
            this.numWordsTextBox = new System.Windows.Forms.TextBox();
            this.averageWordsLabel = new System.Windows.Forms.Label();
            this.numWordsLabel = new System.Windows.Forms.Label();
            this.paragrahLabel = new System.Windows.Forms.Label();
            this.paragraphTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.infoStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.filelStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tokenStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.distinctWordsStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sentenceStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.paragraphStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dateStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.textOptionTab.SuspendLayout();
            this.originalTextPage.SuspendLayout();
            this.tokensPage.SuspendLayout();
            this.distinctWordsPage.SuspendLayout();
            this.sentencesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sentenceUpDown)).BeginInit();
            this.paragraphPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paragraphUpDown)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            //
            // menuStrip1
            //
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(797, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            //
            // fIleToolStripMenuItem
            //
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "File";
            //
            // openToolStripMenuItem
            //
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            //
            // helpToolStripMenuItem
            //
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            //
            // aboutToolStripMenuItem
            //
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
            //
            // textOptionTab
            //
            this.textOptionTab.Controls.Add(this.originalTextPage);
            this.textOptionTab.Controls.Add(this.tokensPage);
            this.textOptionTab.Controls.Add(this.distinctWordsPage);
            this.textOptionTab.Controls.Add(this.sentencesPage);
            this.textOptionTab.Controls.Add(this.paragraphPage);
            this.textOptionTab.Location = new System.Drawing.Point(13, 28);
            this.textOptionTab.Name = "textOptionTab";
            this.textOptionTab.SelectedIndex = 0;
            this.textOptionTab.Size = new System.Drawing.Size(772, 636);
            this.textOptionTab.TabIndex = 2;
            //
            // originalTextPage
            //
            this.originalTextPage.Controls.Add(this.originalTextBox);
            this.originalTextPage.Location = new System.Drawing.Point(4, 22);
            this.originalTextPage.Name = "originalTextPage";
            this.originalTextPage.Padding = new System.Windows.Forms.Padding(3);
            this.originalTextPage.Size = new System.Drawing.Size(764, 610);
            this.originalTextPage.TabIndex = 0;
            this.originalTextPage.Text = "Original Text";
            this.originalTextPage.UseVisualStyleBackColor = true;
            //
            // originalTextBox
            //
            this.originalTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.originalTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalTextBox.Location = new System.Drawing.Point(6, 6);
            this.originalTextBox.Name = "originalTextBox";
            this.originalTextBox.ReadOnly = true;
            this.originalTextBox.Size = new System.Drawing.Size(752, 601);
            this.originalTextBox.TabIndex = 0;
            this.originalTextBox.Text = "Please select a text file for analysis using the File menu above";
            //
            // tokensPage
            //
            this.tokensPage.Controls.Add(this.tokensBox);
            this.tokensPage.Controls.Add(this.label1);
            this.tokensPage.Location = new System.Drawing.Point(4, 22);
            this.tokensPage.Name = "tokensPage";
            this.tokensPage.Padding = new System.Windows.Forms.Padding(3);
            this.tokensPage.Size = new System.Drawing.Size(764, 610);
            this.tokensPage.TabIndex = 1;
            this.tokensPage.Text = "Tokens";
            this.tokensPage.UseVisualStyleBackColor = true;
            //
            // tokensBox
            //
            this.tokensBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tokensBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tokensBox.FormattingEnabled = true;
            this.tokensBox.ItemHeight = 17;
            this.tokensBox.Location = new System.Drawing.Point(267, 49);
            this.tokensBox.Name = "tokensBox";
            this.tokensBox.Size = new System.Drawing.Size(161, 480);
            this.tokensBox.TabIndex = 1;
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(267, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tokens Found";
            //
            // distinctWordsPage
            //
            this.distinctWordsPage.Controls.Add(this.wordsBox);
            this.distinctWordsPage.Controls.Add(this.labelOccurance);
            this.distinctWordsPage.Controls.Add(this.labelToken);
            this.distinctWordsPage.Location = new System.Drawing.Point(4, 22);
            this.distinctWordsPage.Name = "distinctWordsPage";
            this.distinctWordsPage.Padding = new System.Windows.Forms.Padding(3);
            this.distinctWordsPage.Size = new System.Drawing.Size(764, 610);
            this.distinctWordsPage.TabIndex = 2;
            this.distinctWordsPage.Text = "Distinct Words";
            this.distinctWordsPage.UseVisualStyleBackColor = true;
            //
            // wordsBox
            //
            this.wordsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.wordsBox.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordsBox.FormattingEnabled = true;
            this.wordsBox.ItemHeight = 15;
            this.wordsBox.Location = new System.Drawing.Point(210, 50);
            this.wordsBox.Name = "wordsBox";
            this.wordsBox.Size = new System.Drawing.Size(312, 529);
            this.wordsBox.TabIndex = 3;
            //
            // labelOccurance
            //
            this.labelOccurance.AutoSize = true;
            this.labelOccurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOccurance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelOccurance.Location = new System.Drawing.Point(397, 12);
            this.labelOccurance.Name = "labelOccurance";
            this.labelOccurance.Size = new System.Drawing.Size(104, 24);
            this.labelOccurance.TabIndex = 2;
            this.labelOccurance.Text = "Occurance";
            //
            // labelToken
            //
            this.labelToken.AutoSize = true;
            this.labelToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToken.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelToken.Location = new System.Drawing.Point(233, 12);
            this.labelToken.Name = "labelToken";
            this.labelToken.Size = new System.Drawing.Size(65, 24);
            this.labelToken.TabIndex = 1;
            this.labelToken.Text = "Words";
            //
            // sentencesPage
            //
            this.sentencesPage.Controls.Add(this.sentenceUpDown);
            this.sentencesPage.Controls.Add(this.sentencesNextButton);
            this.sentencesPage.Controls.Add(this.sentencesPreviousButton);
            this.sentencesPage.Controls.Add(this.avgWordLengthTextBox);
            this.sentencesPage.Controls.Add(this.numOfWordsTextBox);
            this.sentencesPage.Controls.Add(this.avgWordLengthLabel);
            this.sentencesPage.Controls.Add(this.numOfWordsLabel);
            this.sentencesPage.Controls.Add(this.displayLabel);
            this.sentencesPage.Controls.Add(this.sentenceTextBox);
            this.sentencesPage.Location = new System.Drawing.Point(4, 22);
            this.sentencesPage.Name = "sentencesPage";
            this.sentencesPage.Padding = new System.Windows.Forms.Padding(3);
            this.sentencesPage.Size = new System.Drawing.Size(764, 610);
            this.sentencesPage.TabIndex = 3;
            this.sentencesPage.Text = "Sentences";
            this.sentencesPage.UseVisualStyleBackColor = true;
            //
            // sentenceUpDown
            //
            this.sentenceUpDown.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sentenceUpDown.ForeColor = System.Drawing.Color.Red;
            this.sentenceUpDown.Location = new System.Drawing.Point(380, 49);
            this.sentenceUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sentenceUpDown.Name = "sentenceUpDown";
            this.sentenceUpDown.Size = new System.Drawing.Size(76, 23);
            this.sentenceUpDown.TabIndex = 9;
            this.sentenceUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sentenceUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sentenceUpDown.ValueChanged += new System.EventHandler(this.sentenceUpDown_ValueChanged);
            //
            // sentencesNextButton
            //
            this.sentencesNextButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sentencesNextButton.Image = ((System.Drawing.Image)(resources.GetObject("sentencesNextButton.Image")));
            this.sentencesNextButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sentencesNextButton.Location = new System.Drawing.Point(361, 445);
            this.sentencesNextButton.Name = "sentencesNextButton";
            this.sentencesNextButton.Size = new System.Drawing.Size(113, 35);
            this.sentencesNextButton.TabIndex = 8;
            this.sentencesNextButton.Text = "Next";
            this.sentencesNextButton.UseVisualStyleBackColor = true;
            this.sentencesNextButton.Click += new System.EventHandler(this.sentencesNextButton_Click);
            //
            // sentencesPreviousButton
            //
            this.sentencesPreviousButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sentencesPreviousButton.Image = ((System.Drawing.Image)(resources.GetObject("sentencesPreviousButton.Image")));
            this.sentencesPreviousButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sentencesPreviousButton.Location = new System.Drawing.Point(247, 445);
            this.sentencesPreviousButton.Name = "sentencesPreviousButton";
            this.sentencesPreviousButton.Size = new System.Drawing.Size(108, 35);
            this.sentencesPreviousButton.TabIndex = 7;
            this.sentencesPreviousButton.Text = "Previous";
            this.sentencesPreviousButton.UseVisualStyleBackColor = true;
            this.sentencesPreviousButton.Click += new System.EventHandler(this.sentencesPreviousButton_Click);
            //
            // avgWordLengthTextBox
            //
            this.avgWordLengthTextBox.Location = new System.Drawing.Point(404, 379);
            this.avgWordLengthTextBox.Name = "avgWordLengthTextBox";
            this.avgWordLengthTextBox.ReadOnly = true;
            this.avgWordLengthTextBox.Size = new System.Drawing.Size(76, 20);
            this.avgWordLengthTextBox.TabIndex = 6;
            //
            // numOfWordsTextBox
            //
            this.numOfWordsTextBox.Location = new System.Drawing.Point(404, 341);
            this.numOfWordsTextBox.Name = "numOfWordsTextBox";
            this.numOfWordsTextBox.ReadOnly = true;
            this.numOfWordsTextBox.Size = new System.Drawing.Size(76, 20);
            this.numOfWordsTextBox.TabIndex = 5;
            //
            // avgWordLengthLabel
            //
            this.avgWordLengthLabel.AutoSize = true;
            this.avgWordLengthLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgWordLengthLabel.Location = new System.Drawing.Point(231, 381);
            this.avgWordLengthLabel.Name = "avgWordLengthLabel";
            this.avgWordLengthLabel.Size = new System.Drawing.Size(167, 17);
            this.avgWordLengthLabel.TabIndex = 4;
            this.avgWordLengthLabel.Text = "Average Word Length";
            //
            // numOfWordsLabel
            //
            this.numOfWordsLabel.AutoSize = true;
            this.numOfWordsLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfWordsLabel.Location = new System.Drawing.Point(231, 343);
            this.numOfWordsLabel.Name = "numOfWordsLabel";
            this.numOfWordsLabel.Size = new System.Drawing.Size(138, 17);
            this.numOfWordsLabel.TabIndex = 3;
            this.numOfWordsLabel.Text = "Number Of Words";
            //
            // displayLabel
            //
            this.displayLabel.AutoSize = true;
            this.displayLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.Location = new System.Drawing.Point(189, 48);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(185, 24);
            this.displayLabel.TabIndex = 1;
            this.displayLabel.Text = "Display Sentence";
            //
            // sentenceTextBox
            //
            this.sentenceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sentenceTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sentenceTextBox.Location = new System.Drawing.Point(6, 75);
            this.sentenceTextBox.Name = "sentenceTextBox";
            this.sentenceTextBox.Size = new System.Drawing.Size(752, 234);
            this.sentenceTextBox.TabIndex = 0;
            this.sentenceTextBox.Text = "Please select a text file for analysis using the File menu above";
            //
            // paragraphPage
            //
            this.paragraphPage.BackColor = System.Drawing.Color.White;
            this.paragraphPage.Controls.Add(this.numSentenceTextBox);
            this.paragraphPage.Controls.Add(this.numSentencesLabel);
            this.paragraphPage.Controls.Add(this.paragraphUpDown);
            this.paragraphPage.Controls.Add(this.paragraphNextButton);
            this.paragraphPage.Controls.Add(this.paragraphPreviousButton);
            this.paragraphPage.Controls.Add(this.avgWordsTextBox);
            this.paragraphPage.Controls.Add(this.numWordsTextBox);
            this.paragraphPage.Controls.Add(this.averageWordsLabel);
            this.paragraphPage.Controls.Add(this.numWordsLabel);
            this.paragraphPage.Controls.Add(this.paragrahLabel);
            this.paragraphPage.Controls.Add(this.paragraphTextBox1);
            this.paragraphPage.Location = new System.Drawing.Point(4, 22);
            this.paragraphPage.Name = "paragraphPage";
            this.paragraphPage.Padding = new System.Windows.Forms.Padding(3);
            this.paragraphPage.Size = new System.Drawing.Size(764, 610);
            this.paragraphPage.TabIndex = 4;
            this.paragraphPage.Text = "Paragraphs";
            //
            // numSentenceTextBox
            //
            this.numSentenceTextBox.Location = new System.Drawing.Point(403, 329);
            this.numSentenceTextBox.Name = "numSentenceTextBox";
            this.numSentenceTextBox.ReadOnly = true;
            this.numSentenceTextBox.Size = new System.Drawing.Size(76, 20);
            this.numSentenceTextBox.TabIndex = 20;
            //
            // numSentencesLabel
            //
            this.numSentencesLabel.AutoSize = true;
            this.numSentencesLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSentencesLabel.Location = new System.Drawing.Point(239, 329);
            this.numSentencesLabel.Name = "numSentencesLabel";
            this.numSentencesLabel.Size = new System.Drawing.Size(165, 17);
            this.numSentencesLabel.TabIndex = 19;
            this.numSentencesLabel.Text = "Number of Sentences";
            //
            // paragraphUpDown
            //
            this.paragraphUpDown.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paragraphUpDown.ForeColor = System.Drawing.Color.Red;
            this.paragraphUpDown.Location = new System.Drawing.Point(383, 46);
            this.paragraphUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.paragraphUpDown.Name = "paragraphUpDown";
            this.paragraphUpDown.Size = new System.Drawing.Size(76, 23);
            this.paragraphUpDown.TabIndex = 18;
            this.paragraphUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.paragraphUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.paragraphUpDown.ValueChanged += new System.EventHandler(this.paragraphUpDown_ValueChanged);
            //
            // paragraphNextButton
            //
            this.paragraphNextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.paragraphNextButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paragraphNextButton.Image = ((System.Drawing.Image)(resources.GetObject("paragraphNextButton.Image")));
            this.paragraphNextButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.paragraphNextButton.Location = new System.Drawing.Point(361, 453);
            this.paragraphNextButton.Name = "paragraphNextButton";
            this.paragraphNextButton.Size = new System.Drawing.Size(118, 35);
            this.paragraphNextButton.TabIndex = 17;
            this.paragraphNextButton.Text = "Next";
            this.paragraphNextButton.UseVisualStyleBackColor = true;
            this.paragraphNextButton.Click += new System.EventHandler(this.paragraphNextButton_Click);
            //
            // paragraphPreviousButton
            //
            this.paragraphPreviousButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paragraphPreviousButton.Image = ((System.Drawing.Image)(resources.GetObject("paragraphPreviousButton.Image")));
            this.paragraphPreviousButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.paragraphPreviousButton.Location = new System.Drawing.Point(242, 453);
            this.paragraphPreviousButton.Name = "paragraphPreviousButton";
            this.paragraphPreviousButton.Size = new System.Drawing.Size(113, 35);
            this.paragraphPreviousButton.TabIndex = 16;
            this.paragraphPreviousButton.Text = "Previous";
            this.paragraphPreviousButton.UseVisualStyleBackColor = true;
            this.paragraphPreviousButton.Click += new System.EventHandler(this.paragraphPreviousButton_Click);
            //
            // avgWordsTextBox
            //
            this.avgWordsTextBox.Location = new System.Drawing.Point(403, 406);
            this.avgWordsTextBox.Name = "avgWordsTextBox";
            this.avgWordsTextBox.ReadOnly = true;
            this.avgWordsTextBox.Size = new System.Drawing.Size(76, 20);
            this.avgWordsTextBox.TabIndex = 15;
            //
            // numWordsTextBox
            //
            this.numWordsTextBox.Location = new System.Drawing.Point(403, 368);
            this.numWordsTextBox.Name = "numWordsTextBox";
            this.numWordsTextBox.ReadOnly = true;
            this.numWordsTextBox.Size = new System.Drawing.Size(76, 20);
            this.numWordsTextBox.TabIndex = 14;
            //
            // averageWordsLabel
            //
            this.averageWordsLabel.AutoSize = true;
            this.averageWordsLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageWordsLabel.Location = new System.Drawing.Point(239, 406);
            this.averageWordsLabel.Name = "averageWordsLabel";
            this.averageWordsLabel.Size = new System.Drawing.Size(121, 17);
            this.averageWordsLabel.TabIndex = 13;
            this.averageWordsLabel.Text = "Average Words";
            //
            // numWordsLabel
            //
            this.numWordsLabel.AutoSize = true;
            this.numWordsLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numWordsLabel.Location = new System.Drawing.Point(239, 368);
            this.numWordsLabel.Name = "numWordsLabel";
            this.numWordsLabel.Size = new System.Drawing.Size(138, 17);
            this.numWordsLabel.TabIndex = 12;
            this.numWordsLabel.Text = "Number Of Words";
            //
            // paragrahLabel
            //
            this.paragrahLabel.AutoSize = true;
            this.paragrahLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paragrahLabel.Location = new System.Drawing.Point(180, 46);
            this.paragrahLabel.Name = "paragrahLabel";
            this.paragrahLabel.Size = new System.Drawing.Size(197, 24);
            this.paragrahLabel.TabIndex = 11;
            this.paragrahLabel.Text = "Display Paragraph";
            //
            // paragraphTextBox1
            //
            this.paragraphTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.paragraphTextBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paragraphTextBox1.Location = new System.Drawing.Point(6, 72);
            this.paragraphTextBox1.Name = "paragraphTextBox1";
            this.paragraphTextBox1.Size = new System.Drawing.Size(752, 234);
            this.paragraphTextBox1.TabIndex = 10;
            this.paragraphTextBox1.Text = "Please select a text file for analysis using the File menu above";
            //
            // statusStrip1
            //
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoStripStatusLabel1,
            this.filelStripStatusLabel,
            this.tokenStripStatusLabel1,
            this.distinctWordsStripStatusLabel1,
            this.sentenceStripStatusLabel,
            this.paragraphStripStatusLabel,
            this.dateStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 667);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(797, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            //
            // infoStripStatusLabel1
            //
            this.infoStripStatusLabel1.Name = "infoStripStatusLabel1";
            this.infoStripStatusLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.infoStripStatusLabel1.Size = new System.Drawing.Size(347, 17);
            this.infoStripStatusLabel1.Text = "Text Analysis Toolkit built by Clayton Feathers";
            this.infoStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // filelStripStatusLabel
            //
            this.filelStripStatusLabel.Name = "filelStripStatusLabel";
            this.filelStripStatusLabel.Padding = new System.Windows.Forms.Padding(0, 0, 200, 0);
            this.filelStripStatusLabel.Size = new System.Drawing.Size(231, 17);
            this.filelStripStatusLabel.Text = "File: ";
            this.filelStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filelStripStatusLabel.Visible = false;
            //
            // tokenStripStatusLabel1
            //
            this.tokenStripStatusLabel1.Name = "tokenStripStatusLabel1";
            this.tokenStripStatusLabel1.Size = new System.Drawing.Size(47, 17);
            this.tokenStripStatusLabel1.Text = "Tokens:";
            this.tokenStripStatusLabel1.Visible = false;
            //
            // distinctWordsStripStatusLabel1
            //
            this.distinctWordsStripStatusLabel1.Name = "distinctWordsStripStatusLabel1";
            this.distinctWordsStripStatusLabel1.Size = new System.Drawing.Size(87, 17);
            this.distinctWordsStripStatusLabel1.Text = "Distinct Words:";
            this.distinctWordsStripStatusLabel1.Visible = false;
            //
            // sentenceStripStatusLabel
            //
            this.sentenceStripStatusLabel.Name = "sentenceStripStatusLabel";
            this.sentenceStripStatusLabel.Size = new System.Drawing.Size(63, 17);
            this.sentenceStripStatusLabel.Text = "Sentences:";
            this.sentenceStripStatusLabel.Visible = false;
            //
            // paragraphStripStatusLabel
            //
            this.paragraphStripStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.paragraphStripStatusLabel.Name = "paragraphStripStatusLabel";
            this.paragraphStripStatusLabel.Size = new System.Drawing.Size(69, 17);
            this.paragraphStripStatusLabel.Text = "Paragraphs:";
            this.paragraphStripStatusLabel.Visible = false;
            //
            // dateStripStatusLabel
            //
            this.dateStripStatusLabel.Name = "dateStripStatusLabel";
            this.dateStripStatusLabel.Size = new System.Drawing.Size(130, 17);
            this.dateStripStatusLabel.Text = "Tuesday, March 7, 2017";
            //
            // TextAnalysisForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(797, 689);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textOptionTab);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TextAnalysisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Analysis Toolkit";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.textOptionTab.ResumeLayout(false);
            this.originalTextPage.ResumeLayout(false);
            this.tokensPage.ResumeLayout(false);
            this.tokensPage.PerformLayout();
            this.distinctWordsPage.ResumeLayout(false);
            this.distinctWordsPage.PerformLayout();
            this.sentencesPage.ResumeLayout(false);
            this.sentencesPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sentenceUpDown)).EndInit();
            this.paragraphPage.ResumeLayout(false);
            this.paragraphPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paragraphUpDown)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabControl textOptionTab;
        private System.Windows.Forms.TabPage originalTextPage;
        private System.Windows.Forms.TabPage tokensPage;
        private System.Windows.Forms.TabPage distinctWordsPage;
        private System.Windows.Forms.TabPage sentencesPage;
        private System.Windows.Forms.TabPage paragraphPage;
        private System.Windows.Forms.RichTextBox originalTextBox;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOccurance;
        private System.Windows.Forms.Label labelToken;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.RichTextBox sentenceTextBox;
        private System.Windows.Forms.NumericUpDown sentenceUpDown;
        private System.Windows.Forms.Button sentencesNextButton;
        private System.Windows.Forms.Button sentencesPreviousButton;
        private System.Windows.Forms.TextBox avgWordLengthTextBox;
        private System.Windows.Forms.TextBox numOfWordsTextBox;
        private System.Windows.Forms.Label avgWordLengthLabel;
        private System.Windows.Forms.Label numOfWordsLabel;
        private System.Windows.Forms.NumericUpDown paragraphUpDown;
        private System.Windows.Forms.Button paragraphNextButton;
        private System.Windows.Forms.Button paragraphPreviousButton;
        private System.Windows.Forms.TextBox avgWordsTextBox;
        private System.Windows.Forms.TextBox numWordsTextBox;
        private System.Windows.Forms.Label averageWordsLabel;
        private System.Windows.Forms.Label numWordsLabel;
        private System.Windows.Forms.Label paragrahLabel;
        private System.Windows.Forms.RichTextBox paragraphTextBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel filelStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel tokenStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel distinctWordsStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel sentenceStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel paragraphStripStatusLabel;
        private System.Windows.Forms.TextBox numSentenceTextBox;
        private System.Windows.Forms.Label numSentencesLabel;
        private System.Windows.Forms.ToolStripStatusLabel infoStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel dateStripStatusLabel;
        private System.Windows.Forms.ListBox tokensBox;
        private System.Windows.Forms.ListBox wordsBox;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}
