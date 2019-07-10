# RomanNumeralsConverter
## Convert a given int into Roman Numerals

### Roman Numeral Rules

* If a numeral appears *after* a larger numeral we shall add it 
* If a numeral appears *before* a larger numeral we shall subtract it
* We don't use the same numeral more than three times in a row (IIII is not to be used)

We only want to support numbers between 1 to 3999. We achieve this by returning null if we're given an int outside this range.
 
### Considerations

Variables used for the min and max values for caveat support. This is for readability and to allow them to be easily found and changed at a later stage if our requirements change.

We return null if we're out of the caveat range as this is unambiguous. We could instead throw an ArgumentOutOfRangeException, however whilst it's stated we don't want to support numbers outside the 1-3999 range, we're not sure that an invalid number being passed through is due to either a developer error (which necessitate using the exception) or a system error. As such, returning a null causes the least friction until we know more about the system and this interface's use.

A dictionary was used to store a map of the roman numerals and their numerical values. The values are stored in order of largest to smallest as we want to work our way across from left to right, largest to smallest numbers i.e. 1000s, 100s, 10s etc.