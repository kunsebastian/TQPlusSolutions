using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TQPlusSolutionsDM.Helpers
{
    public class JsonMessages<T>
    {
            public List<T> Results { get; set; }
            public bool Success { get; set; }
            public string ErrorMessage { get; set; }

    }
}