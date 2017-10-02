using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NuGet.Common;

namespace NuGet.Packaging.Signing
{
    public interface ISignPackageReader : IDisposable
    {
        Task<IReadOnlyList<Signature>> GetSignaturesAsync(CancellationToken token);

        Task<SignManifest> GetSignManifestAsync(CancellationToken token);

        Task<SignManifest> CreateManifestAsync(CancellationToken token);

        Task<bool> IsSignedAsync(CancellationToken token);
    }
}
