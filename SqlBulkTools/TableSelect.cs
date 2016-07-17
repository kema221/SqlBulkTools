﻿using System.Collections.Generic;

namespace SqlBulkTools
{
    public class CollectionSelect<T>
    {
        private readonly ICollection<T> _list;
        private readonly string _sourceAlias;
        private readonly string _targetAlias;
        private readonly SqlBulkTools _ext;

        internal CollectionSelect(ICollection<T> list, string sourceAlias, string targetAlias, SqlBulkTools ext)
        {
            _list = list;
            _sourceAlias = sourceAlias;
            _targetAlias = targetAlias;
            _ext = ext;
        }

        /// <summary>
        /// Set the name of table for operation to take place. Registering a table is Required.
        /// </summary>
        /// <param name="table">Name of the table.</param>
        /// <returns></returns>
        public Table<T> WithTable(string table)
        {
            return new Table<T>(_list, table, _sourceAlias, _targetAlias, _ext);
        }
    }
}