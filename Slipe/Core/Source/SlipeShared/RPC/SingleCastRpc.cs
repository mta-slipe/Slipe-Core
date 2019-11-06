using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Rpc
{
    public class SingleCastRpc<T>: BaseRpc
    {
        public T Value { get; set; }

        public SingleCastRpc()
        {

        }

        public SingleCastRpc(T value)
        {
            this.Value = value;
        }

        public override void Parse(dynamic value)
        {
            this.Value = (T)value.Value;
        }
    }
}
