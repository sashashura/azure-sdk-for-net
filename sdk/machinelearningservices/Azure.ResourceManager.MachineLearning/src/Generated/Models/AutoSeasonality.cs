// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The AutoSeasonality. </summary>
    public partial class AutoSeasonality : Seasonality
    {
        /// <summary> Initializes a new instance of AutoSeasonality. </summary>
        public AutoSeasonality()
        {
            Mode = SeasonalityMode.Auto;
        }

        /// <summary> Initializes a new instance of AutoSeasonality. </summary>
        /// <param name="mode"> [Required] Seasonality mode. </param>
        internal AutoSeasonality(SeasonalityMode mode) : base(mode)
        {
            Mode = mode;
        }
    }
}
