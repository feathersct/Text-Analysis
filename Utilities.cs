//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:		Utils/Project 1 - Text Analysis
//	File Name:		        Utilities.cs
//	Description:	        A set of static methods that can be used to make the driver of a project look cleaner
//	Course:			        CSCI 2210-001 - Data Structures
//	Author:			        Clayton Feathers, feathersct@etsu.edu, Computer Science Student, East Tennessee State University
//	Created:		        Thursday, February 9, 2017
//	Copyright:		        Clayton Feathers, 2017
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Utils
{
    /// <summary>
    /// This class holds static methods that can help the Main method 
    /// </summary>
    public class Utilities
    {
        #region GoodBye Message
        /// <summary>
        /// The Goodbye message.
        /// </summary>
        /// <param name="message">The message.</param>
        public static void GoodbyeMessage(string message = "Thank you for using this program. Goodbye.")
        {
            //Cleare the screen
            Console.Clear();

            //Display the Goodbye message to the user
            Console.WriteLine("\t" + message);
        }
        #endregion

        #region Welcome Message
        /// <summary>
        /// The Welcome message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="course">The course.</param>
        /// <param name="author">The author.</param>
        public static void WelcomeMessage(string message, string description, string course = "CSCI 2210-002", string author = "Clayton Feathers")
        {
            //Clear the screen
            Console.Clear();

            //Display the welcome message
            Console.WriteLine("\t" + message);

            //Display the description
            Console.WriteLine("\t\n" + FormatText(description, 8, 60) + "\n");

            //Display the author and course
            Console.WriteLine($"\tAuthor: {author} \n\tCourse: {course}");
        }
        #endregion

        #region Tokenizer
        /// <summary>
        /// Tokenizes the specified string
        /// </summary>
        /// <param name="text">The string.</param>
        /// <param name="delimators">The delimators.</param>
        /// <returns>A List of all the tokens</returns>
        public static List<string> Tokenize(string text, string delimators = @"(\s+|[%-&]|[(-/]|[:-?])")
        {
            string[] token = Regex.Split(text, delimators);

            List<string> tokenList = new List<string>();

            for(int i = 0; i < token.Length; i++)
            {
                if (!token[i].Contains(" ") && !(token[i] == ""))
                {
                    tokenList.Add(token[i]);
                }
                
            }

            return tokenList;
        }
        #endregion

        #region Format Text
        /// <summary>
        /// Formats a string
        /// </summary>
        /// <param name="txt">The text</param>
        /// <param name="leftMargin">The left margin</param>
        /// <param name="rightMargin">The right margin</param>
        /// <returns>String variable that has the margins introduced</returns>
        public static string FormatText(string txt, int leftMargin = 0, int rightMargin = 80)
        {
            List<string> tokenList = Tokenize(txt); //set a list of strings with the tokens in it
            string leftMarginString = "";           //the string that will be put infront of the first word on the new line
            string formattedTxt;                    //the formatted string with the margins
            int count = 0;                          //count to be used for the leftMarginString
            int columnSize = 0;                     //the number of characters in the column
            string punctuationPattern= @"[!\%&()*+,\-./:;<=>?@\[\\\]^_`{|}~]";

            //while the count is less than the number of spaces for the wanted left margin
            while(count < leftMargin)
            {
                //add a space to the string
                leftMarginString += " ";

                //add one to count
                count++;
            }

            //the first line has the tabed margin and the first token
            formattedTxt = leftMarginString + tokenList[0];

            //for every token
            for (int i = 1; i < tokenList.Count; i++)
            {

                //if the columnSize is less than the rightMargin number and number of characters in the next word 
                //is less than rightMargin
                if ((columnSize < rightMargin) && ((tokenList[i].Length + columnSize) < rightMargin))
                {
                    //the token is a punctuation 
                    if(Regex.Match(tokenList[i], punctuationPattern).Success)
                    {
                        //add the token to the formatted text with out a space
                        formattedTxt += tokenList[i];

                        //increment the column size
                        columnSize += tokenList[i].Length;
                    }
                    else
                    {
                        //add the word to the formatted text with a space
                        formattedTxt += " " + tokenList[i];

                        //increment the column size accounting for the space
                        columnSize += tokenList[i].Length + 1;
                    }
                    
                }
                else
                {
                    //create a new line and add the leftMarginString and the current token
                    formattedTxt += "\n" + leftMarginString + tokenList[i];

                    //increment columnSize accounting for the leftMargin and the token length
                    columnSize = leftMargin + tokenList[i].Length;
                }
                    

            }

            return formattedTxt; 
        }
        #endregion

        #region PressAnykey
        /// <summary>
        /// Makes the program stop and wait on user interaction.
        /// </summary>
        /// <param name="txt">Message to display</param>
        public static void PressAnyKey(string txt = "Press enter to continue...")
        {
            //Display the text
            Console.Write(txt);

            //Continue when user has pressed a key
            Console.ReadKey();
        }

        #endregion

        #region Skip
        /// <summary>
        /// Skips the specified number of lines.
        /// </summary>
        /// <param name="i">The number of lines</param>
        public static void Skip(int i = 1)
        {
            //create a new line for the parameter
            for(int n = 0; n<i; n++)
            {
                Console.WriteLine("\n");
            }
        }
        #endregion

        #region Valid Email Address
        /// <summary>
        /// Determines whether a string is a valid email address.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>
        ///   <c>true</c> if valid email; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsValidEmailAddress(string s)
        {
            //compare the string to this regex for a valid email address
            Regex regex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");

            return regex.IsMatch(s);
        }
        #endregion

        #region Valid Phone Number
        /// <summary>
        /// Determines whether a string is a valid email address.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>
        ///   <c>true</c> if valid email; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsValidPhoneNumber(string s)
        {
            //compare the string to this regex for a valid phone number
            var regex = new Regex(@"^(?:\([2-9]\d{2}\)\ ?|[2-9]\d{2}(?:\-?|\ ?))[2-9]\d{2}[- ]?\d{4}$");
            return regex.IsMatch(s);
        }
        #endregion
    }
}
