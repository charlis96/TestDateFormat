using TestDateFormat;
namespace Library.Tests;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CorrectDateTest()
    {
        const string date = "10/11/1997";
        const string expectedDate = "10/11/1997 se convierte a 1997-11-10";
        Assert.AreEqual(expectedDate, DateFormatter.ChangeFormat(date));
    }

    [Test]
    public void IncorrectDateFormatTest()
    {
        const string date = "10/11-997";
        const string expectedDate = "La fecha ingresada no está en el formato correcto.";
        Assert.AreEqual(expectedDate, DateFormatter.ChangeFormat(date));
    }

    [Test]
    public void EmptyDateTest()
    {
        const string date = "";
        const string expectedDate = "La fecha no puede estar vacía.";
        Assert.AreEqual(expectedDate, DateFormatter.ChangeFormat(date));
    }
}