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
    /// FieldOptions
    /// </summary>
    [DataContract]
    public partial class FieldOptions :  IEquatable<FieldOptions>, IValidatableObject
    {
        /// <summary>
        /// Defines Ctype
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CtypeEnum
        {
            
            /// <summary>
            /// Enum STRING for value: STRING
            /// </summary>
            [EnumMember(Value = "STRING")]
            STRING = 1,
            
            /// <summary>
            /// Enum CORD for value: CORD
            /// </summary>
            [EnumMember(Value = "CORD")]
            CORD = 2,
            
            /// <summary>
            /// Enum STRINGPIECE for value: STRING_PIECE
            /// </summary>
            [EnumMember(Value = "STRING_PIECE")]
            STRINGPIECE = 3
        }

        /// <summary>
        /// Gets or Sets Ctype
        /// </summary>
        [DataMember(Name="ctype", EmitDefaultValue=false)]
        public CtypeEnum? Ctype { get; set; }
        /// <summary>
        /// Defines Jstype
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum JstypeEnum
        {
            
            /// <summary>
            /// Enum NORMAL for value: JS_NORMAL
            /// </summary>
            [EnumMember(Value = "JS_NORMAL")]
            NORMAL = 1,
            
            /// <summary>
            /// Enum STRING for value: JS_STRING
            /// </summary>
            [EnumMember(Value = "JS_STRING")]
            STRING = 2,
            
            /// <summary>
            /// Enum NUMBER for value: JS_NUMBER
            /// </summary>
            [EnumMember(Value = "JS_NUMBER")]
            NUMBER = 3
        }

        /// <summary>
        /// Gets or Sets Jstype
        /// </summary>
        [DataMember(Name="jstype", EmitDefaultValue=false)]
        public JstypeEnum? Jstype { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldOptions" /> class.
        /// </summary>
        /// <param name="unknownFields">unknownFields.</param>
        /// <param name="initialized">initialized (default to false).</param>
        /// <param name="parserForType">parserForType.</param>
        /// <param name="defaultInstanceForType">defaultInstanceForType.</param>
        /// <param name="serializedSize">serializedSize.</param>
        /// <param name="ctype">ctype.</param>
        /// <param name="deprecated">deprecated (default to false).</param>
        /// <param name="uninterpretedOptionList">uninterpretedOptionList.</param>
        /// <param name="uninterpretedOptionOrBuilderList">uninterpretedOptionOrBuilderList.</param>
        /// <param name="uninterpretedOptionCount">uninterpretedOptionCount.</param>
        /// <param name="packed">packed (default to false).</param>
        /// <param name="lazy">lazy (default to false).</param>
        /// <param name="weak">weak (default to false).</param>
        /// <param name="jstype">jstype.</param>
        /// <param name="initializationErrorString">initializationErrorString.</param>
        /// <param name="descriptorForType">descriptorForType.</param>
        /// <param name="allFields">allFields.</param>
        /// <param name="allFieldsRaw">allFieldsRaw.</param>
        public FieldOptions(UnknownFieldSet unknownFields = default(UnknownFieldSet), bool? initialized = false, ParserFieldOptions parserForType = default(ParserFieldOptions), FieldOptions defaultInstanceForType = default(FieldOptions), int? serializedSize = default(int?), CtypeEnum? ctype = default(CtypeEnum?), bool? deprecated = false, List<UninterpretedOption> uninterpretedOptionList = default(List<UninterpretedOption>), List<UninterpretedOptionOrBuilder> uninterpretedOptionOrBuilderList = default(List<UninterpretedOptionOrBuilder>), int? uninterpretedOptionCount = default(int?), bool? packed = false, bool? lazy = false, bool? weak = false, JstypeEnum? jstype = default(JstypeEnum?), string initializationErrorString = default(string), Descriptor descriptorForType = default(Descriptor), Dictionary<string, Object> allFields = default(Dictionary<string, Object>), Dictionary<string, Object> allFieldsRaw = default(Dictionary<string, Object>))
        {
            this.UnknownFields = unknownFields;
            // use default value if no "initialized" provided
            if (initialized == null)
            {
                this.Initialized = false;
            }
            else
            {
                this.Initialized = initialized;
            }
            this.ParserForType = parserForType;
            this.DefaultInstanceForType = defaultInstanceForType;
            this.SerializedSize = serializedSize;
            this.Ctype = ctype;
            // use default value if no "deprecated" provided
            if (deprecated == null)
            {
                this.Deprecated = false;
            }
            else
            {
                this.Deprecated = deprecated;
            }
            this.UninterpretedOptionList = uninterpretedOptionList;
            this.UninterpretedOptionOrBuilderList = uninterpretedOptionOrBuilderList;
            this.UninterpretedOptionCount = uninterpretedOptionCount;
            // use default value if no "packed" provided
            if (packed == null)
            {
                this.Packed = false;
            }
            else
            {
                this.Packed = packed;
            }
            // use default value if no "lazy" provided
            if (lazy == null)
            {
                this.Lazy = false;
            }
            else
            {
                this.Lazy = lazy;
            }
            // use default value if no "weak" provided
            if (weak == null)
            {
                this.Weak = false;
            }
            else
            {
                this.Weak = weak;
            }
            this.Jstype = jstype;
            this.InitializationErrorString = initializationErrorString;
            this.DescriptorForType = descriptorForType;
            this.AllFields = allFields;
            this.AllFieldsRaw = allFieldsRaw;
        }
        
        /// <summary>
        /// Gets or Sets UnknownFields
        /// </summary>
        [DataMember(Name="unknownFields", EmitDefaultValue=false)]
        public UnknownFieldSet UnknownFields { get; set; }

        /// <summary>
        /// Gets or Sets Initialized
        /// </summary>
        [DataMember(Name="initialized", EmitDefaultValue=false)]
        public bool? Initialized { get; set; }

        /// <summary>
        /// Gets or Sets ParserForType
        /// </summary>
        [DataMember(Name="parserForType", EmitDefaultValue=false)]
        public ParserFieldOptions ParserForType { get; set; }

        /// <summary>
        /// Gets or Sets DefaultInstanceForType
        /// </summary>
        [DataMember(Name="defaultInstanceForType", EmitDefaultValue=false)]
        public FieldOptions DefaultInstanceForType { get; set; }

        /// <summary>
        /// Gets or Sets SerializedSize
        /// </summary>
        [DataMember(Name="serializedSize", EmitDefaultValue=false)]
        public int? SerializedSize { get; set; }


        /// <summary>
        /// Gets or Sets Deprecated
        /// </summary>
        [DataMember(Name="deprecated", EmitDefaultValue=false)]
        public bool? Deprecated { get; set; }

        /// <summary>
        /// Gets or Sets UninterpretedOptionList
        /// </summary>
        [DataMember(Name="uninterpretedOptionList", EmitDefaultValue=false)]
        public List<UninterpretedOption> UninterpretedOptionList { get; set; }

        /// <summary>
        /// Gets or Sets UninterpretedOptionOrBuilderList
        /// </summary>
        [DataMember(Name="uninterpretedOptionOrBuilderList", EmitDefaultValue=false)]
        public List<UninterpretedOptionOrBuilder> UninterpretedOptionOrBuilderList { get; set; }

        /// <summary>
        /// Gets or Sets UninterpretedOptionCount
        /// </summary>
        [DataMember(Name="uninterpretedOptionCount", EmitDefaultValue=false)]
        public int? UninterpretedOptionCount { get; set; }

        /// <summary>
        /// Gets or Sets Packed
        /// </summary>
        [DataMember(Name="packed", EmitDefaultValue=false)]
        public bool? Packed { get; set; }

        /// <summary>
        /// Gets or Sets Lazy
        /// </summary>
        [DataMember(Name="lazy", EmitDefaultValue=false)]
        public bool? Lazy { get; set; }

        /// <summary>
        /// Gets or Sets Weak
        /// </summary>
        [DataMember(Name="weak", EmitDefaultValue=false)]
        public bool? Weak { get; set; }


        /// <summary>
        /// Gets or Sets InitializationErrorString
        /// </summary>
        [DataMember(Name="initializationErrorString", EmitDefaultValue=false)]
        public string InitializationErrorString { get; set; }

        /// <summary>
        /// Gets or Sets DescriptorForType
        /// </summary>
        [DataMember(Name="descriptorForType", EmitDefaultValue=false)]
        public Descriptor DescriptorForType { get; set; }

        /// <summary>
        /// Gets or Sets AllFields
        /// </summary>
        [DataMember(Name="allFields", EmitDefaultValue=false)]
        public Dictionary<string, Object> AllFields { get; set; }

        /// <summary>
        /// Gets or Sets AllFieldsRaw
        /// </summary>
        [DataMember(Name="allFieldsRaw", EmitDefaultValue=false)]
        public Dictionary<string, Object> AllFieldsRaw { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldOptions {\n");
            sb.Append("  UnknownFields: ").Append(UnknownFields).Append("\n");
            sb.Append("  Initialized: ").Append(Initialized).Append("\n");
            sb.Append("  ParserForType: ").Append(ParserForType).Append("\n");
            sb.Append("  DefaultInstanceForType: ").Append(DefaultInstanceForType).Append("\n");
            sb.Append("  SerializedSize: ").Append(SerializedSize).Append("\n");
            sb.Append("  Ctype: ").Append(Ctype).Append("\n");
            sb.Append("  Deprecated: ").Append(Deprecated).Append("\n");
            sb.Append("  UninterpretedOptionList: ").Append(UninterpretedOptionList).Append("\n");
            sb.Append("  UninterpretedOptionOrBuilderList: ").Append(UninterpretedOptionOrBuilderList).Append("\n");
            sb.Append("  UninterpretedOptionCount: ").Append(UninterpretedOptionCount).Append("\n");
            sb.Append("  Packed: ").Append(Packed).Append("\n");
            sb.Append("  Lazy: ").Append(Lazy).Append("\n");
            sb.Append("  Weak: ").Append(Weak).Append("\n");
            sb.Append("  Jstype: ").Append(Jstype).Append("\n");
            sb.Append("  InitializationErrorString: ").Append(InitializationErrorString).Append("\n");
            sb.Append("  DescriptorForType: ").Append(DescriptorForType).Append("\n");
            sb.Append("  AllFields: ").Append(AllFields).Append("\n");
            sb.Append("  AllFieldsRaw: ").Append(AllFieldsRaw).Append("\n");
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
            return this.Equals(input as FieldOptions);
        }

        /// <summary>
        /// Returns true if FieldOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldOptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UnknownFields == input.UnknownFields ||
                    (this.UnknownFields != null &&
                    this.UnknownFields.Equals(input.UnknownFields))
                ) && 
                (
                    this.Initialized == input.Initialized ||
                    (this.Initialized != null &&
                    this.Initialized.Equals(input.Initialized))
                ) && 
                (
                    this.ParserForType == input.ParserForType ||
                    (this.ParserForType != null &&
                    this.ParserForType.Equals(input.ParserForType))
                ) && 
                (
                    this.DefaultInstanceForType == input.DefaultInstanceForType ||
                    (this.DefaultInstanceForType != null &&
                    this.DefaultInstanceForType.Equals(input.DefaultInstanceForType))
                ) && 
                (
                    this.SerializedSize == input.SerializedSize ||
                    (this.SerializedSize != null &&
                    this.SerializedSize.Equals(input.SerializedSize))
                ) && 
                (
                    this.Ctype == input.Ctype ||
                    (this.Ctype != null &&
                    this.Ctype.Equals(input.Ctype))
                ) && 
                (
                    this.Deprecated == input.Deprecated ||
                    (this.Deprecated != null &&
                    this.Deprecated.Equals(input.Deprecated))
                ) && 
                (
                    this.UninterpretedOptionList == input.UninterpretedOptionList ||
                    this.UninterpretedOptionList != null &&
                    this.UninterpretedOptionList.SequenceEqual(input.UninterpretedOptionList)
                ) && 
                (
                    this.UninterpretedOptionOrBuilderList == input.UninterpretedOptionOrBuilderList ||
                    this.UninterpretedOptionOrBuilderList != null &&
                    this.UninterpretedOptionOrBuilderList.SequenceEqual(input.UninterpretedOptionOrBuilderList)
                ) && 
                (
                    this.UninterpretedOptionCount == input.UninterpretedOptionCount ||
                    (this.UninterpretedOptionCount != null &&
                    this.UninterpretedOptionCount.Equals(input.UninterpretedOptionCount))
                ) && 
                (
                    this.Packed == input.Packed ||
                    (this.Packed != null &&
                    this.Packed.Equals(input.Packed))
                ) && 
                (
                    this.Lazy == input.Lazy ||
                    (this.Lazy != null &&
                    this.Lazy.Equals(input.Lazy))
                ) && 
                (
                    this.Weak == input.Weak ||
                    (this.Weak != null &&
                    this.Weak.Equals(input.Weak))
                ) && 
                (
                    this.Jstype == input.Jstype ||
                    (this.Jstype != null &&
                    this.Jstype.Equals(input.Jstype))
                ) && 
                (
                    this.InitializationErrorString == input.InitializationErrorString ||
                    (this.InitializationErrorString != null &&
                    this.InitializationErrorString.Equals(input.InitializationErrorString))
                ) && 
                (
                    this.DescriptorForType == input.DescriptorForType ||
                    (this.DescriptorForType != null &&
                    this.DescriptorForType.Equals(input.DescriptorForType))
                ) && 
                (
                    this.AllFields == input.AllFields ||
                    this.AllFields != null &&
                    this.AllFields.SequenceEqual(input.AllFields)
                ) && 
                (
                    this.AllFieldsRaw == input.AllFieldsRaw ||
                    this.AllFieldsRaw != null &&
                    this.AllFieldsRaw.SequenceEqual(input.AllFieldsRaw)
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
                if (this.UnknownFields != null)
                    hashCode = hashCode * 59 + this.UnknownFields.GetHashCode();
                if (this.Initialized != null)
                    hashCode = hashCode * 59 + this.Initialized.GetHashCode();
                if (this.ParserForType != null)
                    hashCode = hashCode * 59 + this.ParserForType.GetHashCode();
                if (this.DefaultInstanceForType != null)
                    hashCode = hashCode * 59 + this.DefaultInstanceForType.GetHashCode();
                if (this.SerializedSize != null)
                    hashCode = hashCode * 59 + this.SerializedSize.GetHashCode();
                if (this.Ctype != null)
                    hashCode = hashCode * 59 + this.Ctype.GetHashCode();
                if (this.Deprecated != null)
                    hashCode = hashCode * 59 + this.Deprecated.GetHashCode();
                if (this.UninterpretedOptionList != null)
                    hashCode = hashCode * 59 + this.UninterpretedOptionList.GetHashCode();
                if (this.UninterpretedOptionOrBuilderList != null)
                    hashCode = hashCode * 59 + this.UninterpretedOptionOrBuilderList.GetHashCode();
                if (this.UninterpretedOptionCount != null)
                    hashCode = hashCode * 59 + this.UninterpretedOptionCount.GetHashCode();
                if (this.Packed != null)
                    hashCode = hashCode * 59 + this.Packed.GetHashCode();
                if (this.Lazy != null)
                    hashCode = hashCode * 59 + this.Lazy.GetHashCode();
                if (this.Weak != null)
                    hashCode = hashCode * 59 + this.Weak.GetHashCode();
                if (this.Jstype != null)
                    hashCode = hashCode * 59 + this.Jstype.GetHashCode();
                if (this.InitializationErrorString != null)
                    hashCode = hashCode * 59 + this.InitializationErrorString.GetHashCode();
                if (this.DescriptorForType != null)
                    hashCode = hashCode * 59 + this.DescriptorForType.GetHashCode();
                if (this.AllFields != null)
                    hashCode = hashCode * 59 + this.AllFields.GetHashCode();
                if (this.AllFieldsRaw != null)
                    hashCode = hashCode * 59 + this.AllFieldsRaw.GetHashCode();
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
