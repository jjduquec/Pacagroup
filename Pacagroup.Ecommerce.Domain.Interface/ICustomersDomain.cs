using System;
using System.Collections.Generic;
using System.Text;
using Pacagroup.Ecommerce.Domain.Entity;
using System.Threading.Tasks;  
namespace Pacagroup.Ecommerce.Domain.Interface
{
    public interface ICustomersDomain
    {
        //Metodos Sincronos  
        bool Insert(Customers customer);
        bool Update(Customers customer);
        bool Delete(String customerId);

        Customers Get(String customerId);

        IEnumerable<Customers> GetAll();

        //End Region  

        //Metodos Asincronos  
        Task<bool> InsertAsync(Customers customer);
        Task<bool> UpdateAsync(Customers customer);
        Task<bool> DeleteAsync(String customerId);


        Task<Customers> GetAsync(String customerId);

        Task<IEnumerable<Customers>> GetAllAsync();
    }
}
