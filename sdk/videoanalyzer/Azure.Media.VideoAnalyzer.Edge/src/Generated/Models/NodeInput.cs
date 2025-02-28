// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Media.VideoAnalyzer.Edge;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Describes an input signal to be used on a pipeline node. </summary>
    public partial class NodeInput
    {
        /// <summary> Initializes a new instance of <see cref="NodeInput"/>. </summary>
        /// <param name="nodeName"> The name of the upstream node in the pipeline which output is used as input of the current node. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nodeName"/> is null. </exception>
        public NodeInput(string nodeName)
        {
            if (nodeName == null)
            {
                throw new ArgumentNullException(nameof(nodeName));
            }

            NodeName = nodeName;
            OutputSelectors = new ChangeTrackingList<OutputSelector>();
        }

        /// <summary> Initializes a new instance of <see cref="NodeInput"/>. </summary>
        /// <param name="nodeName"> The name of the upstream node in the pipeline which output is used as input of the current node. </param>
        /// <param name="outputSelectors"> Allows for the selection of specific data streams (eg. video only) from another node. </param>
        internal NodeInput(string nodeName, IList<OutputSelector> outputSelectors)
        {
            NodeName = nodeName;
            OutputSelectors = outputSelectors;
        }

        /// <summary> The name of the upstream node in the pipeline which output is used as input of the current node. </summary>
        public string NodeName { get; set; }
        /// <summary> Allows for the selection of specific data streams (eg. video only) from another node. </summary>
        public IList<OutputSelector> OutputSelectors { get; }
    }
}
