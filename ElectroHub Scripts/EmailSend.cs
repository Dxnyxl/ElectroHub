using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using UnityEngine.SceneManagement;

public class EmailSend : MonoBehaviour
{
    public TMPro.TMP_InputField Subject;
    public TMPro.TMP_InputField Desciption;
    public void SubmitTicket()
    {
        SceneManager.LoadScene("HelpCentre");
        SendEmail();
        
    }
    public void SendEmail()
    {
        MailMessage mail = new MailMessage();
        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
        SmtpServer.Timeout = 10000;
        SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
        SmtpServer.UseDefaultCredentials = false;
        SmtpServer.Port = 587;

        mail.From = new MailAddress("ticketelectrohub@gmail.com");
        mail.To.Add(new MailAddress("ElectrohubSupport@gmail.com"));

        mail.Subject = Subject.text;
        mail.Body = Desciption.text;


        SmtpServer.Credentials = new System.Net.NetworkCredential("electrohub@mail.com", "electrohub") as ICredentialsByHost; SmtpServer.EnableSsl = true;
        ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        };

        mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
        SmtpServer.Send(mail);
    }
}
