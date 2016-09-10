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

        private List<Command> commands;
        private Command currentCommand { get; set; }

        public MainForm()
        {
            InitializeComponent();
            setup();
        }

        private void setup()
        {
            CommandAction.toolTip = toolTipDisplay;
            commandArgumentsTypeComboBox.SelectedIndex = 0;

            commands = new List<Command>();
        }

        // COMMAND SAVING / LOADING METHODS //

        private void loadCommand()
        {

        }

        private void saveToCurrentCommand()
        {

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

        // ARGUMENTS METHODS //
        
        private void commandArgumentsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            byte value = decimal.ToByte(commandArgumentsNumericUpDown.Value);

            if(value == 0)
            {
                commandArgumentsTypeNumericUpDown.Enabled = false;
                commandArgumentsAllowsSpacesCheckBox.Enabled = false;
                commandArgumentsTypeComboBox.Enabled = false;
            }
            else
            {
                commandArgumentsTypeNumericUpDown.Enabled = true;
                commandArgumentsAllowsSpacesCheckBox.Enabled = true;
                commandArgumentsTypeComboBox.Enabled = true;

                commandArgumentsTypeNumericUpDown.Maximum = value;
            }
        }

        // ACTION LIST METHODS //

        private void commandAddActionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selectedItem = commandAddActionComboBox.SelectedItem;
            if (selectedItem == null) return;

            CommandAction action = CommandAction.instantiateFromActionID(currentCommand, selectedItem.ToString());
            if (action != null)
            {
                commandActionsTablePanel.RowCount++;
                commandActionsTablePanel.RowStyles[commandActionsTablePanel.RowStyles.Count - 1].SizeType = SizeType.AutoSize;
                Panel p = action.panel;
                commandActionsTablePanel.Controls.Add(p, 0, 1);
                p.Parent = commandActionsTablePanel;
            }

            commandAddActionComboBox.SelectedItem = null;
        }
    }
}
