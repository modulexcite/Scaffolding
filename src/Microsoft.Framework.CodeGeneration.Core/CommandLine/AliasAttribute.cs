// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Microsoft.Framework.CodeGeneration.CommandLine
{
    /// <summary>
    /// Specifies a command line alias for a code generator.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class AliasAttribute : Attribute
    {
        public AliasAttribute([NotNull]string alias)
        {
            Alias = alias;
        }

        public string Alias { get; private set; }
    }
}