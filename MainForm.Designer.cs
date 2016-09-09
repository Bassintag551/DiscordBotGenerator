namespace DiscordBotGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.commandsPanel = new System.Windows.Forms.Panel();
            this.commandsHeaderPanel = new System.Windows.Forms.Panel();
            this.commandsLabel = new System.Windows.Forms.Label();
            this.commandsListContainer = new System.Windows.Forms.Panel();
            this.commandsList = new System.Windows.Forms.ListView();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.propertiesPanel = new System.Windows.Forms.Panel();
            this.propertiesCommandPrefixTextBox = new System.Windows.Forms.TextBox();
            this.propertiesCommandPrefixLabel = new System.Windows.Forms.Label();
            this.propertiesSecretTextBox = new System.Windows.Forms.TextBox();
            this.propertiesSecretLabel = new System.Windows.Forms.Label();
            this.propertiesClientIDTextBox = new System.Windows.Forms.TextBox();
            this.propertiesClientIDLabel = new System.Windows.Forms.Label();
            this.propertiesBotNameTextBox = new System.Windows.Forms.TextBox();
            this.propertiesBotNameLabel = new System.Windows.Forms.Label();
            this.commandTitlePrefixCheckbox = new System.Windows.Forms.CheckBox();
            this.commandTitleTextBox = new System.Windows.Forms.TextBox();
            this.commandTitleLabel = new System.Windows.Forms.Label();
            this.toolTipDisplay = new System.Windows.Forms.ToolTip(this.components);
            this.propertiesPicture = new System.Windows.Forms.PictureBox();
            this.commandTitleIcon = new System.Windows.Forms.PictureBox();
            this.addCommandButton = new System.Windows.Forms.Button();
            this.removeCommandButton = new System.Windows.Forms.Button();
            this.commandArgumentsLabel = new System.Windows.Forms.Label();
            this.comandArgumentsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.commandArgumentsAllowsSpacesCheckBox = new System.Windows.Forms.CheckBox();
            this.commandsPanel.SuspendLayout();
            this.commandsHeaderPanel.SuspendLayout();
            this.commandsListContainer.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.propertiesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandTitleIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandArgumentsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // commandsPanel
            // 
            this.commandsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.commandsPanel.Controls.Add(this.commandsHeaderPanel);
            this.commandsPanel.Controls.Add(this.commandsListContainer);
            this.commandsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.commandsPanel.Location = new System.Drawing.Point(0, 0);
            this.commandsPanel.Name = "commandsPanel";
            this.commandsPanel.Size = new System.Drawing.Size(200, 461);
            this.commandsPanel.TabIndex = 0;
            // 
            // commandsHeaderPanel
            // 
            this.commandsHeaderPanel.Controls.Add(this.addCommandButton);
            this.commandsHeaderPanel.Controls.Add(this.removeCommandButton);
            this.commandsHeaderPanel.Controls.Add(this.commandsLabel);
            this.commandsHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.commandsHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.commandsHeaderPanel.Name = "commandsHeaderPanel";
            this.commandsHeaderPanel.Size = new System.Drawing.Size(200, 100);
            this.commandsHeaderPanel.TabIndex = 5;
            // 
            // commandsLabel
            // 
            this.commandsLabel.AutoSize = true;
            this.commandsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.commandsLabel.Location = new System.Drawing.Point(32, 60);
            this.commandsLabel.Name = "commandsLabel";
            this.commandsLabel.Size = new System.Drawing.Size(133, 26);
            this.commandsLabel.TabIndex = 3;
            this.commandsLabel.Text = "Commands";
            // 
            // commandsListContainer
            // 
            this.commandsListContainer.Controls.Add(this.commandsList);
            this.commandsListContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandsListContainer.Location = new System.Drawing.Point(0, 0);
            this.commandsListContainer.Name = "commandsListContainer";
            this.commandsListContainer.Size = new System.Drawing.Size(200, 461);
            this.commandsListContainer.TabIndex = 4;
            // 
            // commandsList
            // 
            this.commandsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.commandsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commandsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandsList.Location = new System.Drawing.Point(0, 0);
            this.commandsList.Name = "commandsList";
            this.commandsList.Size = new System.Drawing.Size(200, 461);
            this.commandsList.TabIndex = 2;
            this.commandsList.UseCompatibleStateImageBehavior = false;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.mainPanel.Controls.Add(this.commandArgumentsAllowsSpacesCheckBox);
            this.mainPanel.Controls.Add(this.comandArgumentsNumericUpDown);
            this.mainPanel.Controls.Add(this.commandArgumentsLabel);
            this.mainPanel.Controls.Add(this.commandTitleLabel);
            this.mainPanel.Controls.Add(this.commandTitleTextBox);
            this.mainPanel.Controls.Add(this.commandTitlePrefixCheckbox);
            this.mainPanel.Controls.Add(this.commandTitleIcon);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(200, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(10);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(684, 461);
            this.mainPanel.TabIndex = 1;
            // 
            // propertiesPanel
            // 
            this.propertiesPanel.Controls.Add(this.propertiesCommandPrefixTextBox);
            this.propertiesPanel.Controls.Add(this.propertiesCommandPrefixLabel);
            this.propertiesPanel.Controls.Add(this.propertiesSecretTextBox);
            this.propertiesPanel.Controls.Add(this.propertiesSecretLabel);
            this.propertiesPanel.Controls.Add(this.propertiesClientIDTextBox);
            this.propertiesPanel.Controls.Add(this.propertiesClientIDLabel);
            this.propertiesPanel.Controls.Add(this.propertiesBotNameTextBox);
            this.propertiesPanel.Controls.Add(this.propertiesBotNameLabel);
            this.propertiesPanel.Controls.Add(this.propertiesPicture);
            this.propertiesPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.propertiesPanel.Location = new System.Drawing.Point(684, 0);
            this.propertiesPanel.Name = "propertiesPanel";
            this.propertiesPanel.Size = new System.Drawing.Size(200, 461);
            this.propertiesPanel.TabIndex = 0;
            // 
            // propertiesCommandPrefixTextBox
            // 
            this.propertiesCommandPrefixTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertiesCommandPrefixTextBox.Location = new System.Drawing.Point(139, 251);
            this.propertiesCommandPrefixTextBox.MaxLength = 1;
            this.propertiesCommandPrefixTextBox.Name = "propertiesCommandPrefixTextBox";
            this.propertiesCommandPrefixTextBox.Size = new System.Drawing.Size(23, 20);
            this.propertiesCommandPrefixTextBox.TabIndex = 8;
            this.propertiesCommandPrefixTextBox.Text = "!";
            this.propertiesCommandPrefixTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.propertiesCommandPrefixTextBox.TextChanged += new System.EventHandler(this.propertiesCommandPrefixTextBox_TextChanged);
            // 
            // propertiesCommandPrefixLabel
            // 
            this.propertiesCommandPrefixLabel.AutoSize = true;
            this.propertiesCommandPrefixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.propertiesCommandPrefixLabel.Location = new System.Drawing.Point(4, 251);
            this.propertiesCommandPrefixLabel.Name = "propertiesCommandPrefixLabel";
            this.propertiesCommandPrefixLabel.Size = new System.Drawing.Size(129, 20);
            this.propertiesCommandPrefixLabel.TabIndex = 7;
            this.propertiesCommandPrefixLabel.Text = "Command Prefix:";
            // 
            // propertiesSecretTextBox
            // 
            this.propertiesSecretTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.propertiesSecretTextBox.Location = new System.Drawing.Point(7, 216);
            this.propertiesSecretTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.propertiesSecretTextBox.Name = "propertiesSecretTextBox";
            this.propertiesSecretTextBox.Size = new System.Drawing.Size(182, 20);
            this.propertiesSecretTextBox.TabIndex = 6;
            this.propertiesSecretTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.propertiesSecretTextBox.UseSystemPasswordChar = true;
            this.propertiesSecretTextBox.TextChanged += new System.EventHandler(this.propertiesSecretTextBox_TextChanged);
            // 
            // propertiesSecretLabel
            // 
            this.propertiesSecretLabel.AutoSize = true;
            this.propertiesSecretLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertiesSecretLabel.Location = new System.Drawing.Point(3, 192);
            this.propertiesSecretLabel.Name = "propertiesSecretLabel";
            this.propertiesSecretLabel.Size = new System.Drawing.Size(60, 20);
            this.propertiesSecretLabel.TabIndex = 5;
            this.propertiesSecretLabel.Text = "Secret:";
            // 
            // propertiesClientIDTextBox
            // 
            this.propertiesClientIDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.propertiesClientIDTextBox.Location = new System.Drawing.Point(7, 162);
            this.propertiesClientIDTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.propertiesClientIDTextBox.Name = "propertiesClientIDTextBox";
            this.propertiesClientIDTextBox.Size = new System.Drawing.Size(182, 20);
            this.propertiesClientIDTextBox.TabIndex = 4;
            this.propertiesClientIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.propertiesClientIDTextBox.TextChanged += new System.EventHandler(this.propertiesClientIDTextBox_TextChanged);
            // 
            // propertiesClientIDLabel
            // 
            this.propertiesClientIDLabel.AutoSize = true;
            this.propertiesClientIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertiesClientIDLabel.Location = new System.Drawing.Point(4, 138);
            this.propertiesClientIDLabel.Name = "propertiesClientIDLabel";
            this.propertiesClientIDLabel.Size = new System.Drawing.Size(74, 20);
            this.propertiesClientIDLabel.TabIndex = 3;
            this.propertiesClientIDLabel.Text = "Client ID:";
            // 
            // propertiesBotNameTextBox
            // 
            this.propertiesBotNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.propertiesBotNameTextBox.Location = new System.Drawing.Point(7, 108);
            this.propertiesBotNameTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.propertiesBotNameTextBox.Name = "propertiesBotNameTextBox";
            this.propertiesBotNameTextBox.Size = new System.Drawing.Size(182, 20);
            this.propertiesBotNameTextBox.TabIndex = 2;
            this.propertiesBotNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.propertiesBotNameTextBox.TextChanged += new System.EventHandler(this.propertiesBotNameTextBox_TextChanged);
            // 
            // propertiesBotNameLabel
            // 
            this.propertiesBotNameLabel.AutoSize = true;
            this.propertiesBotNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertiesBotNameLabel.Location = new System.Drawing.Point(3, 83);
            this.propertiesBotNameLabel.Name = "propertiesBotNameLabel";
            this.propertiesBotNameLabel.Size = new System.Drawing.Size(84, 20);
            this.propertiesBotNameLabel.TabIndex = 1;
            this.propertiesBotNameLabel.Text = "Bot Name:";
            // 
            // commandTitlePrefixCheckbox
            // 
            this.commandTitlePrefixCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.commandTitlePrefixCheckbox.AutoSize = true;
            this.commandTitlePrefixCheckbox.Checked = true;
            this.commandTitlePrefixCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.commandTitlePrefixCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.commandTitlePrefixCheckbox.Location = new System.Drawing.Point(365, 12);
            this.commandTitlePrefixCheckbox.Name = "commandTitlePrefixCheckbox";
            this.commandTitlePrefixCheckbox.Size = new System.Drawing.Size(97, 21);
            this.commandTitlePrefixCheckbox.TabIndex = 1;
            this.commandTitlePrefixCheckbox.Text = "Uses prefix";
            this.toolTipDisplay.SetToolTip(this.commandTitlePrefixCheckbox, resources.GetString("commandTitlePrefixCheckbox.ToolTip"));
            this.commandTitlePrefixCheckbox.UseVisualStyleBackColor = true;
            // 
            // commandTitleTextBox
            // 
            this.commandTitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandTitleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.commandTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.commandTitleTextBox.Location = new System.Drawing.Point(60, 37);
            this.commandTitleTextBox.Name = "commandTitleTextBox";
            this.commandTitleTextBox.Size = new System.Drawing.Size(402, 23);
            this.commandTitleTextBox.TabIndex = 2;
            this.commandTitleTextBox.TextChanged += new System.EventHandler(this.commandTitleTextBox_TextChanged);
            // 
            // commandTitleLabel
            // 
            this.commandTitleLabel.AutoSize = true;
            this.commandTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.commandTitleLabel.Location = new System.Drawing.Point(60, 13);
            this.commandTitleLabel.Name = "commandTitleLabel";
            this.commandTitleLabel.Size = new System.Drawing.Size(109, 17);
            this.commandTitleLabel.TabIndex = 3;
            this.commandTitleLabel.Text = "Command label:";
            // 
            // toolTipDisplay
            // 
            this.toolTipDisplay.AutoPopDelay = 500000000;
            this.toolTipDisplay.InitialDelay = 500;
            this.toolTipDisplay.ReshowDelay = 100;
            this.toolTipDisplay.ToolTipTitle = "Help";
            // 
            // propertiesPicture
            // 
            this.propertiesPicture.BackgroundImage = global::DiscordBotGenerator.Properties.Resources.IconProperties;
            this.propertiesPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.propertiesPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.propertiesPicture.Location = new System.Drawing.Point(0, 0);
            this.propertiesPicture.Name = "propertiesPicture";
            this.propertiesPicture.Size = new System.Drawing.Size(200, 80);
            this.propertiesPicture.TabIndex = 0;
            this.propertiesPicture.TabStop = false;
            this.toolTipDisplay.SetToolTip(this.propertiesPicture, "Set up the global properties of your bot\r\nHover over each tooltip for more detail" +
        "s\r\n");
            // 
            // commandTitleIcon
            // 
            this.commandTitleIcon.Image = ((System.Drawing.Image)(resources.GetObject("commandTitleIcon.Image")));
            this.commandTitleIcon.Location = new System.Drawing.Point(6, 12);
            this.commandTitleIcon.Name = "commandTitleIcon";
            this.commandTitleIcon.Size = new System.Drawing.Size(48, 48);
            this.commandTitleIcon.TabIndex = 0;
            this.commandTitleIcon.TabStop = false;
            this.toolTipDisplay.SetToolTip(this.commandTitleIcon, resources.GetString("commandTitleIcon.ToolTip"));
            // 
            // addCommandButton
            // 
            this.addCommandButton.FlatAppearance.BorderSize = 0;
            this.addCommandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCommandButton.Image = ((System.Drawing.Image)(resources.GetObject("addCommandButton.Image")));
            this.addCommandButton.Location = new System.Drawing.Point(3, 3);
            this.addCommandButton.Name = "addCommandButton";
            this.addCommandButton.Size = new System.Drawing.Size(54, 54);
            this.addCommandButton.TabIndex = 0;
            this.toolTipDisplay.SetToolTip(this.addCommandButton, "Add a new command to your bot");
            this.addCommandButton.UseVisualStyleBackColor = true;
            // 
            // removeCommandButton
            // 
            this.removeCommandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeCommandButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.removeCommandButton.Enabled = false;
            this.removeCommandButton.FlatAppearance.BorderSize = 0;
            this.removeCommandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeCommandButton.Image = global::DiscordBotGenerator.Properties.Resources.IconRemove;
            this.removeCommandButton.Location = new System.Drawing.Point(143, 3);
            this.removeCommandButton.Name = "removeCommandButton";
            this.removeCommandButton.Size = new System.Drawing.Size(54, 54);
            this.removeCommandButton.TabIndex = 1;
            this.toolTipDisplay.SetToolTip(this.removeCommandButton, "Remove the currently selected command (cannot be undone)");
            this.removeCommandButton.UseVisualStyleBackColor = false;
            // 
            // commandArgumentsLabel
            // 
            this.commandArgumentsLabel.AutoSize = true;
            this.commandArgumentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.commandArgumentsLabel.Location = new System.Drawing.Point(60, 69);
            this.commandArgumentsLabel.Margin = new System.Windows.Forms.Padding(3);
            this.commandArgumentsLabel.Name = "commandArgumentsLabel";
            this.commandArgumentsLabel.Size = new System.Drawing.Size(146, 17);
            this.commandArgumentsLabel.TabIndex = 5;
            this.commandArgumentsLabel.Text = "Command arguments:";
            // 
            // comandArgumentsNumericUpDown
            // 
            this.comandArgumentsNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comandArgumentsNumericUpDown.Location = new System.Drawing.Point(60, 90);
            this.comandArgumentsNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.comandArgumentsNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.comandArgumentsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.comandArgumentsNumericUpDown.Name = "comandArgumentsNumericUpDown";
            this.comandArgumentsNumericUpDown.Size = new System.Drawing.Size(67, 23);
            this.comandArgumentsNumericUpDown.TabIndex = 6;
            this.comandArgumentsNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.comandArgumentsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // commandArgumentsAllowsSpacesCheckBox
            // 
            this.commandArgumentsAllowsSpacesCheckBox.AutoSize = true;
            this.commandArgumentsAllowsSpacesCheckBox.Checked = true;
            this.commandArgumentsAllowsSpacesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.commandArgumentsAllowsSpacesCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.commandArgumentsAllowsSpacesCheckBox.Location = new System.Drawing.Point(165, 92);
            this.commandArgumentsAllowsSpacesCheckBox.Name = "commandArgumentsAllowsSpacesCheckBox";
            this.commandArgumentsAllowsSpacesCheckBox.Size = new System.Drawing.Size(209, 21);
            this.commandArgumentsAllowsSpacesCheckBox.TabIndex = 7;
            this.commandArgumentsAllowsSpacesCheckBox.Text = "Last argument allows spaces";
            this.toolTipDisplay.SetToolTip(this.commandArgumentsAllowsSpacesCheckBox, resources.GetString("commandArgumentsAllowsSpacesCheckBox.ToolTip"));
            this.commandArgumentsAllowsSpacesCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.propertiesPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.commandsPanel);
            this.Name = "MainForm";
            this.Text = "Discord Bot Generator";
            this.commandsPanel.ResumeLayout(false);
            this.commandsHeaderPanel.ResumeLayout(false);
            this.commandsHeaderPanel.PerformLayout();
            this.commandsListContainer.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.propertiesPanel.ResumeLayout(false);
            this.propertiesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandTitleIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandArgumentsNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel commandsPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button addCommandButton;
        private System.Windows.Forms.Button removeCommandButton;
        private System.Windows.Forms.ListView commandsList;
        private System.Windows.Forms.Label commandsLabel;
        private System.Windows.Forms.Panel propertiesPanel;
        private System.Windows.Forms.PictureBox propertiesPicture;
        private System.Windows.Forms.TextBox propertiesBotNameTextBox;
        private System.Windows.Forms.Label propertiesBotNameLabel;
        private System.Windows.Forms.TextBox propertiesClientIDTextBox;
        private System.Windows.Forms.Label propertiesClientIDLabel;
        private System.Windows.Forms.Panel commandsListContainer;
        private System.Windows.Forms.Panel commandsHeaderPanel;
        private System.Windows.Forms.Label propertiesSecretLabel;
        private System.Windows.Forms.TextBox propertiesSecretTextBox;
        private System.Windows.Forms.TextBox propertiesCommandPrefixTextBox;
        private System.Windows.Forms.Label propertiesCommandPrefixLabel;
        private System.Windows.Forms.PictureBox commandTitleIcon;
        private System.Windows.Forms.CheckBox commandTitlePrefixCheckbox;
        private System.Windows.Forms.TextBox commandTitleTextBox;
        private System.Windows.Forms.Label commandTitleLabel;
        private System.Windows.Forms.ToolTip toolTipDisplay;
        private System.Windows.Forms.NumericUpDown comandArgumentsNumericUpDown;
        private System.Windows.Forms.Label commandArgumentsLabel;
        private System.Windows.Forms.CheckBox commandArgumentsAllowsSpacesCheckBox;
    }
}

