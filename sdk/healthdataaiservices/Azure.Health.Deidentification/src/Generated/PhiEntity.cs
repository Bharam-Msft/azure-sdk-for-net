// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Deidentification
{
    /// <summary> PHI Entity tag in the input. </summary>
    public partial class PhiEntity
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        /// <summary> Initializes a new instance of <see cref="PhiEntity"/>. </summary>
        /// <param name="category"> PHI Category of the entity. </param>
        /// <param name="offset"> Starting index of the location from within the input text. </param>
        /// <param name="length"> Length of the input text. </param>
        internal PhiEntity(PhiCategory category, StringIndex offset, StringIndex length)
        {
            Category = category;
            Offset = offset;
            Length = length;
        }

        /// <summary> Initializes a new instance of <see cref="PhiEntity"/>. </summary>
        /// <param name="category"> PHI Category of the entity. </param>
        /// <param name="offset"> Starting index of the location from within the input text. </param>
        /// <param name="length"> Length of the input text. </param>
        /// <param name="text"> Text of the entity. </param>
        /// <param name="confidenceScore"> Confidence score of the category match. </param>
        /// <param name="additionalBinaryDataProperties"> Keeps track of any properties unknown to the library. </param>
        internal PhiEntity(PhiCategory category, StringIndex offset, StringIndex length, string text, double? confidenceScore, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Category = category;
            Offset = offset;
            Length = length;
            Text = text;
            ConfidenceScore = confidenceScore;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        /// <summary> PHI Category of the entity. </summary>
        public PhiCategory Category { get; }

        /// <summary> Starting index of the location from within the input text. </summary>
        public StringIndex Offset { get; }

        /// <summary> Length of the input text. </summary>
        public StringIndex Length { get; }

        /// <summary> Text of the entity. </summary>
        public string Text { get; }

        /// <summary> Confidence score of the category match. </summary>
        public double? ConfidenceScore { get; }
    }
}
