// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The properties of a file on a compute node.
    /// </summary>
    public partial class FileProperties : IPropertyMetadata
    {
        private readonly long contentLength;
        private readonly string contentType;
        private readonly DateTime? creationTime;
        private readonly string fileMode;
        private readonly DateTime lastModified;

        #region Constructors

        internal FileProperties(Models.FileProperties protocolObject)
        {
            this.contentLength = protocolObject.ContentLength;
            this.contentType = protocolObject.ContentType;
            this.creationTime = protocolObject.CreationTime;
            this.fileMode = protocolObject.FileMode;
            this.lastModified = protocolObject.LastModified;
        }

        #endregion Constructors

        #region FileProperties

        /// <summary>
        /// Gets the length of the file.
        /// </summary>
        public long ContentLength
        {
            get { return this.contentLength; }
        }

        /// <summary>
        /// Gets the content type of the file.
        /// </summary>
        public string ContentType
        {
            get { return this.contentType; }
        }

        /// <summary>
        /// Gets the file creation time.
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this.creationTime; }
        }

        /// <summary>
        /// Gets the permission attribute for the file.
        /// </summary>
        /// <remarks>
        /// This property will be returned only for Linux nodes.
        /// </remarks>
        public string FileMode
        {
            get { return this.fileMode; }
        }

        /// <summary>
        /// Gets the time at which the file was last modified.
        /// </summary>
        public DateTime LastModified
        {
            get { return this.lastModified; }
        }

        #endregion // FileProperties

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata
    }
}