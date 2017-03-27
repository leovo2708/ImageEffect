namespace ImageEffect
{
    partial class MainForm
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
            this.loadButton = new System.Windows.Forms.Button();
            this.inputPictureBox = new System.Windows.Forms.PictureBox();
            this.outputPictureBox = new System.Windows.Forms.PictureBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.decodeButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.filterListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageListView = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.settingGroupBox = new System.Windows.Forms.GroupBox();
            this.saveSettingButton = new System.Windows.Forms.Button();
            this.outputContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.inputPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputPictureBox)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.outputContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(3, 2);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(95, 23);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Select images";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // inputPictureBox
            // 
            this.inputPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPictureBox.Location = new System.Drawing.Point(337, 152);
            this.inputPictureBox.Name = "inputPictureBox";
            this.inputPictureBox.Size = new System.Drawing.Size(460, 115);
            this.inputPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inputPictureBox.TabIndex = 1;
            this.inputPictureBox.TabStop = false;
            // 
            // outputPictureBox
            // 
            this.outputPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputPictureBox.Location = new System.Drawing.Point(337, 297);
            this.outputPictureBox.Name = "outputPictureBox";
            this.outputPictureBox.Size = new System.Drawing.Size(460, 115);
            this.outputPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.outputPictureBox.TabIndex = 1;
            this.outputPictureBox.TabStop = false;
            this.outputPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.outputPictureBox_MouseDown);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 581);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(801, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoToolTip = true;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(786, 17);
            this.statusLabel.Spring = true;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // decodeButton
            // 
            this.decodeButton.Location = new System.Drawing.Point(418, 418);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(75, 23);
            this.decodeButton.TabIndex = 4;
            this.decodeButton.Text = "Decode";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(499, 420);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(200, 20);
            this.outputTextBox.TabIndex = 5;
            // 
            // filterListBox
            // 
            this.filterListBox.FormattingEnabled = true;
            this.filterListBox.Location = new System.Drawing.Point(3, 152);
            this.filterListBox.Name = "filterListBox";
            this.filterListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.filterListBox.Size = new System.Drawing.Size(328, 290);
            this.filterListBox.TabIndex = 8;
            this.filterListBox.SelectedIndexChanged += new System.EventHandler(this.filterListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filter:";
            // 
            // imageListView
            // 
            this.imageListView.LargeImageList = this.imageList;
            this.imageListView.Location = new System.Drawing.Point(3, 31);
            this.imageListView.MultiSelect = false;
            this.imageListView.Name = "imageListView";
            this.imageListView.Size = new System.Drawing.Size(794, 97);
            this.imageListView.SmallImageList = this.imageList;
            this.imageListView.TabIndex = 12;
            this.imageListView.UseCompatibleStateImageBehavior = false;
            this.imageListView.SelectedIndexChanged += new System.EventHandler(this.imageListView_SelectedIndexChanged);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList.ImageSize = new System.Drawing.Size(100, 25);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Before:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "After:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(337, 418);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // settingGroupBox
            // 
            this.settingGroupBox.Location = new System.Drawing.Point(3, 448);
            this.settingGroupBox.Name = "settingGroupBox";
            this.settingGroupBox.Size = new System.Drawing.Size(328, 101);
            this.settingGroupBox.TabIndex = 15;
            this.settingGroupBox.TabStop = false;
            this.settingGroupBox.Text = "Filter Setting";
            // 
            // saveSettingButton
            // 
            this.saveSettingButton.Location = new System.Drawing.Point(3, 553);
            this.saveSettingButton.Name = "saveSettingButton";
            this.saveSettingButton.Size = new System.Drawing.Size(139, 23);
            this.saveSettingButton.TabIndex = 16;
            this.saveSettingButton.Text = "Save and apply setting";
            this.saveSettingButton.UseVisualStyleBackColor = true;
            this.saveSettingButton.Click += new System.EventHandler(this.saveSettingButton_Click);
            // 
            // outputContextMenuStrip
            // 
            this.outputContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.outputContextMenuStrip.Name = "outputContextMenuStrip";
            this.outputContextMenuStrip.Size = new System.Drawing.Size(153, 48);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 603);
            this.Controls.Add(this.saveSettingButton);
            this.Controls.Add(this.settingGroupBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imageListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterListBox);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.outputPictureBox);
            this.Controls.Add(this.inputPictureBox);
            this.Controls.Add(this.loadButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Image Effect";
            ((System.ComponentModel.ISupportInitialize)(this.inputPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputPictureBox)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.outputContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.PictureBox inputPictureBox;
        private System.Windows.Forms.PictureBox outputPictureBox;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.ListBox filterListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView imageListView;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox settingGroupBox;
        private System.Windows.Forms.Button saveSettingButton;
        private System.Windows.Forms.ContextMenuStrip outputContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

