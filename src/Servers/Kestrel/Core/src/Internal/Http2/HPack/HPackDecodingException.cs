﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Http2.HPack
{
    internal class HPackDecodingException : Exception
    {
        public HPackDecodingException(string message)
            : base(message)
        {
        }
        public HPackDecodingException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
