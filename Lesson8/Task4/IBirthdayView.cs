using System;

namespace Task4
{
    public interface IBirthdayView
    {
        DateTime Birthday { get; set; }
        string Index { set; }
        bool TryGetFileNameToSave(out string fileName);
        bool TryGetFileNameToLoad(out string fileName);
        string Name { get; set; }
    }
}
