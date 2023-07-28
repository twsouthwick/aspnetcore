// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.AspNetCore.Server.IIS;

/// <summary>
/// This feature provides access to IIS application information
/// </summary>
public interface IISEnvironmentFeature
{
    /// <summary>
    /// Gets the version of IIS that is being used.
    /// </summary>
    Version IISVersion { get; }

    /// <summary>
    /// Gets the AppPool Id that is currently running
    /// </summary>
    string AppPoolId { get; }

    /// <summary>
    /// Gets path to the AppPool configuration that is currently running
    /// </summary>
    string AppPoolConfig { get; }

    /// <summary>
    /// Gets the path of the application.
    /// </summary>
    string ApplicationPath { get; }

    /// <summary>
    /// Gets the virtual path of the application.
    /// </summary>
    string ApplicationVirtualPath { get; }

    /// <summary>
    /// Gets ID of the current application.
    /// </summary>
    string ApplicationId { get; }

    /// <summary>
    /// Gets the name of the current site.
    /// </summary>
    string SiteName { get; }

    /// <summary>
    /// Gets the id of the current site.
    /// </summary>
    uint SiteId { get; }
}
