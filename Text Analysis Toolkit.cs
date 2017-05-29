using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text
{
    public partial class TextAnalysisForm : Form
    {
        Text txtFile = null;                    //Text file gathered from the file directory
        SentenceList sentenceList = null;       //List of sentences gathered from the text file
        Words listWords = null;                 //List of words gathered from the text file
        ParagraphList paragraphList = null;     //List of paragraphs gathered from the text file

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public TextAnalysisForm()
        {
            InitializeComponent();
        }

        #region Menu Strip Items
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog object.
            OpenFileDialog openFile1 = new OpenFileDialog();

            // Initialize the filter to look for text files.
            openFile1.Title = "Please select a text file to open";
            openFile1.Filter = "Text Files|*.txt";

            // If the user selected a file, load its contents into originalTextBox
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                originalTextBox.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText);

                //set the instances based on the text read from the file the user has chose
                txtFile = new Text(openFile1.FileName);
                sentenceList = new SentenceList(txtFile);
                listWords = new Words(txtFile);
                paragraphList = new ParagraphList(txtFile);

                //For every token put it in the list
                foreach (String token in txtFile.tokenText)
                {
                    tokensBox.Items.Add(token);
                }

                //Sort the word list alphabetically
                listWords.wordList.Sort();

                //for every word in wordList add the word and the number of occurances in the proper format
                for (int i = 0; i < listWords.wordList.Count; i++)
                {

                    wordsBox.Items.Add($"  {listWords.wordList[i].word.PadRight(20)}{listWords.wordList[i].count.ToString().PadLeft(5)}");
                }

                //Don't display the info or date in the status strip
                infoStripStatusLabel1.Visible = false;
                dateStripStatusLabel.Visible = false;

                //display the file, tokens, distinct word, sentence, and paragraph count in the status strip
                filelStripStatusLabel.Visible = true;
                filelStripStatusLabel.Text = "File: " + openFile1.FileName;
                tokenStripStatusLabel1.Visible = true;
                tokenStripStatusLabel1.Text = "Token: " + txtFile.tokenText.Count;
                distinctWordsStripStatusLabel1.Visible = true;
                distinctWordsStripStatusLabel1.Text = "Distinct Words: " + listWords.wordList.Count;
                sentenceStripStatusLabel.Visible = true;
                sentenceStripStatusLabel.Text = "Sentences: " + sentenceList.numSentences;
                paragraphStripStatusLabel.Visible = true;
                paragraphStripStatusLabel.Text = "Paragraphs: " + paragraphList.numParagraphs;
            }

        }

        /// <summary>
        /// Handles the 1 event of the aboutToolStripMenuItem_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Create and display the about box that shows who created the program and important information about the program
            TextAboutBoxForm aboutBox = new TextAboutBoxForm();
            aboutBox.Show();
        }
        #endregion

        #region UpDown Event Handlers
        /// <summary>
        /// Handles the ValueChanged event of the sentenceUpDown control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void sentenceUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                //set the maximum number to be the number of sentences in the list
                sentenceUpDown.Maximum = sentenceList.numSentences;

                //get the value in the counter and offset by one to account for 0 based array
                int n = Convert.ToInt32(sentenceUpDown.Value) - 1;

                //fill the text boxes with the number of sentences, words, and average length of words
                sentenceTextBox.Text = sentenceList.sentenceList[n].ToString();
                numOfWordsTextBox.Text = sentenceList.sentenceList[n].numOfWords.ToString();
                avgWordLengthTextBox.Text = sentenceList.sentenceList[n].avgLengthOfWords.ToString();
            }
            catch
            {
                //don't do anything
            }

        }

        /// <summary>
        /// Handles the Click event of the sentencesNextButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void sentencesNextButton_Click(object sender, EventArgs e)
        {
            //if the value in the sentences counter is less than the maximum sentences
            if ((sentenceUpDown.Value + 1) <= sentenceList.numSentences && txtFile != null)
            {
                //increment value by 1
                sentenceUpDown.Value++;
            }
        }

        /// <summary>
        /// Handles the Click event of the sentencesPreviousButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void sentencesPreviousButton_Click(object sender, EventArgs e)
        {
            //if the value in the sentence counter is greater than 0
            if ((sentenceUpDown.Value - 1) > 0 && txtFile != null)
            {
                //decrement value by 1
                sentenceUpDown.Value--;
            }
        }

        /// <summary>
        /// Handles the ValueChanged event of the paragraphUpDown control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void paragraphUpDown_ValueChanged(object sender, EventArgs e)
        {

            try
            {

                //set maximum value of paragraph counter to be the number of paragraphs in list
                paragraphUpDown.Maximum = paragraphList.numParagraphs;

                //get the value in the counter and offset by one to account for 0 based array
                int n = Convert.ToInt32(paragraphUpDown.Value) - 1;

                //fill the text boxes with the paragraph text number of sentences, words, and average words per sentence
                paragraphTextBox1.Text = paragraphList.paragraphList[n].ToString();
                numSentenceTextBox.Text = paragraphList.paragraphList[n].numSentences.ToString();
                numWordsTextBox.Text = paragraphList.paragraphList[n].numWords.ToString();
                avgWordsTextBox.Text = paragraphList.paragraphList[n].avgWordsPerSentence.ToString();

            }
            catch
            {
                //don't do anything
            }
        }

        /// <summary>
        /// Handles the Click event of the paragraphNextButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void paragraphNextButton_Click(object sender, EventArgs e)
        {
            //if the paragraph counter is below the number of paragraphs in the list
            if ((paragraphUpDown.Value + 1) <= paragraphList.numParagraphs && txtFile != null)
            {
                //increment counter by one
                paragraphUpDown.Value++;
            }

        }

        /// <summary>
        /// Handles the Click event of the paragraphPreviousButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void paragraphPreviousButton_Click(object sender, EventArgs e)
        {
            //if the paragraph counter is above 0
            if ((paragraphUpDown.Value - 1) > 0 && txtFile != null)
            {
                //decrement by one
                paragraphUpDown.Value--;
            }
        }
#endregion


    }
}
