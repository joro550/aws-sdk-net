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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DLM.Model
{
    /// <summary>
    /// Specifies a schedule.
    /// </summary>
    public partial class Schedule
    {
        private bool? _copyTags;
        private CreateRule _createRule;
        private string _name;
        private RetainRule _retainRule;
        private List<Tag> _tagsToAdd = new List<Tag>();
        private List<Tag> _variableTags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property CopyTags. 
        /// <para>
        /// Copy all user-defined tags on a source volume to snapshots of the volume created by
        /// this policy.
        /// </para>
        /// </summary>
        public bool CopyTags
        {
            get { return this._copyTags.GetValueOrDefault(); }
            set { this._copyTags = value; }
        }

        // Check to see if CopyTags property is set
        internal bool IsSetCopyTags()
        {
            return this._copyTags.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreateRule. 
        /// <para>
        /// The create rule.
        /// </para>
        /// </summary>
        public CreateRule CreateRule
        {
            get { return this._createRule; }
            set { this._createRule = value; }
        }

        // Check to see if CreateRule property is set
        internal bool IsSetCreateRule()
        {
            return this._createRule != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RetainRule. 
        /// <para>
        /// The retain rule.
        /// </para>
        /// </summary>
        public RetainRule RetainRule
        {
            get { return this._retainRule; }
            set { this._retainRule = value; }
        }

        // Check to see if RetainRule property is set
        internal bool IsSetRetainRule()
        {
            return this._retainRule != null;
        }

        /// <summary>
        /// Gets and sets the property TagsToAdd. 
        /// <para>
        /// The tags to apply to policy-created resources. These user-defined tags are in addition
        /// to the AWS-added lifecycle tags.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> TagsToAdd
        {
            get { return this._tagsToAdd; }
            set { this._tagsToAdd = value; }
        }

        // Check to see if TagsToAdd property is set
        internal bool IsSetTagsToAdd()
        {
            return this._tagsToAdd != null && this._tagsToAdd.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VariableTags. 
        /// <para>
        /// A collection of key/value pairs with values determined dynamically when the policy
        /// is executed. Keys may be any valid Amazon EC2 tag key. Values must be in one of the
        /// two following formats: <code>$(instance-id)</code> or <code>$(timestamp)</code>. Variable
        /// tags are only valid for EBS Snapshot Management – Instance policies.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> VariableTags
        {
            get { return this._variableTags; }
            set { this._variableTags = value; }
        }

        // Check to see if VariableTags property is set
        internal bool IsSetVariableTags()
        {
            return this._variableTags != null && this._variableTags.Count > 0; 
        }

    }
}