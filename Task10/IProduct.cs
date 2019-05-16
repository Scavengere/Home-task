using System;

namespace Task10
{
    enum Products
    {
        None,
        Eggs,
        Milk
    }
    enum LevelOfProfit
    {
        None,
        Low,
        High
    }
    interface IProduct
    {
        Products Products { set; get; }
        LevelOfProfit Profit { set; get; }
    }
}
