using System;

namespace NuGet.Server.Core.Infrastructure
{
    public class PackageEventArgs : EventArgs
    {
        public IPackage Package { get; set; }
    }
}