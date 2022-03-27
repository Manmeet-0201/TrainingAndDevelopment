using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mocking
{
    public class StringSequenceReader
    {
        IEnumerable<string> _source;

        public StringSequenceReader(IEnumerable<string> source)
        {
            _source = source;
        }

        public string[] ReadAll()
        {
            string[] results = _source.ToArray();

            return results;
        }
    }
}
