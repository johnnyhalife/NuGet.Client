// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NuGet.Common;
using NuGet.Packaging.Core;

namespace NuGet.Packaging.Signing
{
    public class SignPackage : IDisposable
    {
        private readonly IPackageCoreWriter _package;

        public SignPackage(IPackageCoreWriter package)
        {
            _package = package;
        }

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

        public Task<SignManifest> CreateManifestAsync(ILogger logger, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsSignedAsync(ILogger logger, CancellationToken token)
        {
            return Task.FromResult(GetSignManifestAsync(logger, token) != null);
        }

        public void Dispose()
        {
            _package.Dispose();
        }
    }
}
