// @Copyright (C) https://github.com/legrab, 2025
// Free to use under GPLv3 - share & improve with credit

using Shouldly;
using Source.Linq.Cases.LoopedLinq;

namespace Test.Linq.Cases;

[TestFixture]
public class HasAnyEmptyStringLoopedLinqTests
{
    public record TestData(string[] Input, bool OldSuccess, bool NewSuccess)
    {
        public override string ToString()
            => $"Input: {string.Join(", ", Input)}, OldSuccess: {OldSuccess}, NewSuccess: {NewSuccess}";
    }

    private static List<TestData> _testData =
    [
        new(["a", "b", "c"], false, false),
        new([" ", " ", " "], true, true),
        new([" ", " ", " "], true, true),
        new([" ", "  ", " "], true, true),
        new([" ", "   ", " "], true, true)
    ];

    [Test]
    [TestCaseSource(nameof(_testData))]
    public void TestLoopedLinq(TestData data)
    {
        bool oldResult = HasAnyEmptyStringLoopedLinq.ApplyOld(data.Input);
        bool newResult = HasAnyEmptyStringLoopedLinq.ApplyNew(data.Input);
        oldResult.ShouldBe(data.OldSuccess);
        newResult.ShouldBe(data.NewSuccess);

        if (oldResult != newResult)
        {
            TestContext.WriteLine(
                $"{nameof(HasAnyEmptyStringLoopedLinq)} result changed: OldResult = {oldResult}, NewResult = {newResult}");
        }
    }
}
