using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Gui
{
    /// <summary>
    /// Represents the selection mode for gui grid lists
    /// </summary>
    public enum SelectionMode
    {
        SingleRow,
        MultipleRow,
        SingleCell,
        MultipleCell,
        NominatedSingleColumnSection,
        NominatedMultipleColumnSection,
        SingleColumnSection,
        MultipleColumnSection,
        NominatedSingleRowSection,
        NominatedMultipleRowSection
    }
}
