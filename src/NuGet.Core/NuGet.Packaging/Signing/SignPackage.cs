// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NuGet.Common;

namespace NuGet.Packaging.Signing
{
    public class SignPackage
    {
        public Task AddSignatureAsync(Signature signature, ILogger logger, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        public Task RemoveSignatureAsync(Signature signature, ILogger logger, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        public Task RemoveSignaturesAsync(ILogger logger, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Signature>> GetSignaturesAsync(ILogger logger, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        public Task AddSignManifestAsync(ILogger logger, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        public Task AddSignManifestAsync(SignManifest signManifest, ILogger logger, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        public Task<SignManifest> GetSignManifestAsync(ILogger logger, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        public Task<SignVerifySummary> VerifySignaturesAsync(ILogger logger, CancellationToken token)
        {
            throw new NotImplementedException();
        }
    }
}
