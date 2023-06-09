﻿using AnyCompany.Base.Domain.Contract;

namespace AnyCompany
{
    public class Order : IOrder
    {
        public int OrderId { get; set; }
        public double Amount { get; set; }
        public double VAT { get; set; }
        public int CustomerId { get; set; }
    }
}
