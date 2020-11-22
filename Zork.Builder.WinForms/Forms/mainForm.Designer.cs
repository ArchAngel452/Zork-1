namespace Zork.Builder.WinForms.Forms
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.roomsLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editWelcomeMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStartingLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.deleteRoomButton = new System.Windows.Forms.Button();
            this.roomNameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.roomNameTextBox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.neighborsLabel = new System.Windows.Forms.Label();
            this.westLabel = new System.Windows.Forms.Label();
            this.eastLabel = new System.Windows.Forms.Label();
            this.southLabel = new System.Windows.Forms.Label();
            this.northLabel = new System.Windows.Forms.Label();
            this.northTextBox = new System.Windows.Forms.TextBox();
            this.westTextBox = new System.Windows.Forms.TextBox();
            this.eastTextBox = new System.Windows.Forms.TextBox();
            this.southTextBox = new System.Windows.Forms.TextBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // roomsLabel
            // 
            this.roomsLabel.AutoSize = true;
            this.roomsLabel.Location = new System.Drawing.Point(12, 30);
            this.roomsLabel.Name = "roomsLabel";
            this.roomsLabel.Size = new System.Drawing.Size(52, 17);
            this.roomsLabel.TabIndex = 0;
            this.roomsLabel.Text = "Rooms";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editWelcomeMessageToolStripMenuItem,
            this.editStartingLocationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameFileToolStripMenuItem,
            this.loadFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameFileToolStripMenuItem
            // 
            this.newGameFileToolStripMenuItem.Name = "newGameFileToolStripMenuItem";
            this.newGameFileToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.newGameFileToolStripMenuItem.Text = "New Game File";
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.loadFileToolStripMenuItem.Text = "Load";
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.saveFileToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(189, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editWelcomeMessageToolStripMenuItem
            // 
            this.editWelcomeMessageToolStripMenuItem.Name = "editWelcomeMessageToolStripMenuItem";
            this.editWelcomeMessageToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.editWelcomeMessageToolStripMenuItem.Text = "Edit Welcome Message";
            this.editWelcomeMessageToolStripMenuItem.Click += new System.EventHandler(this.editWelcomeMessageToolStripMenuItem_Click);
            // 
            // editStartingLocationToolStripMenuItem
            // 
            this.editStartingLocationToolStripMenuItem.Name = "editStartingLocationToolStripMenuItem";
            this.editStartingLocationToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.editStartingLocationToolStripMenuItem.Text = "Edit Starting Location";
            this.editStartingLocationToolStripMenuItem.Click += new System.EventHandler(this.editStartingLocationToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(291, 324);
            this.listBox1.TabIndex = 2;
            // 
            // addRoomButton
            // 
            this.addRoomButton.Location = new System.Drawing.Point(20, 380);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(283, 23);
            this.addRoomButton.TabIndex = 3;
            this.addRoomButton.Text = "Add Room";
            this.addRoomButton.UseVisualStyleBackColor = true;
            // 
            // deleteRoomButton
            // 
            this.deleteRoomButton.Location = new System.Drawing.Point(20, 415);
            this.deleteRoomButton.Name = "deleteRoomButton";
            this.deleteRoomButton.Size = new System.Drawing.Size(283, 23);
            this.deleteRoomButton.TabIndex = 4;
            this.deleteRoomButton.Text = "Delete Room";
            this.deleteRoomButton.UseVisualStyleBackColor = true;
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.AutoSize = true;
            this.roomNameLabel.Location = new System.Drawing.Point(323, 50);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(86, 17);
            this.roomNameLabel.TabIndex = 5;
            this.roomNameLabel.Text = "Room Name";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(323, 110);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(79, 17);
            this.descriptionLabel.TabIndex = 6;
            this.descriptionLabel.Text = "Description";
            // 
            // roomNameTextBox
            // 
            this.roomNameTextBox.Location = new System.Drawing.Point(326, 70);
            this.roomNameTextBox.Name = "roomNameTextBox";
            this.roomNameTextBox.Size = new System.Drawing.Size(462, 22);
            this.roomNameTextBox.TabIndex = 7;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(326, 131);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(462, 147);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // neighborsLabel
            // 
            this.neighborsLabel.AutoSize = true;
            this.neighborsLabel.Location = new System.Drawing.Point(323, 291);
            this.neighborsLabel.Name = "neighborsLabel";
            this.neighborsLabel.Size = new System.Drawing.Size(73, 17);
            this.neighborsLabel.TabIndex = 9;
            this.neighborsLabel.Text = "Neighbors";
            // 
            // westLabel
            // 
            this.westLabel.AutoSize = true;
            this.westLabel.Location = new System.Drawing.Point(323, 404);
            this.westLabel.Name = "westLabel";
            this.westLabel.Size = new System.Drawing.Size(40, 17);
            this.westLabel.TabIndex = 10;
            this.westLabel.Text = "West";
            // 
            // eastLabel
            // 
            this.eastLabel.AutoSize = true;
            this.eastLabel.Location = new System.Drawing.Point(323, 375);
            this.eastLabel.Name = "eastLabel";
            this.eastLabel.Size = new System.Drawing.Size(36, 17);
            this.eastLabel.TabIndex = 11;
            this.eastLabel.Text = "East";
            // 
            // southLabel
            // 
            this.southLabel.AutoSize = true;
            this.southLabel.Location = new System.Drawing.Point(323, 346);
            this.southLabel.Name = "southLabel";
            this.southLabel.Size = new System.Drawing.Size(45, 17);
            this.southLabel.TabIndex = 12;
            this.southLabel.Text = "South";
            // 
            // northLabel
            // 
            this.northLabel.AutoSize = true;
            this.northLabel.Location = new System.Drawing.Point(323, 318);
            this.northLabel.Name = "northLabel";
            this.northLabel.Size = new System.Drawing.Size(43, 17);
            this.northLabel.TabIndex = 13;
            this.northLabel.Text = "North";
            // 
            // northTextBox
            // 
            this.northTextBox.Location = new System.Drawing.Point(403, 312);
            this.northTextBox.Name = "northTextBox";
            this.northTextBox.Size = new System.Drawing.Size(385, 22);
            this.northTextBox.TabIndex = 14;
            // 
            // westTextBox
            // 
            this.westTextBox.Location = new System.Drawing.Point(403, 399);
            this.westTextBox.Name = "westTextBox";
            this.westTextBox.Size = new System.Drawing.Size(385, 22);
            this.westTextBox.TabIndex = 15;
            // 
            // eastTextBox
            // 
            this.eastTextBox.Location = new System.Drawing.Point(403, 372);
            this.eastTextBox.Name = "eastTextBox";
            this.eastTextBox.Size = new System.Drawing.Size(385, 22);
            this.eastTextBox.TabIndex = 16;
            // 
            // southTextBox
            // 
            this.southTextBox.Location = new System.Drawing.Point(403, 343);
            this.southTextBox.Name = "southTextBox";
            this.southTextBox.Size = new System.Drawing.Size(385, 22);
            this.southTextBox.TabIndex = 17;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataSource = typeof(Zork.Room);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.southTextBox);
            this.Controls.Add(this.eastTextBox);
            this.Controls.Add(this.westTextBox);
            this.Controls.Add(this.northTextBox);
            this.Controls.Add(this.northLabel);
            this.Controls.Add(this.southLabel);
            this.Controls.Add(this.eastLabel);
            this.Controls.Add(this.westLabel);
            this.Controls.Add(this.neighborsLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.roomNameTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.roomNameLabel);
            this.Controls.Add(this.deleteRoomButton);
            this.Controls.Add(this.addRoomButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.roomsLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Zork Builder";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label roomsLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editWelcomeMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStartingLocationToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button addRoomButton;
        private System.Windows.Forms.Button deleteRoomButton;
        private System.Windows.Forms.Label roomNameLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox roomNameTextBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label neighborsLabel;
        private System.Windows.Forms.Label westLabel;
        private System.Windows.Forms.Label eastLabel;
        private System.Windows.Forms.Label southLabel;
        private System.Windows.Forms.Label northLabel;
        private System.Windows.Forms.TextBox northTextBox;
        private System.Windows.Forms.TextBox westTextBox;
        private System.Windows.Forms.TextBox eastTextBox;
        private System.Windows.Forms.TextBox southTextBox;
        private System.Windows.Forms.BindingSource roomsBindingSource;
    }
}

