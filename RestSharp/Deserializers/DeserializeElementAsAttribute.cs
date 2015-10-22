﻿#region License

//   Copyright 2010 John Sheehan
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License. 

#endregion

using System;

namespace RestSharp.Deserializers
{
    /// <summary>
    /// Allows control how class and property names and values are deserialized by XmlAttributeDeserializer
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class, Inherited = false)]
    public sealed class DeserializeElementAsAttribute : Attribute
    {
        /// <summary>
        /// Sets the Element to Deserialize
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Sets the Attribute  to Deserialize
        /// </summary>
        public string Attribute { get; set; }

        /// <summary>
        /// The Element's Attribute's value to locate the serialized element
        /// </summary>
        public string Value { get; set; }

    }
}
