//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 1 - Text Analysis
//	File Name:		Words.cs
//	Description:	This class uses the DistinctWord class to hold the DistinctWord objects for proper display to 
//                  console.
//	Course:			CSCI 2210-001 - Data Structures
//	Author:			Clayton Feathers, feathersct@etsu.edu, Computer Science Student, East Tennessee State University
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

namespace Project2
{
    /// <summary>
    /// The class contains a list of DistinctWords and the number of words and can display them alphabetically
    /// </summary>
    class Words
    {

        /// <summary>
        /// Gets the list of words.
        /// </summary>
        /// <value>
        /// The list of words.
        /// </value>
        public List<DistinctWord> wordList { get; private set; }

        /// <summary>
        /// Gets or sets the number of words.
        /// </summary>
        /// <value>
        /// The number of words.
        /// </value>
        private int numOfWords { get; set; }

        /// <summary>
        /// Gets the text file.
        /// </summary>
        /// <value>
        /// The text file.
        /// </value>
        public Text txtFile { get; private set; }

        #region Constructures
        /// <summary>
        /// Initializes a new instance of the <see cref="Words"/> class.
        /// </summary>
        public Words()
        {
            //set the wordList to an empty list
            wordList = new List<DistinctWord>();

            //set the number of words to the count of wordList which should be 0
            numOfWords = wordList.Count;
        }

        /// <summary>
        /// Parameterized Constructor, Initializes a new instance of the <see cref="Words"/> class.
        /// </summary>
        /// <param name="text">A text object</param>
        public Words(Text text)
        {
            //set the wordList to an empty list
            wordList = new List<DistinctWord>();

            //for every word in the text that is a word or digit and isnt already in the list, add it to the list
            for(int i = 0; i < text.tokenText.Count; i++)
            {
                if (Regex.IsMatch(text.tokenText[i], @"\w") && !EqualADistinctWord(text.tokenText[i]))
                {
                    wordList.Add(new DistinctWord(text.tokenText[i], text));
                }
            }

            //set the number of words to the count of the built wordList
            numOfWords = wordList.Count;

            //set text file used
            txtFile = text;
        }
        #endregion

        #region Helper Methods
        /// <summary>
        /// Checks to see if a certain string equals a DistinctWord object in the existing word list.
        /// </summary>
        /// <param name="word">A string to compare</param>
        /// <returns>true if there is a word the same as the parameter; otherwise false</returns>
        private bool EqualADistinctWord(string word)
        {
            bool result = false;

            //for every word in the list check to see if it matches any words in the list
            //if so return true, if not then return false
            for(int i = 0; i < wordList.Count; i++)
            {
                if(word.ToLower().Equals(wordList[i].word.ToLower()))
                {
                    result = true;
                }
            }

            return result;
        }
        #endregion

        #region Display Methods
        /// <summary>
        /// Displays the contents of wordList alphabetically.
        /// </summary>
        /// <returns>string containing contents of wordList</returns>
        public string DisplayAlphabetically()
        {
            //the string that will be returned with the header that will display what is in what
            //column using the string format method
            string result = string.Format("\n\n\t{0,-20}  {1,-20}", "Word", "Count" +
                                            "\n\t--------            ---------\n");
            int n = 1;

            //for every word in the list min is i
            for (int i = 0; i < wordList.Count - 1; ++i)
            {
                int min = i;
                
                //for word j in the list compare to i
                for (int j = i + 1; j < wordList.Count; ++j)
                {
                    //if word j is smaller than i then the min is now j
                    if (wordList[j].CompareTo(wordList[min]) < 0)
                    {
                        min = j;
                    }
                }
                
                //temporary DistinctWord
                DistinctWord temp = wordList[i];

                //add word to wordList
                wordList[i] = wordList[min];
                wordList[min] = temp;
            }

            //format the words for display
            foreach(DistinctWord word in wordList)
            {
                result += "\n\t" + n + ". " + word;
                n++;
            }

            return result;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents a list of words.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents a list of words.
        /// </returns>
        public override string ToString()
        {
            string result = "";

            //foreach word in the wordList add it to the string that will be returned
            foreach(DistinctWord word in wordList)
            {
                result += "\n" + word.ToString();
            }

            return result;
        }
        #endregion
    }
}
