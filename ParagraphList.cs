//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Text Analysis
//	File Name:		ParagraphList.cs
//	Description:	This class uses the paragraph class to gather all the paragraphs in a certain text document. It will
//                  then calculate the average sentence count per paragraph and how mamy paragraphs are in the text
//                  document.
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
    /// This class uses the paragraph class to gather all the paragraphs in a certain text document. It will then calculate the average
    /// sentence count per paragraph and how mamy paragraphs are in the text
    /// </summary>
    class ParagraphList
    {
        /// <summary>
        /// Gets the list of paragraphes.
        /// </summary>
        /// <value>
        /// The list of paragraphes.
        /// </value>
        public List<Paragraph> paragraphList { get; private set; }

        /// <summary>
        /// Gets the number of paragraphs.
        /// </summary>
        /// <value>
        /// The number of paragraphs.
        /// </value>
        public int numParagraphs { get; private set; }

        /// <summary>
        /// Gets the average words per paragraph.
        /// </summary>
        /// <value>
        /// The average words per paragraph.
        /// </value>
        public int avgWordsPerParagraph { get; private set; }

        /// <summary>
        /// The text file used
        /// </summary>
        private Text usedText;

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="ParagraphList"/> class.
        /// </summary>
        public ParagraphList()
        {
            //Set the list of paragraphes to be empty
            paragraphList = new List<Paragraph>();

            //Set the number of paragraphes to be the count of the list, should be 0
            numParagraphs = paragraphList.Count;

            //Set the avgWordsPerParagraph to be 0
            avgWordsPerParagraph = 0;

            //usedText should be null
            usedText = null;
        }

        /// <summary>
        /// Parameter Constructor that initializes a new instance of the <see cref="ParagraphList"/> class.
        /// </summary>
        /// <param name="textFile">A text file.</param>
        public ParagraphList(Text textFile)
        {
            //set paragraphList
            this.paragraphList = new List<Paragraph>();


            int firstToken = 0;
            while (firstToken < textFile.tokenText.Count)
            {
                //Create an instance of a paragraph at the token location and add it to the list of paragraphes
                Paragraph paragraph = new Paragraph(textFile, firstToken);
                paragraphList.Add(paragraph);

                //set firstToken to the subscript 1 greater than the lastToken
                firstToken = paragraph.lastToken + 1;
            }

            //set numParagraphs
            this.numParagraphs = paragraphList.Count;

            //set avgWordsPerParagraph
            int totalWords = 0;
            for (int i = 0; i < paragraphList.Count; i++)
            {
                //add the number of words in the paragraph to the totalWords
                totalWords += paragraphList[i].numWords;
            }

            this.avgWordsPerParagraph = totalWords / numParagraphs;

            //set usedText
             this. usedText = textFile;
        }
        #endregion

        #region ToString
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents a list of paragraphs and their properties.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that representsa list of paragraphs and their properties.
        /// </returns>
        public override string ToString()
        {
            string content = "Paragraphs found in the text: \n";

            int count = 1;

            //for each paragraph in the list of paragraphes
            foreach (Paragraph paragraph in paragraphList)
            {
                //add where the paragraph is positioned in relevance to the other paragraphes
                content += $"\nParagraph {count}.";

                //add paragraph string
                content += $"\n\n{paragraph}\n";

                //increment count by one
                count++;
            }

            //add the number of paragraphes and the average number of words in the paragraph
            content += $"\n\n\n\tThere are {this.numParagraphs} paragraphs. The average number of words in the pragraphs is {this.avgWordsPerParagraph}.";

            return content;
        }
        #endregion

    }
}
