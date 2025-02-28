// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Source and target column mapping details. </summary>
    public partial class MapperAttributeMapping
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

        /// <summary> Initializes a new instance of <see cref="MapperAttributeMapping"/>. </summary>
        public MapperAttributeMapping()
        {
            AttributeReferences = new ChangeTrackingList<MapperAttributeReference>();
        }

        /// <summary> Initializes a new instance of <see cref="MapperAttributeMapping"/>. </summary>
        /// <param name="name"> Name of the target column. </param>
        /// <param name="mappingType"> Type of the CDC attribute mapping. Note: 'Advanced' mapping type is also saved as 'Derived'. </param>
        /// <param name="functionName"> Name of the function used for 'Aggregate' and 'Derived' (except 'Advanced') type mapping. </param>
        /// <param name="expression"> Expression used for 'Aggregate' and 'Derived' type mapping. </param>
        /// <param name="attributeReference"> Reference of the source column used in the mapping. It is used for 'Direct' mapping type only. </param>
        /// <param name="attributeReferences"> List of references for source columns. It is used for 'Derived' and 'Aggregate' type mappings only. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MapperAttributeMapping(string name, MappingType? mappingType, string functionName, string expression, MapperAttributeReference attributeReference, IList<MapperAttributeReference> attributeReferences, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            MappingType = mappingType;
            FunctionName = functionName;
            Expression = expression;
            AttributeReference = attributeReference;
            AttributeReferences = attributeReferences;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the target column. </summary>
        public string Name { get; set; }
        /// <summary> Type of the CDC attribute mapping. Note: 'Advanced' mapping type is also saved as 'Derived'. </summary>
        public MappingType? MappingType { get; set; }
        /// <summary> Name of the function used for 'Aggregate' and 'Derived' (except 'Advanced') type mapping. </summary>
        public string FunctionName { get; set; }
        /// <summary> Expression used for 'Aggregate' and 'Derived' type mapping. </summary>
        public string Expression { get; set; }
        /// <summary> Reference of the source column used in the mapping. It is used for 'Direct' mapping type only. </summary>
        public MapperAttributeReference AttributeReference { get; set; }
        /// <summary> List of references for source columns. It is used for 'Derived' and 'Aggregate' type mappings only. </summary>
        public IList<MapperAttributeReference> AttributeReferences { get; }
    }
}
