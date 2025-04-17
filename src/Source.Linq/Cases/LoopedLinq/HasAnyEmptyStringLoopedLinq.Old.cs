// @Copyright (C) https://github.com/legrab, 2025
// Free to use under GPLv3 - share & improve with credit

namespace Source.Linq.Cases.LoopedLinq;

public static partial class HasAnyEmptyStringLoopedLinq
{
    private static bool ShouldSkipRecord(string[] strings)
    {
        bool hasContent = false;
        strings.ToList().ForEach(s => hasContent = hasContent || s.Trim().Length != 0);
        return !hasContent;
    }
}
