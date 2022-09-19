using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class AgileConfigController: ControllerBase
{
    public AgileConfigController(IOptions<GlobalOptions> options,IOptionsMonitor<GlobalOptions> optionsMonitor,
        IOptionsSnapshot<GlobalOptions> optionsSnapshot)
    {
        Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " IOptions: " + options.Value.OptionsTest);
        Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")+ " IOptionsMonitor: " + optionsMonitor.CurrentValue.OptionsTest);
        Console.WriteLine( DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " IOptionsSnapshot: " + optionsSnapshot.Value.OptionsTest);
    }

    [HttpGet]
    public Task TestAsync()
    {
        return Task.CompletedTask;
    } 
}