// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The ServicePrincipalInKVCredential. </summary>
    internal partial class ServicePrincipalInKVCredential : DataSourceCredential
    {
        /// <summary> Initializes a new instance of ServicePrincipalInKVCredential. </summary>
        /// <param name="dataSourceCredentialName"> Name of data source credential. </param>
        /// <param name="parameters"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSourceCredentialName"/> or <paramref name="parameters"/> is null. </exception>
        public ServicePrincipalInKVCredential(string dataSourceCredentialName, ServicePrincipalInKVParam parameters) : base(dataSourceCredentialName)
        {
            if (dataSourceCredentialName == null)
            {
                throw new ArgumentNullException(nameof(dataSourceCredentialName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            Parameters = parameters;
            DataSourceCredentialType = DataSourceCredentialType.ServicePrincipalInKV;
        }

        /// <summary> Initializes a new instance of ServicePrincipalInKVCredential. </summary>
        /// <param name="dataSourceCredentialType"> Type of data source credential. </param>
        /// <param name="dataSourceCredentialId"> Unique id of data source credential. </param>
        /// <param name="dataSourceCredentialName"> Name of data source credential. </param>
        /// <param name="dataSourceCredentialDescription"> Description of data source credential. </param>
        /// <param name="parameters"> . </param>
        internal ServicePrincipalInKVCredential(DataSourceCredentialType dataSourceCredentialType, Guid? dataSourceCredentialId, string dataSourceCredentialName, string dataSourceCredentialDescription, ServicePrincipalInKVParam parameters) : base(dataSourceCredentialType, dataSourceCredentialId, dataSourceCredentialName, dataSourceCredentialDescription)
        {
            Parameters = parameters;
            DataSourceCredentialType = dataSourceCredentialType;
        }

        public ServicePrincipalInKVParam Parameters { get; set; }
    }
}
