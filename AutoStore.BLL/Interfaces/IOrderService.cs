﻿using AutoStore.BLL.DTO;
using AutoStore.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoStore.BLL.Interfaces
{
    public interface IOrderService
    {
        OperationDetails MakeOrder(OrderDTO orderDTO);
        AutoDetailDTO GetAutoDetail(int? id);
        IEnumerable<AutoDetailDTO> GetAutoDetails();
        IEnumerable<OrderDTO> GetOrders();
        OperationDetails DeleteOrder(int id);

        OperationDetails CreateDetail(AutoDetailDTO autoDetailDTO);
        OperationDetails EditDetail(AutoDetailDTO autoDetailDTO);
        OperationDetails DeleteDetail(int id);


        void Dispose();

    }
}
