// @Copyright (C) https://github.com/legrab, 2025
// Free to use under GPLv3 - share & improve with credit

using Benchmarks.Linq.Cases;

RunBenchmarks();

return;

void RunBenchmarks()
{
    Summary summary = BenchmarkRunner.Run<HasAnyEmptyStringLoopedLinqBenchmarks>();
    Console.WriteLine(summary);
}
