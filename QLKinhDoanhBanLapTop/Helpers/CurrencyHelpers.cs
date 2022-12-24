namespace QLKinhDoanhBanLapTop.Helpers
{
    internal static class CurrencyHelpers
    {
        public static string FormatCurrency(int currency)
        {
            var result = new Stack<char>();
            var count = 0;
            currency
                .ToString()
                .Reverse()
                .ToList()
                .ForEach(number =>
                {
                    count++;
                    result.Push(number);
                    if (count == 3)
                    {
                        result.Push('.');
                        count = 0;
                    }
                });
            if (currency.ToString().Length % 3 == 0)
            {
                result.Pop();
            }
            return string.Join(string.Empty, result);
        }

        public static int DeFormatCurrency(string formatedCurrency)
        {
            _ = int.TryParse(string.Join(string.Empty,
                    formatedCurrency
                    .Where(character => char.IsNumber(character))
                ), out int result);
            return result;
        }

    }
}
