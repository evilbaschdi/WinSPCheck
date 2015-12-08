﻿namespace WinSPCheck.Internal
{
    /// <summary>
    ///     Interface for classes that provide values about the current windows version.
    /// </summary>
    public interface IWindowsVersionInformation
    {
        /// <summary>
        ///     Contains WindowsVersionInformation values.
        /// </summary>
        IWindowsVersionInformationHelper Values { get; }
    }
}