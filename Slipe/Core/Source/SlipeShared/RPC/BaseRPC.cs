using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.RPC
{
    public class BaseRPC
    {

        public T[] GetArray<T>(dynamic table)
        {
            return Slipe.MtaDefinitions.MtaShared.GetArrayFromTable<T>(table, "");
        }

        public MtaElement[] CreateElementArray(Element[] elements)
        {
            MtaElement[] mtaElements = new MtaElement[elements.Length];

            for (int i = 0; i < elements.Length; i++)
            {
                mtaElements[i] = elements[i].MTAElement;
            }

            return mtaElements;
        }

        public T[] GetElementArray<T>(dynamic table) where T : Element
        {
            MtaElement[] mtaElements = Slipe.MtaDefinitions.MtaShared.GetArrayFromTable<MtaElement>(table, "");

            T[] elements = new T[mtaElements.Length];
            for (int i = 0; i < mtaElements.Length; i++)
            {
                elements[i] = ElementManager.Instance.GetElement<T>(mtaElements[i]);
            }
            return elements;
        }

        public T GetElement<T>(dynamic mtaElement) where T: Element
        {
            return ElementManager.Instance.GetElement<T>(mtaElement);
        }



    }
}
