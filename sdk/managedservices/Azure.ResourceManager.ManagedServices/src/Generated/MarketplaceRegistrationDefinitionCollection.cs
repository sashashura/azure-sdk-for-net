// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ManagedServices
{
    /// <summary>
    /// A class representing a collection of <see cref="MarketplaceRegistrationDefinitionResource" /> and their operations.
    /// Each <see cref="MarketplaceRegistrationDefinitionResource" /> in the collection will belong to the same instance of <see cref="ArmResource" />.
    /// To get a <see cref="MarketplaceRegistrationDefinitionCollection" /> instance call the GetMarketplaceRegistrationDefinitions method from an instance of <see cref="ArmResource" />.
    /// </summary>
    public partial class MarketplaceRegistrationDefinitionCollection : ArmCollection, IEnumerable<MarketplaceRegistrationDefinitionResource>, IAsyncEnumerable<MarketplaceRegistrationDefinitionResource>
    {
        private readonly ClientDiagnostics _marketplaceRegistrationDefinitionClientDiagnostics;
        private readonly MarketplaceRegistrationDefinitionsRestOperations _marketplaceRegistrationDefinitionRestClient;

        /// <summary> Initializes a new instance of the <see cref="MarketplaceRegistrationDefinitionCollection"/> class for mocking. </summary>
        protected MarketplaceRegistrationDefinitionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MarketplaceRegistrationDefinitionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MarketplaceRegistrationDefinitionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _marketplaceRegistrationDefinitionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagedServices", MarketplaceRegistrationDefinitionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MarketplaceRegistrationDefinitionResource.ResourceType, out string marketplaceRegistrationDefinitionApiVersion);
            _marketplaceRegistrationDefinitionRestClient = new MarketplaceRegistrationDefinitionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, marketplaceRegistrationDefinitionApiVersion);
        }

        /// <summary>
        /// Get the marketplace registration definition for the marketplace identifier.
        /// Request Path: /{scope}/providers/Microsoft.ManagedServices/marketplaceRegistrationDefinitions/{marketplaceIdentifier}
        /// Operation Id: MarketplaceRegistrationDefinitions_Get
        /// </summary>
        /// <param name="marketplaceIdentifier"> The Azure Marketplace identifier. Expected formats: {publisher}.{product[-preview]}.{planName}.{version} or {publisher}.{product[-preview]}.{planName} or {publisher}.{product[-preview]} or {publisher}). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="marketplaceIdentifier"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="marketplaceIdentifier"/> is null. </exception>
        public virtual async Task<Response<MarketplaceRegistrationDefinitionResource>> GetAsync(string marketplaceIdentifier, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(marketplaceIdentifier, nameof(marketplaceIdentifier));

            using var scope = _marketplaceRegistrationDefinitionClientDiagnostics.CreateScope("MarketplaceRegistrationDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = await _marketplaceRegistrationDefinitionRestClient.GetAsync(Id, marketplaceIdentifier, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MarketplaceRegistrationDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the marketplace registration definition for the marketplace identifier.
        /// Request Path: /{scope}/providers/Microsoft.ManagedServices/marketplaceRegistrationDefinitions/{marketplaceIdentifier}
        /// Operation Id: MarketplaceRegistrationDefinitions_Get
        /// </summary>
        /// <param name="marketplaceIdentifier"> The Azure Marketplace identifier. Expected formats: {publisher}.{product[-preview]}.{planName}.{version} or {publisher}.{product[-preview]}.{planName} or {publisher}.{product[-preview]} or {publisher}). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="marketplaceIdentifier"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="marketplaceIdentifier"/> is null. </exception>
        public virtual Response<MarketplaceRegistrationDefinitionResource> Get(string marketplaceIdentifier, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(marketplaceIdentifier, nameof(marketplaceIdentifier));

            using var scope = _marketplaceRegistrationDefinitionClientDiagnostics.CreateScope("MarketplaceRegistrationDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = _marketplaceRegistrationDefinitionRestClient.Get(Id, marketplaceIdentifier, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MarketplaceRegistrationDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of the marketplace registration definitions for the marketplace identifier.
        /// Request Path: /{scope}/providers/Microsoft.ManagedServices/marketplaceRegistrationDefinitions
        /// Operation Id: MarketplaceRegistrationDefinitions_List
        /// </summary>
        /// <param name="filter"> The filter query parameter to filter managed services resources by. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MarketplaceRegistrationDefinitionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MarketplaceRegistrationDefinitionResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<MarketplaceRegistrationDefinitionResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _marketplaceRegistrationDefinitionClientDiagnostics.CreateScope("MarketplaceRegistrationDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _marketplaceRegistrationDefinitionRestClient.ListAsync(Id, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MarketplaceRegistrationDefinitionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<MarketplaceRegistrationDefinitionResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _marketplaceRegistrationDefinitionClientDiagnostics.CreateScope("MarketplaceRegistrationDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _marketplaceRegistrationDefinitionRestClient.ListNextPageAsync(nextLink, Id, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MarketplaceRegistrationDefinitionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets a list of the marketplace registration definitions for the marketplace identifier.
        /// Request Path: /{scope}/providers/Microsoft.ManagedServices/marketplaceRegistrationDefinitions
        /// Operation Id: MarketplaceRegistrationDefinitions_List
        /// </summary>
        /// <param name="filter"> The filter query parameter to filter managed services resources by. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MarketplaceRegistrationDefinitionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MarketplaceRegistrationDefinitionResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<MarketplaceRegistrationDefinitionResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _marketplaceRegistrationDefinitionClientDiagnostics.CreateScope("MarketplaceRegistrationDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _marketplaceRegistrationDefinitionRestClient.List(Id, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MarketplaceRegistrationDefinitionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<MarketplaceRegistrationDefinitionResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _marketplaceRegistrationDefinitionClientDiagnostics.CreateScope("MarketplaceRegistrationDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _marketplaceRegistrationDefinitionRestClient.ListNextPage(nextLink, Id, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MarketplaceRegistrationDefinitionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /{scope}/providers/Microsoft.ManagedServices/marketplaceRegistrationDefinitions/{marketplaceIdentifier}
        /// Operation Id: MarketplaceRegistrationDefinitions_Get
        /// </summary>
        /// <param name="marketplaceIdentifier"> The Azure Marketplace identifier. Expected formats: {publisher}.{product[-preview]}.{planName}.{version} or {publisher}.{product[-preview]}.{planName} or {publisher}.{product[-preview]} or {publisher}). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="marketplaceIdentifier"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="marketplaceIdentifier"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string marketplaceIdentifier, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(marketplaceIdentifier, nameof(marketplaceIdentifier));

            using var scope = _marketplaceRegistrationDefinitionClientDiagnostics.CreateScope("MarketplaceRegistrationDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _marketplaceRegistrationDefinitionRestClient.GetAsync(Id, marketplaceIdentifier, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /{scope}/providers/Microsoft.ManagedServices/marketplaceRegistrationDefinitions/{marketplaceIdentifier}
        /// Operation Id: MarketplaceRegistrationDefinitions_Get
        /// </summary>
        /// <param name="marketplaceIdentifier"> The Azure Marketplace identifier. Expected formats: {publisher}.{product[-preview]}.{planName}.{version} or {publisher}.{product[-preview]}.{planName} or {publisher}.{product[-preview]} or {publisher}). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="marketplaceIdentifier"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="marketplaceIdentifier"/> is null. </exception>
        public virtual Response<bool> Exists(string marketplaceIdentifier, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(marketplaceIdentifier, nameof(marketplaceIdentifier));

            using var scope = _marketplaceRegistrationDefinitionClientDiagnostics.CreateScope("MarketplaceRegistrationDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = _marketplaceRegistrationDefinitionRestClient.Get(Id, marketplaceIdentifier, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MarketplaceRegistrationDefinitionResource> IEnumerable<MarketplaceRegistrationDefinitionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MarketplaceRegistrationDefinitionResource> IAsyncEnumerable<MarketplaceRegistrationDefinitionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
