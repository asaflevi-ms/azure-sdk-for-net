// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Kernel information. </summary>
    public partial class NotebookKernelSpec
    {
        /// <summary> Initializes a new instance of <see cref="NotebookKernelSpec"/>. </summary>
        /// <param name="name"> Name of the kernel specification. </param>
        /// <param name="displayName"> Name to display in UI. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="displayName"/> is null. </exception>
        public NotebookKernelSpec(string name, string displayName)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (displayName == null)
            {
                throw new ArgumentNullException(nameof(displayName));
            }

            Name = name;
            DisplayName = displayName;
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of <see cref="NotebookKernelSpec"/>. </summary>
        /// <param name="name"> Name of the kernel specification. </param>
        /// <param name="displayName"> Name to display in UI. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal NotebookKernelSpec(string name, string displayName, IDictionary<string, object> additionalProperties)
        {
            Name = name;
            DisplayName = displayName;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Name of the kernel specification. </summary>
        public string Name { get; set; }
        /// <summary> Name to display in UI. </summary>
        public string DisplayName { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
