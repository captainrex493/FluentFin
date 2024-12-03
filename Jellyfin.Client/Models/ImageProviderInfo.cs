// <auto-generated/>
#pragma warning disable CS0618


using System.Collections.Generic;
using System.IO;
using System;
namespace Jellyfin.Client.Models
{
    /// <summary>
    /// Class ImageProviderInfo.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ImageProviderInfo 
    {
        /// <summary>Gets the name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Gets the supported image types.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Jellyfin.Client.Models.ImageType?>? SupportedImages { get; set; }
#nullable restore
#else
        public List<global::Jellyfin.Client.Models.ImageType?> SupportedImages { get; set; }
#endif
    }
}
#pragma warning restore CS0618
