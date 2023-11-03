using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace xuanqi.Pages;

[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
[IgnoreAntiforgeryToken]
public class CollaborationModel : PageModel
{
    public List<CollaborationEntry> Storages { get; set; }

    // public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

    private readonly ILogger<CollaborationModel> _logger;

    public CollaborationModel(ILogger<CollaborationModel> logger)
    {
        _logger = logger;
        Storages = new List<CollaborationEntry>
        {
            new() { Name = "老彭语录、百家争鸣、名梗记录etc", Url = """https://lanig8kpv8.xuduan.vip/storageManager/viewOnly/喵喵喵喵喵/生活暗记anki库/\"高中老彭语录&百家争鸣语录！|2022-01-21 15:51:31\"/2da0fb493ca6c05915c7297a10b8c0230d12d7453502204666e51096dbc47129?auth2=b<iS(x|{n+9OO%o2Hl&:""", Description = "致汇文初高中，经典咏流传" }
        };
    }

    public void OnGet()
    {
        // RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
    }

    public string ToTemplate()
    {
        var sb = new System.Text.StringBuilder();
        foreach(var s in Storages)
        {
            sb.AppendLine(s.ToString());
        }
        return sb.ToString();
    }
}

public class CollaborationEntry
{
    public string Name { get; set; } = "";
    public string Url { get; set; } = "";
    public string Description { get; set; } = "";

    public override string ToString() => $"[\"{Name}\", \"{Url}\", \"{Description}\"]";
}