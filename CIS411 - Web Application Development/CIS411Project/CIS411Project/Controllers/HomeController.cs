using CIS411Project.Data;
using CIS411Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CIS411Project.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    /*public IActionResult Privacy()
    {
        return View();
    }*/

    public IActionResult Send()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Send([Bind("MessageReceiver, MessageContent")] Message message)
    {

        message.MessageTime = DateTime.Now;
        message.MessageSender = HttpContext.User.Identity.Name;

        MessageDBContext db = new MessageDBContext();
        List<Message> messages = db.Message.ToList<Message>();
        db.Add(message);
        messages.Add(message);
        db.SaveChanges();
        return RedirectToAction("Sent");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Inbox()
    {
        if (HttpContext.User.Identity.Name == null || HttpContext.User.Identity.IsAuthenticated == false)
        {
            Response.Redirect("/Index");
        }
        else
        {
            MessageDBContext db = new MessageDBContext();
            List<Message> messages = db.Message.ToList<Message>();

            List<Message> userMessage = new List<Message>();
            foreach (Message message in messages)
            {
                if (message.MessageReceiver == HttpContext.User.Identity.Name.ToLower())
                {
                    userMessage.Add(message);
                }
            }
            return View(userMessage);
        }
        return View();
    }
    public IActionResult Sent()
    {
        if (HttpContext.User.Identity.Name == null || HttpContext.User.Identity.IsAuthenticated == false)
        {
            Response.Redirect("/Index");
        }
        else
        {
            MessageDBContext db = new MessageDBContext();
            List<Message> messages = db.Message.ToList<Message>();

            List<Message> userMessage = new List<Message>();
            foreach (Message message in messages)
            {
                if (message.MessageSender == HttpContext.User.Identity.Name.ToLower())
                {
                    userMessage.Add(message);
                }
            }
            return View(userMessage);
        }
        return View();
    }

    [HttpGet]
    public async Task<IActionResult> DeleteInbox(int id)
    {
        MessageDBContext db = new MessageDBContext();
        var deleteMessage = await db.Message.FindAsync(id);
        db.Message.Remove(deleteMessage);
        await db.SaveChangesAsync();
        return RedirectToAction("Inbox");
    }
    [HttpGet]
    public async Task<IActionResult> DeleteSent(int id)
    {
        MessageDBContext db = new MessageDBContext();
        var deleteMessage = await db.Message.FindAsync(id);
        db.Message.Remove(deleteMessage);
        await db.SaveChangesAsync();
        return RedirectToAction("Sent");
    }

}
