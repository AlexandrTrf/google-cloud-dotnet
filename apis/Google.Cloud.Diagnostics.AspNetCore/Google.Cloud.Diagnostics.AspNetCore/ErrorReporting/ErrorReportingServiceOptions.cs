﻿// Copyright 2017 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Cloud.Diagnostics.Common;
using System;

#if NETCOREAPP3_1
namespace Google.Cloud.Diagnostics.AspNetCore3
#elif NETSTANDARD2_0
namespace Google.Cloud.Diagnostics.AspNetCore
#else
#error unknown target framework
#endif
{
    /// <summary>
    /// Configuration for initializing error reporting.
    /// </summary>
    [Obsolete("Use Google.Cloud.Diagnostics.Common.ErrorReportingServiceOptions instead.")]
    public sealed class ErrorReportingServiceOptions
    {
        /// <summary>
        /// The Google Cloud Platform project ID. If unspecified and running on GAE or GCE the project
        /// ID will be detected from the platform.
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// An identifier of the service, such as the name of the executable or job. May be null.
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// Represents the source code version that the developer provided. May be null.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Error reporting options for exception logging. May be null.
        /// </summary>
        public ErrorReportingOptions Options { get; set; }
    }
}
