public class ISBN10 : ISBN
{
    public ISBN10(string number) : base(number) {}

    public override bool IsValid()
    {
        if (Number.Length != 10) return false;

        int sum = 0;
        for (int i = 0; i < 9; i++)
        {
            if (!char.IsDigit(Number[i])) return false;
            sum += (Number[i] - '0') * (10 - i);
        }

        char lastChar = Number[9];
        if (lastChar == 'X') sum += 10;
        else if (char.IsDigit(lastChar)) sum += (lastChar - '0');
        else return false;

        return sum % 11 == 0;
    }
}