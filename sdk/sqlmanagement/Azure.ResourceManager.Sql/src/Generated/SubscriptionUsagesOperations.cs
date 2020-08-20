// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> The SubscriptionUsages service client. </summary>
    public partial class SubscriptionUsagesOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal SubscriptionUsagesRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of SubscriptionUsagesOperations for mocking. </summary>
        protected SubscriptionUsagesOperations()
        {
        }
        /// <summary> Initializes a new instance of SubscriptionUsagesOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal SubscriptionUsagesOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new SubscriptionUsagesRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets a subscription usage metric. </summary>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <param name="usageName"> Name of usage metric to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SubscriptionUsage>> GetAsync(string locationName, string usageName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubscriptionUsagesOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(locationName, usageName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a subscription usage metric. </summary>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <param name="usageName"> Name of usage metric to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SubscriptionUsage> Get(string locationName, string usageName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubscriptionUsagesOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(locationName, usageName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all subscription usage metrics in a given location. </summary>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        public virtual AsyncPageable<SubscriptionUsage> ListByLocationAsync(string locationName, CancellationToken cancellationToken = default)
        {
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }

            async Task<Page<SubscriptionUsage>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubscriptionUsagesOperations.ListByLocation");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByLocationAsync(locationName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SubscriptionUsage>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubscriptionUsagesOperations.ListByLocation");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByLocationNextPageAsync(nextLink, locationName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all subscription usage metrics in a given location. </summary>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        public virtual Pageable<SubscriptionUsage> ListByLocation(string locationName, CancellationToken cancellationToken = default)
        {
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }

            Page<SubscriptionUsage> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubscriptionUsagesOperations.ListByLocation");
                scope.Start();
                try
                {
                    var response = RestClient.ListByLocation(locationName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SubscriptionUsage> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubscriptionUsagesOperations.ListByLocation");
                scope.Start();
                try
                {
                    var response = RestClient.ListByLocationNextPage(nextLink, locationName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}