//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 1 - Text Analysis
//	File Name:		Text.cs
//	Description:	Takes a text document and can store in a string for original display or parse out to multiple 
//                  tokens where they can be used to process the text document.
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
using System.Threading.Tasks;
using Utils;
using System.Windows.Forms;
using System.IO;

namespace Project2
{
    /// <summary>
    /// Takes a text document and can store in a string for original display or parse out to multiple tokens where they can be used to process the text document.
    /// </summary>
    class Text
    {
        /// <summary>
        /// Gets the original text.
        /// </summary>
        /// <value>
        /// The original text.
        /// </value>
        public string originalText { get; private set; }

        /// <summary>
        /// Gets the list of tokens.
        /// </summary>
        /// <value>
        /// The list of tokens.
        /// </value>
        public List<string> tokenText { get; private set; }
        
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Text"/> class.
        /// </summary>
        public Text()
        {
            //set the original text to nothing
            this.originalText = "";

            //create an empty instance of a List of strings
            this.tokenText = new List<string>();
        }

        /// <summary>
        /// Parameterized Constructor that initializes a new instance of the <see cref="Text"/> class.
        /// </summary>
        /// <param name="filePath">The path to the text file.</param>
        public Text(string filePath)
        {
            //Read the text file and put into originalText variable
            originalText = File.ReadAllText(filePath);

            //tokenize originalText
            tokenText = Utilities.Tokenize(originalText);
        }
        #endregion

        #region Display Methods
        /// <summary>
        /// Displays the original text.
        /// </summary>
        /// <returns>The string that was originally input from text file.</returns>
        public string DisplayOriginalText()
        {
            return originalText;
        }

        /// <summary>
        /// Displays the formatted text from the file.
        /// </summary>
        /// <returns>The string that holds the formatted text.</returns>
        public string DisplayFormatText()
        {
            return Utilities.FormatText(originalText, 10, 70);
        }

        /// <summary>
        /// Displays the tokens.
        /// </summary>
        /// <returns></returns>
        public string DisplayTokens()
        {
            string content = "";

            //for each token add to content
            foreach(string token in tokenText)
            {
                content += $"\n{token}";
            }

            return content;

        }
        #endregion
    }
}
