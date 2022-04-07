/*
 * Conductor API Server
 *
 * Conductor API Server
 *
 * The version of the OpenAPI document: v0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
// uncomment below to import models
//using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing AdminResourceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AdminResourceApiTests : IDisposable
    {
        private AdminResourceApi instance;

        public AdminResourceApiTests()
        {
            instance = new AdminResourceApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AdminResourceApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AdminResourceApi
            //Assert.IsType<AdminResourceApi>(instance);
        }

        /// <summary>
        /// Test GetEventQueues
        /// </summary>
        [Fact]
        public void GetEventQueuesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? verbose = null;
            //var response = instance.GetEventQueues(verbose);
            //Assert.IsType<Dictionary<string, Object>>(response);
        }

        /// <summary>
        /// Test RequeueSweep
        /// </summary>
        [Fact]
        public void RequeueSweepTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workflowId = null;
            //var response = instance.RequeueSweep(workflowId);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test VerifyAndRepairWorkflowConsistency
        /// </summary>
        [Fact]
        public void VerifyAndRepairWorkflowConsistencyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workflowId = null;
            //var response = instance.VerifyAndRepairWorkflowConsistency(workflowId);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test View
        /// </summary>
        [Fact]
        public void ViewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tasktype = null;
            //int? start = null;
            //int? count = null;
            //var response = instance.View(tasktype, start, count);
            //Assert.IsType<List<Task>>(response);
        }
    }
}
