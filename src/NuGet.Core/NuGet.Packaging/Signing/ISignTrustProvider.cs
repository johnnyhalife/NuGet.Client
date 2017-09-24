using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NuGet.Common;

namespace NuGet.Packaging.Signing
{
    public interface ISignTrustProvider
    {
        Task<bool> IsTrusted(Signature signature, ILogger logger, CancellationToken token);
    }
}
