/*
 * Copyright 2026 Google Inc. All Rights Reserved.
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file or at
 * https://developers.google.com/open-source/licenses/bsd
 */

using System.Text.Json.Nodes;

namespace Google.Api.Gax
{
    /// <summary>
    /// Helpers for parsing the (GCE/GKE/Cloud Run) metadata-server JSON without Newtonsoft.Json, using
    /// System.Text.Json's <see cref="JsonNode"/> DOM. Replaces the previous <c>JObject.Parse</c> usage.
    /// </summary>
    internal static class PlatformMetadataJson
    {
        /// <summary>
        /// Parses <paramref name="json"/> and returns the root object, or <c>null</c> if the input is not valid JSON
        /// or is not a JSON object. This mirrors the previous <c>JObject.Parse</c>-in-a-try behavior (both invalid
        /// JSON and non-object JSON were treated as "not available").
        /// </summary>
        internal static JsonObject ParseObjectOrNull(string json)
        {
            try
            {
                return JsonNode.Parse(json) as JsonObject;
            }
            catch
            {
                return null;
            }
        }
    }
}
