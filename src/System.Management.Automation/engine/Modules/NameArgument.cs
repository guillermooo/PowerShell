// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace System.Management.Automation.engine.Modules
{
    /// <summary>
    /// Represents input data to a <c>-Name</c> or <c>-FullyQualifiedName</c> parameter.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         <see cref="NameArgument"/> is a bundle of input data and ancillary data that eases
    ///         the processing of the <c>-Name</c> and <c>-FullyQualifiedName</c> parameters.
    ///     </para>
    /// </remarks>
    internal sealed class NameArgument
    {
        /// <summary>
        /// The name of the parameter that received the argument.
        /// </summary>
        public required string ParameterName { get; init; }

        /// <summary>
        /// The path or name argument as it was provided by the user.
        /// </summary>
        public required string Verbatim { get; init; }

        /// <summary>
        /// Indicates whether the path or name argument contains wildcard characters.
        /// </summary>
        public required bool HasWildcards { get; init; }

        /// <summary>
        /// Indicates whether the argument is a path.
        /// </summary>
        public required bool IsPath { get; init; }

        /// <summary>
        /// The name argument.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         If <see cref="IsPath"/> is <see langword="false"/>, this property is not <see langword="null"/>.
        ///     </para>
        /// </remarks>
        public required string Name { get; init; }

        /// <summary>
        /// The fully qualified paths, if any, resolved from the path argument.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         If <see cref="IsPath"/> is <see langword="true"/>, this property may still be empty.
        ///     </para>
        /// </remarks>
        public required IReadOnlyCollection<string> Paths
        {
            get;
            init => field = value ?? Array.Empty<string>();
        }

        public required Guid? Guid { get; init; }

        public required Version Version { get; init; }

        public required string MaximumVersion { get; init; }

        public required Version RequiredVersion { get; init; }
    }
}
