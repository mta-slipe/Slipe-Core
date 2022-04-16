using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Shared.Rpc
{
    public abstract class BaseRpc: IRpc
    {
        private ClientRpcFailedAction rpcFailedAction;
        public ClientRpcFailedAction OnClientRpcFailed
        {
            get
            {
                return rpcFailedAction;
            }
            set
            {
                rpcFailedAction = value;
            }
        }

        public BaseRpc()
        {
            rpcFailedAction = ClientRpcFailedAction.Ignore;
        }

        protected T[] GetArray<T>(dynamic table)
        {
            return SlipeLua.MtaDefinitions.MtaShared.GetArrayFromTable<T>(table, "");
        }

        protected MtaElement[] CreateElementArray(Element[] elements)
        {
            MtaElement[] mtaElements = new MtaElement[elements.Length];

            for (int i = 0; i < elements.Length; i++)
            {
                mtaElements[i] = elements[i].MTAElement;
            }

            return mtaElements;
        }

        protected T[] GetElementArray<T>(dynamic table) where T : Element
        {
            dynamic[] mtaElements = SlipeLua.MtaDefinitions.MtaShared.GetArrayFromTable<MtaElement>(table, "");

            T[] elements = new T[mtaElements.Length];
            for (int i = 0; i < mtaElements.Length; i++)
            {
                elements[i] = GetElement<T>(mtaElements[i]);
            }
            return elements;
        }

        protected T GetElement<T>(dynamic mtaElement) where T: Element
        {
            return ElementManager.Instance.GetElement<T>(mtaElement.element);
        }
        
        public abstract void Parse(dynamic value);

    }
}
