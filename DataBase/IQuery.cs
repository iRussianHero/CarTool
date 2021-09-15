using System;
using System.Collections;
using System.Collections.Generic;

namespace DataBaseLib
{
    public interface IQuery
    {
        public void Insert(ConnectionDB connection);

        public IList Select(ConnectionDB connection);
    }
}