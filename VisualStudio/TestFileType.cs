﻿using System;

namespace Chutzpah.VisualStudio
{
    [Flags]
    public enum TestFileType
    {
        Other = 0,
        JS = 1,
        HTML = 2,
        Folder = 8
    }
}