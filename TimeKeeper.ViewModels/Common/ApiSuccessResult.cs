﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TimeKeeper.ViewModels.Common
{
    public  class ApiSuccessResult<T> : ApiResult<T>
    {
        public  ApiSuccessResult(T reslutObj)
        {
            IsSuccessed = true;
            ObjResult = reslutObj;
        }
        public ApiSuccessResult()
        {
            IsSuccessed = true;
        }
    }
}
