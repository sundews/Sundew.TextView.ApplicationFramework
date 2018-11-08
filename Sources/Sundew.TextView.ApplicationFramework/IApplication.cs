﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IApplication.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.TextView.ApplicationFramework
{
    /// <summary>
    /// Interface for implementing an application.
    /// </summary>
    /// <seealso cref="IApplicationIdleMonitoring" />
    /// <seealso cref="IApplicationRendering" />
    public interface IApplication : IApplicationIdleMonitoring, IApplicationRendering, IApplicationExit
    {
    }
}