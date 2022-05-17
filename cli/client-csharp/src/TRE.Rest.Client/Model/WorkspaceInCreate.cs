/*
 * Azure TRE API
 *
 * Welcome to the Azure TRE API - for more information about templates and workspaces see the [Azure TRE documentation](https://microsoft.github.io/AzureTRE)
 *
 * The version of the OpenAPI document: 0.2.14
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = TRE.Rest.Client.Client.OpenAPIDateConverter;

namespace TRE.Rest.Client.Model
{
    /// <summary>
    /// WorkspaceInCreate
    /// </summary>
    [DataContract(Name = "WorkspaceInCreate")]
    public partial class WorkspaceInCreate : IEquatable<WorkspaceInCreate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceInCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkspaceInCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceInCreate" /> class.
        /// </summary>
        /// <param name="templateName">Bundle name (required).</param>
        /// <param name="properties">Values for the parameters required by the workspace resource specification.</param>
        public WorkspaceInCreate(string templateName = default(string), Object properties = default(Object))
        {
            // to ensure "templateName" is required (not null)
            if (templateName == null) {
                throw new ArgumentNullException("templateName is a required property for WorkspaceInCreate and cannot be null");
            }
            this.TemplateName = templateName;
            this.Properties = properties;
        }

        /// <summary>
        /// Bundle name
        /// </summary>
        /// <value>Bundle name</value>
        [DataMember(Name = "templateName", IsRequired = true, EmitDefaultValue = false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Values for the parameters required by the workspace resource specification
        /// </summary>
        /// <value>Values for the parameters required by the workspace resource specification</value>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        public Object Properties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkspaceInCreate {\n");
            sb.Append("  TemplateName: ").Append(TemplateName).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkspaceInCreate);
        }

        /// <summary>
        /// Returns true if WorkspaceInCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkspaceInCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkspaceInCreate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TemplateName == input.TemplateName ||
                    (this.TemplateName != null &&
                    this.TemplateName.Equals(input.TemplateName))
                ) && 
                (
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.Equals(input.Properties))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.TemplateName != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateName.GetHashCode();
                }
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}