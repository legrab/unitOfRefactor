// @Copyright (C) https://github.com/legrab, 2025
// Free to use under GPLv3 - share & improve with credit

namespace Source.Linq.Cases.LoopedLinq;

public static partial class HasAnyEmptyStringLoopedLinq
{
    public static bool ApplyOld(string[] strings)
        => ShouldSkipRecord(strings);

    public static bool ApplyNew(string[] strings)
        => strings.HasNoData();
}
