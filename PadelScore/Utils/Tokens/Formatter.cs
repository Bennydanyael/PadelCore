using System.Globalization;
namespace PadelScore.Utils.Tokens;

public static class Formatter
{
    public static string FormatCurrency(decimal amount)
    {
        var culture = new CultureInfo("id-ID");
        return $"Rp {amount.ToString("#,##0", culture)}";
    }

    public static string FormatDate(DateTime date)
    {
        var culture = new CultureInfo("id-ID");
        return date.ToString("dd MMM", culture);
    }

    public static string FormatNumber(int number)
    {
        var culture = new CultureInfo("id-ID");
        return number.ToString("#,##0", culture);
    }

    public static string FormatShortDay(DateTime date)
    {
        var culture = new CultureInfo("id-ID");
        return date.ToString("ddd", culture);
    }

    public static string FormatTime(TimeSpan time)
    {
        return time.ToString(@"hh\:mm");
    }
}