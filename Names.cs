//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Text Analysis
//	File Name:		Names.cs
//	Description:	Controls all the parts of a name and can display them by first or last name
//	Author:			Clayton Feathers
//	Created:		Thursday, January 26, 2017
//	Copyright:		Clayton Feathers, 2017
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Text
{
    /// <summary>
    /// This class contains properties of a full name and methods that will construct the names and display them in a certain format
    /// </summary>
    public class Names
    {
        //The array to check and see if there is a prefix
        string[] prefixArray = { "MR.", "MRS.", "MR", "MRS", "MS", "MS.", "MISS", "DR.", "DR"};

        //The array to check and see if there is a suffix
        string[] suffixArray = { "SR", "SR.", "JR.", "JR", "III", "MD", "JD", "PHD" };

        /// <summary>
        /// This property represents the prefix for a full name such as Mr, Mrs, Dr., etc.
        /// </summary>
        /// <value>
        /// The string variable for prefix
        /// </value>
        public string prefix { get; set; }

        /// <summary>
        /// This property represents the first name for a full name
        /// </summary>
        /// <value>
        /// The string variable for a first name
        /// </value>
        public string firstName { get; set; }

        /// <summary>
        /// This property represents the first middle name for a full name
        /// </summary>
        /// <value>
        /// The string variable for the first middle name
        /// </value>
        public string firstMiddleName { get; set; }

        /// <summary>
        /// This property represents the second middle name for a full name
        /// </summary>
        /// <value>
        /// The string variable for the second middle name
        /// </value>
        public string secondMiddleName { get; set; }

        /// <summary>
        /// This property represents the last name for a full name
        /// </summary>
        /// <value>
        /// The string variable for the last name
        /// </value>
        public string lastName { get; set; }

        /// <summary>
        /// This property represents the suffix for a full name, for example Jr, Sr, MD, PhD, etc.
        /// </summary>
        /// <value>
        /// The string variable for suffix
        /// </value>
        public string suffix { get; set; }



        /// <summary>
        /// Constructor, Initializes a new instance of the <see cref="Names"/> class.
        /// </summary>
        public Names()
        {

            //Sets all the properties to empty
            prefix = "";
            firstName = "";
            firstMiddleName = "";
            secondMiddleName = "";
            lastName = "";
            suffix = "";
        }



        /// <summary>
        /// Copy Constructor, Initializes a new instance of the <see cref="Names"/> class.
        /// </summary>
        /// <param name="name">Another instance of the names class</param>
        public Names(Names name)
        {
            //Copies the properties of another name to this name
            this.prefix = name.prefix;
            this.firstName = name.firstName;
            this.firstMiddleName = name.firstMiddleName;
            this.secondMiddleName = name.secondMiddleName;
            this.lastName = name.lastName;
            this.suffix = name.suffix;

        }



        /// <summary>
        /// Parameterized Constructor, Initializes a new instance of the <see cref="Names"/> class.
        /// </summary>
        /// <param name="name">The user's input</param>
        public Names(string name)
        {
            //Split name into parts
            string[] split = Regex.Split(name, @"\s+");

            //How many words are in the string
            int numSpaces = split.Length;

            //Check to see if there are multiple commas
            bool multipleCommas = name.IndexOf(",") != name.LastIndexOf(",");

            //Check to see if there is a comma in the string
            bool comma = name.Contains(",");

            //Check to see if there is a prefix in the string
            bool prefixCheck = CheckForPrefix(name);

            //Check to see if there is a suffix in the string
            bool suffixCheck = CheckForSuffix(name);

            //Switch statment with number of spaces in the name
            switch (numSpaces)
            {
                case 2:
                    //If there is a comma
                    if (comma)
                    {
                        //user typed last, first
                        this.lastName = FormatName(split[0]);
                        this.firstName = FormatName(split[1]);

                    }
                    //If there is no comma
                    else
                    {
                        //user typed first, last
                        this.firstName = FormatName(split[0]);
                        this.lastName = FormatName(split[1]);

                    }
                    break;



                case 3:
                    if (comma)
                    {
                        //If there is a suffix
                        if(suffixCheck)
                        {
                            //If there is multiple commas
                            if(multipleCommas)
                            {
                                //user typed last, first, suffix
                                this.lastName = FormatName(split[0]);
                                this.firstName = FormatName(split[1]);
                                this.suffix = split[2];
                            }
                            //If there is not multiple commas
                            else
                            {
                                //user typed first, last, suffix
                                this.firstName = FormatName(split[0]);
                                this.lastName = FormatName(split[1]);
                                this.suffix = split[2];
                            }
                        }
                        //If there is not a suffix
                        else
                        {
                            //user typed last, first, middle
                            this.lastName = FormatName(split[0]);
                            this.firstName = FormatName(split[1]);
                            this.firstMiddleName = FormatName(split[2]);
                        }

                    }

                    //If no comma
                    else
                    {
                        //if there is a prefix
                        if (prefixCheck)
                        {
                            //user typed prefix, first, last
                            this.prefix = FormatName(split[0]);
                            this.firstName = FormatName(split[1]);
                            this.lastName = FormatName(split[2]);

                        }
                        //if there is no prefix
                        else
                        {
                            //user typed first, middle, last
                            this.firstName = FormatName(split[0]);
                            this.firstMiddleName = FormatName(split[1]);
                            this.lastName = FormatName(split[2]);

                        }
                    }
                    break;



                case 4:
                    if (comma)
                    {
                        //if multiple commas
                        if(multipleCommas)
                        {
                            //user typed Last, first, middle, suffix
                            this.lastName = FormatName(split[0]);
                            this.firstName = FormatName(split[1]);
                            this.firstMiddleName = FormatName(split[2]);
                            this.suffix = split[3];
                        }
                        //if single comma
                        else
                        {
                            //if suffix
                            if(suffixCheck)
                            {
                                //user typed first, middle, last, suffix
                                this.lastName = FormatName(split[2]);
                                this.firstName = FormatName(split[0]);
                                this.firstMiddleName = FormatName(split[1]);
                                this.suffix = split[3];
                            }
                            //if no suffix
                            else
                            {
                                //if prefix
                                if(prefixCheck)
                                {
                                    //user typed last, prefix, first, middle
                                    this.prefix = FormatName(split[1]);
                                    this.lastName = FormatName(split[0]);
                                    this.firstName = FormatName(split[2]);
                                    this.firstMiddleName = FormatName(split[3]);
                                }
                                //if no prefix
                                else
                                {
                                    //user typed last, first, middle, middle
                                    this.lastName = FormatName(split[0]);
                                    this.firstName = FormatName(split[1]);
                                    this.firstMiddleName = FormatName(split[2]);
                                    this.secondMiddleName = FormatName(split[3]);
                                }
                            }
                        }
                    }
                    //if no comma
                    else
                    {
                        //if prefix
                        if(prefixCheck)
                        {
                            //user typed prefix, first, middle, last
                            this.prefix = FormatName(split[0]);
                            this.lastName = FormatName(split[3]);
                            this.firstName = FormatName(split[1]);
                            this.firstMiddleName = FormatName(split[2]);
                        }
                        //if no prefix
                        else
                        {
                            //user typed first, middle, middle, last
                            this.lastName = FormatName(split[3]);
                            this.firstName = FormatName(split[0]);
                            this.firstMiddleName = FormatName(split[1]);
                            this.secondMiddleName = FormatName(split[2]);
                        }
                    }
                    break;
            }
        }


        /// <summary>
        /// Helper method for the parameterized constructor. Checks for a suffix in a string
        /// </summary>
        /// <param name="name">The user's input</param>
        /// <returns>Returns if there is a suffix or not</returns>
        bool CheckForSuffix(string name)
        {
            bool result = false;    //the result, default is false
            int i = 0;              //the counter


            //while there is not a suffix and the array has not ended continue loop
            while(result == false && i < suffixArray.Length)
            {
                //if the string contains a suffix set result to true
                if(name.ToUpper().Contains(suffixArray[i]))
                {
                    result = true;  //result is now true
                }

                i++;    //increment by one
            }

            return result;      //return true if there is a suffix and false otherwise
        }



        /// <summary>
        /// Helper method for the parameterized constructor. Checks for prefix in a string
        /// </summary>
        /// <param name="name">The user's input.</param>
        /// <returns>Returns if there is a prefix or not</returns>
        bool CheckForPrefix(string name)
        {
            bool result = false;    //the result, default is false
            int i = 0;              //the counter


            //while there is not a prefix and the array has not ended continue loop
            while (result == false && i < prefixArray.Length)
            {
                //if the string contains a prefix set result to true
                if (name.ToUpper().Contains(prefixArray[i]))
                {
                    result = true;  //result is now true
                }

                i++;    //increment by one
            }


            return result;      //return true if there is a prefix and false otherwise
        }



        /// <summary>
        /// Formats the name to have the first character be capitalized and the rest lowercase
        /// </summary>
        /// <param name="s">The name that wants to be formatted</param>
        /// <returns>Returns the string formatted</returns>
        string FormatName(string s)
        {
            //set the first letter of the name to capital and the rest lowercase
            string name = char.ToUpper(s[0]) + s.Substring(1).ToLower();

            //Check to see if there is a comma in the string
            bool comma = s.Contains(",");

            //if there is a comma get rid of it, else return the formated name
            if (comma)
                return name.TrimEnd(',');
            else
                return name;
        }



        /// <summary>
        /// This method is used to display the last name first of the full name
        /// </summary>
        /// <returns>a string with the appropriate format</returns>
        public string LastNameFirst()
        {
            string lastNameFirst = "";

            //if there is a last name add to return string
            if (this.lastName != null)
            {
                lastNameFirst += this.lastName + ", ";
            }

            //if there is a prefix add to return string
            if (this.prefix != null)
            {
                lastNameFirst += this.prefix + " ";
            }

            //if there is a first name add to return string
            if (this.firstName != null)
            {
                lastNameFirst += this.firstName;
            }

            //if there is a middle name add to return string
            if (this.firstMiddleName != null)
            {
                lastNameFirst += " " + this.firstMiddleName;
            }

            //if there is a second middle name add to return string
            if (this.secondMiddleName != null)
            {
                lastNameFirst += " " + this.secondMiddleName;
            }

            //if there is a suffix add to return string
            if (this.suffix != null)
            {
                lastNameFirst += ", " + this.suffix;
            }

            //return the name in the correct format
            return lastNameFirst;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents the full name.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents the full name.
        /// </returns>
        public override string ToString()
        {
            string output = "";

            //prefix, first, middle, middle, last, suffix

            //if there is a prefix add to return string
            if (this.prefix != null)
            {
                output += this.prefix + " ";
            }

            //if there is a first name add to return string
            if (this.firstName != null)
            {
                output += this.firstName;
            }

            //if there is a middle name add to return string
            if (this.firstMiddleName != null)
            {
                output += " " + this.firstMiddleName;
            }

            // if there is a second middle name add to return string
            if (this.secondMiddleName != null)
            {
                output += " " + this.secondMiddleName;
            }

            //if there is a last name add to return string
            if (this.lastName != null)
            {
                output += " " + this.lastName;
            }

            //if there is a last name add to return string
            if (this.suffix != null)
            {
                output += ", " + this.suffix;
            }

            //return name
            return output;
        }

    }
}
