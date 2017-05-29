using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text
{
    static class Project2Driver
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            User user = null;       //The user's information as input in UserInputForm

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());
            Application.Run(new UserInputForm());

            //Get the user's information that they input
            user = UserInputForm.User;

            //If the user is not null then run the MainForm
            if (user != null)
            {
                Application.Run(new TextAnalysisForm());

            }

            //Message, Caption, Buttons for the Goodbye window to be displayed
            string message = $"Thank you for using this program, {user.name.firstName}. I have emailed your invoice for the use of this program to {user.email}.\n\nHave a great day.";
            string caption = "Goodbye";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Information);

        }
    }
}
