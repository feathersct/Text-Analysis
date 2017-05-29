//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Text Analysis
//	File Name:		Paragraph.cs
//	Description:	This class takes a text document and can find all the paragraphs in it. It can then be used for
//                  several other classes as needed
//	Author:			Clayton Feathers
//	Created:		Thursday, February 9, 2017
//	Copyright:		Clayton Feathers, 2017
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Utils;

namespace Text
{
    /// <summary>
    /// This class takes a text document and can find all the paragraphs in it. It can then be used for several other classes as needed.
    /// </summary>
    class Paragraph
    {
        /// <summary>
        /// Gets the number of sentences.
        /// </summary>
        /// <value>
        /// The number of sentences.
        /// </value>
        public int numSentences { get; private set; }

        /// <summary>
        /// Gets the number of words.
        /// </summary>
        /// <value>
        /// The number of words.
        /// </value>
        public int numWords { get; private set; }

        /// <summary>
        /// Gets the average words per sentence.
        /// </summary>
        /// <value>
        /// The average words per sentence.
        /// </value>
        public int avgWordsPerSentence { get; private set; }

        /// <summary>
        /// Gets the first token.
        /// </summary>
        /// <value>
        /// The first token.
        /// </value>
        public int firstToken { get; private set; }

        /// <summary>
        /// Gets the last token.
        /// </summary>
        /// <value>
        /// The last token.
        /// </value>
        public int lastToken { get; private set; }

        /// <summary>
        /// The text used
        /// </summary>
        private Text usedText = null;

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Paragraph"/> class.
        /// </summary>
        public Paragraph()
        {
            //set all properties value to 0
            this.numSentences = 0;
            this.numWords = 0;
            this.avgWordsPerSentence = 0;
            this.firstToken = 0;
            this.lastToken = 0;
        }

        /// <summary>
        /// Parameterized Constructor that initializes a new instance of the <see cref="Paragraph"/> class.
        /// </summary>
        /// <param name="textFile">The text file.</param>
        /// <param name="firstWord">The first word.</param>
        public Paragraph(Text textFile, int firstWord)
        {
            this.firstToken = firstWord;

            //set lastToken
            bool cont = true;
            while (cont)
            {
                //if the token is a 2 new line or return characters, else if its at the end of the list, else increment firstWord by 1
                if (Regex.IsMatch(textFile.tokenText[firstWord], @"(\n|\r|\r\n)"))
                {
                    //lastToken equals the firstWord
                    this.lastToken = firstWord;

                    //do not loop again
                    cont = false;
                }
                else if ((firstWord + 1) == textFile.tokenText.Count)
                {
                    //do not loop again
                    cont = false;
                    //lastToken equals the number of tokens minus 1
                    this.lastToken = textFile.tokenText.Count - 1;
                }
                else
                    firstWord++;
            }

            //set number of sentences
            this.numSentences = 0;

            for (int i = firstToken; i < lastToken + 1; i++)
            {
                //if the token matches an end of sentence punctuation mark
                if (Regex.IsMatch(textFile.tokenText[i], @"[.!?]"))
                {
                    //increment number of sentences by 1
                    this.numSentences++;
                }
            }


            //set number of words
            this.numWords = 0;

            for (int i = firstToken; i < lastToken + 1; i++)
            {
                //if the current token matches a digit or word
                if (Regex.IsMatch(textFile.tokenText[i], @"\w"))
                {
                    //increment numWords by 1
                    this.numWords++;
                }
            }

            //set average words per sentence
            this.avgWordsPerSentence = this.numWords / this.numSentences;

            //set text file
            usedText = textFile;

        }
        #endregion

        #region ToString Method
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            string content = "";

            //for all the tokens in the paragraph
            for (int i = firstToken; i < lastToken + 1; i++)
            {
                //add the current token to content
                content += " " + usedText.tokenText[i];
            }

            return content;
        }
        #endregion

    }
}
