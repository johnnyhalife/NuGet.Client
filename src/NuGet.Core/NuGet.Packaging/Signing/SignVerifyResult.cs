using System;
using System.Collections.Generic;
using System.Text;

namespace NuGet.Packaging.Signing
{
    /// <summary>
    /// Individual signature verification result.
    /// </summary>
    public class SignVerifyResult
    {
        public bool Valid { get; set; }

        public Signature Signature { get; set; }
    }
}
