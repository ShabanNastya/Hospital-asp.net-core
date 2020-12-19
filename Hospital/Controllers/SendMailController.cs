using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using Hospital.Models;


namespace Hospital.Controllers
{
    public class SendEmailController : Controller
    {
        public IActionResult Sending()
        {
            return View();
        }
        
        // GET
        [HttpPost]
        public IActionResult Sending(Email em)
        {
            string to = em.To;
            string subject = em.Subject; 
            string body = em.Body; 
            MailMessage mm = new MailMessage();
            mm.To.Add(to);
            mm.Subject = subject;
            mm.Body = body;
            mm.IsBodyHtml = false;
            SmtpClient smtp = new SmtpClient("shabannastya1402@gmail.com");
            smtp.Port = 587;
            smtp.UseDefaultCredentials = true;
            smtp.EnableSsl = true;
            smtp.Send(mm);
            return View();
        }
    }
}