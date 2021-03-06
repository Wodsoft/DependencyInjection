// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// The result of <see cref="ActivatorUtilitiesExtensions.CreateFactory(Type, Type[])"/>.
    /// </summary>
    /// <param name="serviceProvider">The <see cref="IServiceProvider"/> to get service arguments from.</param>
    /// <param name="arguments">Additional constructor arguments.</param>
    /// <returns>The instantiated type.</returns>
    public delegate object ObjectFactory(IServiceProvider serviceProvider, object[] arguments);
}