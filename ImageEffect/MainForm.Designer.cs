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
            this.runButton = new System.Windows.Forms.Button();
            this.outputPictureBox = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.decodeButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.inputListBox = new System.Windows.Forms.ListBox();
            this.autoPreprocessCheckBox = new System.Windows.Forms.CheckBox();
            this.filterListBox = new System.Windows.Forms.ListBox();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inputPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputPictureBox)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(13, 12);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // inputPictureBox
            // 
            this.inputPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPictureBox.Location = new System.Drawing.Point(510, 12);
            this.inputPictureBox.Name = "inputPictureBox";
            this.inputPictureBox.Size = new System.Drawing.Size(200, 50);
            this.inputPictureBox.TabIndex = 1;
            this.inputPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.inputPictureBox, "Click to zoom");
            this.inputPictureBox.Click += new System.EventHandler(this.inputPictureBox_Click);
            // 
            // runButton
            // 
            this.runButton.Enabled = false;
            this.runButton.Location = new System.Drawing.Point(510, 90);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 2;
            this.runButton.Text = "Preprocess";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // outputPictureBox
            // 
            this.outputPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputPictureBox.Location = new System.Drawing.Point(510, 119);
            this.outputPictureBox.Name = "outputPictureBox";
            this.outputPictureBox.Size = new System.Drawing.Size(200, 50);
            this.outputPictureBox.TabIndex = 1;
            this.outputPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.outputPictureBox, "Click to zoom");
            this.outputPictureBox.Click += new System.EventHandler(this.outputPictureBox_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 292);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(725, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoToolTip = true;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(710, 17);
            this.statusLabel.Spring = true;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // decodeButton
            // 
            this.decodeButton.Location = new System.Drawing.Point(510, 194);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(75, 23);
            this.decodeButton.TabIndex = 4;
            this.decodeButton.Text = "Decode";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(510, 223);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(200, 20);
            this.outputTextBox.TabIndex = 5;
            // 
            // inputListBox
            // 
            this.inputListBox.FormattingEnabled = true;
            this.inputListBox.Location = new System.Drawing.Point(12, 41);
            this.inputListBox.Name = "inputListBox";
            this.inputListBox.Size = new System.Drawing.Size(222, 238);
            this.inputListBox.TabIndex = 6;
            this.inputListBox.SelectedIndexChanged += new System.EventHandler(this.inputListBox_SelectedIndexChanged);
            // 
            // autoPreprocessCheckBox
            // 
            this.autoPreprocessCheckBox.AutoSize = true;
            this.autoPreprocessCheckBox.Location = new System.Drawing.Point(591, 94);
            this.autoPreprocessCheckBox.Name = "autoPreprocessCheckBox";
            this.autoPreprocessCheckBox.Size = new System.Drawing.Size(48, 17);
            this.autoPreprocessCheckBox.TabIndex = 7;
            this.autoPreprocessCheckBox.Text = "Auto";
            this.autoPreprocessCheckBox.UseVisualStyleBackColor = true;
            this.autoPreprocessCheckBox.CheckedChanged += new System.EventHandler(this.autoPreprocessCheckBox_CheckedChanged);
            // 
            // filterListBox
            // 
            this.filterListBox.AllowDrop = true;
            this.filterListBox.FormattingEnabled = true;
            this.filterListBox.Location = new System.Drawing.Point(240, 41);
            this.filterListBox.Name = "filterListBox";
            this.filterListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.filterListBox.Size = new System.Drawing.Size(247, 238);
            this.filterListBox.TabIndex = 8;
            this.filterListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.filterListBox_DragDrop);
            this.filterListBox.DragOver += new System.Windows.Forms.DragEventHandler(this.filterListBox_DragOver);
            this.filterListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.filterListBox_KeyDown);
            this.filterListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.filterListBox_MouseDown);
            // 
            // filterComboBox
            // 
            this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(275, 13);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(131, 21);
            this.filterComboBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filter:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(412, 13);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 314);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.filterListBox);
            this.Controls.Add(this.autoPreprocessCheckBox);
            this.Controls.Add(this.inputListBox);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.runButton);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.PictureBox inputPictureBox;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.PictureBox outputPictureBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.ListBox inputListBox;
        private System.Windows.Forms.CheckBox autoPreprocessCheckBox;
        private System.Windows.Forms.ListBox filterListBox;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
    }
}

