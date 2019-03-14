// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Http2
{
    [Flags]
    internal enum Http2SettingsFrameFlags : byte
    {
        NONE = 0x0,
        ACK = 0x1,
    }
}
