using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class ISBNController : ControllerBase
{
    private readonly IISBNValidatorService _isbnValidatorService;

    public ISBNController(IISBNValidatorService isbnValidatorService)
    {
        _isbnValidatorService = isbnValidatorService;
    }

    [HttpGet("validate")]
    public IActionResult ValidateISBN([FromQuery] string isbn)
    {
        if (string.IsNullOrWhiteSpace(isbn)) return BadRequest("ISBN cannot be null or empty.");

        bool isValid = _isbnValidatorService.ValidateISBN(isbn);

        return isValid ? Ok($"{isbn} is a valid ISBN.") : BadRequest($"{isbn} is an invalid ISBN.");
    }
}