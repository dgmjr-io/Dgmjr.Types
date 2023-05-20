namespace System.Globalization;

public partial class LanguageCodeCulture : System.Globalization.CultureInfo
{
  public LanguageCodeCulture(string languageCode) : this()
  {
    try { value = LanguageCodeCulture.FromShortName(languageCode); }
    catch { throw new OutOfRangeException($"{languageCode} was not recognized as a valid culture code by C#"); }
  }
}
