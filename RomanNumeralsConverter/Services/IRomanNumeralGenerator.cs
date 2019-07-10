namespace RomanNumeralsConverter.Services
{
    public interface IRomanNumeralGenerator
    {
        /// <summary>
        /// Converts any integer number from 1 to 3999 into a Roman Numeral
        /// </summary>
        /// <param name="number">Integer value to convert</param>
        /// <returns></returns>
        string Generate(int number);
    }
}
