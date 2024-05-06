﻿using System;
using Pacagroup.Ecommerce.Domain.Entity;
using Pacagroup.Ecommerce.Infraestructure.Interface;
using Pacagroup.Ecommerce.Transversal.Common;
using Dapper;
using System.Data;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Pacagroupd.Ecommerce.Infraestructure.Repository
{
    public class CustomerRepository: ICustomersRepository
    {



        private readonly IConnectionFactory _connectionFactory;
        public CustomerRepository(IConnectionFactory connectionFactory) { 
        
        
            _connectionFactory = connectionFactory;
        
        
        
        }

        //Metodos sincronos 
        public bool Insert(Customers customers) {

            using (var connection = _connectionFactory.GetConnection) {

                var query = "CustomerInsert";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", customers.CustomerId);
                parameters.Add("CompanyName", customers.CompanyName);
                parameters.Add("ContactName", customers.ContactName);
                parameters.Add("ContactTitle",customers.ContactTitle);
                parameters.Add("Address",customers.Address);
                parameters.Add("City", customers.City);
                parameters.Add("Region", customers.Region);
                parameters.Add("Postal Code",customers.PostalCode);
                parameters.Add("Country", customers.Country);
                parameters.Add("Phone", customers.Phone);
                parameters.Add("Fax", customers.Fax);


                var result = connection.Execute(query,param:parameters,commandType: CommandType.StoredProcedure);
                return result > 0;
            
            }
        
        
        
        }

        public bool Update(Customers customers)
        {

            using (var connection = _connectionFactory.GetConnection)
            {

                var query = "CustomerUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", customers.CustomerId);
                parameters.Add("CompanyName", customers.CompanyName);
                parameters.Add("ContactName", customers.ContactName);
                parameters.Add("ContactTitle", customers.ContactTitle);
                parameters.Add("Address", customers.Address);
                parameters.Add("City", customers.City);
                parameters.Add("Region", customers.Region);
                parameters.Add("Postal Code", customers.PostalCode);
                parameters.Add("Country", customers.Country);
                parameters.Add("Phone", customers.Phone);
                parameters.Add("Fax", customers.Fax);


                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;

            }



        }

        public bool Delete(String CustomerId)
        {

            using (var connection = _connectionFactory.GetConnection)
            {

                var query = "CustomerDelete";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", CustomerId);
                

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;

            }



        }

        public Customers Get(String CustomerId)
        {

            using (var connection = _connectionFactory.GetConnection)
            {

                var query = "CustomerGetByID";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", CustomerId);


                var customers = connection.QuerySingle<Customers>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return customers;

            }



        }
        public IEnumerable<Customers> GetAll()
        {

            using (var connection = _connectionFactory.GetConnection)
            {

                var query = "CustomerList";
                

                var customers = connection.Query<Customers>(query,commandType: CommandType.StoredProcedure);
                return customers;

            }



        }

        //Fin metodos sincronos  

        //Metodos Asincronos 

        public async Task<bool> InsertAsync(Customers customers)
        {

            using (var connection = _connectionFactory.GetConnection)
            {

                var query = "CustomerInsert";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", customers.CustomerId);
                parameters.Add("CompanyName", customers.CompanyName);
                parameters.Add("ContactName", customers.ContactName);
                parameters.Add("ContactTitle", customers.ContactTitle);
                parameters.Add("Address", customers.Address);
                parameters.Add("City", customers.City);
                parameters.Add("Region", customers.Region);
                parameters.Add("Postal Code", customers.PostalCode);
                parameters.Add("Country", customers.Country);
                parameters.Add("Phone", customers.Phone);
                parameters.Add("Fax", customers.Fax);


                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;

            }



        }

        public async Task<bool> UpdateAsync(Customers customers)
        {

            using (var connection = _connectionFactory.GetConnection)
            {

                var query = "CustomerUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", customers.CustomerId);
                parameters.Add("CompanyName", customers.CompanyName);
                parameters.Add("ContactName", customers.ContactName);
                parameters.Add("ContactTitle", customers.ContactTitle);
                parameters.Add("Address", customers.Address);
                parameters.Add("City", customers.City);
                parameters.Add("Region", customers.Region);
                parameters.Add("Postal Code", customers.PostalCode);
                parameters.Add("Country", customers.Country);
                parameters.Add("Phone", customers.Phone);
                parameters.Add("Fax", customers.Fax);


                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;

            }



        }

        public async Task<bool> DeleteAsync(String CustomerId)
        {

            using (var connection = _connectionFactory.GetConnection)
            {

                var query = "CustomerDelete";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", CustomerId);


                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;

            }



        }

        public async Task<Customers> GetAsync(String CustomerId)
        {

            using (var connection = _connectionFactory.GetConnection)
            {

                var query = "CustomerGetByID";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", CustomerId);


                var customers = await connection.QuerySingleAsync<Customers>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return customers;

            }



        }
        public async Task<IEnumerable<Customers>> GetAllAsync()
        {

            using (var connection = _connectionFactory.GetConnection)
            {

                var query = "CustomerList";


                var customers = await connection.QueryAsync<Customers>(query, commandType: CommandType.StoredProcedure);
                return customers;

            }



        }








    }








}
