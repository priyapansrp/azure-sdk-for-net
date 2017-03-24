// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Key Vault container for a certificate that is purchased through Azure.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class AppServiceCertificateInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the AppServiceCertificateInner class.
        /// </summary>
        public AppServiceCertificateInner() { }

        /// <summary>
        /// Initializes a new instance of the AppServiceCertificateInner class.
        /// </summary>
        /// <param name="keyVaultId">Key Vault Csm resource Id.</param>
        /// <param name="keyVaultSecretName">Key Vault secret name.</param>
        /// <param name="provisioningState">Status of the Key Vault secret.
        /// Possible values include: 'Initialized',
        /// 'WaitingOnCertificateOrder', 'Succeeded',
        /// 'CertificateOrderFailed', 'OperationNotPermittedOnKeyVault',
        /// 'AzureServiceUnauthorizedToAccessKeyVault',
        /// 'KeyVaultDoesNotExist', 'KeyVaultSecretDoesNotExist',
        /// 'UnknownError', 'ExternalPrivateKey', 'Unknown'</param>
        public AppServiceCertificateInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string keyVaultId = default(string), string keyVaultSecretName = default(string), KeyVaultSecretStatus? provisioningState = default(KeyVaultSecretStatus?))
            : base(location, id, name, type, tags)
        {
            KeyVaultId = keyVaultId;
            KeyVaultSecretName = keyVaultSecretName;
            ProvisioningState = provisioningState;
        }

        /// <summary>
        /// Gets or sets key Vault Csm resource Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.keyVaultId")]
        public string KeyVaultId { get; set; }

        /// <summary>
        /// Gets or sets key Vault secret name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.keyVaultSecretName")]
        public string KeyVaultSecretName { get; set; }

        /// <summary>
        /// Gets status of the Key Vault secret. Possible values include:
        /// 'Initialized', 'WaitingOnCertificateOrder', 'Succeeded',
        /// 'CertificateOrderFailed', 'OperationNotPermittedOnKeyVault',
        /// 'AzureServiceUnauthorizedToAccessKeyVault',
        /// 'KeyVaultDoesNotExist', 'KeyVaultSecretDoesNotExist',
        /// 'UnknownError', 'ExternalPrivateKey', 'Unknown'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public KeyVaultSecretStatus? ProvisioningState { get; private set; }

    }
}