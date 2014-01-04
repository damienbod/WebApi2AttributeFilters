using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi2Attributes
{
    public class DummyBusinessClass : IDummyBusinessClass
    {
        public string GetSomething()
        {
            return "got something";
        }
    }

    public interface IDummyBusinessClass
    {
        string GetSomething();

    }
}