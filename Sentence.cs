//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Text Analysis
//	File Name:		Sentence.cs
//	Description:	This class takes a text document and can find all the sentences in it. It can then be used for
//                  several other classes as needed.
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
    /// This class takes a text document and can find all the sentences in it. It can then be used for several other classes as needed.
    /// </summary>
    class Sentence
    {
        /// <summary>
        /// Gets the number of words.
        /// </summary>
        /// <value>
        /// The number of words.
        /// </value>
        public int numOfWords { get; private set; }

        /// <summary>
        /// Gets the average length of words.
        /// </summary>
        /// <value>
        /// The average length of words.
        /// </value>
        public int avgLengthOfWords { get; private set; }

        /// <summary>
        /// Gets the first word subscript.
        /// </summary>
        /// <value>
        /// The first word subscript.
        /// </value>
        public int firstWordSub { get; private set; }

        /// <summary>
        /// Gets the last word subscript.
        /// </summary>
        /// <value>
        /// The last word subscript.
        /// </value>
        public int lastWordSub { get; private set; }

        /// <summary>
        /// The text used
        /// </summary>
        public Text usedText = null;

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Sentence"/> class.
        /// </summary>
        public Sentence()
        {
            //set all the properties to 0
            this.numOfWords = 0;
            this.avgLengthOfWords = 0;
            this.firstWordSub = 0;
            this.lastWordSub = 0;
        }

        /// <summary>
        /// Parameterized Constructs that initializes a new instance of the <see cref="Sentence"/> class.
        /// </summary>
        /// <param name="text">A text document.</param>
        /// <param name="firstSub">The subscript of the first word in the sentence.</param>
        public Sentence(Text text, int firstSub)
        {
            //set firstWordSub to equal the parameterized value
            this.firstWordSub = firstSub;

            //whether to loop or not
            bool loop = true;

            //finding the lastWordSub
            while (loop)
            {
                //if the tokenText at firstSub is a match, else if 1 + firstSub is equal to the count of tokenText, else increment firstSub by 1
                if (Regex.IsMatch(text.tokenText[firstSub], @"[.!?]"))
                {
                    //set lastWordSub to equal firstSub and don't loop again
                    this.lastWordSub = firstSub;
                    loop = false;
                }
                else if ((firstSub+1) == text.tokenText.Count)
                {
                    //set lastWordSub to equal the count of the tokens minus 1 and don't loop again
                    loop = false;
                    this.lastWordSub = text.tokenText.Count - 1;
                }
                else
                    firstSub++;
            }



            //set numOfWords
            this.numOfWords = 0;

            for(int i = firstWordSub; i < lastWordSub+1; i++)
            {
                //if the token matches a word or digit then increment numOfWords by 1
                if(Regex.IsMatch(text.tokenText[i], @"\w"))
                {
                    this.numOfWords++;
                }
            }



            //set avgLengthOfWords
            int numTotalChar = 0;       //total number of characters in the sentence

            for (int i = firstWordSub; i < lastWordSub; i++)
            {
                //if the token matches a word or digit the numTotalChar increments by the length of the current token
                if (Regex.IsMatch(text.tokenText[i], @"\w"))
                {
                    numTotalChar += text.tokenText[i].Length;
                }
            }

            this.avgLengthOfWords = numTotalChar / this.numOfWords; //divide number of characters by number of words

            //set text for toString
            usedText = text;

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
            string content = "";

            for (int i = firstWordSub; i < lastWordSub + 1; i++)
            {
                //add the token with a space in front of it
                content += " " + usedText.tokenText[i];
            }

            return content;
        }
        #endregion

    }
}
