// <auto-generated/>
#pragma warning disable CS0618


using System.Collections.Generic;
using System.IO;
using System;
namespace Jellyfin.Client.Models
{
    /// <summary>
    /// Defines the MediaBrowser.Model.Dlna.ContainerProfile.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ContainerProfile 
    {
        /// <summary>Gets or sets the list of MediaBrowser.Model.Dlna.ProfileCondition which this container will be applied to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Jellyfin.Client.Models.ProfileCondition>? Conditions { get; set; }
#nullable restore
#else
        public List<global::Jellyfin.Client.Models.ProfileCondition> Conditions { get; set; }
#endif
        /// <summary>Gets or sets the container(s) which this container must meet.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Container { get; set; }
#nullable restore
#else
        public string Container { get; set; }
#endif
        /// <summary>Gets or sets the sub container(s) which this container must meet.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubContainer { get; set; }
#nullable restore
#else
        public string SubContainer { get; set; }
#endif
        /// <summary>Gets or sets the MediaBrowser.Model.Dlna.DlnaProfileType which this container must meet.</summary>
        public global::Jellyfin.Client.Models.ContainerProfile_Type? Type { get; set; }
    }
}
#pragma warning restore CS0618
