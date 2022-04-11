/*
 * Conductor API Server
 *
 * Conductor API Server
 *
 * The version of the OpenAPI document: v0
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
using OpenAPIDateConverter = Conductor.Client.OpenAPIDateConverter;

namespace Conductor.Client.Models
{
    /// <summary>
    /// SearchResultWorkflowSummary
    /// </summary>
    [DataContract(Name = "SearchResultWorkflowSummary")]
    public partial class SearchResultWorkflowSummary : IEquatable<SearchResultWorkflowSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultWorkflowSummary" /> class.
        /// </summary>
        /// <param name="totalHits">totalHits.</param>
        /// <param name="results">results.</param>
        public SearchResultWorkflowSummary(long totalHits = default(long), List<WorkflowSummary> results = default(List<WorkflowSummary>))
        {
            this.TotalHits = totalHits;
            this.Results = results;
        }

        /// <summary>
        /// Gets or Sets TotalHits
        /// </summary>
        [DataMember(Name = "totalHits", EmitDefaultValue = false)]
        public long TotalHits { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name = "results", EmitDefaultValue = false)]
        public List<WorkflowSummary> Results { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchResultWorkflowSummary {\n");
            sb.Append("  TotalHits: ").Append(TotalHits).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
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
            return this.Equals(input as SearchResultWorkflowSummary);
        }

        /// <summary>
        /// Returns true if SearchResultWorkflowSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchResultWorkflowSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchResultWorkflowSummary input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TotalHits == input.TotalHits ||
                    this.TotalHits.Equals(input.TotalHits)
                ) && 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    input.Results != null &&
                    this.Results.SequenceEqual(input.Results)
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
                hashCode = (hashCode * 59) + this.TotalHits.GetHashCode();
                if (this.Results != null)
                {
                    hashCode = (hashCode * 59) + this.Results.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
