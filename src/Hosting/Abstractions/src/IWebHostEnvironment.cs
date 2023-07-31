// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections;
using System.Linq;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;

namespace Microsoft.AspNetCore.Hosting;

/// <summary>
/// Provides information about the web hosting environment an application is running in.
/// </summary>
public interface IWebHostEnvironment : IHostEnvironment
{
    /// <summary>
    /// Gets a feature collection for the hosting environment.
    /// </summary>
    IFeatureCollection Features => EmptyFeatures.Instance;

    /// <summary>
    /// Gets or sets the absolute path to the directory that contains the web-servable application content files.
    /// This defaults to the 'wwwroot' subfolder.
    /// </summary>
    string WebRootPath { get; set; }

    /// <summary>
    /// Gets or sets an <see cref="IFileProvider"/> pointing at <see cref="WebRootPath"/>.
    /// This defaults to referencing files from the 'wwwroot' subfolder.
    /// </summary>
    IFileProvider WebRootFileProvider { get; set; }
}

internal sealed class EmptyFeatures : IFeatureCollection
{
    public static EmptyFeatures Instance { get; } = new();

    public object? this[Type key]
    {
        get => null;
        set => throw new NotImplementedException();
    }

    public bool IsReadOnly => true;

    public int Revision => 0;

    public TFeature? Get<TFeature>() => default;

    public IEnumerator<KeyValuePair<Type, object>> GetEnumerator() => Enumerable.Empty<KeyValuePair<Type, object>>().GetEnumerator();

    public void Set<TFeature>(TFeature? instance) => throw new NotImplementedException();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
