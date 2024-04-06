namespace GmailSender
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
            textBoxID = new TextBox();
            textBoxPassword = new TextBox();
            textBoxSend = new TextBox();
            textBoxSubject = new TextBox();
            textBoxAttachments = new TextBox();
            textBoxMessage = new TextBox();
            textBoxAddress = new TextBox();
            textBoxPort = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            buttonSend = new Button();
            buttonClear = new Button();
            buttonBrowse = new Button();
            SuspendLayout();
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(119, 23);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(149, 23);
            textBoxID.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(119, 67);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(149, 23);
            textBoxPassword.TabIndex = 1;
            // 
            // textBoxSend
            // 
            textBoxSend.Location = new Point(119, 116);
            textBoxSend.Name = "textBoxSend";
            textBoxSend.Size = new Size(149, 23);
            textBoxSend.TabIndex = 2;
            // 
            // textBoxSubject
            // 
            textBoxSubject.Location = new Point(119, 165);
            textBoxSubject.Name = "textBoxSubject";
            textBoxSubject.Size = new Size(278, 23);
            textBoxSubject.TabIndex = 3;
            // 
            // textBoxAttachments
            // 
            textBoxAttachments.Location = new Point(119, 212);
            textBoxAttachments.Name = "textBoxAttachments";
            textBoxAttachments.ReadOnly = true;
            textBoxAttachments.Size = new Size(278, 23);
            textBoxAttachments.TabIndex = 4;
            // 
            // textBoxMessage
            // 
            textBoxMessage.Location = new Point(119, 274);
            textBoxMessage.Multiline = true;
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.Size = new Size(647, 135);
            textBoxMessage.TabIndex = 5;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(651, 23);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(115, 23);
            textBoxAddress.TabIndex = 6;
            textBoxAddress.Text = "smtp.gmail.com";
            // 
            // textBoxPort
            // 
            textBoxPort.Location = new Point(651, 67);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.Size = new Size(115, 23);
            textBoxPort.TabIndex = 7;
            textBoxPort.Text = "587";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(560, 26);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 8;
            label1.Text = "Server address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(607, 70);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 9;
            label2.Text = "Port:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 26);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 10;
            label3.Text = "Gmail ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 70);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 11;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 119);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 12;
            label5.Text = "Send to:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 168);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 13;
            label6.Text = "Subject:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 215);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 14;
            label7.Text = "Attachments:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 274);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 15;
            label8.Text = "Message:";
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(691, 415);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(75, 23);
            buttonSend.TabIndex = 16;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(607, 415);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 17;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonBrowse
            // 
            buttonBrowse.Location = new Point(417, 211);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(75, 23);
            buttonBrowse.TabIndex = 18;
            buttonBrowse.Text = "Browse";
            buttonBrowse.UseVisualStyleBackColor = true;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBrowse);
            Controls.Add(buttonClear);
            Controls.Add(buttonSend);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPort);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxMessage);
            Controls.Add(textBoxAttachments);
            Controls.Add(textBoxSubject);
            Controls.Add(textBoxSend);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxID);
            Name = "Form1";
            Text = "Gmail Sender";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxID;
        private TextBox textBoxPassword;
        private TextBox textBoxSend;
        private TextBox textBoxSubject;
        private TextBox textBoxAttachments;
        private TextBox textBoxMessage;
        private TextBox textBoxAddress;
        private TextBox textBoxPort;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button buttonSend;
        private Button buttonClear;
        private Button buttonBrowse;
    }
}
