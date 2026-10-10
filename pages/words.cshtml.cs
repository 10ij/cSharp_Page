using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class WordsModel : PageModel
{
    // [BindProperty] automatically maps form inputs matching this property name
    [BindProperty]
    public string Words { get; set; } = "";

    public int? WordCount { get; set; }

    // Handles standard GET requests (visiting the page)
    public void OnGet() 
    {
    }

    // Handles POST requests (submitting the form)
    public void OnPost()
    {
        // Explicitly safe-check and count
        WordCount = Words?.Length ?? 0;
    }
}