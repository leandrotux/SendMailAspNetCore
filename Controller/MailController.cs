using Microsoft.AspNetCore.Mvc;
using SendMailAspNetCore.models;
using SendMailAspNetCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SendMailAspNetCore.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        private readonly IMailService mailService;
        public MailController(IMailService mailService)
        {
            this.mailService = mailService;
        }
        [HttpPost("send")]
        public async Task<IActionResult> SendMail([FromForm]Mail mail)
        {
            try
            {
                await mailService.SendEmailAsync(mail);
                return Ok();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
