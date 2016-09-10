using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace DiscordBotGenerator
{
    abstract class CommandAction
    {
        public abstract String displayName { get; }
        public abstract Bitmap displayIcon { get; }
        public abstract String helpToolTip { get; }

        public Panel panel { get; private set; }

        public static ToolTip toolTip { get; set; }

        public Command owner { get; private set; }

        public CommandAction(Command owner)
        {
            panel = createPanel();
            this.owner = owner;
        }

        public static CommandAction instantiateFromActionID(Command owner, String ID)
        {
            switch (ID)
            {
                case "Message Reply":
                    return new MessageReply(owner);
                default:
                    return null;
            }
                
        }

        private Panel createPanel()
        {
            Panel panel = new Panel();
            panel.AutoSize = true;
            panel.Dock = DockStyle.Fill;

            PictureBox picture = createLogo();
            Label label = createLabel();
            Button button = createDeleteButton();

            panel.Controls.Add(picture);
            panel.Controls.Add(label);
            panel.Controls.Add(button);

            return panel;
        }

        private PictureBox createLogo()
        {
            PictureBox picture = new PictureBox();
            picture.Top = 5;
            picture.Left = 5;
            picture.Size = new Size(48, 48);

            picture.Image = displayIcon;

            toolTip.SetToolTip(picture, helpToolTip);

            return picture;
        }

        private Label createLabel()
        {
            Label label = new Label();
            label.Font = new Font("Microsoft Sans Serif", 10);
            label.Top = 5;
            label.Left = 63;
            label.AutoSize = true;

            label.Text = displayName;

            return label;
        }

        private Button createDeleteButton()
        {
            Button button = new Button();
            button.Size = new Size(25, 25);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button.Image = Properties.Resources.IconDelete;
            button.Left = 170;
            button.Top = 3;

            button.Click += onDeleteButtonClick;

            return button;
        }

        private void onDeleteButtonClick(object sender, EventArgs e)
        {
            panel.Parent.Controls.Remove(panel);
        }
    }

    class MessageReply : CommandAction
    {
        public override String displayName { get { return "Message Reply"; } }

        public override Bitmap displayIcon { get { return Properties.Resources.IconMessage; } }

        public override String helpToolTip { get { return "Makes the bot send back a message after receiving the command\nUse $[arg num] to use args in the reply"; } }

        private TextBox messageTextBox;

        public MessageReply(Command owner) : base(owner)
        {
            messageTextBox = new TextBox();
            messageTextBox.Left = 63;
            messageTextBox.Top = 28;
            messageTextBox.Size = new Size(100, 18);
            messageTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;

            panel.Controls.Add(messageTextBox);
        }
    }
}
