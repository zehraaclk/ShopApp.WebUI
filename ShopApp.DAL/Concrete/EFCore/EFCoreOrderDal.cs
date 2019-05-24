using ShopApp.DAL.Abstract;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.DAL.Concrete.EFCore
{
    public class EFCoreOrderDal:EFCoreGenericRepository<Order, ShopContext>,IOrderDal
    {

    }
}
