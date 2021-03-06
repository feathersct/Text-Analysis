﻿///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Utils/Menu
//	File Name:         Menu.cs
//	Description:       Define a Menu class that will allow a menu to be displayed in a Console window.
//                          The user's choice is obtained and verified. 
//	Created:           Monday, February 23, 2015
//	Copyright:         Don Bailes, 2015
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;

namespace Utils
{
    /// <summary>
    /// Implementation of a Menu class for console applications
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// The items
        /// </summary>
        private List<string> Items = new List<string> ( );

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="title">the title to be displayed above menu</param>
        public Menu (string title = "Menu")
        {
            Title = title;
        }
        #endregion

        #region Plus and Minus Operators
        /// <summary>
        /// Operator + adds a choice to the menu
        /// </summary>
        /// <param name="m">the menu to which the choice is added</param>
        /// <param name="item">the choice to be added</param>
        /// <returns></returns>
        public static Menu operator + (Menu m, string item)
        {
            m.Items.Add (item);
            return m;
        }

        /// <summary>
        /// Operator  - removes a choice from the menu
        /// </summary>
        /// <param name="m">the menu from which the choice is removed</param>
        /// <param name="item">the number of the choice to be removed</param>
        /// <returns></returns>
        public static Menu operator - (Menu m, int n)
        {
            if (n > 0 && n <= m.Items.Count)
                m.Items.RemoveAt (n - 1);
            return m;
        }
        #endregion

        #region Display and GetChoice methods
        /// <summary>
        /// Display the menu on the console window
        /// </summary>
        public void Display ( )
        {
            string str = "";
            Console.Clear ( );
            str = DateTime.Today.ToLongDateString ( );
            Console.SetCursorPosition (Console.WindowWidth - str.Length, 0);
            Console.WriteLine (str);

            Console.WriteLine ("\n\n\t   " + Title);
            Console.Write ("\t   ");
            for (int n = 0; n < Title.Length; n++)
                Console.Write ("-");
            Console.WriteLine ("\n");
            for (int n = 0; n < Items.Count; n++)
                Console.WriteLine ("\t{0}. {1}", (n + 1), Items [n]);
        }

        /// <summary>
        /// Obtain the user's selection, verify it is valid, and return it
        /// </summary>
        /// <returns>the number of the user's valid selection</returns>
        public int GetChoice ( )
        {
            int choice = -1;
            string line;
            if (Items.Count < 1)
                throw new Exception ("The menu is empty");

            while (true)
            {
                Display ( );
                Console.Write ("\n\t   Type the number of your choice from the menu: ");

                line = Console.ReadLine ( );

                if (!Int32.TryParse (line, out choice))
                {
                    Console.WriteLine ("\n\t   Your choice is not a number between 1 and {0}.  Please try again.",
                        Items.Count);
                    Console.ReadKey ( );
                }
                else
                {
                    if (choice < 1 || choice > Items.Count)
                    {
                        Console.WriteLine ("\n\t   Your choice is not a number between 1 and {0}.  Please try again.",
                        Items.Count);
                        Console.ReadKey ( );
                    }
                    else
                    {
                        Console.Clear ( );
                        return choice;
                    }
                }
            }
        }
        #endregion
    }
}
