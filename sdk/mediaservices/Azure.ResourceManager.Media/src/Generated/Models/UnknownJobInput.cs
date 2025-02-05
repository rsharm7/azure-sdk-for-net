// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The UnknownJobInput. </summary>
    internal partial class UnknownJobInput : MediaJobInputBasicProperties
    {
        /// <summary> Initializes a new instance of UnknownJobInput. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        internal UnknownJobInput(string odataType) : base(odataType)
        {
            OdataType = odataType ?? "Unknown";
        }
    }
}
