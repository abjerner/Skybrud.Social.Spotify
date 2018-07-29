﻿using System;
using Skybrud.Essentials.Common;
using Skybrud.Social.Http;
using Skybrud.Social.Spotify.OAuth;
using Skybrud.Social.Spotify.Options.Artists;

namespace Skybrud.Social.Spotify.Endpoints.Raw {
    
    /// <summary>
    /// Class representing the raw implementation of the user profile endpoint.
    /// </summary>
    public class SpotifyPersonalizationRawEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public SpotifyOAuthClient Client { get; private set; }

        #endregion

        #region Constructors

        internal SpotifyPersonalizationRawEndpoint(SpotifyOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Get detailed profile information about the current user (including the current user’s username).
        /// </summary>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://developer.spotify.com/web-api/get-artist/</cref>
        /// </see>
        public SocialHttpResponse GetMe() {
            return Client.DoHttpGetRequest("https://api.spotify.com/v1/me/");
        }


        /// <summary>
        /// Get public profile information about a Spotify user identified by their unique user ID.
        /// </summary>
        /// <param name="id">The Spotify user ID for the user. </param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://developer.spotify.com/web-api/get-artist/</cref>
        /// </see>
        public SocialHttpResponse GetUser(string id)
        {
            if (String.IsNullOrWhiteSpace(id)) throw new ArgumentNullException("id");
            return Client.DoHttpGetRequest("https://api.spotify.com/v1/users/" + id);
        }


        #endregion

    }

}