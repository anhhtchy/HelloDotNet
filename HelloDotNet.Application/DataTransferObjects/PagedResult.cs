using System;
using System.Collections.Generic;

namespace HelloDotNet.Application.DataTransferObjects
{
    public class PagedResult<T>
    {
        public List<T> Items { get; set; }
        public int TotalRecord { get; set; }
    }
}
