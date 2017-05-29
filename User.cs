//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 1 - Text Analysis
//	File Name:		User.cs
//	Description:	This class will hold data about the user of the program and can display it in a proper format.
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

namespace Project2
{
    /// <summary>
    /// This class holds information about the user such as their name, email, and phone number.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets the user's name.
        /// </summary>
        /// <value>
        /// The user's name
        /// </value>
        public Names name { get; private set; }

        /// <summary>
        /// Gets the user's email.
        /// </summary>
        /// <value>
        /// The user's email.
        /// </value>
        public string email { get; private set; }

        /// <summary>
        /// Gets the user's phone number.
        /// </summary>
        /// <value>
        /// The user's phone number.
        /// </value>
        public string phoneNumber { get; private set; }

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        public User()
        {
            //Sets name to null
            name = null;

            //Sets email to the default email
            email = "randomname@default.com";

            //Sets phoneNumber to all X's
            phoneNumber = "XXX-XXX-XXXX";
        }

        /// <summary>
        /// Parameterized Constructor that initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        /// <param name="nameString">The name string.</param>
        /// <param name="emailString">The email string.</param>
        /// <param name="phone">The phone.</param>
        /// <exception cref="ArgumentException">
        /// </exception>
        public User(string nameString, string emailString, string phone = "423-423-4234")
        {
            //if all the inputs do not crash the program
            try
            {
                name = new Names(nameString);

                //if email is valid set to the emailString, else throw an exception
                if (Utilities.IsValidEmailAddress(emailString))
                {
                    email = emailString;
                }
                else
                {
                    throw new ArgumentException();
                }

                //if the phone is valid then set to be the phone number, else throw an exception
                if (Utilities.IsValidPhoneNumber(phone))
                {
                    phoneNumber = phone;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            catch(ArgumentException e)
            {

                throw new Exception();
            }
        }
        #endregion

        #region ToString Method
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents the user.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents the user.
        /// </returns>
        public override string ToString()
        {
            string content = "";

            //Add the name, email, and phone number to the string
            content = $"\n\tName: {name} \n\tEmail: {email} \n\tPhone: {phoneNumber}";

            return content;
        }
        #endregion

    }
}
