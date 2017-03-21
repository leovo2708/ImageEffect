namespace ImageEffect.Filters
{
    partial class BlobsFilteringForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minHeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxHeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.minWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxWidthNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Height:";
            // 
            // minWidthNumericUpDown
            // 
            this.minWidthNumericUpDown.Location = new System.Drawing.Point(59, 12);
            this.minWidthNumericUpDown.Name = "minWidthNumericUpDown";
            this.minWidthNumericUpDown.Size = new System.Drawing.Size(94, 20);
            this.minWidthNumericUpDown.TabIndex = 1;
            // 
            // minHeightNumericUpDown
            // 
            this.minHeightNumericUpDown.Location = new System.Drawing.Point(59, 43);
            this.minHeightNumericUpDown.Name = "minHeightNumericUpDown";
            this.minHeightNumericUpDown.Size = new System.Drawing.Size(94, 20);
            this.minHeightNumericUpDown.TabIndex = 1;
            // 
            // maxHeightNumericUpDown
            // 
            this.maxHeightNumericUpDown.Location = new System.Drawing.Point(159, 43);
            this.maxHeightNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.maxHeightNumericUpDown.Name = "maxHeightNumericUpDown";
            this.maxHeightNumericUpDown.Size = new System.Drawing.Size(94, 20);
            this.maxHeightNumericUpDown.TabIndex = 1;
            // 
            // maxWidthNumericUpDown
            // 
            this.maxWidthNumericUpDown.Location = new System.Drawing.Point(159, 12);
            this.maxWidthNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.maxWidthNumericUpDown.Name = "maxWidthNumericUpDown";
            this.maxWidthNumericUpDown.Size = new System.Drawing.Size(94, 20);
            this.maxWidthNumericUpDown.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(178, 72);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // BlobsFilteringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 106);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.maxHeightNumericUpDown);
            this.Controls.Add(this.minHeightNumericUpDown);
            this.Controls.Add(this.maxWidthNumericUpDown);
            this.Controls.Add(this.minWidthNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BlobsFilteringForm";
            this.Text = "ContrastCorrectionForm";
            ((System.ComponentModel.ISupportInitialize)(this.minWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minHeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxHeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxWidthNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown minWidthNumericUpDown;
        private System.Windows.Forms.NumericUpDown minHeightNumericUpDown;
        private System.Windows.Forms.NumericUpDown maxHeightNumericUpDown;
        private System.Windows.Forms.NumericUpDown maxWidthNumericUpDown;
        private System.Windows.Forms.Button okButton;
    }
}