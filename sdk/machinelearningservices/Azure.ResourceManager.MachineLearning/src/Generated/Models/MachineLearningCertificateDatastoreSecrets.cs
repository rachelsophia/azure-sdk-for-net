// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Datastore certificate secrets.
    /// Serialized Name: CertificateDatastoreSecrets
    /// </summary>
    public partial class MachineLearningCertificateDatastoreSecrets : MachineLearningDatastoreSecrets
    {
        /// <summary> Initializes a new instance of MachineLearningCertificateDatastoreSecrets. </summary>
        public MachineLearningCertificateDatastoreSecrets()
        {
            SecretsType = SecretsType.Certificate;
        }

        /// <summary> Initializes a new instance of MachineLearningCertificateDatastoreSecrets. </summary>
        /// <param name="secretsType">
        /// [Required] Credential type used to authentication with storage.
        /// Serialized Name: DatastoreSecrets.secretsType
        /// </param>
        /// <param name="certificate">
        /// Service principal certificate.
        /// Serialized Name: CertificateDatastoreSecrets.certificate
        /// </param>
        internal MachineLearningCertificateDatastoreSecrets(SecretsType secretsType, string certificate) : base(secretsType)
        {
            Certificate = certificate;
            SecretsType = secretsType;
        }

        /// <summary>
        /// Service principal certificate.
        /// Serialized Name: CertificateDatastoreSecrets.certificate
        /// </summary>
        public string Certificate { get; set; }
    }
}
