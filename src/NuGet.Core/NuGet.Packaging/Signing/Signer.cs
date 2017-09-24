using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NuGet.Common;
using NuGet.Packaging.Core;

namespace NuGet.Packaging.Signing
{
    public class Signer
    {
        private readonly IPackageCoreWriter _package;

        public Signer(IPackageCoreWriter package)
        {
            _package = package ?? throw new ArgumentNullException(nameof(package));
        }

        public Task SignAsync(Signature signature, ILogger logger, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        public Task RemoveSignaturesAsync(ILogger logger, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        public Task RemoveSignatureAsync(Signature signature, ILogger logger, CancellationToken token)
        {
            throw new NotImplementedException();
        }
    }
}
