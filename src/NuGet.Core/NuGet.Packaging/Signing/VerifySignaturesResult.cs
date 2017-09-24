using System;
using System.Collections.Generic;
using System.Text;

namespace NuGet.Packaging.Signing
{
    /// <summary>
    /// Collection of signature verification results.
    /// </summary>
    public class VerifySignaturesResult
    {
        public bool Valid { get; set; }

        public IReadOnlyList<SignVerifyResult> Results { get; set; }
    }
}
