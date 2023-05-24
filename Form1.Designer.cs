namespace CipherApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EncryptMessageButton = new Button();
            InputTextBox = new RichTextBox();
            OutputEncryptedTextBox = new RichTextBox();
            CopyEncryptionButton = new Button();
            splitContainer1 = new SplitContainer();
            OutputDecryptedTextbox = new RichTextBox();
            InputDecryptBox = new RichTextBox();
            DecryptButton = new Button();
            PasteTextButton = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // EncryptMessageButton
            // 
            EncryptMessageButton.Location = new Point(36, 19);
            EncryptMessageButton.Name = "EncryptMessageButton";
            EncryptMessageButton.Size = new Size(140, 23);
            EncryptMessageButton.TabIndex = 0;
            EncryptMessageButton.Text = "Encrypt Message";
            EncryptMessageButton.UseVisualStyleBackColor = true;
            EncryptMessageButton.Click += EncryptMessageButton_Click;
            // 
            // InputTextBox
            // 
            InputTextBox.BorderStyle = BorderStyle.FixedSingle;
            InputTextBox.Location = new Point(36, 48);
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(140, 103);
            InputTextBox.TabIndex = 1;
            InputTextBox.Text = "";
            // 
            // OutputEncryptedTextBox
            // 
            OutputEncryptedTextBox.BorderStyle = BorderStyle.FixedSingle;
            OutputEncryptedTextBox.Location = new Point(36, 157);
            OutputEncryptedTextBox.Name = "OutputEncryptedTextBox";
            OutputEncryptedTextBox.ReadOnly = true;
            OutputEncryptedTextBox.Size = new Size(140, 109);
            OutputEncryptedTextBox.TabIndex = 2;
            OutputEncryptedTextBox.Text = "";
            // 
            // CopyEncryptionButton
            // 
            CopyEncryptionButton.Location = new Point(36, 272);
            CopyEncryptionButton.Name = "CopyEncryptionButton";
            CopyEncryptionButton.Size = new Size(140, 23);
            CopyEncryptionButton.TabIndex = 3;
            CopyEncryptionButton.Text = "Copy Encryption";
            CopyEncryptionButton.UseVisualStyleBackColor = true;
            CopyEncryptionButton.Click += CopyEncryptionButton_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(InputTextBox);
            splitContainer1.Panel1.Controls.Add(EncryptMessageButton);
            splitContainer1.Panel1.Controls.Add(CopyEncryptionButton);
            splitContainer1.Panel1.Controls.Add(OutputEncryptedTextBox);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(OutputDecryptedTextbox);
            splitContainer1.Panel2.Controls.Add(InputDecryptBox);
            splitContainer1.Panel2.Controls.Add(DecryptButton);
            splitContainer1.Panel2.Controls.Add(PasteTextButton);
            splitContainer1.Size = new Size(450, 310);
            splitContainer1.SplitterDistance = 212;
            splitContainer1.TabIndex = 4;
            // 
            // OutputDecryptedTextbox
            // 
            OutputDecryptedTextbox.Location = new Point(46, 157);
            OutputDecryptedTextbox.Name = "OutputDecryptedTextbox";
            OutputDecryptedTextbox.ReadOnly = true;
            OutputDecryptedTextbox.Size = new Size(140, 104);
            OutputDecryptedTextbox.TabIndex = 3;
            OutputDecryptedTextbox.Text = "";
            // 
            // InputDecryptBox
            // 
            InputDecryptBox.Location = new Point(46, 48);
            InputDecryptBox.Name = "InputDecryptBox";
            InputDecryptBox.Size = new Size(140, 103);
            InputDecryptBox.TabIndex = 2;
            InputDecryptBox.Text = "";
            // 
            // DecryptButton
            // 
            DecryptButton.Location = new Point(46, 19);
            DecryptButton.Name = "DecryptButton";
            DecryptButton.Size = new Size(104, 23);
            DecryptButton.TabIndex = 1;
            DecryptButton.Text = "Decrypt Text";
            DecryptButton.UseVisualStyleBackColor = true;
            DecryptButton.Click += DecryptButton_Click;
            // 
            // PasteTextButton
            // 
            PasteTextButton.Location = new Point(156, 19);
            PasteTextButton.Name = "PasteTextButton";
            PasteTextButton.Size = new Size(75, 23);
            PasteTextButton.TabIndex = 0;
            PasteTextButton.Text = "Paste Text";
            PasteTextButton.UseVisualStyleBackColor = true;
            PasteTextButton.Click += PasteTextButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 334);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button EncryptMessageButton;
        private RichTextBox InputTextBox;
        private RichTextBox OutputEncryptedTextBox;
        private Button CopyEncryptionButton;
        private SplitContainer splitContainer1;
        private RichTextBox OutputDecryptedTextbox;
        private RichTextBox InputDecryptBox;
        private Button DecryptButton;
        private Button PasteTextButton;
    }
}