using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF
{
    internal interface IAddAssortmentFormView
    {
        int ProductID { get; set; }
        decimal Price { get; set; }
        int Amount { get; set; }
        string ProductName { get; set; }
        event EventHandler AddProductEvent;
        event EventHandler AutocompleteEvent;
    }
}
