using System;

namespace CodeDom
{
    public abstract class CodeDomTypeWrapper
    {
        protected Type _wrappedType { get; set; }
        protected object _instance { get; set; }

        public CodeDomTypeWrapper(Type wrappedType)
        {
            _wrappedType = wrappedType;
            _instance = Activator.CreateInstance(_wrappedType);
        }
    }
}
