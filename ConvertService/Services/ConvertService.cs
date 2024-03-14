using System.Text;

public class ConvertService : IConvertService
{
  public string ConvertNumberToText(string Number)
  {
    string[] arrPlace = { "", "thousand", "million", "billion", "trillion" };
    StringBuilder sb = new StringBuilder();
    string[] parts = Number.Split('.');
    string integer = parts[0];
    string decimalPart = parts.Length > 1 ? parts[1] : "";

    int place = 0;
    string numText = "";

    for (int i = integer.Length; i > 0; i -= 3)
    {
      place++;
      string text = DoNumberToText(integer.Substring(Math.Max(0, i - 3), Math.Min(3, i)), arrPlace[place - 1]);
      if (text != "") {
        sb.Append(text);
        sb.Append(" ");
      }
      sb.Append(numText);
      numText = sb.ToString();
      sb.Clear();
    }

    string textDecimal = !string.IsNullOrEmpty(decimalPart) ? DoNumberToText(decimalPart, "") : "";
    return $"{numText.Trim()}{(!string.IsNullOrEmpty(textDecimal) ? " and " + textDecimal.Trim() : "")}";
  }

  private string DoNumberToText(string part, string place)
  {
    if (part == "0") return "zero";
    if (part == "000") place = "";
    string[] tensPlace = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
    string[] teenPlace = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
    string[] twentiesPlace = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

    string text3 = "", text2 = "", text1 = "";
    string digit3 = "", digit2 = "", digit1 = "";

    switch (part.Length)
    {
        case 1: digit1 = part; break;
        case 2: digit2 = part[0].ToString(); digit1 = part[1].ToString(); break;
        case 3: digit3 = part[0].ToString(); digit2 = part[1].ToString(); digit1 = part[2].ToString(); break;
        default: break;
    }

    if (digit3 != "")
    {
      text3 = digit3 == "0" ? "" : $"{tensPlace[int.Parse(digit3) - 1]} hundred ";
    }

    if (digit2 != "")
    {
      if (digit2 == "1")
      {
        text2 = $"{teenPlace[int.Parse(digit1)]} ";
      }
      else
      {
        text2 = digit2 == "0" ? "" : $"{twentiesPlace[int.Parse(digit2) - 2]} ";
      }
    }

    if (digit1 != "" && digit1 != "0" && digit2 != "1")
    {
      text1 = $"{tensPlace[int.Parse(digit1) - 1]} ";
    }

    return text3 + text2 + text1 + place;
  }
}