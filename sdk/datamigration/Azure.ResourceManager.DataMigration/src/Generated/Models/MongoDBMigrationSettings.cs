// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Describes how a MongoDB data migration should be performed. </summary>
    public partial class MongoDBMigrationSettings
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

        /// <summary> Initializes a new instance of <see cref="MongoDBMigrationSettings"/>. </summary>
        /// <param name="databases"> The databases on the source cluster to migrate to the target. The keys are the names of the databases. </param>
        /// <param name="source"> Settings used to connect to the source cluster. </param>
        /// <param name="target"> Settings used to connect to the target cluster. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="databases"/>, <paramref name="source"/> or <paramref name="target"/> is null. </exception>
        public MongoDBMigrationSettings(IDictionary<string, MongoDBDatabaseSettings> databases, MongoDBConnectionInfo source, MongoDBConnectionInfo target)
        {
            if (databases == null)
            {
                throw new ArgumentNullException(nameof(databases));
            }
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (target == null)
            {
                throw new ArgumentNullException(nameof(target));
            }

            Databases = databases;
            Source = source;
            Target = target;
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBMigrationSettings"/>. </summary>
        /// <param name="boostRUs"> The RU limit on a CosmosDB target that collections will be temporarily increased to (if lower) during the initial copy of a migration, from 10,000 to 1,000,000, or 0 to use the default boost (which is generally the maximum), or null to not boost the RUs. This setting has no effect on non-CosmosDB targets. </param>
        /// <param name="databases"> The databases on the source cluster to migrate to the target. The keys are the names of the databases. </param>
        /// <param name="replication"> Describes how changes will be replicated from the source to the target. The default is OneTime. </param>
        /// <param name="source"> Settings used to connect to the source cluster. </param>
        /// <param name="target"> Settings used to connect to the target cluster. </param>
        /// <param name="throttling"> Settings used to limit the resource usage of the migration. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MongoDBMigrationSettings(int? boostRUs, IDictionary<string, MongoDBDatabaseSettings> databases, MongoDBReplication? replication, MongoDBConnectionInfo source, MongoDBConnectionInfo target, MongoDBThrottlingSettings throttling, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            BoostRUs = boostRUs;
            Databases = databases;
            Replication = replication;
            Source = source;
            Target = target;
            Throttling = throttling;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBMigrationSettings"/> for deserialization. </summary>
        internal MongoDBMigrationSettings()
        {
        }

        /// <summary> The RU limit on a CosmosDB target that collections will be temporarily increased to (if lower) during the initial copy of a migration, from 10,000 to 1,000,000, or 0 to use the default boost (which is generally the maximum), or null to not boost the RUs. This setting has no effect on non-CosmosDB targets. </summary>
        public int? BoostRUs { get; set; }
        /// <summary> The databases on the source cluster to migrate to the target. The keys are the names of the databases. </summary>
        public IDictionary<string, MongoDBDatabaseSettings> Databases { get; }
        /// <summary> Describes how changes will be replicated from the source to the target. The default is OneTime. </summary>
        public MongoDBReplication? Replication { get; set; }
        /// <summary> Settings used to connect to the source cluster. </summary>
        public MongoDBConnectionInfo Source { get; set; }
        /// <summary> Settings used to connect to the target cluster. </summary>
        public MongoDBConnectionInfo Target { get; set; }
        /// <summary> Settings used to limit the resource usage of the migration. </summary>
        public MongoDBThrottlingSettings Throttling { get; set; }
    }
}
