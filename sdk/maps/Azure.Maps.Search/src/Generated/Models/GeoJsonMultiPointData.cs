// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Maps.Search.Models
{
    /// <summary> Data contained by a `GeoJson MultiPoint`. </summary>
    public partial class GeoJsonMultiPointData
    {
        /// <summary> Initializes a new instance of <see cref="GeoJsonMultiPointData"/>. </summary>
        /// <param name="coordinates"> Coordinates for the `GeoJson MultiPoint` geometry. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="coordinates"/> is null. </exception>
        public GeoJsonMultiPointData(IEnumerable<IList<double>> coordinates)
        {
            if (coordinates == null)
            {
                throw new ArgumentNullException(nameof(coordinates));
            }

            Coordinates = coordinates.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="GeoJsonMultiPointData"/>. </summary>
        /// <param name="coordinates"> Coordinates for the `GeoJson MultiPoint` geometry. </param>
        internal GeoJsonMultiPointData(IList<IList<double>> coordinates)
        {
            Coordinates = coordinates;
        }

        /// <summary> Coordinates for the `GeoJson MultiPoint` geometry. </summary>
        public IList<IList<double>> Coordinates { get; }
    }
}
