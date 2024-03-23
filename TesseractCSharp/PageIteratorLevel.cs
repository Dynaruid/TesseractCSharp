using System;
using System.Collections.Generic;
using System.Text;

namespace TesseractCSharp
{
    public enum PageIteratorLevel : int
    {
        Block,
        Para,
        TextLine,
        Word,
        Symbol
    }
}
