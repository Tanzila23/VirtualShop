﻿using ShopModels.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Contracts
{
   public interface IGetPracticeEmployeeDetailsManager
    {
        List<PracticeEmployeeVm> GetEmployeePracticeDetails(int id);
    }
}
