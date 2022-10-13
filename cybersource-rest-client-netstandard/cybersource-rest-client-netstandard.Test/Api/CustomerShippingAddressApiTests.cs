/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using CyberSource.Client;
using CyberSource.Api;
using CyberSource.Model;

namespace CyberSource.Test
{
    /// <summary>
    ///  Class for testing CustomerShippingAddressApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CustomerShippingAddressApiTests
    {
        private CustomerShippingAddressApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CustomerShippingAddressApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CustomerShippingAddressApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CustomerShippingAddressApi
            //Assert.IsInstanceOfType(typeof(CustomerShippingAddressApi), instance, "instance is a CustomerShippingAddressApi");
        }

        
        /// <summary>
        /// Test DeleteCustomerShippingAddress
        /// </summary>
        [Test]
        public void DeleteCustomerShippingAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customerTokenId = null;
            //string shippingAddressTokenId = null;
            //string profileId = null;
            //instance.DeleteCustomerShippingAddress(customerTokenId, shippingAddressTokenId, profileId);
            
        }
        
        /// <summary>
        /// Test GetCustomerShippingAddress
        /// </summary>
        [Test]
        public void GetCustomerShippingAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customerTokenId = null;
            //string shippingAddressTokenId = null;
            //string profileId = null;
            //var response = instance.GetCustomerShippingAddress(customerTokenId, shippingAddressTokenId, profileId);
            //Assert.IsInstanceOf<Tmsv2customersEmbeddedDefaultShippingAddress> (response, "response is Tmsv2customersEmbeddedDefaultShippingAddress");
        }
        
        /// <summary>
        /// Test GetCustomerShippingAddressesList
        /// </summary>
        [Test]
        public void GetCustomerShippingAddressesListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customerTokenId = null;
            //string profileId = null;
            //long? offset = null;
            //long? limit = null;
            //var response = instance.GetCustomerShippingAddressesList(customerTokenId, profileId, offset, limit);
            //Assert.IsInstanceOf<ShippingAddressListForCustomer> (response, "response is ShippingAddressListForCustomer");
        }
        
        /// <summary>
        /// Test PatchCustomersShippingAddress
        /// </summary>
        [Test]
        public void PatchCustomersShippingAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customerTokenId = null;
            //string shippingAddressTokenId = null;
            //PatchCustomerShippingAddressRequest patchCustomerShippingAddressRequest = null;
            //string profileId = null;
            //string ifMatch = null;
            //var response = instance.PatchCustomersShippingAddress(customerTokenId, shippingAddressTokenId, patchCustomerShippingAddressRequest, profileId, ifMatch);
            //Assert.IsInstanceOf<Tmsv2customersEmbeddedDefaultShippingAddress> (response, "response is Tmsv2customersEmbeddedDefaultShippingAddress");
        }
        
        /// <summary>
        /// Test PostCustomerShippingAddress
        /// </summary>
        [Test]
        public void PostCustomerShippingAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customerTokenId = null;
            //PostCustomerShippingAddressRequest postCustomerShippingAddressRequest = null;
            //string profileId = null;
            //var response = instance.PostCustomerShippingAddress(customerTokenId, postCustomerShippingAddressRequest, profileId);
            //Assert.IsInstanceOf<Tmsv2customersEmbeddedDefaultShippingAddress> (response, "response is Tmsv2customersEmbeddedDefaultShippingAddress");
        }
        
    }

}
