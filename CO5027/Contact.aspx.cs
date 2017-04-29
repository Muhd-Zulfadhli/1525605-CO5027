using System;
using System.Net.Mail;

namespace CO5027.Pages
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitbtn_click_Click(object sender, EventArgs e)
        {

            //settings sepcific to the mail service, e.g. server location, port number and that ssl is required
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;

            //create credentials - e.g. username and password for the account
            System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("ohmyg2wd@gmail.com", "zulfadhli");
            smtpClient.Credentials = credentials;


            MailMessage msg = new MailMessage("ohmyg2wd@gmail.com", emailtxtbox.Text);
            msg.Subject = "Name: " + nametxtbox.Text + " Topic: " + topictxtbox.Text;
            msg.Body = messagetextbox.Text;

            

            
            

            //display success to the user
            try
            {
                smtpClient.Send(msg);
                litResult.Text = "<p>Success, mail sent using SMTP with secure connection and credentials</p>";
            }
            catch (Exception ex)
            {
                //display the full error to the user
                litResult.Text = "<p>Send failed: " + ex.Message + ":" + ex.InnerException + "</p>";
            }
        }
    }
}