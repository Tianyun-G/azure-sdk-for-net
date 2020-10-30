// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.Monitor.OpenTelemetry.Exporter.Models
{
    /// <summary> The error details. </summary>
    internal partial class TelemetryErrorDetails
    {
        /// <summary> Initializes a new instance of TelemetryErrorDetails. </summary>
        internal TelemetryErrorDetails()
        {
        }

        /// <summary> Initializes a new instance of TelemetryErrorDetails. </summary>
        /// <param name="index"> The index in the original payload of the item. </param>
        /// <param name="statusCode"> The item specific [HTTP Response status code](#Response Status Codes). </param>
        /// <param name="message"> The error message. </param>
        internal TelemetryErrorDetails(int? index, int? statusCode, string message)
        {
            Index = index;
            StatusCode = statusCode;
            Message = message;
        }

        /// <summary> The index in the original payload of the item. </summary>
        public int? Index { get; }
        /// <summary> The item specific [HTTP Response status code](#Response Status Codes). </summary>
        public int? StatusCode { get; }
        /// <summary> The error message. </summary>
        public string Message { get; }
    }
}