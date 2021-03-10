using System;
using System.Collections.Generic;
using System.Text;
using TurkTicaretCRM.Core.CrosCuttingConcerns.Validations.FluentValidation;
using TurkTicaretCRM.TT.Bussiness.Abstract;
using TurkTicaretCRM.TT.Bussiness.ValidationRules.FluentValidation;
using TurkTicaretCRM.TT.DataAccess.Abstract;
using TurkTicaretCRM.TT.Entities.Concrete;

namespace TurkTicaretCRM.TT.Bussiness.Concrete.Managers
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public CustomerManager()
        {

        }
        
        public Customer Add(Customer customer)
        {
            return _customerDal.Add(customer);
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetList();
        }

        public Customer GetById(int id)
        {
            return _customerDal.Get(c => c.CustomerID == id);
        }

        public bool Delete(Customer customer)
        {
            try
            {
                _customerDal.Delete(customer);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteById(int id)
        {
            try
            {
                _customerDal.DeleteById(x => x.CustomerID == id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
