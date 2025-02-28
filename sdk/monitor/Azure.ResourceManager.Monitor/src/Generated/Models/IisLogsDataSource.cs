// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Enables IIS logs to be collected by this data collection rule. </summary>
    public partial class IisLogsDataSource
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

        /// <summary> Initializes a new instance of <see cref="IisLogsDataSource"/>. </summary>
        /// <param name="streams"> IIS streams. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="streams"/> is null. </exception>
        public IisLogsDataSource(IEnumerable<string> streams)
        {
            if (streams == null)
            {
                throw new ArgumentNullException(nameof(streams));
            }

            Streams = streams.ToList();
            LogDirectories = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="IisLogsDataSource"/>. </summary>
        /// <param name="streams"> IIS streams. </param>
        /// <param name="logDirectories"> Absolute paths file location. </param>
        /// <param name="name">
        /// A friendly name for the data source.
        /// This name should be unique across all data sources (regardless of type) within the data collection rule.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IisLogsDataSource(IList<string> streams, IList<string> logDirectories, string name, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Streams = streams;
            LogDirectories = logDirectories;
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="IisLogsDataSource"/> for deserialization. </summary>
        internal IisLogsDataSource()
        {
        }

        /// <summary> IIS streams. </summary>
        public IList<string> Streams { get; }
        /// <summary> Absolute paths file location. </summary>
        public IList<string> LogDirectories { get; }
        /// <summary>
        /// A friendly name for the data source.
        /// This name should be unique across all data sources (regardless of type) within the data collection rule.
        /// </summary>
        public string Name { get; set; }
    }
}
