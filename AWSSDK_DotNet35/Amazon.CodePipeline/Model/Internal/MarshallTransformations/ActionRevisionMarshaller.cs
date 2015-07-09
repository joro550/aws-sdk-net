/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodePipeline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodePipeline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ActionRevision Marshaller
    /// </summary>       
    public class ActionRevisionMarshaller : IRequestMarshaller<ActionRevision, JsonMarshallerContext> 
    {
        public void Marshall(ActionRevision requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCreated())
            {
                context.Writer.WritePropertyName("created");
                context.Writer.Write(requestObject.Created);
            }

            if(requestObject.IsSetRevisionChangeId())
            {
                context.Writer.WritePropertyName("revisionChangeId");
                context.Writer.Write(requestObject.RevisionChangeId);
            }

            if(requestObject.IsSetRevisionId())
            {
                context.Writer.WritePropertyName("revisionId");
                context.Writer.Write(requestObject.RevisionId);
            }

        }

        public readonly static ActionRevisionMarshaller Instance = new ActionRevisionMarshaller();

    }
}