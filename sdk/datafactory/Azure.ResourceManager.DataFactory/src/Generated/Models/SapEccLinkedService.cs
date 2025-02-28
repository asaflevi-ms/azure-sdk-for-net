// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Linked service for SAP ERP Central Component(SAP ECC). </summary>
    public partial class SapEccLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="SapEccLinkedService"/>. </summary>
        /// <param name="uri"> The URL of SAP ECC OData API. For example, '[https://hostname:port/sap/opu/odata/sap/servicename/]'. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/> is null. </exception>
        public SapEccLinkedService(DataFactoryElement<string> uri)
        {
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri));
            }

            Uri = uri;
            LinkedServiceType = "SapEcc";
        }

        /// <summary> Initializes a new instance of <see cref="SapEccLinkedService"/>. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="uri"> The URL of SAP ECC OData API. For example, '[https://hostname:port/sap/opu/odata/sap/servicename/]'. Type: string (or Expression with resultType string). </param>
        /// <param name="username"> The username for Basic authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> The password for Basic authentication. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Either encryptedCredential or username/password must be provided. Type: string. </param>
        internal SapEccLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> uri, DataFactoryElement<string> username, DataFactorySecretBaseDefinition password, string encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            Uri = uri;
            Username = username;
            Password = password;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "SapEcc";
        }

        /// <summary> Initializes a new instance of <see cref="SapEccLinkedService"/> for deserialization. </summary>
        internal SapEccLinkedService()
        {
        }

        /// <summary> The URL of SAP ECC OData API. For example, '[https://hostname:port/sap/opu/odata/sap/servicename/]'. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Uri { get; set; }
        /// <summary> The username for Basic authentication. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Username { get; set; }
        /// <summary> The password for Basic authentication. </summary>
        public DataFactorySecretBaseDefinition Password { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Either encryptedCredential or username/password must be provided. Type: string. </summary>
        public string EncryptedCredential { get; set; }
    }
}
