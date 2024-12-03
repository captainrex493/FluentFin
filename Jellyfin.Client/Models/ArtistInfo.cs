// <auto-generated/>
#pragma warning disable CS0618


using System.Collections.Generic;
using System.IO;
using System;
namespace Jellyfin.Client.Models
{
	[global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
#pragma warning disable CS1591
	public partial class ArtistInfo
#pragma warning restore CS1591
	{
		/// <summary>The IndexNumber property</summary>
		public int? IndexNumber { get; set; }
		/// <summary>The IsAutomated property</summary>
		public bool? IsAutomated { get; set; }
		/// <summary>Gets or sets the metadata country code.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
		public string? MetadataCountryCode { get; set; }
#nullable restore
#else
        public string MetadataCountryCode { get; set; }
#endif
		/// <summary>Gets or sets the metadata language.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
		public string? MetadataLanguage { get; set; }
#nullable restore
#else
        public string MetadataLanguage { get; set; }
#endif
		/// <summary>Gets or sets the name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
		public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
		/// <summary>Gets or sets the original title.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
		public string? OriginalTitle { get; set; }
#nullable restore
#else
        public string OriginalTitle { get; set; }
#endif
		/// <summary>The ParentIndexNumber property</summary>
		public int? ParentIndexNumber { get; set; }
		/// <summary>Gets or sets the path.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
		public string? Path { get; set; }
#nullable restore
#else
        public string Path { get; set; }
#endif
		/// <summary>The PremiereDate property</summary>
		public DateTimeOffset? PremiereDate { get; set; }
		/// <summary>Gets or sets the provider ids.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
		public global::Jellyfin.Client.Models.ArtistInfo_ProviderIds? ProviderIds { get; set; }
#nullable restore
#else
        public global::Jellyfin.Client.Models.ArtistInfo_ProviderIds ProviderIds { get; set; }
#endif
		/// <summary>The SongInfos property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
		public List<global::Jellyfin.Client.Models.SongInfo>? SongInfos { get; set; }
#nullable restore
#else
        public List<global::Jellyfin.Client.Models.SongInfo> SongInfos { get; set; }
#endif
		/// <summary>Gets or sets the year.</summary>
		public int? Year { get; set; }
	}
}
#pragma warning restore CS0618
