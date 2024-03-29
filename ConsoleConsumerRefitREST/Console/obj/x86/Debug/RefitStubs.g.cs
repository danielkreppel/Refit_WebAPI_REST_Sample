﻿// <auto-generated />
using System;
using System.Net.Http;
using System.Collections.Generic;
using Common.Models;
using Refit;
using System.Threading.Tasks;

/* ******** Hey You! *********
 *
 * This is a generated file, and gets rewritten every time you build the
 * project. If you want to edit it, you need to edit the mustache template
 * in the Refit package */

#pragma warning disable
namespace Poliedro.SincronizaSeidorEdros.RefitInternalGenerated
{
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
    sealed class PreserveAttribute : Attribute
    {

        //
        // Fields
        //
        public bool AllMembers;

        public bool Conditional;
    }
}
#pragma warning restore

namespace SampleApp.Interfaces
{
    using Poliedro.SincronizaSeidorEdros.RefitInternalGenerated;

    /// <inheritdoc />
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.Diagnostics.DebuggerNonUserCode]
    [Preserve]
    [global::System.Reflection.Obfuscation(Exclude=true)]
    partial class AutoGeneratedIApiService : IApiService
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedIApiService(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        Task<IEnumerable<Customer>> IApiService.GetCustomersAsync()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetCustomersAsync", new Type[] {  });
            return (Task<IEnumerable<Customer>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<ResponseMessage> IApiService.SaveCustomerAsync(Customer customer)
        {
            var arguments = new object[] { customer };
            var func = requestBuilder.BuildRestResultFuncForMethod("SaveCustomerAsync", new Type[] { typeof(Customer) });
            return (Task<ResponseMessage>)func(Client, arguments);
        }
    }
}

namespace SampleApp.Interfaces
{
    using Poliedro.SincronizaSeidorEdros.RefitInternalGenerated;

    /// <inheritdoc />
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.Diagnostics.DebuggerNonUserCode]
    [Preserve]
    [global::System.Reflection.Obfuscation(Exclude=true)]
    partial class AutoGeneratedILoginApiService : ILoginApiService
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedILoginApiService(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        Task<string> ILoginApiService.GetToken(Login login)
        {
            var arguments = new object[] { login };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetToken", new Type[] { typeof(Login) });
            return (Task<string>)func(Client, arguments);
        }
    }
}
