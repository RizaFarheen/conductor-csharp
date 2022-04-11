/* 
 * 
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Conductor.Client.Models
{
    /// <summary>
    /// Health
    /// </summary>
    [DataContract]
    public partial class Health :  IEquatable<Health>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Health" /> class.
        /// </summary>
        /// <param name="details">details.</param>
        /// <param name="healthy">healthy (default to false).</param>
        /// <param name="errorMessage">errorMessage.</param>
        public Health(Dictionary<string, Object> details = default(Dictionary<string, Object>), bool? healthy = false, string errorMessage = default(string))
        {
            this.Details = details;
            // use default value if no "healthy" provided
            if (healthy == null)
            {
                this.Healthy = false;
            }
            else
            {
                this.Healthy = healthy;
            }
            this.ErrorMessage = errorMessage;
        }
        
        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public Dictionary<string, Object> Details { get; set; }

        /// <summary>
        /// Gets or Sets Healthy
        /// </summary>
        [DataMember(Name="healthy", EmitDefaultValue=false)]
        public bool? Healthy { get; set; }

        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Health {\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Healthy: ").Append(Healthy).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Health);
        }

        /// <summary>
        /// Returns true if Health instances are equal
        /// </summary>
        /// <param name="input">Instance of Health to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Health input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(input.Details)
                ) && 
                (
                    this.Healthy == input.Healthy ||
                    (this.Healthy != null &&
                    this.Healthy.Equals(input.Healthy))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
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
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.Healthy != null)
                    hashCode = hashCode * 59 + this.Healthy.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
