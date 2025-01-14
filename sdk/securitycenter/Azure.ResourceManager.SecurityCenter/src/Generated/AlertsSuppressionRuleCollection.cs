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

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="AlertsSuppressionRuleResource" /> and their operations.
    /// Each <see cref="AlertsSuppressionRuleResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get an <see cref="AlertsSuppressionRuleCollection" /> instance call the GetAlertsSuppressionRules method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class AlertsSuppressionRuleCollection : ArmCollection, IEnumerable<AlertsSuppressionRuleResource>, IAsyncEnumerable<AlertsSuppressionRuleResource>
    {
        private readonly ClientDiagnostics _alertsSuppressionRuleClientDiagnostics;
        private readonly AlertsSuppressionRulesRestOperations _alertsSuppressionRuleRestClient;

        /// <summary> Initializes a new instance of the <see cref="AlertsSuppressionRuleCollection"/> class for mocking. </summary>
        protected AlertsSuppressionRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AlertsSuppressionRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AlertsSuppressionRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _alertsSuppressionRuleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", AlertsSuppressionRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AlertsSuppressionRuleResource.ResourceType, out string alertsSuppressionRuleApiVersion);
            _alertsSuppressionRuleRestClient = new AlertsSuppressionRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, alertsSuppressionRuleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Update existing rule or create new rule if it doesn&apos;t exist
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/alertsSuppressionRules/{alertsSuppressionRuleName}
        /// Operation Id: AlertsSuppressionRules_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="alertsSuppressionRuleName"> The unique name of the suppression alert rule. </param>
        /// <param name="data"> Suppression rule object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertsSuppressionRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertsSuppressionRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AlertsSuppressionRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string alertsSuppressionRuleName, AlertsSuppressionRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertsSuppressionRuleName, nameof(alertsSuppressionRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _alertsSuppressionRuleClientDiagnostics.CreateScope("AlertsSuppressionRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _alertsSuppressionRuleRestClient.UpdateAsync(Id.SubscriptionId, alertsSuppressionRuleName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation<AlertsSuppressionRuleResource>(Response.FromValue(new AlertsSuppressionRuleResource(Client, response), response.GetRawResponse()));
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
        /// Update existing rule or create new rule if it doesn&apos;t exist
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/alertsSuppressionRules/{alertsSuppressionRuleName}
        /// Operation Id: AlertsSuppressionRules_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="alertsSuppressionRuleName"> The unique name of the suppression alert rule. </param>
        /// <param name="data"> Suppression rule object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertsSuppressionRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertsSuppressionRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AlertsSuppressionRuleResource> CreateOrUpdate(WaitUntil waitUntil, string alertsSuppressionRuleName, AlertsSuppressionRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertsSuppressionRuleName, nameof(alertsSuppressionRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _alertsSuppressionRuleClientDiagnostics.CreateScope("AlertsSuppressionRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _alertsSuppressionRuleRestClient.Update(Id.SubscriptionId, alertsSuppressionRuleName, data, cancellationToken);
                var operation = new SecurityCenterArmOperation<AlertsSuppressionRuleResource>(Response.FromValue(new AlertsSuppressionRuleResource(Client, response), response.GetRawResponse()));
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
        /// Get dismiss rule, with name: {alertsSuppressionRuleName}, for the given subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/alertsSuppressionRules/{alertsSuppressionRuleName}
        /// Operation Id: AlertsSuppressionRules_Get
        /// </summary>
        /// <param name="alertsSuppressionRuleName"> The unique name of the suppression alert rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertsSuppressionRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertsSuppressionRuleName"/> is null. </exception>
        public virtual async Task<Response<AlertsSuppressionRuleResource>> GetAsync(string alertsSuppressionRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertsSuppressionRuleName, nameof(alertsSuppressionRuleName));

            using var scope = _alertsSuppressionRuleClientDiagnostics.CreateScope("AlertsSuppressionRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _alertsSuppressionRuleRestClient.GetAsync(Id.SubscriptionId, alertsSuppressionRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AlertsSuppressionRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get dismiss rule, with name: {alertsSuppressionRuleName}, for the given subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/alertsSuppressionRules/{alertsSuppressionRuleName}
        /// Operation Id: AlertsSuppressionRules_Get
        /// </summary>
        /// <param name="alertsSuppressionRuleName"> The unique name of the suppression alert rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertsSuppressionRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertsSuppressionRuleName"/> is null. </exception>
        public virtual Response<AlertsSuppressionRuleResource> Get(string alertsSuppressionRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertsSuppressionRuleName, nameof(alertsSuppressionRuleName));

            using var scope = _alertsSuppressionRuleClientDiagnostics.CreateScope("AlertsSuppressionRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _alertsSuppressionRuleRestClient.Get(Id.SubscriptionId, alertsSuppressionRuleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AlertsSuppressionRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List of all the dismiss rules for the given subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/alertsSuppressionRules
        /// Operation Id: AlertsSuppressionRules_List
        /// </summary>
        /// <param name="alertType"> Type of the alert to get rules for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AlertsSuppressionRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AlertsSuppressionRuleResource> GetAllAsync(string alertType = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<AlertsSuppressionRuleResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _alertsSuppressionRuleClientDiagnostics.CreateScope("AlertsSuppressionRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _alertsSuppressionRuleRestClient.ListAsync(Id.SubscriptionId, alertType, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AlertsSuppressionRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AlertsSuppressionRuleResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _alertsSuppressionRuleClientDiagnostics.CreateScope("AlertsSuppressionRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _alertsSuppressionRuleRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, alertType, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AlertsSuppressionRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List of all the dismiss rules for the given subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/alertsSuppressionRules
        /// Operation Id: AlertsSuppressionRules_List
        /// </summary>
        /// <param name="alertType"> Type of the alert to get rules for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AlertsSuppressionRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AlertsSuppressionRuleResource> GetAll(string alertType = null, CancellationToken cancellationToken = default)
        {
            Page<AlertsSuppressionRuleResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _alertsSuppressionRuleClientDiagnostics.CreateScope("AlertsSuppressionRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _alertsSuppressionRuleRestClient.List(Id.SubscriptionId, alertType, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AlertsSuppressionRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AlertsSuppressionRuleResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _alertsSuppressionRuleClientDiagnostics.CreateScope("AlertsSuppressionRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _alertsSuppressionRuleRestClient.ListNextPage(nextLink, Id.SubscriptionId, alertType, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AlertsSuppressionRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/alertsSuppressionRules/{alertsSuppressionRuleName}
        /// Operation Id: AlertsSuppressionRules_Get
        /// </summary>
        /// <param name="alertsSuppressionRuleName"> The unique name of the suppression alert rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertsSuppressionRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertsSuppressionRuleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string alertsSuppressionRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertsSuppressionRuleName, nameof(alertsSuppressionRuleName));

            using var scope = _alertsSuppressionRuleClientDiagnostics.CreateScope("AlertsSuppressionRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _alertsSuppressionRuleRestClient.GetAsync(Id.SubscriptionId, alertsSuppressionRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/alertsSuppressionRules/{alertsSuppressionRuleName}
        /// Operation Id: AlertsSuppressionRules_Get
        /// </summary>
        /// <param name="alertsSuppressionRuleName"> The unique name of the suppression alert rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertsSuppressionRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertsSuppressionRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string alertsSuppressionRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertsSuppressionRuleName, nameof(alertsSuppressionRuleName));

            using var scope = _alertsSuppressionRuleClientDiagnostics.CreateScope("AlertsSuppressionRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _alertsSuppressionRuleRestClient.Get(Id.SubscriptionId, alertsSuppressionRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AlertsSuppressionRuleResource> IEnumerable<AlertsSuppressionRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AlertsSuppressionRuleResource> IAsyncEnumerable<AlertsSuppressionRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
