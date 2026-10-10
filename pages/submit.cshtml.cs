using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class NameModel : PageModel
{
    // [BindProperty] automatically maps form inputs matching this property name
    [BindProperty]
    public string Username { get; set; } = "";

    // Handles standard GET requests (visiting the page)
    public void OnGet() 
    {
    }

    // Handles POST requests (submitting the form)
    public void OnPost()
    {
        
    }
}