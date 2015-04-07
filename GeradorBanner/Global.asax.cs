using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Net.Mail;
using System.Net;

namespace GeradorBanner
{
    public class Global : System.Web.HttpApplication
    {

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            MailMessage mail = new MailMessage();
            mail.To.Add("silvanopfj@gmail.com");
            mail.Subject = "#START#: MBL-Banner";
            mail.Body = "Start da aplicação." + "<br><br>";
            
            mail.From = new MailAddress("silvanopfj@gmail.com");
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.Credentials = CredentialCache.DefaultNetworkCredentials;
            smtp.Port = 587;
            smtp.Send(mail);
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
        //    // Code that runs when an unhandled error occurs
        //    Exception LastError = Server.GetLastError();
            
            
        //    MailMessage mail = new MailMessage();
        //    mail.To.Add("silvanopfj@gmail.com");
        //    mail.Subject = "#Error#: MBL-Banner";
        //    mail.Body = "Somebody has experienced an error." + "<br><br>";
        //    mail.Body += LastError.ToString();

        //    mail.IsBodyHtml = true;
        //    SmtpClient smtp = new SmtpClient();
        //    smtp.Host = "smtp.gmail.com";
        //    smtp.EnableSsl = true;
        //    smtp.Credentials = CredentialCache.DefaultNetworkCredentials;
        //    smtp.Port = 587;
        //    smtp.Send(mail);


            
        }

        void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started

        }

        void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.

        }

    }
}
