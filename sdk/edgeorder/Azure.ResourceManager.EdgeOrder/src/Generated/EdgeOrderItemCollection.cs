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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.EdgeOrder
{
    /// <summary>
    /// A class representing a collection of <see cref="EdgeOrderItemResource" /> and their operations.
    /// Each <see cref="EdgeOrderItemResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get an <see cref="EdgeOrderItemCollection" /> instance call the GetEdgeOrderItems method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class EdgeOrderItemCollection : ArmCollection, IEnumerable<EdgeOrderItemResource>, IAsyncEnumerable<EdgeOrderItemResource>
    {
        private readonly ClientDiagnostics _edgeOrderItemClientDiagnostics;
        private readonly EdgeOrderManagementRestOperations _edgeOrderItemRestClient;

        /// <summary> Initializes a new instance of the <see cref="EdgeOrderItemCollection"/> class for mocking. </summary>
        protected EdgeOrderItemCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EdgeOrderItemCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal EdgeOrderItemCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _edgeOrderItemClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EdgeOrder", EdgeOrderItemResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(EdgeOrderItemResource.ResourceType, out string edgeOrderItemApiVersion);
            _edgeOrderItemRestClient = new EdgeOrderManagementRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, edgeOrderItemApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates an order item. Existing order item cannot be updated with this api and should instead be updated with the Update order item API.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orderItems/{orderItemName}
        /// Operation Id: CreateOrderItem
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="orderItemName"> The name of the order item. </param>
        /// <param name="data"> Order item details from request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="orderItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="orderItemName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<EdgeOrderItemResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string orderItemName, EdgeOrderItemData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(orderItemName, nameof(orderItemName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _edgeOrderItemClientDiagnostics.CreateScope("EdgeOrderItemCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _edgeOrderItemRestClient.CreateOrderItemAsync(Id.SubscriptionId, Id.ResourceGroupName, orderItemName, data, cancellationToken).ConfigureAwait(false);
                var operation = new EdgeOrderArmOperation<EdgeOrderItemResource>(new EdgeOrderItemOperationSource(Client), _edgeOrderItemClientDiagnostics, Pipeline, _edgeOrderItemRestClient.CreateCreateOrderItemRequest(Id.SubscriptionId, Id.ResourceGroupName, orderItemName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates an order item. Existing order item cannot be updated with this api and should instead be updated with the Update order item API.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orderItems/{orderItemName}
        /// Operation Id: CreateOrderItem
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="orderItemName"> The name of the order item. </param>
        /// <param name="data"> Order item details from request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="orderItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="orderItemName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<EdgeOrderItemResource> CreateOrUpdate(WaitUntil waitUntil, string orderItemName, EdgeOrderItemData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(orderItemName, nameof(orderItemName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _edgeOrderItemClientDiagnostics.CreateScope("EdgeOrderItemCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _edgeOrderItemRestClient.CreateOrderItem(Id.SubscriptionId, Id.ResourceGroupName, orderItemName, data, cancellationToken);
                var operation = new EdgeOrderArmOperation<EdgeOrderItemResource>(new EdgeOrderItemOperationSource(Client), _edgeOrderItemClientDiagnostics, Pipeline, _edgeOrderItemRestClient.CreateCreateOrderItemRequest(Id.SubscriptionId, Id.ResourceGroupName, orderItemName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets an order item.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orderItems/{orderItemName}
        /// Operation Id: GetOrderItemByName
        /// </summary>
        /// <param name="orderItemName"> The name of the order item. </param>
        /// <param name="expand"> $expand is supported on device details, forward shipping details and reverse shipping details parameters. Each of these can be provided as a comma separated list. Device Details for order item provides details on the devices of the product, Forward and Reverse Shipping details provide forward and reverse shipping details respectively. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="orderItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="orderItemName"/> is null. </exception>
        public virtual async Task<Response<EdgeOrderItemResource>> GetAsync(string orderItemName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(orderItemName, nameof(orderItemName));

            using var scope = _edgeOrderItemClientDiagnostics.CreateScope("EdgeOrderItemCollection.Get");
            scope.Start();
            try
            {
                var response = await _edgeOrderItemRestClient.GetOrderItemByNameAsync(Id.SubscriptionId, Id.ResourceGroupName, orderItemName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EdgeOrderItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an order item.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orderItems/{orderItemName}
        /// Operation Id: GetOrderItemByName
        /// </summary>
        /// <param name="orderItemName"> The name of the order item. </param>
        /// <param name="expand"> $expand is supported on device details, forward shipping details and reverse shipping details parameters. Each of these can be provided as a comma separated list. Device Details for order item provides details on the devices of the product, Forward and Reverse Shipping details provide forward and reverse shipping details respectively. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="orderItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="orderItemName"/> is null. </exception>
        public virtual Response<EdgeOrderItemResource> Get(string orderItemName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(orderItemName, nameof(orderItemName));

            using var scope = _edgeOrderItemClientDiagnostics.CreateScope("EdgeOrderItemCollection.Get");
            scope.Start();
            try
            {
                var response = _edgeOrderItemRestClient.GetOrderItemByName(Id.SubscriptionId, Id.ResourceGroupName, orderItemName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EdgeOrderItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists order item at resource group level.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orderItems
        /// Operation Id: ListOrderItemsAtResourceGroupLevel
        /// </summary>
        /// <param name="filter"> $filter is supported to filter based on order id. Filter supports only equals operation. </param>
        /// <param name="expand"> $expand is supported on device details, forward shipping details and reverse shipping details parameters. Each of these can be provided as a comma separated list. Device Details for order item provides details on the devices of the product, Forward and Reverse Shipping details provide forward and reverse shipping details respectively. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of order items, which provides the next page in the list of order items. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EdgeOrderItemResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EdgeOrderItemResource> GetAllAsync(string filter = null, string expand = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<EdgeOrderItemResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _edgeOrderItemClientDiagnostics.CreateScope("EdgeOrderItemCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _edgeOrderItemRestClient.ListOrderItemsAtResourceGroupLevelAsync(Id.SubscriptionId, Id.ResourceGroupName, filter, expand, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new EdgeOrderItemResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<EdgeOrderItemResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _edgeOrderItemClientDiagnostics.CreateScope("EdgeOrderItemCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _edgeOrderItemRestClient.ListOrderItemsAtResourceGroupLevelNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter, expand, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new EdgeOrderItemResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists order item at resource group level.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orderItems
        /// Operation Id: ListOrderItemsAtResourceGroupLevel
        /// </summary>
        /// <param name="filter"> $filter is supported to filter based on order id. Filter supports only equals operation. </param>
        /// <param name="expand"> $expand is supported on device details, forward shipping details and reverse shipping details parameters. Each of these can be provided as a comma separated list. Device Details for order item provides details on the devices of the product, Forward and Reverse Shipping details provide forward and reverse shipping details respectively. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of order items, which provides the next page in the list of order items. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EdgeOrderItemResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EdgeOrderItemResource> GetAll(string filter = null, string expand = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Page<EdgeOrderItemResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _edgeOrderItemClientDiagnostics.CreateScope("EdgeOrderItemCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _edgeOrderItemRestClient.ListOrderItemsAtResourceGroupLevel(Id.SubscriptionId, Id.ResourceGroupName, filter, expand, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new EdgeOrderItemResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<EdgeOrderItemResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _edgeOrderItemClientDiagnostics.CreateScope("EdgeOrderItemCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _edgeOrderItemRestClient.ListOrderItemsAtResourceGroupLevelNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter, expand, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new EdgeOrderItemResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orderItems/{orderItemName}
        /// Operation Id: GetOrderItemByName
        /// </summary>
        /// <param name="orderItemName"> The name of the order item. </param>
        /// <param name="expand"> $expand is supported on device details, forward shipping details and reverse shipping details parameters. Each of these can be provided as a comma separated list. Device Details for order item provides details on the devices of the product, Forward and Reverse Shipping details provide forward and reverse shipping details respectively. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="orderItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="orderItemName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string orderItemName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(orderItemName, nameof(orderItemName));

            using var scope = _edgeOrderItemClientDiagnostics.CreateScope("EdgeOrderItemCollection.Exists");
            scope.Start();
            try
            {
                var response = await _edgeOrderItemRestClient.GetOrderItemByNameAsync(Id.SubscriptionId, Id.ResourceGroupName, orderItemName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orderItems/{orderItemName}
        /// Operation Id: GetOrderItemByName
        /// </summary>
        /// <param name="orderItemName"> The name of the order item. </param>
        /// <param name="expand"> $expand is supported on device details, forward shipping details and reverse shipping details parameters. Each of these can be provided as a comma separated list. Device Details for order item provides details on the devices of the product, Forward and Reverse Shipping details provide forward and reverse shipping details respectively. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="orderItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="orderItemName"/> is null. </exception>
        public virtual Response<bool> Exists(string orderItemName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(orderItemName, nameof(orderItemName));

            using var scope = _edgeOrderItemClientDiagnostics.CreateScope("EdgeOrderItemCollection.Exists");
            scope.Start();
            try
            {
                var response = _edgeOrderItemRestClient.GetOrderItemByName(Id.SubscriptionId, Id.ResourceGroupName, orderItemName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EdgeOrderItemResource> IEnumerable<EdgeOrderItemResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EdgeOrderItemResource> IAsyncEnumerable<EdgeOrderItemResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
