using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Rpc
{
    public interface IRpc
    {
        void Parse(dynamic value);
    }
}
