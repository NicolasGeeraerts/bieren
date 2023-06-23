using Microsoft.AspNetCore.Mvc;

public class MijnFooter : ViewComponent
{
    public IViewComponentResult Invoke(string footerTekst)
    {
        return View((object)footerTekst);
    }
}