// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The recurrence schedule. </summary>
    public partial class DataFactoryRecurrenceSchedule
    {
        /// <summary> Initializes a new instance of <see cref="DataFactoryRecurrenceSchedule"/>. </summary>
        public DataFactoryRecurrenceSchedule()
        {
            Minutes = new ChangeTrackingList<int>();
            Hours = new ChangeTrackingList<int>();
            WeekDays = new ChangeTrackingList<DataFactoryDayOfWeek>();
            MonthDays = new ChangeTrackingList<int>();
            MonthlyOccurrences = new ChangeTrackingList<DataFactoryRecurrenceScheduleOccurrence>();
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="DataFactoryRecurrenceSchedule"/>. </summary>
        /// <param name="minutes"> The minutes. </param>
        /// <param name="hours"> The hours. </param>
        /// <param name="weekDays"> The days of the week. </param>
        /// <param name="monthDays"> The month days. </param>
        /// <param name="monthlyOccurrences"> The monthly occurrences. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal DataFactoryRecurrenceSchedule(IList<int> minutes, IList<int> hours, IList<DataFactoryDayOfWeek> weekDays, IList<int> monthDays, IList<DataFactoryRecurrenceScheduleOccurrence> monthlyOccurrences, IDictionary<string, BinaryData> additionalProperties)
        {
            Minutes = minutes;
            Hours = hours;
            WeekDays = weekDays;
            MonthDays = monthDays;
            MonthlyOccurrences = monthlyOccurrences;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The minutes. </summary>
        public IList<int> Minutes { get; }
        /// <summary> The hours. </summary>
        public IList<int> Hours { get; }
        /// <summary> The days of the week. </summary>
        public IList<DataFactoryDayOfWeek> WeekDays { get; }
        /// <summary> The month days. </summary>
        public IList<int> MonthDays { get; }
        /// <summary> The monthly occurrences. </summary>
        public IList<DataFactoryRecurrenceScheduleOccurrence> MonthlyOccurrences { get; }
        /// <summary>
        /// Additional Properties
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
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
