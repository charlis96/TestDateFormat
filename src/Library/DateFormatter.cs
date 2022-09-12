namespace TestDateFormat;

/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{

    /// <summary>
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
    /// asumido.
    /// </summary>
    /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
    /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
    public static string ChangeFormat(string date)
    {

        if (String.IsNullOrEmpty(date))
        {
            return "La fecha no puede estar vacía.";
        }

        else if (!CorrectFormat(date))
        {
            return "La fecha ingresada no está en el formato correcto.";
        }

        else
        {
            return $"{date} se convierte a {date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2)}";
        }
    }

    public static bool CorrectFormat(string date)
    {
        if (date.Length != 10)
        {
            return false;
        }
        else if (date.Substring(2, 1) != "/" || date.Substring(5, 1) != "/")
        {
            return false;
        }
        else
        {
            int Month = Int32.Parse(date.Substring(3, 2));
            int Day = Int32.Parse(date.Substring(0, 2));
            bool Correct = false;
            List<int> LongMonths = new List<int> { 01, 03, 05, 07, 08, 10, 12 };
            List<int> ShortMonths = new List<int> { 02, 04, 06, 09, 11 };
            if (LongMonths.Contains(Month) && Day <= 31 && Day > 0)
            {
                Correct = true;
            }
            else if (ShortMonths.Contains(Month) && Day <= 30 && Day > 0)
            {
                Correct = true;
            }
            else if (Month == 02 && Day <= 28 && Day > 0)
            {
                Correct = true;
            }
            return Correct;
        }
    }
}
