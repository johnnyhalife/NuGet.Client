using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NuGet.Common;

namespace NuGet.Packaging.Signing
{
    /// <summary>
    /// Loads trust providers and verifies package signatures.
    /// </summary>
    public class SignVerifier
    {
        public SignVerifier(IEnumerable<ISignTrustProvider> trustProviders)
        {

        }

        public Task<VerifySignaturesResult> VerifySignaturesAsync(SignPackage package, ILogger logger, CancellationToken token)
        {
            throw new NotImplementedException();
        }
    }
}
