// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace NuGet.CommandLine.Commands
{
    [Command(typeof(NuGetCommand), "sign", "SignCommandDescription", MinArgs = 2, MaxArgs = 4,
        UsageSummaryResourceName = "SignCommandSummary",
        UsageExampleResourceName = "SignCommandExamples")]
    public class SignCommand : Command
    {
        [Option(typeof(NuGetCommand), "LocalsCommandClearDescription")]
        public string PackagPath { get; set; }

        [Option(typeof(NuGetCommand), "LocalsCommandListDescription")]
        public string CertificatePath { get; set; }

        [Option(typeof(NuGetCommand), "LocalsCommandClearDescription")]
        public string CertificatePassword { get; set; }

        [Option(typeof(NuGetCommand), "LocalsCommandListDescription")]
        public string EncodingType { get; set; }

        public SignCommandRunner SignCommandRunner { get; set; }

        public override Task ExecuteCommandAsync()
        {
            if (string.IsNullOrEmpty(PackagPath) || string.IsNullOrEmpty(CertificatePath))
            {
                throw new ArgumentException("Need to provide package path and certificate path");
            }

            var certificate = new X509Certificate(CertificatePath);

            Encoding encoding;
            if (!Enum.TryParse(EncodingType, out encoding))
            {
                encoding = Encoding.SHA512;
            }

            var signArgs = new SignArgs()
            {
                Certificate = certificate,
                PackagePath = PackagPath,
                CertificatePassword = CertificatePassword,
                Encoding = encoding
            };

            var result = SignCommandRunner.ExecuteCommand(signArgs);

            if (result != null)
            {
                Console.Log(result);
            }
            else
            {
                Console.WriteLine("Signing Succeeded");
            }

            return Task.FromResult(0);
        }
    }
}
