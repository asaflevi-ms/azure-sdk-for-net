// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Defines the request body for commit operation. </summary>
    public partial class MoverCommitContent
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MoverCommitContent"/>. </summary>
        /// <param name="moverResources"> Gets or sets the list of resource Id's, by default it accepts move resource id's unless the input type is switched via moveResourceInputType property. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="moverResources"/> is null. </exception>
        public MoverCommitContent(IEnumerable<ResourceIdentifier> moverResources)
        {
            if (moverResources == null)
            {
                throw new ArgumentNullException(nameof(moverResources));
            }

            MoverResources = moverResources.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="MoverCommitContent"/>. </summary>
        /// <param name="validateOnly"> Gets or sets a value indicating whether the operation needs to only run pre-requisite. </param>
        /// <param name="moverResources"> Gets or sets the list of resource Id's, by default it accepts move resource id's unless the input type is switched via moveResourceInputType property. </param>
        /// <param name="moverResourceInputType"> Defines the move resource input type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MoverCommitContent(bool? validateOnly, IList<ResourceIdentifier> moverResources, MoverResourceInputType? moverResourceInputType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ValidateOnly = validateOnly;
            MoverResources = moverResources;
            MoverResourceInputType = moverResourceInputType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MoverCommitContent"/> for deserialization. </summary>
        internal MoverCommitContent()
        {
        }

        /// <summary> Gets or sets a value indicating whether the operation needs to only run pre-requisite. </summary>
        public bool? ValidateOnly { get; set; }
        /// <summary> Gets or sets the list of resource Id's, by default it accepts move resource id's unless the input type is switched via moveResourceInputType property. </summary>
        public IList<ResourceIdentifier> MoverResources { get; }
        /// <summary> Defines the move resource input type. </summary>
        public MoverResourceInputType? MoverResourceInputType { get; set; }
    }
}
