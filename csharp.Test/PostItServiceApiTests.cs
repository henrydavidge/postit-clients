using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing PostItServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PostItServiceApiTests
    {
        private PostItServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new PostItServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PostItServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<PostItServiceApi> (instance, "instance is a PostItServiceApi");
        }

        
        /// <summary>
        /// Test CreatePostItTable
        /// </summary>
        [Test]
        public void CreatePostItTableTest()
        {
            // TODO: add unit test for the method 'CreatePostItTable'
            PostitCreatePostItTable body = null; // TODO: replace null with proper value
            
            var response = instance.CreatePostItTable(body);
            Assert.IsInstanceOf<PostitCreatePostItTableResponse> (response, "response is PostitCreatePostItTableResponse"); 
        }
        
        /// <summary>
        /// Test DeleteApiKey
        /// </summary>
        [Test]
        public void DeleteApiKeyTest()
        {
            // TODO: add unit test for the method 'DeleteApiKey'
            PostitDeleteApiKey body = null; // TODO: replace null with proper value
            
            var response = instance.DeleteApiKey(body);
            Assert.IsInstanceOf<PostitDeleteApiKeyResponse> (response, "response is PostitDeleteApiKeyResponse"); 
        }
        
        /// <summary>
        /// Test PostIt
        /// </summary>
        [Test]
        public void PostItTest()
        {
            // TODO: add unit test for the method 'PostIt'
            PostitPostIt body = null; // TODO: replace null with proper value
            
            var response = instance.PostIt(body);
            Assert.IsInstanceOf<PostitPostItResponse> (response, "response is PostitPostItResponse"); 
        }
        
        /// <summary>
        /// Test RegenerateApiKey
        /// </summary>
        [Test]
        public void RegenerateApiKeyTest()
        {
            // TODO: add unit test for the method 'RegenerateApiKey'
            PostitRegenerateApiKey body = null; // TODO: replace null with proper value
            
            var response = instance.RegenerateApiKey(body);
            Assert.IsInstanceOf<PostitRegenerateApiKeyResponse> (response, "response is PostitRegenerateApiKeyResponse"); 
        }
        
        /// <summary>
        /// Test UpdatePostItTable
        /// </summary>
        [Test]
        public void UpdatePostItTableTest()
        {
            // TODO: add unit test for the method 'UpdatePostItTable'
            PostitUpdatePostItTable body = null; // TODO: replace null with proper value
            
            var response = instance.UpdatePostItTable(body);
            Assert.IsInstanceOf<PostitUpdatePostItTableResponse> (response, "response is PostitUpdatePostItTableResponse"); 
        }
        
    }

}
