﻿using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public  abstract class BaseContextLogic
    {
        protected readonly ServiceContext _serviceContext; 
        protected BaseContextLogic(ServiceContext serviceContext)
        {
            _serviceContext = serviceContext;
        }
    }
}
