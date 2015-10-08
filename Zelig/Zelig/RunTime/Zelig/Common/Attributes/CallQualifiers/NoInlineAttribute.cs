//
// Copyright (c) Microsoft Corporation.    All rights reserved.
//

namespace Microsoft.Zelig.Runtime
{
    using System;

    [TypeSystem.WellKnownType( "Microsoft_Zelig_Runtime_NoInlineAttribute" )]
    [AttributeUsage(AttributeTargets.Constructor |
                    AttributeTargets.Method      )]
    public sealed class NoInlineAttribute : Attribute
    {
    }
}