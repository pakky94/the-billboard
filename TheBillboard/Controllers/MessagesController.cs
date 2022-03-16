using Microsoft.AspNetCore.Mvc;
using TheBillboard.Abstract;
using TheBillboard.Models;

namespace TheBillboard.Controllers;

public class MessagesController : Controller
{
    private readonly IMessageGateway _messageGateway;
    private readonly IAuthorGateway _authorGateway;
    private readonly IMessageViewGateway _messageViewGateway;
    private readonly ILogger<MessagesController> _logger;

    public MessagesController(IMessageGateway messageGateway, ILogger<MessagesController> logger, IAuthorGateway authorGateway, IMessageViewGateway messageViewGateway)
    {
        _messageGateway = messageGateway;
        _logger = logger;
        _authorGateway = authorGateway;
        _messageViewGateway = messageViewGateway;
    }

    public IActionResult Index()
    {
        var messages = _messageViewGateway.GetAll();
        return View(messages);
    }

    [HttpGet]
    public IActionResult Create(int? id)
    {
        var message = id is not null ? _messageGateway.GetById((int)id) : new Message();

        if (message is null)
        {
            // errore
            return View("Error");
        } else
        {
            var viewModel = new MessageCreationViewModel(message, _authorGateway.GetAll());
            return View(viewModel);
        }
    }

    [HttpPost]
    public IActionResult Create(Message message) 
    {
        if (!ModelState.IsValid)
        {
            return View(new MessageCreationViewModel(message, _authorGateway.GetAll()));
        }

        if (message.Id == default)
        {
            _messageGateway.Create(message);
        }
        else
        {
            _messageGateway.Update(message);
        }

        _logger.LogInformation($"Message received: {message.Title}");
        return RedirectToAction("Index");
    }
    
    public IActionResult Detail(int id)
    {
        var message = _messageViewGateway.GetById(id);
        if (message is null)
        {
            // errore
            return View("Error");
        }
        return View(message);
    }
    
    public IActionResult Delete(int id)
    {
        _messageGateway.Delete(id);
        return RedirectToAction("Index");
    }
}