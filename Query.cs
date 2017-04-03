using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateBase
{
    class Query
    {
        public string Entity { get; set; }
        public string Property { get; set; }
        public string Condition { get; set; }
        public string Value { get; set; }
        public string Link { get; set; }
    }
}
