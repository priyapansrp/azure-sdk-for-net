// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.KeyVault.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A SAS definition bundle consists of key vault SAS definition details
    /// plus its attributes.
    /// </summary>
    public partial class SasDefinitionBundle
    {
        /// <summary>
        /// Initializes a new instance of the SasDefinitionBundle class.
        /// </summary>
        public SasDefinitionBundle()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SasDefinitionBundle class.
        /// </summary>
        /// <param name="id">The SAS definition id.</param>
        /// <param name="secretId">Storage account SAS definition secret
        /// id.</param>
        /// <param name="templateUri">The SAS definition token template signed
        /// with an arbitrary key.  Tokens created according to the SAS
        /// definition will have the same properties as the template.</param>
        /// <param name="sasType">The type of SAS token the SAS definition will
        /// create. Possible values include: 'account', 'service'</param>
        /// <param name="validityPeriod">The validity period of SAS tokens
        /// created according to the SAS definition.</param>
        /// <param name="attributes">The SAS definition attributes.</param>
        /// <param name="tags">Application specific metadata in the form of
        /// key-value pairs</param>
        public SasDefinitionBundle(string id = default(string), string secretId = default(string), string templateUri = default(string), string sasType = default(string), string validityPeriod = default(string), SasDefinitionAttributes attributes = default(SasDefinitionAttributes), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Id = id;
            SecretId = secretId;
            TemplateUri = templateUri;
            SasType = sasType;
            ValidityPeriod = validityPeriod;
            Attributes = attributes;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the SAS definition id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets storage account SAS definition secret id.
        /// </summary>
        [JsonProperty(PropertyName = "sid")]
        public string SecretId { get; private set; }

        /// <summary>
        /// Gets the SAS definition token template signed with an arbitrary
        /// key.  Tokens created according to the SAS definition will have the
        /// same properties as the template.
        /// </summary>
        [JsonProperty(PropertyName = "templateUri")]
        public string TemplateUri { get; private set; }

        /// <summary>
        /// Gets the type of SAS token the SAS definition will create. Possible
        /// values include: 'account', 'service'
        /// </summary>
        [JsonProperty(PropertyName = "sasType")]
        public string SasType { get; private set; }

        /// <summary>
        /// Gets the validity period of SAS tokens created according to the SAS
        /// definition.
        /// </summary>
        [JsonProperty(PropertyName = "validityPeriod")]
        public string ValidityPeriod { get; private set; }

        /// <summary>
        /// Gets the SAS definition attributes.
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public SasDefinitionAttributes Attributes { get; private set; }

        /// <summary>
        /// Gets application specific metadata in the form of key-value pairs
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; private set; }

    }
}