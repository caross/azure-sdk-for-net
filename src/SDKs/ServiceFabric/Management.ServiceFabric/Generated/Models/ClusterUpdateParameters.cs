// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabric.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Cluster update request
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ClusterUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the ClusterUpdateParameters class.
        /// </summary>
        public ClusterUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClusterUpdateParameters class.
        /// </summary>
        /// <param name="addOnFeatures">The list of add-on features to enable
        /// in the cluster.</param>
        /// <param name="certificate">The certificate to use for securing the
        /// cluster. The certificate provided will be used for  node to node
        /// security within the cluster, SSL certificate for cluster management
        /// endpoint and default  admin client.</param>
        /// <param name="certificateCommonNames">Describes a list of server
        /// certificates referenced by common name that are used to secure the
        /// cluster.</param>
        /// <param name="clientCertificateCommonNames">The list of client
        /// certificates referenced by common name that are allowed to manage
        /// the cluster. This will overwrite the existing list.</param>
        /// <param name="clientCertificateThumbprints">The list of client
        /// certificates referenced by thumbprint that are allowed to manage
        /// the cluster. This will overwrite the existing list.</param>
        /// <param name="clusterCodeVersion">The Service Fabric runtime version
        /// of the cluster. This property can only by set the user when
        /// **upgradeMode** is set to 'Manual'. To get list of available
        /// Service Fabric versions for new clusters use [ClusterVersion
        /// API](./ClusterVersion.md). To get the list of available version for
        /// existing clusters use **availableClusterVersions**.</param>
        /// <param name="fabricSettings">The list of custom fabric settings to
        /// configure the cluster. This will overwrite the existing
        /// list.</param>
        /// <param name="nodeTypes">The list of node types in the cluster. This
        /// will overwrite the existing list.</param>
        /// <param name="reliabilityLevel">The reliability level sets the
        /// replica set size of system services. Learn about
        /// [ReliabilityLevel](https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-cluster-capacity).
        ///
        /// - None - Run the System services with a target replica set count of
        /// 1. This should only be used for test clusters.
        /// - Bronze - Run the System services with a target replica set count
        /// of 3. This should only be used for test clusters.
        /// - Silver - Run the System services with a target replica set count
        /// of 5.
        /// - Gold - Run the System services with a target replica set count of
        /// 7.
        /// - Platinum - Run the System services with a target replica set
        /// count of 9.
        /// . Possible values include: 'None', 'Bronze', 'Silver', 'Gold',
        /// 'Platinum'</param>
        /// <param name="reverseProxyCertificate">The server certificate used
        /// by reverse proxy.</param>
        /// <param name="upgradeDescription">The policy to use when upgrading
        /// the cluster.</param>
        /// <param name="upgradeMode">The upgrade mode of the cluster when new
        /// Service Fabric runtime version is available.
        ///
        /// - Automatic - The cluster will be automatically upgraded to the
        /// latest Service Fabric runtime version as soon as it is available.
        /// - Manual - The cluster will not be automatically upgraded to the
        /// latest Service Fabric runtime version. The cluster is upgraded by
        /// setting the **clusterCodeVersion** property in the cluster
        /// resource.
        /// . Possible values include: 'Automatic', 'Manual'</param>
        /// <param name="tags">Cluster update parameters</param>
        public ClusterUpdateParameters(IList<string> addOnFeatures = default(IList<string>), CertificateDescription certificate = default(CertificateDescription), ServerCertificateCommonNames certificateCommonNames = default(ServerCertificateCommonNames), IList<ClientCertificateCommonName> clientCertificateCommonNames = default(IList<ClientCertificateCommonName>), IList<ClientCertificateThumbprint> clientCertificateThumbprints = default(IList<ClientCertificateThumbprint>), string clusterCodeVersion = default(string), IList<SettingsSectionDescription> fabricSettings = default(IList<SettingsSectionDescription>), IList<NodeTypeDescription> nodeTypes = default(IList<NodeTypeDescription>), string reliabilityLevel = default(string), CertificateDescription reverseProxyCertificate = default(CertificateDescription), ClusterUpgradePolicy upgradeDescription = default(ClusterUpgradePolicy), string upgradeMode = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            AddOnFeatures = addOnFeatures;
            Certificate = certificate;
            CertificateCommonNames = certificateCommonNames;
            ClientCertificateCommonNames = clientCertificateCommonNames;
            ClientCertificateThumbprints = clientCertificateThumbprints;
            ClusterCodeVersion = clusterCodeVersion;
            FabricSettings = fabricSettings;
            NodeTypes = nodeTypes;
            ReliabilityLevel = reliabilityLevel;
            ReverseProxyCertificate = reverseProxyCertificate;
            UpgradeDescription = upgradeDescription;
            UpgradeMode = upgradeMode;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of add-on features to enable in the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.addOnFeatures")]
        public IList<string> AddOnFeatures { get; set; }

        /// <summary>
        /// Gets or sets the certificate to use for securing the cluster. The
        /// certificate provided will be used for  node to node security within
        /// the cluster, SSL certificate for cluster management endpoint and
        /// default  admin client.
        /// </summary>
        [JsonProperty(PropertyName = "properties.certificate")]
        public CertificateDescription Certificate { get; set; }

        /// <summary>
        /// Gets or sets describes a list of server certificates referenced by
        /// common name that are used to secure the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.certificateCommonNames")]
        public ServerCertificateCommonNames CertificateCommonNames { get; set; }

        /// <summary>
        /// Gets or sets the list of client certificates referenced by common
        /// name that are allowed to manage the cluster. This will overwrite
        /// the existing list.
        /// </summary>
        [JsonProperty(PropertyName = "properties.clientCertificateCommonNames")]
        public IList<ClientCertificateCommonName> ClientCertificateCommonNames { get; set; }

        /// <summary>
        /// Gets or sets the list of client certificates referenced by
        /// thumbprint that are allowed to manage the cluster. This will
        /// overwrite the existing list.
        /// </summary>
        [JsonProperty(PropertyName = "properties.clientCertificateThumbprints")]
        public IList<ClientCertificateThumbprint> ClientCertificateThumbprints { get; set; }

        /// <summary>
        /// Gets or sets the Service Fabric runtime version of the cluster.
        /// This property can only by set the user when **upgradeMode** is set
        /// to 'Manual'. To get list of available Service Fabric versions for
        /// new clusters use [ClusterVersion API](./ClusterVersion.md). To get
        /// the list of available version for existing clusters use
        /// **availableClusterVersions**.
        /// </summary>
        [JsonProperty(PropertyName = "properties.clusterCodeVersion")]
        public string ClusterCodeVersion { get; set; }

        /// <summary>
        /// Gets or sets the list of custom fabric settings to configure the
        /// cluster. This will overwrite the existing list.
        /// </summary>
        [JsonProperty(PropertyName = "properties.fabricSettings")]
        public IList<SettingsSectionDescription> FabricSettings { get; set; }

        /// <summary>
        /// Gets or sets the list of node types in the cluster. This will
        /// overwrite the existing list.
        /// </summary>
        [JsonProperty(PropertyName = "properties.nodeTypes")]
        public IList<NodeTypeDescription> NodeTypes { get; set; }

        /// <summary>
        /// Gets or sets the reliability level sets the replica set size of
        /// system services. Learn about
        /// [ReliabilityLevel](https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-cluster-capacity).
        ///
        /// - None - Run the System services with a target replica set count of
        /// 1. This should only be used for test clusters.
        /// - Bronze - Run the System services with a target replica set count
        /// of 3. This should only be used for test clusters.
        /// - Silver - Run the System services with a target replica set count
        /// of 5.
        /// - Gold - Run the System services with a target replica set count of
        /// 7.
        /// - Platinum - Run the System services with a target replica set
        /// count of 9.
        /// . Possible values include: 'None', 'Bronze', 'Silver', 'Gold',
        /// 'Platinum'
        /// </summary>
        [JsonProperty(PropertyName = "properties.reliabilityLevel")]
        public string ReliabilityLevel { get; set; }

        /// <summary>
        /// Gets or sets the server certificate used by reverse proxy.
        /// </summary>
        [JsonProperty(PropertyName = "properties.reverseProxyCertificate")]
        public CertificateDescription ReverseProxyCertificate { get; set; }

        /// <summary>
        /// Gets or sets the policy to use when upgrading the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.upgradeDescription")]
        public ClusterUpgradePolicy UpgradeDescription { get; set; }

        /// <summary>
        /// Gets or sets the upgrade mode of the cluster when new Service
        /// Fabric runtime version is available.
        ///
        /// - Automatic - The cluster will be automatically upgraded to the
        /// latest Service Fabric runtime version as soon as it is available.
        /// - Manual - The cluster will not be automatically upgraded to the
        /// latest Service Fabric runtime version. The cluster is upgraded by
        /// setting the **clusterCodeVersion** property in the cluster
        /// resource.
        /// . Possible values include: 'Automatic', 'Manual'
        /// </summary>
        [JsonProperty(PropertyName = "properties.upgradeMode")]
        public string UpgradeMode { get; set; }

        /// <summary>
        /// Gets or sets cluster update parameters
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Certificate != null)
            {
                Certificate.Validate();
            }
            if (ClientCertificateCommonNames != null)
            {
                foreach (var element in ClientCertificateCommonNames)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (ClientCertificateThumbprints != null)
            {
                foreach (var element1 in ClientCertificateThumbprints)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (FabricSettings != null)
            {
                foreach (var element2 in FabricSettings)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
            if (NodeTypes != null)
            {
                foreach (var element3 in NodeTypes)
                {
                    if (element3 != null)
                    {
                        element3.Validate();
                    }
                }
            }
            if (ReverseProxyCertificate != null)
            {
                ReverseProxyCertificate.Validate();
            }
            if (UpgradeDescription != null)
            {
                UpgradeDescription.Validate();
            }
        }
    }
}
