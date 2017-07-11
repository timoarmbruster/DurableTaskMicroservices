﻿//  ----------------------------------------------------------------------------------
//  Copyright daenet Gesellschaft für Informationstechnologie mbH
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//  http://www.apache.org/licenses/LICENSE-2.0
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//  ----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Daenet.DurableTask.Microservices
{
    [Serializable]
    public class ServiceHostException : Exception
    {
        
        public ServiceHostException()
        {
        }

        public ServiceHostException(string message)
            : base(message)
        {
        }

        public ServiceHostException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public ServiceHostException(int eventId, string message, Exception innerException)
            : base(message, innerException)
        {
            EventId = eventId;
        }

        protected ServiceHostException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public int EventId { get; set; }
    }
}
