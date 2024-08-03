﻿namespace Clean.Architecture.And.DDD.Template.Domian.Orders
{
    public interface IOrderRepository
    {
        Task AddAsync(Order order);
    }
}
