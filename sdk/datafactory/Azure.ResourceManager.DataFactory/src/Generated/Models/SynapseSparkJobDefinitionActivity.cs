// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Execute spark job activity. </summary>
    public partial class SynapseSparkJobDefinitionActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of <see cref="SynapseSparkJobDefinitionActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="sparkJob"> Synapse spark job reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="sparkJob"/> is null. </exception>
        public SynapseSparkJobDefinitionActivity(string name, SynapseSparkJobReference sparkJob) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (sparkJob == null)
            {
                throw new ArgumentNullException(nameof(sparkJob));
            }

            SparkJob = sparkJob;
            Arguments = new ChangeTrackingList<BinaryData>();
            Files = new ChangeTrackingList<BinaryData>();
            PythonCodeReference = new ChangeTrackingList<BinaryData>();
            FilesV2 = new ChangeTrackingList<BinaryData>();
            SparkConfig = new ChangeTrackingDictionary<string, BinaryData>();
            ActivityType = "SparkJob";
        }

        /// <summary> Initializes a new instance of <see cref="SynapseSparkJobDefinitionActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="sparkJob"> Synapse spark job reference. </param>
        /// <param name="arguments"> User specified arguments to SynapseSparkJobDefinitionActivity. </param>
        /// <param name="file"> The main file used for the job, which will override the 'file' of the spark job definition you provide. Type: string (or Expression with resultType string). </param>
        /// <param name="scanFolder"> Scanning subfolders from the root folder of the main definition file, these files will be added as reference files. The folders named 'jars', 'pyFiles', 'files' or 'archives' will be scanned, and the folders name are case sensitive. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="className"> The fully-qualified identifier or the main class that is in the main definition file, which will override the 'className' of the spark job definition you provide. Type: string (or Expression with resultType string). </param>
        /// <param name="files"> (Deprecated. Please use pythonCodeReference and filesV2) Additional files used for reference in the main definition file, which will override the 'files' of the spark job definition you provide. </param>
        /// <param name="pythonCodeReference"> Additional python code files used for reference in the main definition file, which will override the 'pyFiles' of the spark job definition you provide. </param>
        /// <param name="filesV2"> Additional files used for reference in the main definition file, which will override the 'jars' and 'files' of the spark job definition you provide. </param>
        /// <param name="targetBigDataPool"> The name of the big data pool which will be used to execute the spark batch job, which will override the 'targetBigDataPool' of the spark job definition you provide. </param>
        /// <param name="executorSize"> Number of core and memory to be used for executors allocated in the specified Spark pool for the job, which will be used for overriding 'executorCores' and 'executorMemory' of the spark job definition you provide. Type: string (or Expression with resultType string). </param>
        /// <param name="conf"> Spark configuration properties, which will override the 'conf' of the spark job definition you provide. </param>
        /// <param name="driverSize"> Number of core and memory to be used for driver allocated in the specified Spark pool for the job, which will be used for overriding 'driverCores' and 'driverMemory' of the spark job definition you provide. Type: string (or Expression with resultType string). </param>
        /// <param name="numExecutors"> Number of executors to launch for this job, which will override the 'numExecutors' of the spark job definition you provide. Type: integer (or Expression with resultType integer). </param>
        /// <param name="configurationType"> The type of the spark config. </param>
        /// <param name="targetSparkConfiguration"> The spark configuration of the spark job. </param>
        /// <param name="sparkConfig"> Spark configuration property. </param>
        internal SynapseSparkJobDefinitionActivity(string name, string activityType, string description, PipelineActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<PipelineActivityDependency> dependsOn, IList<PipelineActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, DataFactoryLinkedServiceReference linkedServiceName, PipelineActivityPolicy policy, SynapseSparkJobReference sparkJob, IList<BinaryData> arguments, DataFactoryElement<string> file, DataFactoryElement<bool> scanFolder, DataFactoryElement<string> className, IList<BinaryData> files, IList<BinaryData> pythonCodeReference, IList<BinaryData> filesV2, BigDataPoolParametrizationReference targetBigDataPool, DataFactoryElement<string> executorSize, BinaryData conf, DataFactoryElement<string> driverSize, DataFactoryElement<int> numExecutors, DataFactorySparkConfigurationType? configurationType, SparkConfigurationParametrizationReference targetSparkConfiguration, IDictionary<string, BinaryData> sparkConfig) : base(name, activityType, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            SparkJob = sparkJob;
            Arguments = arguments;
            File = file;
            ScanFolder = scanFolder;
            ClassName = className;
            Files = files;
            PythonCodeReference = pythonCodeReference;
            FilesV2 = filesV2;
            TargetBigDataPool = targetBigDataPool;
            ExecutorSize = executorSize;
            Conf = conf;
            DriverSize = driverSize;
            NumExecutors = numExecutors;
            ConfigurationType = configurationType;
            TargetSparkConfiguration = targetSparkConfiguration;
            SparkConfig = sparkConfig;
            ActivityType = activityType ?? "SparkJob";
        }

        /// <summary> Initializes a new instance of <see cref="SynapseSparkJobDefinitionActivity"/> for deserialization. </summary>
        internal SynapseSparkJobDefinitionActivity()
        {
        }

        /// <summary> Synapse spark job reference. </summary>
        public SynapseSparkJobReference SparkJob { get; set; }
        /// <summary>
        /// User specified arguments to SynapseSparkJobDefinitionActivity.
        /// <para>
        /// To assign an object to the element of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public IList<BinaryData> Arguments { get; }
        /// <summary> The main file used for the job, which will override the 'file' of the spark job definition you provide. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> File { get; set; }
        /// <summary> Scanning subfolders from the root folder of the main definition file, these files will be added as reference files. The folders named 'jars', 'pyFiles', 'files' or 'archives' will be scanned, and the folders name are case sensitive. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> ScanFolder { get; set; }
        /// <summary> The fully-qualified identifier or the main class that is in the main definition file, which will override the 'className' of the spark job definition you provide. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ClassName { get; set; }
        /// <summary>
        /// (Deprecated. Please use pythonCodeReference and filesV2) Additional files used for reference in the main definition file, which will override the 'files' of the spark job definition you provide.
        /// <para>
        /// To assign an object to the element of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public IList<BinaryData> Files { get; }
        /// <summary>
        /// Additional python code files used for reference in the main definition file, which will override the 'pyFiles' of the spark job definition you provide.
        /// <para>
        /// To assign an object to the element of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public IList<BinaryData> PythonCodeReference { get; }
        /// <summary>
        /// Additional files used for reference in the main definition file, which will override the 'jars' and 'files' of the spark job definition you provide.
        /// <para>
        /// To assign an object to the element of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public IList<BinaryData> FilesV2 { get; }
        /// <summary> The name of the big data pool which will be used to execute the spark batch job, which will override the 'targetBigDataPool' of the spark job definition you provide. </summary>
        public BigDataPoolParametrizationReference TargetBigDataPool { get; set; }
        /// <summary> Number of core and memory to be used for executors allocated in the specified Spark pool for the job, which will be used for overriding 'executorCores' and 'executorMemory' of the spark job definition you provide. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ExecutorSize { get; set; }
        /// <summary>
        /// Spark configuration properties, which will override the 'conf' of the spark job definition you provide.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData Conf { get; set; }
        /// <summary> Number of core and memory to be used for driver allocated in the specified Spark pool for the job, which will be used for overriding 'driverCores' and 'driverMemory' of the spark job definition you provide. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> DriverSize { get; set; }
        /// <summary> Number of executors to launch for this job, which will override the 'numExecutors' of the spark job definition you provide. Type: integer (or Expression with resultType integer). </summary>
        public DataFactoryElement<int> NumExecutors { get; set; }
        /// <summary> The type of the spark config. </summary>
        public DataFactorySparkConfigurationType? ConfigurationType { get; set; }
        /// <summary> The spark configuration of the spark job. </summary>
        public SparkConfigurationParametrizationReference TargetSparkConfiguration { get; set; }
        /// <summary>
        /// Spark configuration property.
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
        public IDictionary<string, BinaryData> SparkConfig { get; }
    }
}
