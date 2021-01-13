using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public interface IProductService
    {
        int GetTotalPrice(List<string> products);
    }
}
