using System;
using System.Collections.Generic;
using System.Text;
using TurkTicaretCRM.TT.Entities.Concrete;

namespace TurkTicaretCRM.TT.Bussiness.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetById(int id);
        Customer Add(Customer customer);

        bool Delete(Customer customer);
        bool DeleteById(int id);
    }
}
