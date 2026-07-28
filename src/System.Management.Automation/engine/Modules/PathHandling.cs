// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace System.Management.Automation.Internal
{
    internal static class PathHandling
    {
        /// <summary>
        /// Normalizess <paramref name="path"/>.
        /// </summary>
        /// <param name="path">The path to normalize directory separators for.</param>
        /// <returns>A path based on <paramref name="path"/> that contains only default
        /// directory separators and does not end with one.</returns>
        public static string NormalizeDirectorySeparators(string path)
        {
            return path.Replace(StringLiterals.AlternatePathSeparator, StringLiterals.DefaultPathSeparator).TrimEnd(StringLiterals.DefaultPathSeparator);
        }
    }
}
