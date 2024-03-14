using dotnetflix.Models.Dtos.Email;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace dotnetflix.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmailController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> SendEmail([FromBody] EmailDto emailDto)
    {
        var emailMessage = new MimeMessage();

        emailMessage.From.Add(new MailboxAddress("Elisha McClure", "elisha.mcclure@ethereal.email"));
        emailMessage.To.Add(new MailboxAddress("", emailDto.Recipient));
        emailMessage.Subject = emailDto.Subject;
        emailMessage.Body = new TextPart("plain") { Text = emailDto.Message };

        using (var client = new SmtpClient())
        {
            await client.ConnectAsync("smtp.ethereal.email", 587, false);
            await client.AuthenticateAsync("elisha.mcclure@ethereal.email", "6uKpb8uc7yDRbNjSnV");
            await client.SendAsync(emailMessage);

            await client.DisconnectAsync(true);
        }

        return Ok();
    }
}