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
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Represents the output of a put action revision action.
    /// </summary>
    public partial class PutActionRevisionResult : AmazonWebServiceResponse
    {
        private bool? _newRevision;
        private string _pipelineExecutionId;

        /// <summary>
        /// Gets and sets the property NewRevision. 
        /// <para>
        /// The new revision number or ID for the revision after the action completes.
        /// </para>
        /// </summary>
        public bool NewRevision
        {
            get { return this._newRevision.GetValueOrDefault(); }
            set { this._newRevision = value; }
        }

        // Check to see if NewRevision property is set
        internal bool IsSetNewRevision()
        {
            return this._newRevision.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PipelineExecutionId. 
        /// <para>
        /// The ID of the current workflow state of the pipeline. 
        /// </para>
        /// </summary>
        public string PipelineExecutionId
        {
            get { return this._pipelineExecutionId; }
            set { this._pipelineExecutionId = value; }
        }

        // Check to see if PipelineExecutionId property is set
        internal bool IsSetPipelineExecutionId()
        {
            return this._pipelineExecutionId != null;
        }

    }
}