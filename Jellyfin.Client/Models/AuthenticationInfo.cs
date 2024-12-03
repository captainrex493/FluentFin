// <auto-generated/>
#pragma warning disable CS0618


using System.Collections.Generic;
using System.IO;
using System;
namespace Jellyfin.Client.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class AuthenticationInfo 
    #pragma warning restore CS1591
    {
        /// <summary>Gets or sets the access token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccessToken { get; set; }
#nullable restore
#else
        public string AccessToken { get; set; }
#endif
        /// <summary>Gets or sets the name of the application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppName { get; set; }
#nullable restore
#else
        public string AppName { get; set; }
#endif
        /// <summary>Gets or sets the application version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppVersion { get; set; }
#nullable restore
#else
        public string AppVersion { get; set; }
#endif
        /// <summary>Gets or sets the date created.</summary>
        public DateTimeOffset? DateCreated { get; set; }
        /// <summary>The DateLastActivity property</summary>
        public DateTimeOffset? DateLastActivity { get; set; }
        /// <summary>Gets or sets the date revoked.</summary>
        public DateTimeOffset? DateRevoked { get; set; }
        /// <summary>Gets or sets the device identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId { get; set; }
#nullable restore
#else
        public string DeviceId { get; set; }
#endif
        /// <summary>Gets or sets the name of the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceName { get; set; }
#nullable restore
#else
        public string DeviceName { get; set; }
#endif
        /// <summary>Gets or sets the identifier.</summary>
        public long? Id { get; set; }
        /// <summary>Gets or sets a value indicating whether this instance is active.</summary>
        public bool? IsActive { get; set; }
        /// <summary>Gets or sets the user identifier.</summary>
        public Guid? UserId { get; set; }
        /// <summary>The UserName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserName { get; set; }
#nullable restore
#else
        public string UserName { get; set; }
#endif
    }
}
#pragma warning restore CS0618
