# RomanNumeralsConverter
## Convert a given int into Roman Numerals

### Roman Numeral Rules

* If a numeral appears *after* a larger numeral we shall add it 
* If a numeral appears *before* a larger numeral we shall subtract it
* We don't use the same numeral more than three times in a row (IIII is not to be used)

We only want to support numbers between 1 to 3999. We achieve this by returning null if we're given an int outside this range.
 
