using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class ZebraFotaArtifact : Entity, IParsable {
        /// <summary>The version of the Board Support Package (BSP. E.g.: 01.18.02.00)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BoardSupportPackageVersion {
            get { return BackingStore?.Get<string?>("boardSupportPackageVersion"); }
            set { BackingStore?.Set("boardSupportPackageVersion", value); }
        }
#nullable restore
#else
        public string BoardSupportPackageVersion {
            get { return BackingStore?.Get<string>("boardSupportPackageVersion"); }
            set { BackingStore?.Set("boardSupportPackageVersion", value); }
        }
#endif
        /// <summary>Artifact description. (e.g.: `LifeGuard Update 98 (released 24-September-2021)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Applicable device model (e.g.: TC8300)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceModel {
            get { return BackingStore?.Get<string?>("deviceModel"); }
            set { BackingStore?.Set("deviceModel", value); }
        }
#nullable restore
#else
        public string DeviceModel {
            get { return BackingStore?.Get<string>("deviceModel"); }
            set { BackingStore?.Set("deviceModel", value); }
        }
#endif
        /// <summary>Artifact OS version (e.g.: 8.1.0)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsVersion {
            get { return BackingStore?.Get<string?>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
#nullable restore
#else
        public string OsVersion {
            get { return BackingStore?.Get<string>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
#endif
        /// <summary>Artifact patch version (e.g.: U00)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PatchVersion {
            get { return BackingStore?.Get<string?>("patchVersion"); }
            set { BackingStore?.Set("patchVersion", value); }
        }
#nullable restore
#else
        public string PatchVersion {
            get { return BackingStore?.Get<string>("patchVersion"); }
            set { BackingStore?.Set("patchVersion", value); }
        }
#endif
        /// <summary>Artifact release notes URL (e.g.: https://www.zebra.com/&lt;filename.pdf&gt;)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReleaseNotesUrl {
            get { return BackingStore?.Get<string?>("releaseNotesUrl"); }
            set { BackingStore?.Set("releaseNotesUrl", value); }
        }
#nullable restore
#else
        public string ReleaseNotesUrl {
            get { return BackingStore?.Get<string>("releaseNotesUrl"); }
            set { BackingStore?.Set("releaseNotesUrl", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ZebraFotaArtifact CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ZebraFotaArtifact();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"boardSupportPackageVersion", n => { BoardSupportPackageVersion = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"deviceModel", n => { DeviceModel = n.GetStringValue(); } },
                {"osVersion", n => { OsVersion = n.GetStringValue(); } },
                {"patchVersion", n => { PatchVersion = n.GetStringValue(); } },
                {"releaseNotesUrl", n => { ReleaseNotesUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("boardSupportPackageVersion", BoardSupportPackageVersion);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("deviceModel", DeviceModel);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteStringValue("patchVersion", PatchVersion);
            writer.WriteStringValue("releaseNotesUrl", ReleaseNotesUrl);
        }
    }
}
