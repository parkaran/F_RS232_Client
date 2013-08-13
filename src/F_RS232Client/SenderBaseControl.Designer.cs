﻿namespace F_RS232Client
{
    partial class SenderBaseControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sentDataRichTextBox = new System.Windows.Forms.RichTextBox();
            this.dataToSendTextBox = new System.Windows.Forms.TextBox();
            this.displayModeGroupBox = new System.Windows.Forms.GroupBox();
            this.asciiDMRadioButton = new System.Windows.Forms.RadioButton();
            this.decDMRadioButton = new System.Windows.Forms.RadioButton();
            this.hexDMRadioButton = new System.Windows.Forms.RadioButton();
            this.octDMRadioButton = new System.Windows.Forms.RadioButton();
            this.clearConsoleButton = new System.Windows.Forms.Button();
            this.circularSendingGroupBox = new System.Windows.Forms.GroupBox();
            this.intervalCSTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startStopCSButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.displayModeGroupBox.SuspendLayout();
            this.circularSendingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sentDataRichTextBox
            // 
            this.sentDataRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sentDataRichTextBox.Location = new System.Drawing.Point(3, 3);
            this.sentDataRichTextBox.Name = "sentDataRichTextBox";
            this.sentDataRichTextBox.ReadOnly = true;
            this.sentDataRichTextBox.Size = new System.Drawing.Size(502, 188);
            this.sentDataRichTextBox.TabIndex = 0;
            this.sentDataRichTextBox.Text = "";
            // 
            // dataToSendTextBox
            // 
            this.dataToSendTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataToSendTextBox.Location = new System.Drawing.Point(3, 194);
            this.dataToSendTextBox.Name = "dataToSendTextBox";
            this.dataToSendTextBox.Size = new System.Drawing.Size(502, 20);
            this.dataToSendTextBox.TabIndex = 1;
            // 
            // displayModeGroupBox
            // 
            this.displayModeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.displayModeGroupBox.Controls.Add(this.octDMRadioButton);
            this.displayModeGroupBox.Controls.Add(this.hexDMRadioButton);
            this.displayModeGroupBox.Controls.Add(this.decDMRadioButton);
            this.displayModeGroupBox.Controls.Add(this.asciiDMRadioButton);
            this.displayModeGroupBox.Location = new System.Drawing.Point(511, 3);
            this.displayModeGroupBox.Name = "displayModeGroupBox";
            this.displayModeGroupBox.Size = new System.Drawing.Size(122, 69);
            this.displayModeGroupBox.TabIndex = 2;
            this.displayModeGroupBox.TabStop = false;
            this.displayModeGroupBox.Text = "Display Mode";
            // 
            // asciiDMRadioButton
            // 
            this.asciiDMRadioButton.AutoSize = true;
            this.asciiDMRadioButton.Location = new System.Drawing.Point(6, 19);
            this.asciiDMRadioButton.Name = "asciiDMRadioButton";
            this.asciiDMRadioButton.Size = new System.Drawing.Size(52, 17);
            this.asciiDMRadioButton.TabIndex = 0;
            this.asciiDMRadioButton.TabStop = true;
            this.asciiDMRadioButton.Text = "ASCII";
            this.asciiDMRadioButton.UseVisualStyleBackColor = true;
            // 
            // decDMRadioButton
            // 
            this.decDMRadioButton.AutoSize = true;
            this.decDMRadioButton.Location = new System.Drawing.Point(6, 42);
            this.decDMRadioButton.Name = "decDMRadioButton";
            this.decDMRadioButton.Size = new System.Drawing.Size(47, 17);
            this.decDMRadioButton.TabIndex = 1;
            this.decDMRadioButton.TabStop = true;
            this.decDMRadioButton.Text = "DEC";
            this.decDMRadioButton.UseVisualStyleBackColor = true;
            // 
            // hexDMRadioButton
            // 
            this.hexDMRadioButton.AutoSize = true;
            this.hexDMRadioButton.Location = new System.Drawing.Point(64, 19);
            this.hexDMRadioButton.Name = "hexDMRadioButton";
            this.hexDMRadioButton.Size = new System.Drawing.Size(47, 17);
            this.hexDMRadioButton.TabIndex = 2;
            this.hexDMRadioButton.TabStop = true;
            this.hexDMRadioButton.Text = "HEX";
            this.hexDMRadioButton.UseVisualStyleBackColor = true;
            // 
            // octDMRadioButton
            // 
            this.octDMRadioButton.AutoSize = true;
            this.octDMRadioButton.Location = new System.Drawing.Point(64, 42);
            this.octDMRadioButton.Name = "octDMRadioButton";
            this.octDMRadioButton.Size = new System.Drawing.Size(47, 17);
            this.octDMRadioButton.TabIndex = 3;
            this.octDMRadioButton.TabStop = true;
            this.octDMRadioButton.Text = "OCT";
            this.octDMRadioButton.UseVisualStyleBackColor = true;
            // 
            // clearConsoleButton
            // 
            this.clearConsoleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearConsoleButton.Location = new System.Drawing.Point(511, 78);
            this.clearConsoleButton.Name = "clearConsoleButton";
            this.clearConsoleButton.Size = new System.Drawing.Size(122, 25);
            this.clearConsoleButton.TabIndex = 3;
            this.clearConsoleButton.Text = "Clear Console";
            this.clearConsoleButton.UseVisualStyleBackColor = true;
            // 
            // circularSendingGroupBox
            // 
            this.circularSendingGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.circularSendingGroupBox.Controls.Add(this.startStopCSButton);
            this.circularSendingGroupBox.Controls.Add(this.label1);
            this.circularSendingGroupBox.Controls.Add(this.intervalCSTextBox);
            this.circularSendingGroupBox.Location = new System.Drawing.Point(511, 109);
            this.circularSendingGroupBox.Name = "circularSendingGroupBox";
            this.circularSendingGroupBox.Size = new System.Drawing.Size(122, 74);
            this.circularSendingGroupBox.TabIndex = 4;
            this.circularSendingGroupBox.TabStop = false;
            this.circularSendingGroupBox.Text = "Circular Sending";
            // 
            // intervalCSTextBox
            // 
            this.intervalCSTextBox.Location = new System.Drawing.Point(6, 19);
            this.intervalCSTextBox.Name = "intervalCSTextBox";
            this.intervalCSTextBox.Size = new System.Drawing.Size(84, 20);
            this.intervalCSTextBox.TabIndex = 0;
            this.intervalCSTextBox.Text = "1000";
            this.intervalCSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ms";
            // 
            // startStopCSButton
            // 
            this.startStopCSButton.Location = new System.Drawing.Point(6, 45);
            this.startStopCSButton.Name = "startStopCSButton";
            this.startStopCSButton.Size = new System.Drawing.Size(110, 23);
            this.startStopCSButton.TabIndex = 2;
            this.startStopCSButton.Text = "Start";
            this.startStopCSButton.UseVisualStyleBackColor = true;
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Location = new System.Drawing.Point(511, 192);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(122, 23);
            this.sendButton.TabIndex = 5;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // SenderBaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.circularSendingGroupBox);
            this.Controls.Add(this.clearConsoleButton);
            this.Controls.Add(this.displayModeGroupBox);
            this.Controls.Add(this.dataToSendTextBox);
            this.Controls.Add(this.sentDataRichTextBox);
            this.Name = "SenderBaseControl";
            this.Size = new System.Drawing.Size(636, 217);
            this.displayModeGroupBox.ResumeLayout(false);
            this.displayModeGroupBox.PerformLayout();
            this.circularSendingGroupBox.ResumeLayout(false);
            this.circularSendingGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox sentDataRichTextBox;
        private System.Windows.Forms.TextBox dataToSendTextBox;
        private System.Windows.Forms.GroupBox displayModeGroupBox;
        private System.Windows.Forms.RadioButton octDMRadioButton;
        private System.Windows.Forms.RadioButton hexDMRadioButton;
        private System.Windows.Forms.RadioButton decDMRadioButton;
        private System.Windows.Forms.RadioButton asciiDMRadioButton;
        private System.Windows.Forms.Button clearConsoleButton;
        private System.Windows.Forms.GroupBox circularSendingGroupBox;
        private System.Windows.Forms.Button startStopCSButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox intervalCSTextBox;
        private System.Windows.Forms.Button sendButton;
    }
}