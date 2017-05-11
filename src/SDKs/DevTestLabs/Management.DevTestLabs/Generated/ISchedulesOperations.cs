// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure.OData;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// SchedulesOperations operations.
    /// </summary>
    public partial interface ISchedulesOperations
    {
        /// <summary>
        /// List schedules in a given lab.
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<Schedule>>> ListWithHttpMessagesAsync(string labName, ODataQuery<Schedule> odataQuery = default(ODataQuery<Schedule>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get schedule.
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        /// <param name='expand'>
        /// Specify the $expand query. Example: 'properties($select=status)'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Schedule>> GetWithHttpMessagesAsync(string labName, string name, string expand = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or replace an existing schedule.
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        /// <param name='schedule'>
        /// A schedule.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Schedule>> CreateOrUpdateWithHttpMessagesAsync(string labName, string name, Schedule schedule, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete schedule.
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string labName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Modify properties of schedules.
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        /// <param name='schedule'>
        /// A schedule.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Schedule>> UpdateWithHttpMessagesAsync(string labName, string name, ScheduleFragment schedule, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Execute a schedule. This operation can take a while to complete.
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> ExecuteWithHttpMessagesAsync(string labName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Execute a schedule. This operation can take a while to complete.
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginExecuteWithHttpMessagesAsync(string labName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all applicable schedules
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<Schedule>>> ListApplicableWithHttpMessagesAsync(string labName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List schedules in a given lab.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<Schedule>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all applicable schedules
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<Schedule>>> ListApplicableNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
