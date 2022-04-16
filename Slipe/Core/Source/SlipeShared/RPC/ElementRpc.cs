using SlipeLua.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Shared.Rpc
{
    public class ElementRpc: BaseRpc
    {
        public Element Element { get; set; }

        public ElementRpc()
        {

        }

        public ElementRpc(Element element)
        {
            this.Element = element;
        }

        public override void Parse(dynamic value)
        {
            this.Element = GetElement<Element>(value.Element);
        }
    }

    public class ElementRpc<ElementType> : BaseRpc where ElementType: Element
    {
        public ElementType Element { get; set; }

        public ElementRpc()
        {

        }

        public ElementRpc(ElementType element)
        {
            this.Element = element;
        }

        public override void Parse(dynamic value)
        {
            this.Element = GetElement<ElementType>(value.Element);
        }
    }
}
