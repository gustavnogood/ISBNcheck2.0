public class ISBN13 : ISBN
{
    public ISBN13(string number) : base(number) {}

    public override bool IsValid()
    {
        if (Number.Length != 13) return false;

        int sum = 0;
        for (int i = 0; i < 13; i++)
        {
            if (!char.IsDigit(Number[i])) return false;
            int digit = Number[i] - '0';
            sum += (i % 2 == 0) ? digit : digit * 3;
        }

        return sum % 10 == 0;
    }
}