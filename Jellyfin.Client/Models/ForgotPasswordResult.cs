// <auto-generated/>
#pragma warning disable CS0618


using System.Collections.Generic;
using System.IO;
using System;
namespace Jellyfin.Client.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ForgotPasswordResult 
    #pragma warning restore CS1591
    {
        /// <summary>Gets or sets the action.</summary>
        public global::Jellyfin.Client.Models.ForgotPasswordResult_Action? Action { get; set; }
        /// <summary>Gets or sets the pin expiration date.</summary>
        public DateTimeOffset? PinExpirationDate { get; set; }
        /// <summary>Gets or sets the pin file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PinFile { get; set; }
#nullable restore
#else
        public string PinFile { get; set; }
#endif
    }
}
#pragma warning restore CS0618
