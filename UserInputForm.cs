using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class UserInputForm : Form
    {
        public static User User = null;     //User object to be used to address the user

        /// <summary>
        /// Initializes a new instance of the <see cref="UserInputForm"/> class.
        /// </summary>
        public UserInputForm()
        {
            InitializeComponent();
        }

        #region Event Handlers
        /// <summary>
        /// Handles the Click event of the okButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void okButton_Click(object sender, EventArgs e)
        {
            //get the user input from both text boxes            
            string name  = nameTextBox.Text;
            string email = emailTextBox.Text;

            try
            {
                //Create a user with user's input
                User = new Project2.User(name, email);
                Close();
            }
            catch
            {
                //if the user information was not in the right format then display an error and change text to red
                directionsLabel.Text = "ERROR: User input validation incorrect";
                nameTextBox.BackColor = Color.Red;
                emailTextBox.BackColor = Color.Red;
            }

        }

        /// <summary>
        /// Handles the TextChanged event of the nameTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            //change back color to white when text has been changed
            nameTextBox.BackColor = Color.White;
            emailTextBox.BackColor = Color.White;
        }
        #endregion
    }
}
