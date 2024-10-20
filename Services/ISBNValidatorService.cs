public class ISBNValidatorService : IISBNValidatorService
{
    public bool ValidateISBN(string isbn)
    {
        if (string.IsNullOrEmpty(isbn)) return false;

        ISBN isbnValidator = isbn.Length == 10 ? new ISBN10(isbn) : new ISBN13(isbn);
        return isbnValidator.IsValid();
    }
}