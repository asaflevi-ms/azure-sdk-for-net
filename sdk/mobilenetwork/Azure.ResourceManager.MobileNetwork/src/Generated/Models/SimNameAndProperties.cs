// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MobileNetwork;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> SIM name and properties. </summary>
    public partial class SimNameAndProperties
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

        /// <summary> Initializes a new instance of <see cref="SimNameAndProperties"/>. </summary>
        /// <param name="name"> The name of the SIM. </param>
        /// <param name="internationalMobileSubscriberIdentity"> The international mobile subscriber identity (IMSI) for the SIM. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="internationalMobileSubscriberIdentity"/> is null. </exception>
        public SimNameAndProperties(string name, string internationalMobileSubscriberIdentity)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (internationalMobileSubscriberIdentity == null)
            {
                throw new ArgumentNullException(nameof(internationalMobileSubscriberIdentity));
            }

            Name = name;
            SiteProvisioningState = new ChangeTrackingDictionary<string, MobileNetworkSiteProvisioningState>();
            InternationalMobileSubscriberIdentity = internationalMobileSubscriberIdentity;
            StaticIPConfiguration = new ChangeTrackingList<SimStaticIPProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="SimNameAndProperties"/>. </summary>
        /// <param name="name"> The name of the SIM. </param>
        /// <param name="provisioningState"> The provisioning state of the SIM resource. </param>
        /// <param name="simState"> The state of the SIM resource. </param>
        /// <param name="siteProvisioningState"> A dictionary of sites to the provisioning state of this SIM on that site. </param>
        /// <param name="internationalMobileSubscriberIdentity"> The international mobile subscriber identity (IMSI) for the SIM. </param>
        /// <param name="integratedCircuitCardIdentifier"> The integrated circuit card ID (ICCID) for the SIM. </param>
        /// <param name="deviceType"> An optional free-form text field that can be used to record the device type this SIM is associated with, for example 'Video camera'. The Azure portal allows SIMs to be grouped and filtered based on this value. </param>
        /// <param name="simPolicy"> The SIM policy used by this SIM. The SIM policy must be in the same location as the SIM. </param>
        /// <param name="staticIPConfiguration"> A list of static IP addresses assigned to this SIM. Each address is assigned at a defined network scope, made up of {attached data network, slice}. </param>
        /// <param name="vendorName"> The name of the SIM vendor who provided this SIM, if any. </param>
        /// <param name="vendorKeyFingerprint"> The public key fingerprint of the SIM vendor who provided this SIM, if any. </param>
        /// <param name="authenticationKey"> The Ki value for the SIM. </param>
        /// <param name="operatorKeyCode"> The Opc value for the SIM. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SimNameAndProperties(string name, MobileNetworkProvisioningState? provisioningState, MobileNetworkSimState? simState, IReadOnlyDictionary<string, MobileNetworkSiteProvisioningState> siteProvisioningState, string internationalMobileSubscriberIdentity, string integratedCircuitCardIdentifier, string deviceType, WritableSubResource simPolicy, IList<SimStaticIPProperties> staticIPConfiguration, string vendorName, string vendorKeyFingerprint, string authenticationKey, string operatorKeyCode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            ProvisioningState = provisioningState;
            SimState = simState;
            SiteProvisioningState = siteProvisioningState;
            InternationalMobileSubscriberIdentity = internationalMobileSubscriberIdentity;
            IntegratedCircuitCardIdentifier = integratedCircuitCardIdentifier;
            DeviceType = deviceType;
            SimPolicy = simPolicy;
            StaticIPConfiguration = staticIPConfiguration;
            VendorName = vendorName;
            VendorKeyFingerprint = vendorKeyFingerprint;
            AuthenticationKey = authenticationKey;
            OperatorKeyCode = operatorKeyCode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SimNameAndProperties"/> for deserialization. </summary>
        internal SimNameAndProperties()
        {
        }

        /// <summary> The name of the SIM. </summary>
        public string Name { get; }
        /// <summary> The provisioning state of the SIM resource. </summary>
        public MobileNetworkProvisioningState? ProvisioningState { get; }
        /// <summary> The state of the SIM resource. </summary>
        public MobileNetworkSimState? SimState { get; }
        /// <summary> A dictionary of sites to the provisioning state of this SIM on that site. </summary>
        public IReadOnlyDictionary<string, MobileNetworkSiteProvisioningState> SiteProvisioningState { get; }
        /// <summary> The international mobile subscriber identity (IMSI) for the SIM. </summary>
        public string InternationalMobileSubscriberIdentity { get; }
        /// <summary> The integrated circuit card ID (ICCID) for the SIM. </summary>
        public string IntegratedCircuitCardIdentifier { get; set; }
        /// <summary> An optional free-form text field that can be used to record the device type this SIM is associated with, for example 'Video camera'. The Azure portal allows SIMs to be grouped and filtered based on this value. </summary>
        public string DeviceType { get; set; }
        /// <summary> The SIM policy used by this SIM. The SIM policy must be in the same location as the SIM. </summary>
        internal WritableSubResource SimPolicy { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SimPolicyId
        {
            get => SimPolicy is null ? default : SimPolicy.Id;
            set
            {
                if (SimPolicy is null)
                    SimPolicy = new WritableSubResource();
                SimPolicy.Id = value;
            }
        }

        /// <summary> A list of static IP addresses assigned to this SIM. Each address is assigned at a defined network scope, made up of {attached data network, slice}. </summary>
        public IList<SimStaticIPProperties> StaticIPConfiguration { get; }
        /// <summary> The name of the SIM vendor who provided this SIM, if any. </summary>
        public string VendorName { get; }
        /// <summary> The public key fingerprint of the SIM vendor who provided this SIM, if any. </summary>
        public string VendorKeyFingerprint { get; }
        /// <summary> The Ki value for the SIM. </summary>
        public string AuthenticationKey { get; set; }
        /// <summary> The Opc value for the SIM. </summary>
        public string OperatorKeyCode { get; set; }
    }
}
