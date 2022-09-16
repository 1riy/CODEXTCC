using Microsoft.AspNetCore.Mvc;

[CodexController]
[Route("/Codex")]
public class Codex : CodexBase
{
    [HttpGet("Codex/menu")]

    public string GetIndex()
    {
        var html = System.IO.File.ReadAllText(@".Pages\index.html");

        return base.Content(html, text/html)
    }

}
