using System;
using System.Collections.Generic;
using System.Linq;
// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NuGet.CommandLine.Commands
{
    public class SignArgs
    {
        public string PackagePath { get; set; }
        public X509Certificate Certificate { get; set; }
        public string CertificatePassword { get; set; }
        public Encoding Encoding { get; set; }

    }
}
