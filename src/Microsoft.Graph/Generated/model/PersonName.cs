// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Person Name.
    /// </summary>
    public partial class PersonName : ItemFacet
    {
    
		///<summary>
		/// The PersonName constructor
		///</summary>
        public PersonName()
        {
            this.ODataType = "microsoft.graph.personName";
        }
	
        /// <summary>
        /// Gets or sets display name.
        /// Provides an ordered rendering of firstName and lastName depending on the locale of the user or their device.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets first.
        /// First name of the user.
        /// </summary>
        [JsonPropertyName("first")]
        public string First { get; set; }
    
        /// <summary>
        /// Gets or sets initials.
        /// Initials of the user.
        /// </summary>
        [JsonPropertyName("initials")]
        public string Initials { get; set; }
    
        /// <summary>
        /// Gets or sets language tag.
        /// Contains the name for the language (en-US, no-NB, en-AU) following IETF BCP47 format.
        /// </summary>
        [JsonPropertyName("languageTag")]
        public string LanguageTag { get; set; }
    
        /// <summary>
        /// Gets or sets last.
        /// Last name of the user.
        /// </summary>
        [JsonPropertyName("last")]
        public string Last { get; set; }
    
        /// <summary>
        /// Gets or sets maiden.
        /// Maiden name of the user.
        /// </summary>
        [JsonPropertyName("maiden")]
        public string Maiden { get; set; }
    
        /// <summary>
        /// Gets or sets middle.
        /// Middle name of the user.
        /// </summary>
        [JsonPropertyName("middle")]
        public string Middle { get; set; }
    
        /// <summary>
        /// Gets or sets nickname.
        /// Nickname of the user.
        /// </summary>
        [JsonPropertyName("nickname")]
        public string Nickname { get; set; }
    
        /// <summary>
        /// Gets or sets pronunciation.
        /// Guidance on how to pronounce the users name.
        /// </summary>
        [JsonPropertyName("pronunciation")]
        public YomiPersonName Pronunciation { get; set; }
    
        /// <summary>
        /// Gets or sets suffix.
        /// Designators used after the users name (eg: PhD.)
        /// </summary>
        [JsonPropertyName("suffix")]
        public string Suffix { get; set; }
    
        /// <summary>
        /// Gets or sets title.
        /// Honorifics used to prefix a users name (eg: Dr, Sir, Madam, Mrs.)
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    
    }
}

