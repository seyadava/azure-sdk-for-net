// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{

    /// <summary>
    /// Defines values for JobState.
    /// </summary>
    public static class JobState
    {
        /// <summary>
        /// The job was canceled. This is a final state for the job.
        /// </summary>
        public const string Canceled = "Canceled";
        /// <summary>
        /// The job is in the process of being canceled. This is a transient
        /// state for the job.
        /// </summary>
        public const string Canceling = "Canceling";
        /// <summary>
        /// The job has encountered an error. This is a final state for the
        /// job.
        /// </summary>
        public const string Error = "Error";
        /// <summary>
        /// The job is finished. This is a final state for the job.
        /// </summary>
        public const string Finished = "Finished";
        /// <summary>
        /// The job is processing. This is a transient state for the job.
        /// </summary>
        public const string Processing = "Processing";
        /// <summary>
        /// The job is in a queued state, waiting for resources to become
        /// available. This is a transient state.
        /// </summary>
        public const string Queued = "Queued";
        /// <summary>
        /// The job is being scheduled to run on an available resource. This is
        /// a transient state, between queued and processing states.
        /// </summary>
        public const string Scheduled = "Scheduled";
    }
}
