//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Text Analysis
//	File Name:		SentenceList.cs
//	Description:	This class uses the sentence class to gather all the sentences in a certain text document. It will
//                  then calculate how many words are in each sentence and how mamy sentences are in the text document.
//	Author:			Clayton Feathers
//	Created:		Thursday, February 9, 2017
//	Copyright:		Clayton Feathers, 2017
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    /// <summary>
    /// This class uses the sentence class to gather all the sentences in a certain text document. It will then calculate how many
    /// words are in each sentence and how mamy sentences are in the text document.
    /// </summary>
    class SentenceList
    {
        /// <summary>
        /// Gets the list of sentences.
        /// </summary>
        /// <value>
        /// The list of sentences.
        /// </value>
        public List<Sentence> sentenceList { get; private set; }

        /// <summary>
        /// Gets the number of sentences.
        /// </summary>
        /// <value>
        /// The number of sentences.
        /// </value>
        public int numSentences { get; private set; }

        /// <summary>
        /// Gets the average number of words on each sentence.
        /// </summary>
        /// <value>
        /// The average number of words.
        /// </value>
        public int avgWords { get; private set; }

        /// <summary>
        /// The text used
        /// </summary>
        private Text usedText = null;

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="SentenceList"/> class.
        /// </summary>
        public SentenceList()
        {
            //Sets the list of sentences to an empty list
            this.sentenceList = new List<Sentence>();

            //Sets the number of sentences in the list, should be 0
            this.numSentences = sentenceList.Count;

            //Sets average number of words to 0
            this.avgWords = 0;

        }

        /// <summary>
        /// Parameter Constructor that initializes a new instance of the <see cref="SentenceList"/> class.
        /// </summary>
        /// <param name="textFile">A text file.</param>
        public SentenceList(Text textFile)
        {
            //set sentence list
            this.sentenceList = new List<Sentence>();


            int firstToken = 0;
            while (firstToken < textFile.tokenText.Count)
            {
                //create a new sentence and add it to the sentence list
                Sentence sentence = new Sentence(textFile, firstToken);
                sentenceList.Add(sentence);

                //get subscript for the last word of the sentence and add 1 to get the next token
                firstToken = sentence.lastWordSub + 1;
            }

            //set number of sentences
            this.numSentences = sentenceList.Count;

            //set average number of words per sentence
            int totalWords = 0;
            for(int i = 0; i < sentenceList.Count; i++)
            {
                totalWords += sentenceList[i].numOfWords;
            }

            this.avgWords = totalWords / numSentences;

            //set used text file for toString
            usedText = textFile;
        }
        #endregion

        #region ToString
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            string content = "Sentences found in the text: \n";

            int count = 1;

            //for each sentence in sentence list add the count and sentence to the content to display
            foreach(Sentence sentence in sentenceList)
            {
                content += $"\nSentence {count}.";
                content += $"\n\n{sentence}\n";
                count++;
            }

            //Add how many sentences there are and the average number of characters in the words
            content += $"\n\n\n\tThere are {this.numSentences} sentences with an average length of {this.avgWords} words.";

            return content;
        }
        #endregion
    }
}
