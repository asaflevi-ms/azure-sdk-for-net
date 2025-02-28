// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// The MonitoringSignalBase.
    /// Please note <see cref="MonitoringSignalBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="CustomMonitoringSignal"/>, <see cref="DataDriftMonitoringSignal"/>, <see cref="DataQualityMonitoringSignal"/>, <see cref="FeatureAttributionDriftMonitoringSignal"/>, <see cref="GenerationSafetyQualityMonitoringSignal"/>, <see cref="GenerationTokenStatisticsSignal"/>, <see cref="ModelPerformanceSignal"/> and <see cref="PredictionDriftMonitoringSignal"/>.
    /// </summary>
    public abstract partial class MonitoringSignalBase
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MonitoringSignalBase"/>. </summary>
        protected MonitoringSignalBase()
        {
            Properties = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="MonitoringSignalBase"/>. </summary>
        /// <param name="mode"> The current notification mode for this signal. </param>
        /// <param name="properties"> Property dictionary. Properties can be added, but not removed or altered. </param>
        /// <param name="signalType"> [Required] Specifies the type of signal to monitor. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MonitoringSignalBase(MonitoringNotificationMode? mode, IDictionary<string, string> properties, MonitoringSignalType signalType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Mode = mode;
            Properties = properties;
            SignalType = signalType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The current notification mode for this signal. </summary>
        public MonitoringNotificationMode? Mode { get; set; }
        /// <summary> Property dictionary. Properties can be added, but not removed or altered. </summary>
        public IDictionary<string, string> Properties { get; set; }
        /// <summary> [Required] Specifies the type of signal to monitor. </summary>
        internal MonitoringSignalType SignalType { get; set; }
    }
}
