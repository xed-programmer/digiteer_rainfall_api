namespace DigiteerRainFall.DigiteerRainFall.Contracts.RainFall;

public record RainFall(
    string Id ,
    DateTimeOffset DateTime ,
    string Measure ,
    double Value
);