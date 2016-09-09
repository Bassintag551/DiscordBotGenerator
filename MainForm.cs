using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordBotGenerator
{
    public partial class MainForm : Form
    {
        private Color colorError = Color.FromArgb(255, 225, 225);

        public MainForm()
        {
            InitializeComponent();
        }

        // TEXT BOX METHODS //

        private void changeColorIfEmpty(ref TextBox textBox)
        {
            String content = textBox.Text;
            content = content.Trim();
            if (content.Length == 0)
            {
                textBox.BackColor = colorError;
            }
            else
            {
                textBox.BackColor = SystemColors.Window;
            }
        }

        private void propertiesBotNameTextBox_TextChanged(object sender, EventArgs e)
        {
            changeColorIfEmpty(ref propertiesBotNameTextBox);
        }

        private void commandTitleTextBox_TextChanged(object sender, EventArgs e)
        {
            changeColorIfEmpty(ref commandTitleTextBox);
        }

        private void propertiesClientIDTextBox_TextChanged(object sender, EventArgs e)
        {
            changeColorIfEmpty(ref propertiesClientIDTextBox);
        }

        private void propertiesSecretTextBox_TextChanged(object sender, EventArgs e)
        {
            changeColorIfEmpty(ref propertiesSecretTextBox);
        }

        private void propertiesCommandPrefixTextBox_TextChanged(object sender, EventArgs e)
        {
            changeColorIfEmpty(ref propertiesCommandPrefixTextBox);
        }
    }
}
