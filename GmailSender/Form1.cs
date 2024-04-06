using System.Net.Mail;
using System.Net;

namespace GmailSender
{
    public partial class Form1 : Form
    {
        MailMessage message = new MailMessage();


        public Form1()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxSend.Text = string.Empty;
            textBoxSubject.Text = string.Empty;
            textBoxAttachments.Text = string.Empty;

            textBoxMessage.Text = string.Empty;

            message.Attachments.Clear();
        }

        private async void buttonSend_Click(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress(textBoxID.Text);
            MailAddress to = new MailAddress(textBoxSend.Text);

            message.From = from;
            message.To.Add(to);

            message.Subject = textBoxSubject.Text;
            message.Body = textBoxMessage.Text;

            SmtpClient smtpClient = new SmtpClient(textBoxAddress.Text, int.Parse(textBoxPort.Text));
            smtpClient.Credentials = new NetworkCredential(textBoxID.Text, textBoxPassword.Text);
            smtpClient.EnableSsl = true;
            
            try
            {
                await smtpClient.SendMailAsync(message);
                MessageBox.Show($"Your email was successfully sent", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*";
            openFileDialog.Title = "Select File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if(textBoxAttachments.Text.Length != 0)
                {
                    textBoxAttachments.Text += ", ";
                }
                textBoxAttachments.Text += openFileDialog.FileName;

                message.Attachments.Add(new Attachment(openFileDialog.FileName));
            }
        }
    }
}
