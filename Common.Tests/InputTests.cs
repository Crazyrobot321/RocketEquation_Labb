using AdventOfCode.Common;
using System.Threading.Tasks;

namespace Common.Tests;

public class InputTests
{
    [Test]
    public async Task Lines_SplitsOnNewline()
    {
        // Arrange
        var text = "abc\ndef\nghi";

        // Act
        var actual = Input.Lines(text);

        // Assert
        await Assert.That(actual).IsEquivalentTo(new[] { "abc", "def", "ghi" });
    }

    [Test]
    public async Task Lines_TrimsWhitespaceAndWindowsLineEndings()
    {
        // Arrange
        var text = "  abc \r\ndef\r\n";

        // Act
        var actual = Input.Lines(text);

        // Assert
        await Assert.That(actual).IsEquivalentTo(new[] { "abc", "def" });
    }

    [Test]
    public async Task Lines_SkipsEmptyLines()
    {
        // Arrange
        var text = "abc\n\n\ndef\n";

        // Act
        var actual = Input.Lines(text);

        // Assert
        await Assert.That(actual).IsEquivalentTo(new[] { "abc", "def" });
    }

    [Test]
    public async Task Lines_OfEmptyText_IsEmpty()
    {
        // Arrange
        // Act
        var actual = Input.Lines("");

        // Assert
        await Assert.That(actual).IsEmpty();
    }

    [Test]
    [Arguments("1 2 3", new[] { 1, 2, 3 })]
    [Arguments("16,1,2", new[] { 16, 1, 2 })]
    [Arguments("2x3x4", new[] { 2, 3, 4 })]
    [Arguments("199\n200\n208", new[] { 199, 200, 208 })]
    [Arguments("-5 10", new[] { -5, 10 })]
    public async Task Numbers_SplitsOnAnySeparator(string text, int[] expected)
    {
        // Arrange
        // Act
        var actual = Input.Numbers(text);

        // Assert
        await Assert.That(actual).IsEquivalentTo(expected);
    }

    [Test]
    public async Task Numbers_OfEmptyText_IsEmpty()
    {
        // Arrange
        // Act
        var actual = Input.Numbers("   \n  ");

        // Assert
        await Assert.That(actual).IsEmpty();
    }
}