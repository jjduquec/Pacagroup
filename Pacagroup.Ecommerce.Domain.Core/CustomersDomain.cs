using System;
using Pacagroup.Ecommerce.Domain.Entity;
using Pacagroup.Ecommerce.Domain.Interface;
using Pacagroup.Ecommerce.Infraestructure.Interface;
using System.Threading.Tasks;
using System.Collections.Generic;  

namespace Pacagroup.Ecommerce.Domain.Core
{
    public class CustomersDomain: ICustomersDomain
    {
        private readonly ICustomersRepository _customersRepository; 

         
        public CustomersDomain(ICustomersRepository customersRepository)
        {


            _customersRepository = customersRepository;

        }

        //Metodos sincronos 

        public bool Insert(Customers customers) { 
        
        
            return _customersRepository.Insert(customers);
        
        
        
        
        }

        public bool Update(Customers customers)
        {


            return _customersRepository.Update(customers);




        }

        public bool Delete(String CustomerId)
        {


            return _customersRepository.Delete(CustomerId);




        }

        public Customers Get(String CustomerId)
        {


            return _customersRepository.Get(CustomerId);




        }

        public IEnumerable<Customers> GetAll()
        {

            return _customersRepository.GetAll();
        }


        //Metodos Asincronos  
       

        public async Task<bool> InsertAsync(Customers customers)
        {


            return await _customersRepository.InsertAsync(customers);




        }

        public async Task<bool> UpdateAsync(Customers customers)
        {


            return await _customersRepository.UpdateAsync(customers);




        }

        public async Task<bool> DeleteAsync(String CustomerId)
        {


            return await _customersRepository.DeleteAsync(CustomerId);




        }

        public async Task<Customers> GetAsync(String CustomerId)
        {


            return await _customersRepository.GetAsync(CustomerId);




        }

        public async  Task<IEnumerable<Customers>> GetAllAsync()
        {

            return await _customersRepository.GetAllAsync();
        }









    }//end class  

}//end namespace 
