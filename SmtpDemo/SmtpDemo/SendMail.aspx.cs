using System;
using System.Net;
using System.Net.Mail;

namespace SmtpDemo
{
    public partial class SendMail : System.Web.UI.Page
    {
        protected void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("visualprogrammingsmtp@gmail.com");
                msg.To.Add("visualprogrammingsmtp@gmail.com"); // add your mail
                msg.Subject = "Test Mail";
                msg.Body = "This is a test email sent from ASP.NET using Gmail SMTP.";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("visualprogrammingsmtp@gmail.com", "ojbvqopkdqcxhskt");
                smtp.EnableSsl = true;

                smtp.Send(msg);

                lblMsg.Text = "Mail sent successfully!";
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Error: " + ex.Message;
            }
        }
    }
}
