// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Synapse.Models
{
    using global::Azure.Analytics.Synapse.Artifacts.Models;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.WindowsAzure.Commands.Utilities.Common;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// HDInsight MapReduce activity type.
    /// </summary>
    [Newtonsoft.Json.JsonObject("HDInsightMapReduce")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSHDInsightMapReduceActivity : PSExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the PSHDInsightMapReduceActivity
        /// class.
        /// </summary>
        public PSHDInsightMapReduceActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets storage linked service references.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.storageLinkedServices")]
        public IList<LinkedServiceReference> StorageLinkedServices { get; set; }

        /// <summary>
        /// Gets or sets user specified arguments to HDInsightActivity.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.arguments")]
        public IList<object> Arguments { get; set; }

        /// <summary>
        /// Gets or sets debug info option. Possible values include: 'None',
        /// 'Always', 'Failure'
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.getDebugInfo")]
        public string GetDebugInfo { get; set; }

        /// <summary>
        /// Gets or sets class name. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.className")]
        public object ClassName { get; set; }

        /// <summary>
        /// Gets or sets jar path. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.jarFilePath")]
        public object JarFilePath { get; set; }

        /// <summary>
        /// Gets or sets jar linked service reference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.jarLinkedService")]
        public LinkedServiceReference JarLinkedService { get; set; }

        /// <summary>
        /// Gets or sets jar libs.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.jarLibs")]
        public IList<object> JarLibs { get; set; }

        /// <summary>
        /// Gets or sets allows user to specify defines for the MapReduce job
        /// request.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.defines")]
        public IDictionary<string, object> Defines { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (ClassName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ClassName");
            }
            if (JarFilePath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "JarFilePath");
            }
        }

        public override Activity ToSdkObject()
        {
            var activity = new HDInsightMapReduceActivity(this.Name, this.ClassName, this.JarFilePath);
            this.StorageLinkedServices?.ForEach(item => activity.StorageLinkedServices.Add(item));
            this.Arguments?.ForEach(item => activity.Arguments.Add(item));
            activity.GetDebugInfo = this.GetDebugInfo;
            activity.JarLinkedService = this.JarLinkedService;
            this.JarLibs?.ForEach(item => activity.JarLibs.Add(item));
            this.Defines?.ForEach(item => activity.Defines.Add(item));
            activity.LinkedServiceName = this.LinkedServiceName;
            activity.Policy = this.Policy;
            SetProperties(activity);
            return activity;
        }
    }
}

