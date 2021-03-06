/*
 * Copyright © The DevOps Collective, Inc. All rights reserved.
 * Licnesed under GNU GPL v3. See top-level LICENSE.txt for more details.
 */

using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TugDSC.Util
{
    /// Base class implementation supporting extension data with JSON serialization.
    public abstract class ExtDataBase : IExtData
    {
        [JsonExtensionData]
        protected IDictionary<string, JToken> _extData = new Dictionary<string, JToken>();

        IDictionary<string, JToken> IExtData.GetExtData()
        {
            return _extData;
        }
    }
}