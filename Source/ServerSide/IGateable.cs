using System;
using System.Collections.Generic;
using System.Text;

namespace ServerSide
{
    public interface IGateable
    {
        void Open();
        void Close();
    }
}
