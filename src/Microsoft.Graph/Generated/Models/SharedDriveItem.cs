using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SharedDriveItem : BaseItem, IParsable {
        /// <summary>Used to access the underlying driveItem</summary>
        public Microsoft.Graph.Beta.Models.DriveItem DriveItem { get; set; }
        /// <summary>All driveItems contained in the sharing root. This collection cannot be enumerated.</summary>
        public List<Microsoft.Graph.Beta.Models.DriveItem> Items { get; set; }
        /// <summary>Used to access the underlying list</summary>
        public Microsoft.Graph.Beta.Models.List List { get; set; }
        /// <summary>Used to access the underlying listItem</summary>
        public Microsoft.Graph.Beta.Models.ListItem ListItem { get; set; }
        /// <summary>Information about the owner of the shared item being referenced.</summary>
        public IdentitySet Owner { get; set; }
        /// <summary>Used to access the permission representing the underlying sharing link</summary>
        public Microsoft.Graph.Beta.Models.Permission Permission { get; set; }
        /// <summary>Used to access the underlying driveItem. Deprecated -- use driveItem instead.</summary>
        public Microsoft.Graph.Beta.Models.DriveItem Root { get; set; }
        /// <summary>Used to access the underlying site</summary>
        public Microsoft.Graph.Beta.Models.Site Site { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SharedDriveItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SharedDriveItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"driveItem", n => { DriveItem = n.GetObjectValue<Microsoft.Graph.Beta.Models.DriveItem>(Microsoft.Graph.Beta.Models.DriveItem.CreateFromDiscriminatorValue); } },
                {"items", n => { Items = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DriveItem>(Microsoft.Graph.Beta.Models.DriveItem.CreateFromDiscriminatorValue).ToList(); } },
                {"list", n => { List = n.GetObjectValue<Microsoft.Graph.Beta.Models.List>(Microsoft.Graph.Beta.Models.List.CreateFromDiscriminatorValue); } },
                {"listItem", n => { ListItem = n.GetObjectValue<Microsoft.Graph.Beta.Models.ListItem>(Microsoft.Graph.Beta.Models.ListItem.CreateFromDiscriminatorValue); } },
                {"owner", n => { Owner = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"permission", n => { Permission = n.GetObjectValue<Microsoft.Graph.Beta.Models.Permission>(Microsoft.Graph.Beta.Models.Permission.CreateFromDiscriminatorValue); } },
                {"root", n => { Root = n.GetObjectValue<Microsoft.Graph.Beta.Models.DriveItem>(Microsoft.Graph.Beta.Models.DriveItem.CreateFromDiscriminatorValue); } },
                {"site", n => { Site = n.GetObjectValue<Microsoft.Graph.Beta.Models.Site>(Microsoft.Graph.Beta.Models.Site.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DriveItem>("driveItem", DriveItem);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DriveItem>("items", Items);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.List>("list", List);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ListItem>("listItem", ListItem);
            writer.WriteObjectValue<IdentitySet>("owner", Owner);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Permission>("permission", Permission);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DriveItem>("root", Root);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Site>("site", Site);
        }
    }
}
