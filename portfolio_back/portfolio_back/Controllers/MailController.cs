
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using portfolio_back.Models;
using portfolio_back.Services;

namespace portfolio_back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController: ControllerBase
    {

       SendMailService sendMailService = new SendMailService();

        [HttpPost]
        [Route("/sendMail")]
        public void sendEmailToMe(MailRequest request)
        {
            sendMailService.sendNotification(request);
        }
    }
}