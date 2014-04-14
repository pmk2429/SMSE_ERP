using System;
using System.Collections.Generic;
using System.Text;

namespace Deepak_Xerox
{
    interface IDataBinder
    {
        object DataSource { get; set; }
        string PropertyName { get; set; }
        string FormatString { get; set; }
    }

    interface IItemInfo
    {
        int Id { get; }
        string ItemName { get; }
    }
}
