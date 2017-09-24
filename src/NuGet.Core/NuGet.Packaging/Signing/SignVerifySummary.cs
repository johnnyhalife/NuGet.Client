using System;
using System.Collections.Generic;
using System.Text;

namespace NuGet.Packaging.Signing
{
    public class SignVerifySummary
    {
        public bool Valid { get; set; }

        public IReadOnlyList<SignVerifyResult> Results { get; set; }
    }
}
