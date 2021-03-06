// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.LocationBasedServices.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The description of what resources to move between resource groups.
    /// </summary>
    public partial class LocationBasedServicesAccountsMoveRequest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LocationBasedServicesAccountsMoveRequest class.
        /// </summary>
        public LocationBasedServicesAccountsMoveRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LocationBasedServicesAccountsMoveRequest class.
        /// </summary>
        /// <param name="targetResourceGroup">The name of the destination
        /// resource group.</param>
        /// <param name="resourceIds">A list of resource names to move from the
        /// source resource group.</param>
        public LocationBasedServicesAccountsMoveRequest(string targetResourceGroup, IList<string> resourceIds)
        {
            TargetResourceGroup = targetResourceGroup;
            ResourceIds = resourceIds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the destination resource group.
        /// </summary>
        [JsonProperty(PropertyName = "targetResourceGroup")]
        public string TargetResourceGroup { get; set; }

        /// <summary>
        /// Gets or sets a list of resource names to move from the source
        /// resource group.
        /// </summary>
        [JsonProperty(PropertyName = "resourceIds")]
        public IList<string> ResourceIds { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TargetResourceGroup == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetResourceGroup");
            }
            if (ResourceIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ResourceIds");
            }
        }
    }
}
