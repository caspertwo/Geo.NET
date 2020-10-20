﻿// <copyright file="IMapBoxGeocoding.cs" company="Geo.NET">
// Copyright (c) Geo.NET. All rights reserved.
// </copyright>

namespace Geo.MapBox.Abstractions
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Geo.MapBox.Models;
    using Geo.MapBox.Models.Exceptions;
    using Geo.MapBox.Models.Parameters;
    using Geo.MapBox.Models.Responses;

    /// <summary>
    /// An interface for calling the MapBox geocoding methods.
    /// </summary>
    public interface IMapBoxGeocoding
    {
        /// <summary>
        /// Calls the MapBox geocoding API and returns the results.
        /// </summary>
        /// <param name="parameters">A <see cref="GeocodingParameters"/> with the parameters of the request.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> used to cancel the request.</param>
        /// <returns>A <see cref="Response{List{string}}"/> with the response from MapBox.</returns>
        /// <exception cref="MapBoxException">Thrown for multiple different reasons. Check the inner exception for more information.</exception>
        Task<Response<List<string>>> GeocodingAsync(GeocodingParameters parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Calls the MapBox reverse geocoding API and returns the results.
        /// </summary>
        /// <param name="parameters">A <see cref="ReverseGeocodingParameters"/> with the parameters of the request.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> used to cancel the request.</param>
        /// <returns>A <see cref="Response{Coordinate}"/> with the response from MapBox.</returns>
        /// <exception cref="MapBoxException">Thrown for multiple different reasons. Check the inner exception for more information.</exception>
        Task<Response<Coordinate>> ReverseGeocodingAsync(ReverseGeocodingParameters parameters, CancellationToken cancellationToken = default);
    }
}
