namespace ImageEffect.Filters
{
    partial class ColorFilteringForm
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
            this.redNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.greenNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.blueNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.okButton = new System.Windows.Forms.Button();
            this.redNumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.greenNumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.blueNumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.redNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redNumericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenNumericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueNumericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // redNumericUpDown1
            // 
            this.redNumericUpDown1.Location = new System.Drawing.Point(57, 12);
            this.redNumericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.redNumericUpDown1.Name = "redNumericUpDown1";
            this.redNumericUpDown1.Size = new System.Drawing.Size(90, 20);
            this.redNumericUpDown1.TabIndex = 0;
            this.redNumericUpDown1.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Red:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Green:";
            // 
            // greenNumericUpDown1
            // 
            this.greenNumericUpDown1.Location = new System.Drawing.Point(57, 44);
            this.greenNumericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.greenNumericUpDown1.Name = "greenNumericUpDown1";
            this.greenNumericUpDown1.Size = new System.Drawing.Size(90, 20);
            this.greenNumericUpDown1.TabIndex = 0;
            this.greenNumericUpDown1.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Blue:";
            // 
            // blueNumericUpDown1
            // 
            this.blueNumericUpDown1.Location = new System.Drawing.Point(57, 77);
            this.blueNumericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blueNumericUpDown1.Name = "blueNumericUpDown1";
            this.blueNumericUpDown1.Size = new System.Drawing.Size(90, 20);
            this.blueNumericUpDown1.TabIndex = 0;
            this.blueNumericUpDown1.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(172, 108);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // redNumericUpDown2
            // 
            this.redNumericUpDown2.Location = new System.Drawing.Point(157, 12);
            this.redNumericUpDown2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.redNumericUpDown2.Name = "redNumericUpDown2";
            this.redNumericUpDown2.Size = new System.Drawing.Size(90, 20);
            this.redNumericUpDown2.TabIndex = 0;
            this.redNumericUpDown2.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // greenNumericUpDown2
            // 
            this.greenNumericUpDown2.Location = new System.Drawing.Point(157, 44);
            this.greenNumericUpDown2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.greenNumericUpDown2.Name = "greenNumericUpDown2";
            this.greenNumericUpDown2.Size = new System.Drawing.Size(90, 20);
            this.greenNumericUpDown2.TabIndex = 0;
            this.greenNumericUpDown2.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // blueNumericUpDown2
            // 
            this.blueNumericUpDown2.Location = new System.Drawing.Point(157, 77);
            this.blueNumericUpDown2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blueNumericUpDown2.Name = "blueNumericUpDown2";
            this.blueNumericUpDown2.Size = new System.Drawing.Size(90, 20);
            this.blueNumericUpDown2.TabIndex = 0;
            this.blueNumericUpDown2.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // ColorFilteringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 143);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blueNumericUpDown2);
            this.Controls.Add(this.blueNumericUpDown1);
            this.Controls.Add(this.greenNumericUpDown2);
            this.Controls.Add(this.greenNumericUpDown1);
            this.Controls.Add(this.redNumericUpDown2);
            this.Controls.Add(this.redNumericUpDown1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ColorFilteringForm";
            this.Text = "ColorFilteringForm";
            ((System.ComponentModel.ISupportInitialize)(this.redNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redNumericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenNumericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueNumericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown redNumericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown greenNumericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown blueNumericUpDown1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.NumericUpDown redNumericUpDown2;
        private System.Windows.Forms.NumericUpDown greenNumericUpDown2;
        private System.Windows.Forms.NumericUpDown blueNumericUpDown2;
    }
}