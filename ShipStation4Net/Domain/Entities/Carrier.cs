﻿#region License
/*
 * Copyright 2017 Brandon James
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */
#endregion

using Newtonsoft.Json;

namespace ShipStation4Net.Domain.Entities
{
    public class Carrier
    {
        /// <summary>
        /// The name of the carrier
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The code of the carrier
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty("requiresFundedAccount")]
        public bool? RequiresFundedAccount { get; set; }

        [JsonProperty("balance")]
        public double? Balance { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("shippingProviderId")]
        public int? ShippingProviderId { get; set; }

        [JsonProperty("primary")]
        public bool? IsPrimary { get; set; }
    }
}
