// @Copyright (C) https://github.com/legrab, 2025
// Free to use under GPLv3 - share & improve with credit

using Source.Linq.Cases.LoopedLinq;

namespace Benchmarks.Linq.Cases;

[MemoryDiagnoser]
[ShortRunJob]
public class HasAnyEmptyStringLoopedLinqBenchmarks
{
    [Params(
        new[] { "a", "b", "c" },
        new[] { " ", " ", " " },
        new[] { " ", " ", " " },
        new[] { " ", "  ", " " },
        new[] { " ", "   ", " " }
    )]
    [UsedImplicitly]
    public required string[] Strings { get; set; }

    [Benchmark]
    public bool Old_HasAnyEmptyString_LoopedLinq() => HasAnyEmptyStringLoopedLinq.ApplyOld(Strings);

    [Benchmark]
    public bool New_HasAnyEmptyString_LoopedLinq() => HasAnyEmptyStringLoopedLinq.ApplyNew(Strings);
}
