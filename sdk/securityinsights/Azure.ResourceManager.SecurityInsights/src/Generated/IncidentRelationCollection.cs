// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="IncidentRelationResource" /> and their operations.
    /// Each <see cref="IncidentRelationResource" /> in the collection will belong to the same instance of <see cref="IncidentResource" />.
    /// To get an <see cref="IncidentRelationCollection" /> instance call the GetIncidentRelations method from an instance of <see cref="IncidentResource" />.
    /// </summary>
    public partial class IncidentRelationCollection : ArmCollection, IEnumerable<IncidentRelationResource>, IAsyncEnumerable<IncidentRelationResource>
    {
        private readonly ClientDiagnostics _incidentRelationClientDiagnostics;
        private readonly IncidentRelationsRestOperations _incidentRelationRestClient;

        /// <summary> Initializes a new instance of the <see cref="IncidentRelationCollection"/> class for mocking. </summary>
        protected IncidentRelationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="IncidentRelationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal IncidentRelationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _incidentRelationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityInsights", IncidentRelationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(IncidentRelationResource.ResourceType, out string incidentRelationApiVersion);
            _incidentRelationRestClient = new IncidentRelationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, incidentRelationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != IncidentResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, IncidentResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the incident relation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}/relations/{relationName}
        /// Operation Id: IncidentRelations_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="relationName"> Relation Name. </param>
        /// <param name="data"> The relation model. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="relationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="relationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<IncidentRelationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string relationName, RelationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(relationName, nameof(relationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _incidentRelationClientDiagnostics.CreateScope("IncidentRelationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _incidentRelationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, relationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityInsightsArmOperation<IncidentRelationResource>(Response.FromValue(new IncidentRelationResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates the incident relation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}/relations/{relationName}
        /// Operation Id: IncidentRelations_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="relationName"> Relation Name. </param>
        /// <param name="data"> The relation model. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="relationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="relationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<IncidentRelationResource> CreateOrUpdate(WaitUntil waitUntil, string relationName, RelationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(relationName, nameof(relationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _incidentRelationClientDiagnostics.CreateScope("IncidentRelationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _incidentRelationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, relationName, data, cancellationToken);
                var operation = new SecurityInsightsArmOperation<IncidentRelationResource>(Response.FromValue(new IncidentRelationResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an incident relation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}/relations/{relationName}
        /// Operation Id: IncidentRelations_Get
        /// </summary>
        /// <param name="relationName"> Relation Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="relationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="relationName"/> is null. </exception>
        public virtual async Task<Response<IncidentRelationResource>> GetAsync(string relationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(relationName, nameof(relationName));

            using var scope = _incidentRelationClientDiagnostics.CreateScope("IncidentRelationCollection.Get");
            scope.Start();
            try
            {
                var response = await _incidentRelationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, relationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IncidentRelationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an incident relation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}/relations/{relationName}
        /// Operation Id: IncidentRelations_Get
        /// </summary>
        /// <param name="relationName"> Relation Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="relationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="relationName"/> is null. </exception>
        public virtual Response<IncidentRelationResource> Get(string relationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(relationName, nameof(relationName));

            using var scope = _incidentRelationClientDiagnostics.CreateScope("IncidentRelationCollection.Get");
            scope.Start();
            try
            {
                var response = _incidentRelationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, relationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IncidentRelationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all incident relations.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}/relations
        /// Operation Id: IncidentRelations_List
        /// </summary>
        /// <param name="filter"> Filters the results, based on a Boolean condition. Optional. </param>
        /// <param name="orderby"> Sorts the results. Optional. </param>
        /// <param name="top"> Returns only the first n results. Optional. </param>
        /// <param name="skipToken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IncidentRelationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IncidentRelationResource> GetAllAsync(string filter = null, string orderby = null, int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<IncidentRelationResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _incidentRelationClientDiagnostics.CreateScope("IncidentRelationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _incidentRelationRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, orderby, top, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new IncidentRelationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<IncidentRelationResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _incidentRelationClientDiagnostics.CreateScope("IncidentRelationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _incidentRelationRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, orderby, top, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new IncidentRelationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all incident relations.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}/relations
        /// Operation Id: IncidentRelations_List
        /// </summary>
        /// <param name="filter"> Filters the results, based on a Boolean condition. Optional. </param>
        /// <param name="orderby"> Sorts the results. Optional. </param>
        /// <param name="top"> Returns only the first n results. Optional. </param>
        /// <param name="skipToken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IncidentRelationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IncidentRelationResource> GetAll(string filter = null, string orderby = null, int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Page<IncidentRelationResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _incidentRelationClientDiagnostics.CreateScope("IncidentRelationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _incidentRelationRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, orderby, top, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new IncidentRelationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<IncidentRelationResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _incidentRelationClientDiagnostics.CreateScope("IncidentRelationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _incidentRelationRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, orderby, top, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new IncidentRelationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}/relations/{relationName}
        /// Operation Id: IncidentRelations_Get
        /// </summary>
        /// <param name="relationName"> Relation Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="relationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="relationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string relationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(relationName, nameof(relationName));

            using var scope = _incidentRelationClientDiagnostics.CreateScope("IncidentRelationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _incidentRelationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, relationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}/relations/{relationName}
        /// Operation Id: IncidentRelations_Get
        /// </summary>
        /// <param name="relationName"> Relation Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="relationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="relationName"/> is null. </exception>
        public virtual Response<bool> Exists(string relationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(relationName, nameof(relationName));

            using var scope = _incidentRelationClientDiagnostics.CreateScope("IncidentRelationCollection.Exists");
            scope.Start();
            try
            {
                var response = _incidentRelationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, relationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<IncidentRelationResource> IEnumerable<IncidentRelationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<IncidentRelationResource> IAsyncEnumerable<IncidentRelationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
