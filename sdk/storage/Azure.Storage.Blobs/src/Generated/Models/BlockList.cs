// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Storage.Blobs;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> The BlockList. </summary>
    public partial class BlockList
    {
        /// <summary> Initializes a new instance of <see cref="BlockList"/>. </summary>
        internal BlockList()
        {
            CommittedBlocks = new ChangeTrackingList<BlobBlock>();
            UncommittedBlocks = new ChangeTrackingList<BlobBlock>();
        }

        /// <summary> Initializes a new instance of <see cref="BlockList"/>. </summary>
        /// <param name="committedBlocks"></param>
        /// <param name="uncommittedBlocks"></param>
        internal BlockList(IEnumerable<BlobBlock> committedBlocks, IEnumerable<BlobBlock> uncommittedBlocks)
        {
            CommittedBlocks = committedBlocks;
            UncommittedBlocks = uncommittedBlocks;
        }
    }
}
