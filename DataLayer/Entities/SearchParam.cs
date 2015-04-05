using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    class SearchParam
    {
        public string ColumnName;
        public Operation Operation;
        public string Value;

    }

    enum Operation
    {
        GreaterThan,
        LessThan,
        GreaterThanEqual,
        LessThanEqual,
        Equal,
        Startswith,
        EndsWith,
        Like,
        NotLike,
        NotEqual



    }
}
