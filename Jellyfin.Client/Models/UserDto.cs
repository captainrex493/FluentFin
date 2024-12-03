// <auto-generated/>
#pragma warning disable CS0618


using System.Collections.Generic;
using System.IO;
using System;
namespace Jellyfin.Client.Models
{
    /// <summary>
    /// Class UserDto.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UserDto 
    {
        /// <summary>Gets or sets the configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Jellyfin.Client.Models.UserConfiguration? Configuration { get; set; }
#nullable restore
#else
        public global::Jellyfin.Client.Models.UserConfiguration Configuration { get; set; }
#endif
        /// <summary>Gets or sets whether async login is enabled or not.</summary>
        public bool? EnableAutoLogin { get; set; }
        /// <summary>Gets or sets a value indicating whether this instance has configured easy password.</summary>
        [Obsolete("")]
        public bool? HasConfiguredEasyPassword { get; set; }
        /// <summary>Gets or sets a value indicating whether this instance has configured password.</summary>
        public bool? HasConfiguredPassword { get; set; }
        /// <summary>Gets or sets a value indicating whether this instance has password.</summary>
        public bool? HasPassword { get; set; }
		/// <summary>Gets or sets the id.</summary>

		[JsonConverter(typeof(NullableGuidConveter))]
		public Guid? Id { get; set; }
        /// <summary>Gets or sets the last activity date.</summary>
        public DateTimeOffset? LastActivityDate { get; set; }
        /// <summary>Gets or sets the last login date.</summary>
        public DateTimeOffset? LastLoginDate { get; set; }
        /// <summary>Gets or sets the name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Gets or sets the policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Jellyfin.Client.Models.UserPolicy? Policy { get; set; }
#nullable restore
#else
        public global::Jellyfin.Client.Models.UserPolicy Policy { get; set; }
#endif
        /// <summary>Gets or sets the primary image aspect ratio.</summary>
        public double? PrimaryImageAspectRatio { get; set; }
        /// <summary>Gets or sets the primary image tag.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrimaryImageTag { get; set; }
#nullable restore
#else
        public string PrimaryImageTag { get; set; }
#endif
        /// <summary>Gets or sets the server identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServerId { get; set; }
#nullable restore
#else
        public string ServerId { get; set; }
#endif
        /// <summary>Gets or sets the name of the server.This is not used by the server and is for client-side usage only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServerName { get; set; }
#nullable restore
#else
        public string ServerName { get; set; }
#endif
    }
}
#pragma warning restore CS0618
