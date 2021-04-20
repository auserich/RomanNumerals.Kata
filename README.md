# RomanNumerals.Kata

## Explanation:
We require a class library that can transform integers into Roman Numerals.  This library should be robust and usable in (most) C# projects.

## Code Requirements:
- Accepts an `int` and outputs a `string`.
- `I = 1`
- `V = 5`
- `X = 10`
- `L = 50`
- `C = 100`
- `D = 500`
- `M = 1000`
- No Roman Numeral may be repeated more than 3 times.
- `I`, `X`, and `C` may be used subtractively when preceding `V`, `L`, or `D`.  Therefore `IV = 4`.
- `I` may precede `V` or `X`, `X` may precede `L` or `C`, and `C` may precede `D` or `M`.
- `I`, `X`, `C`, and `M` are addative when succeeding eachother or `V`, `L`, or `D`.  Therefore `VI = 6`. 
- Negative numbers are not supported.
- Throws appropriate `Exceptions` when input is invalid.

## Challenge:
Use the principles of Test Driven Development to complete the class library.
Create a GitHub repository and commit after each successful test and refactor to show your work.

Use [xUnit.net](https://xunit.net/) as your unit testing framework.
Strive for 100% code coverage in this exercise.