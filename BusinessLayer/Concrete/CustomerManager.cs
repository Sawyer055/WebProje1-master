using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomer _ICustomer;

        public CustomerManager(ICustomer ıCustomer)
        {
            _ICustomer = ıCustomer;
        }

        public void CustomerAdd(Customer customer)
        {
            _ICustomer.insert(customer);

        }

        public void CustomerDelete(Customer customer)
        {
            _ICustomer?.delete(customer);
        }


        public void CustomerUpdate(Customer customer)
        {
            _ICustomer?.update(customer);
        }

        //public Customer GetCustomer(int id)
        //{
        //    return _ICustomer.Get(x=>x.CustomerID==id);
        //}

        public Customer GetCustomer(int? id)
        {
            return _ICustomer.Get(x => x.CustomerID == id);
        }

        public List<Customer> GetList()
        {
            return _ICustomer.List();
        }


    }
    //GenericRepositries<Customer> repo = new GenericRepositries<Customer>();

    //    public List<Customer> GetAll()
    //    {
    //        return repo.List();
    //    }
    //    public void CustomerAdd(Customer customer)
    //    {
    //        if (customer.CustomerName == "" || customer.CustomerName.Length < 3 ||
    //            customer.CustomerSurname == "" || customer.CustomerSurname.Length < 3 || customer.CustomerPassword == "")
    //        {
    //            //hata mesajı
    //        }
    //        else
    //        {
    //            repo.insert(customer);
    //        }
    //    }

}

