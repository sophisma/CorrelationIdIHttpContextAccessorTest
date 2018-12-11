using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationServices
{
    public interface ISomeService
    {
        IEnumerable<string> SomeMethod();
    }
}
