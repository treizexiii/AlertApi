﻿using AlertAPi.Models;
using Microsoft.AspNetCore.Mvc;

namespace AlertAPi.Controllers;

[ApiController]
[Route("[controller]")]
public class AlertController : Controller
{
    private readonly ILogger<AlertController> _logger;

    public AlertController(ILogger<AlertController> logger)
    {
        _logger = logger;
    }
    
    [HttpPost("{method}")]
    public IActionResult Alert(string method)
    {
        var ip = HttpContext.Connection.RemoteIpAddress;
        _logger.LogInformation("{Method} called from {@Ip}", method, ip);
        return Ok("AlertController.Alert() called");
    }
}