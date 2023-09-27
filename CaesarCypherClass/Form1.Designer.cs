namespace CaesarCypherClass
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
            inputTextBox = new RichTextBox();
            encryptButton = new Button();
            outputTextBox = new RichTextBox();
            encryptV2Button = new Button();
            SuspendLayout();
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(12, 12);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(776, 150);
            inputTextBox.TabIndex = 0;
            inputTextBox.Text = "";
            // 
            // encryptButton
            // 
            encryptButton.Location = new Point(12, 168);
            encryptButton.Name = "encryptButton";
            encryptButton.Size = new Size(382, 43);
            encryptButton.TabIndex = 1;
            encryptButton.Text = "Szyfruj";
            encryptButton.UseVisualStyleBackColor = true;
            encryptButton.Click += Encrypt;
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(12, 217);
            outputTextBox.Name = "outputTextBox";
            outputTextBox.ReadOnly = true;
            outputTextBox.Size = new Size(776, 221);
            outputTextBox.TabIndex = 2;
            outputTextBox.Text = "";
            // 
            // encryptV2Button
            // 
            encryptV2Button.Location = new Point(400, 168);
            encryptV2Button.Name = "encryptV2Button";
            encryptV2Button.Size = new Size(388, 43);
            encryptV2Button.TabIndex = 3;
            encryptV2Button.Text = "Szyfruj V2";
            encryptV2Button.UseVisualStyleBackColor = true;
            encryptV2Button.Click += EncryptV2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(encryptV2Button);
            Controls.Add(outputTextBox);
            Controls.Add(encryptButton);
            Controls.Add(inputTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox inputTextBox;
        private Button encryptButton;
        private RichTextBox outputTextBox;
        private Button encryptV2Button;
    }
}