using Microsoft.AspNetCore.Mvc;
using TheBillboard.Abstract;
using TheBillboard.Models;

namespace TheBillboard.Controllers;

public class MessagesController : Controller
{
    private readonly IMessageGateway _messageGateway;
    private readonly ILogger<MessagesController> _logger;

    public MessagesController(IMessageGateway messageGateway, ILogger<MessagesController> logger)
    {
        _messageGateway = messageGateway;
        _logger = logger;
    }
    
    public IActionResult Index()
    {
        var messages = _messageGateway.GetAll();
        return View(messages);
    }

    [HttpPost]
    public void Create(Message message) 
    {
        _logger.LogInformation($"Message received: {message.Title}");   
    }
    
    public IActionResult Detail(int id)
    {
        var message = _messageGateway.GetById(id);
        return View(message);
    }
    
    public IActionResult Create()
    {
        return View();
    }

    public IActionResult Delete(int id)
    {
        _messageGateway.Delete(id);
        return RedirectToAction("Index");
    }
}