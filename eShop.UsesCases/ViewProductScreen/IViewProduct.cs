﻿using eShop.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.UsesCases.ViewProductScreen
{
    public interface IViewProduct
    {
        Product Execute(int id);
    }
}
