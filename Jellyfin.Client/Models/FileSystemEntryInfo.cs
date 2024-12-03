// <auto-generated/>
#pragma warning disable CS0618


using System.Collections.Generic;
using System.IO;
using System;
namespace Jellyfin.Client.Models
{
    /// <summary>
    /// Class FileSystemEntryInfo.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class FileSystemEntryInfo 
    {
        /// <summary>Gets the name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Gets the path.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Path { get; set; }
#nullable restore
#else
        public string Path { get; set; }
#endif
        /// <summary>Gets the type.</summary>
        public global::Jellyfin.Client.Models.FileSystemEntryInfo_Type? Type { get; set; }
    }
}
#pragma warning restore CS0618
