using System;
using System.Collections.Generic;
using System.Threading;

public class ConvertServiceTests
{
  private readonly ConvertService _convertService;

  public ConvertServiceTests()
  {
      _convertService = new ConvertService();
  }

  public void ConvertNumberToText_Test()
  {
    Console.WriteLine("Test for zero integer");
    ConvertNumberToText_RunTest("0.99", "zero and ninety nine");

    Console.WriteLine("Test for tensPlace");
    ConvertNumberToText_RunTest("1", "one");
    ConvertNumberToText_RunTest("5", "five");
    ConvertNumberToText_RunTest("9", "nine");

    Console.WriteLine("Test for teenPlace");
    ConvertNumberToText_RunTest("10", "ten");
    ConvertNumberToText_RunTest("15", "fifteen");
    ConvertNumberToText_RunTest("19", "nineteen");

    Console.WriteLine("Test for twentiesPlace");
    ConvertNumberToText_RunTest("20", "twenty");
    ConvertNumberToText_RunTest("50", "fifty");
    ConvertNumberToText_RunTest("90", "ninety");

    Console.WriteLine("Test for places");
    ConvertNumberToText_RunTest("100", "one hundred");
    ConvertNumberToText_RunTest("1000", "one thousand");
    ConvertNumberToText_RunTest("10000", "ten thousand");
    ConvertNumberToText_RunTest("100000", "one hundred thousand");
    ConvertNumberToText_RunTest("1000000", "one million");
    ConvertNumberToText_RunTest("10000000", "ten million");
    ConvertNumberToText_RunTest("100000000", "one hundred million");
    ConvertNumberToText_RunTest("1000000000", "one billion");
    ConvertNumberToText_RunTest("10000000000", "ten billion");
    ConvertNumberToText_RunTest("100000000000", "one hundred billion");
    ConvertNumberToText_RunTest("1000000000000", "one trillion");
    ConvertNumberToText_RunTest("10000000000000", "ten trillion");
    ConvertNumberToText_RunTest("100000000000000", "one hundred trillion");

    Console.WriteLine("Other Test Cases A");
    ConvertNumberToText_RunTest("121.13", "one hundred twenty one and thirteen");
    ConvertNumberToText_RunTest("1201.13", "one thousand two hundred one and thirteen");
    ConvertNumberToText_RunTest("12001.13", "twelve thousand one and thirteen");
    ConvertNumberToText_RunTest("120001.13", "one hundred twenty thousand one and thirteen");
    ConvertNumberToText_RunTest("1200001.13", "one million two hundred thousand one and thirteen");
    ConvertNumberToText_RunTest("12000001.13", "twelve million one and thirteen");
    ConvertNumberToText_RunTest("120000001.13", "one hundred twenty million one and thirteen");
    ConvertNumberToText_RunTest("1200000001.13", "one billion two hundred million one and thirteen");
    ConvertNumberToText_RunTest("12000000001.13", "twelve billion one and thirteen");
    ConvertNumberToText_RunTest("120000000001.13", "one hundred twenty billion one and thirteen");
    ConvertNumberToText_RunTest("1200000000001.13", "one trillion two hundred billion one and thirteen");
    ConvertNumberToText_RunTest("12000000000001.13", "twelve trillion one and thirteen");
    ConvertNumberToText_RunTest("120000000000001.13", "one hundred twenty trillion one and thirteen");

    Console.WriteLine("Other Test Cases B");
    ConvertNumberToText_RunTest("1.13", "one and thirteen");
    ConvertNumberToText_RunTest("12.13", "twelve and thirteen");
    ConvertNumberToText_RunTest("123.13", "one hundred twenty three and thirteen");
    ConvertNumberToText_RunTest("1234.13", "one thousand two hundred thirty four and thirteen");
    ConvertNumberToText_RunTest("12345.13", "twelve thousand three hundred forty five and thirteen");
    ConvertNumberToText_RunTest("123456.13", "one hundred twenty three thousand four hundred fifty six and thirteen");
    ConvertNumberToText_RunTest("1234567.13", "one million two hundred thirty four thousand five hundred sixty seven and thirteen");
    ConvertNumberToText_RunTest("12345678.13", "twelve million three hundred forty five thousand six hundred seventy eight and thirteen");
    ConvertNumberToText_RunTest("123456789.13", "one hundred twenty three million four hundred fifty six thousand seven hundred eighty nine and thirteen");
    ConvertNumberToText_RunTest("9123456789.13", "nine billion one hundred twenty three million four hundred fifty six thousand seven hundred eighty nine and thirteen");
    ConvertNumberToText_RunTest("89123456789.13", "eighty nine billion one hundred twenty three million four hundred fifty six thousand seven hundred eighty nine and thirteen");
    ConvertNumberToText_RunTest("789123456789.13", "seven hundred eighty nine billion one hundred twenty three million four hundred fifty six thousand seven hundred eighty nine and thirteen");
    ConvertNumberToText_RunTest("6789123456789.13", "six trillion seven hundred eighty nine billion one hundred twenty three million four hundred fifty six thousand seven hundred eighty nine and thirteen");
    ConvertNumberToText_RunTest("56789123456789.13", "fifty six trillion seven hundred eighty nine billion one hundred twenty three million four hundred fifty six thousand seven hundred eighty nine and thirteen");
    ConvertNumberToText_RunTest("456789123456789.13", "four hundred fifty six trillion seven hundred eighty nine billion one hundred twenty three million four hundred fifty six thousand seven hundred eighty nine and thirteen");

    Console.WriteLine("End");
  }

  private void ConvertNumberToText_RunTest(string input, string expectedOutput)
  {
    string actualOutput = _convertService.ConvertNumberToText(input);

    if (actualOutput == expectedOutput)
    {
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine($"Test Passed:\n\tCorrect: {input} | {actualOutput}");
    }
    else
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine($"Test Failed:\n\tWrong: {input} | {actualOutput}\n\tExpectation: {expectedOutput}");
    }

    Console.ResetColor();
    Thread.Sleep(500);
  }
}