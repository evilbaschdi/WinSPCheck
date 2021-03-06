﻿using EvilBaschdi.Core;

namespace SystemPropertiesChecker.Core.Internal.DotNet
{
    /// <inheritdoc />
    /// <summary>
    ///     Interface for classes that return a list of current installed .net core sdks
    /// </summary>
    public interface IDotNetCoreSdks : IValue<string>
    {
    }
}