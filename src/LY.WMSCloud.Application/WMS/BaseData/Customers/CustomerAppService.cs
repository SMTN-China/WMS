using LY.WMSCloud.Entities.BaseData;
using LY.WMSCloud.WMS.BaseData.Customers.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace LY.WMSCloud.WMS.BaseData.Customers
{
    public class CustomerAppService : ServiceBase<Customer, CustomerDto, string>, ICustomerAppService
    {
        public CustomerAppService(IWMSRepositories<Customer, string> repository) : base(repository)
        {
        }
    }
}
