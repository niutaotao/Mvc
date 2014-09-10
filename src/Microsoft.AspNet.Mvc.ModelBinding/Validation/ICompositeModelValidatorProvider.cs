﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNet.Mvc.ModelBinding
{
    /// <summary>
    /// Represents aggregate of <see cref="IModelValidatorProvider"/>s that delegates to its underlying providers.
    /// </summary>
    public interface ICompositeModelValidatorProvider : IModelValidatorProvider
    {
    }
}