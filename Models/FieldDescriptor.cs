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
    /// FieldDescriptor
    /// </summary>
    [DataContract]
    public partial class FieldDescriptor :  IEquatable<FieldDescriptor>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum DOUBLE for value: DOUBLE
            /// </summary>
            [EnumMember(Value = "DOUBLE")]
            DOUBLE = 1,
            
            /// <summary>
            /// Enum FLOAT for value: FLOAT
            /// </summary>
            [EnumMember(Value = "FLOAT")]
            FLOAT = 2,
            
            /// <summary>
            /// Enum INT64 for value: INT64
            /// </summary>
            [EnumMember(Value = "INT64")]
            INT64 = 3,
            
            /// <summary>
            /// Enum UINT64 for value: UINT64
            /// </summary>
            [EnumMember(Value = "UINT64")]
            UINT64 = 4,
            
            /// <summary>
            /// Enum INT32 for value: INT32
            /// </summary>
            [EnumMember(Value = "INT32")]
            INT32 = 5,
            
            /// <summary>
            /// Enum FIXED64 for value: FIXED64
            /// </summary>
            [EnumMember(Value = "FIXED64")]
            FIXED64 = 6,
            
            /// <summary>
            /// Enum FIXED32 for value: FIXED32
            /// </summary>
            [EnumMember(Value = "FIXED32")]
            FIXED32 = 7,
            
            /// <summary>
            /// Enum BOOL for value: BOOL
            /// </summary>
            [EnumMember(Value = "BOOL")]
            BOOL = 8,
            
            /// <summary>
            /// Enum STRING for value: STRING
            /// </summary>
            [EnumMember(Value = "STRING")]
            STRING = 9,
            
            /// <summary>
            /// Enum GROUP for value: GROUP
            /// </summary>
            [EnumMember(Value = "GROUP")]
            GROUP = 10,
            
            /// <summary>
            /// Enum MESSAGE for value: MESSAGE
            /// </summary>
            [EnumMember(Value = "MESSAGE")]
            MESSAGE = 11,
            
            /// <summary>
            /// Enum BYTES for value: BYTES
            /// </summary>
            [EnumMember(Value = "BYTES")]
            BYTES = 12,
            
            /// <summary>
            /// Enum UINT32 for value: UINT32
            /// </summary>
            [EnumMember(Value = "UINT32")]
            UINT32 = 13,
            
            /// <summary>
            /// Enum ENUM for value: ENUM
            /// </summary>
            [EnumMember(Value = "ENUM")]
            ENUM = 14,
            
            /// <summary>
            /// Enum SFIXED32 for value: SFIXED32
            /// </summary>
            [EnumMember(Value = "SFIXED32")]
            SFIXED32 = 15,
            
            /// <summary>
            /// Enum SFIXED64 for value: SFIXED64
            /// </summary>
            [EnumMember(Value = "SFIXED64")]
            SFIXED64 = 16,
            
            /// <summary>
            /// Enum SINT32 for value: SINT32
            /// </summary>
            [EnumMember(Value = "SINT32")]
            SINT32 = 17,
            
            /// <summary>
            /// Enum SINT64 for value: SINT64
            /// </summary>
            [EnumMember(Value = "SINT64")]
            SINT64 = 18
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Defines LiteType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LiteTypeEnum
        {
            
            /// <summary>
            /// Enum DOUBLE for value: DOUBLE
            /// </summary>
            [EnumMember(Value = "DOUBLE")]
            DOUBLE = 1,
            
            /// <summary>
            /// Enum FLOAT for value: FLOAT
            /// </summary>
            [EnumMember(Value = "FLOAT")]
            FLOAT = 2,
            
            /// <summary>
            /// Enum INT64 for value: INT64
            /// </summary>
            [EnumMember(Value = "INT64")]
            INT64 = 3,
            
            /// <summary>
            /// Enum UINT64 for value: UINT64
            /// </summary>
            [EnumMember(Value = "UINT64")]
            UINT64 = 4,
            
            /// <summary>
            /// Enum INT32 for value: INT32
            /// </summary>
            [EnumMember(Value = "INT32")]
            INT32 = 5,
            
            /// <summary>
            /// Enum FIXED64 for value: FIXED64
            /// </summary>
            [EnumMember(Value = "FIXED64")]
            FIXED64 = 6,
            
            /// <summary>
            /// Enum FIXED32 for value: FIXED32
            /// </summary>
            [EnumMember(Value = "FIXED32")]
            FIXED32 = 7,
            
            /// <summary>
            /// Enum BOOL for value: BOOL
            /// </summary>
            [EnumMember(Value = "BOOL")]
            BOOL = 8,
            
            /// <summary>
            /// Enum STRING for value: STRING
            /// </summary>
            [EnumMember(Value = "STRING")]
            STRING = 9,
            
            /// <summary>
            /// Enum GROUP for value: GROUP
            /// </summary>
            [EnumMember(Value = "GROUP")]
            GROUP = 10,
            
            /// <summary>
            /// Enum MESSAGE for value: MESSAGE
            /// </summary>
            [EnumMember(Value = "MESSAGE")]
            MESSAGE = 11,
            
            /// <summary>
            /// Enum BYTES for value: BYTES
            /// </summary>
            [EnumMember(Value = "BYTES")]
            BYTES = 12,
            
            /// <summary>
            /// Enum UINT32 for value: UINT32
            /// </summary>
            [EnumMember(Value = "UINT32")]
            UINT32 = 13,
            
            /// <summary>
            /// Enum ENUM for value: ENUM
            /// </summary>
            [EnumMember(Value = "ENUM")]
            ENUM = 14,
            
            /// <summary>
            /// Enum SFIXED32 for value: SFIXED32
            /// </summary>
            [EnumMember(Value = "SFIXED32")]
            SFIXED32 = 15,
            
            /// <summary>
            /// Enum SFIXED64 for value: SFIXED64
            /// </summary>
            [EnumMember(Value = "SFIXED64")]
            SFIXED64 = 16,
            
            /// <summary>
            /// Enum SINT32 for value: SINT32
            /// </summary>
            [EnumMember(Value = "SINT32")]
            SINT32 = 17,
            
            /// <summary>
            /// Enum SINT64 for value: SINT64
            /// </summary>
            [EnumMember(Value = "SINT64")]
            SINT64 = 18
        }

        /// <summary>
        /// Gets or Sets LiteType
        /// </summary>
        [DataMember(Name="liteType", EmitDefaultValue=false)]
        public LiteTypeEnum? LiteType { get; set; }
        /// <summary>
        /// Defines JavaType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum JavaTypeEnum
        {
            
            /// <summary>
            /// Enum INT for value: INT
            /// </summary>
            [EnumMember(Value = "INT")]
            INT = 1,
            
            /// <summary>
            /// Enum LONG for value: LONG
            /// </summary>
            [EnumMember(Value = "LONG")]
            LONG = 2,
            
            /// <summary>
            /// Enum FLOAT for value: FLOAT
            /// </summary>
            [EnumMember(Value = "FLOAT")]
            FLOAT = 3,
            
            /// <summary>
            /// Enum DOUBLE for value: DOUBLE
            /// </summary>
            [EnumMember(Value = "DOUBLE")]
            DOUBLE = 4,
            
            /// <summary>
            /// Enum BOOLEAN for value: BOOLEAN
            /// </summary>
            [EnumMember(Value = "BOOLEAN")]
            BOOLEAN = 5,
            
            /// <summary>
            /// Enum STRING for value: STRING
            /// </summary>
            [EnumMember(Value = "STRING")]
            STRING = 6,
            
            /// <summary>
            /// Enum BYTESTRING for value: BYTE_STRING
            /// </summary>
            [EnumMember(Value = "BYTE_STRING")]
            BYTESTRING = 7,
            
            /// <summary>
            /// Enum ENUM for value: ENUM
            /// </summary>
            [EnumMember(Value = "ENUM")]
            ENUM = 8,
            
            /// <summary>
            /// Enum MESSAGE for value: MESSAGE
            /// </summary>
            [EnumMember(Value = "MESSAGE")]
            MESSAGE = 9
        }

        /// <summary>
        /// Gets or Sets JavaType
        /// </summary>
        [DataMember(Name="javaType", EmitDefaultValue=false)]
        public JavaTypeEnum? JavaType { get; set; }
        /// <summary>
        /// Defines LiteJavaType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LiteJavaTypeEnum
        {
            
            /// <summary>
            /// Enum INT for value: INT
            /// </summary>
            [EnumMember(Value = "INT")]
            INT = 1,
            
            /// <summary>
            /// Enum LONG for value: LONG
            /// </summary>
            [EnumMember(Value = "LONG")]
            LONG = 2,
            
            /// <summary>
            /// Enum FLOAT for value: FLOAT
            /// </summary>
            [EnumMember(Value = "FLOAT")]
            FLOAT = 3,
            
            /// <summary>
            /// Enum DOUBLE for value: DOUBLE
            /// </summary>
            [EnumMember(Value = "DOUBLE")]
            DOUBLE = 4,
            
            /// <summary>
            /// Enum BOOLEAN for value: BOOLEAN
            /// </summary>
            [EnumMember(Value = "BOOLEAN")]
            BOOLEAN = 5,
            
            /// <summary>
            /// Enum STRING for value: STRING
            /// </summary>
            [EnumMember(Value = "STRING")]
            STRING = 6,
            
            /// <summary>
            /// Enum BYTESTRING for value: BYTE_STRING
            /// </summary>
            [EnumMember(Value = "BYTE_STRING")]
            BYTESTRING = 7,
            
            /// <summary>
            /// Enum ENUM for value: ENUM
            /// </summary>
            [EnumMember(Value = "ENUM")]
            ENUM = 8,
            
            /// <summary>
            /// Enum MESSAGE for value: MESSAGE
            /// </summary>
            [EnumMember(Value = "MESSAGE")]
            MESSAGE = 9
        }

        /// <summary>
        /// Gets or Sets LiteJavaType
        /// </summary>
        [DataMember(Name="liteJavaType", EmitDefaultValue=false)]
        public LiteJavaTypeEnum? LiteJavaType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldDescriptor" /> class.
        /// </summary>
        /// <param name="index">index.</param>
        /// <param name="fullName">fullName.</param>
        /// <param name="jsonName">jsonName.</param>
        /// <param name="_file">_file.</param>
        /// <param name="extensionScope">extensionScope.</param>
        /// <param name="type">type.</param>
        /// <param name="containingType">containingType.</param>
        /// <param name="messageType">messageType.</param>
        /// <param name="containingOneof">containingOneof.</param>
        /// <param name="enumType">enumType.</param>
        /// <param name="defaultValue">defaultValue.</param>
        /// <param name="options">options.</param>
        /// <param name="optional">optional (default to false).</param>
        /// <param name="packed">packed (default to false).</param>
        /// <param name="required">required (default to false).</param>
        /// <param name="liteType">liteType.</param>
        /// <param name="extension">extension (default to false).</param>
        /// <param name="repeated">repeated (default to false).</param>
        /// <param name="javaType">javaType.</param>
        /// <param name="mapField">mapField (default to false).</param>
        /// <param name="liteJavaType">liteJavaType.</param>
        /// <param name="packable">packable (default to false).</param>
        /// <param name="name">name.</param>
        /// <param name="number">number.</param>
        public FieldDescriptor(int? index = default(int?), string fullName = default(string), string jsonName = default(string), FileDescriptor _file = default(FileDescriptor), Descriptor extensionScope = default(Descriptor), TypeEnum? type = default(TypeEnum?), Descriptor containingType = default(Descriptor), Descriptor messageType = default(Descriptor), OneofDescriptor containingOneof = default(OneofDescriptor), EnumDescriptor enumType = default(EnumDescriptor), Object defaultValue = default(Object), FieldOptions options = default(FieldOptions), bool? optional = false, bool? packed = false, bool? required = false, LiteTypeEnum? liteType = default(LiteTypeEnum?), bool? extension = false, bool? repeated = false, JavaTypeEnum? javaType = default(JavaTypeEnum?), bool? mapField = false, LiteJavaTypeEnum? liteJavaType = default(LiteJavaTypeEnum?), bool? packable = false, string name = default(string), int? number = default(int?))
        {
            this.Index = index;
            this.FullName = fullName;
            this.JsonName = jsonName;
            this._File = _file;
            this.ExtensionScope = extensionScope;
            this.Type = type;
            this.ContainingType = containingType;
            this.MessageType = messageType;
            this.ContainingOneof = containingOneof;
            this.EnumType = enumType;
            this.DefaultValue = defaultValue;
            this.Options = options;
            // use default value if no "optional" provided
            if (optional == null)
            {
                this.Optional = false;
            }
            else
            {
                this.Optional = optional;
            }
            // use default value if no "packed" provided
            if (packed == null)
            {
                this.Packed = false;
            }
            else
            {
                this.Packed = packed;
            }
            // use default value if no "required" provided
            if (required == null)
            {
                this.Required = false;
            }
            else
            {
                this.Required = required;
            }
            this.LiteType = liteType;
            // use default value if no "extension" provided
            if (extension == null)
            {
                this.Extension = false;
            }
            else
            {
                this.Extension = extension;
            }
            // use default value if no "repeated" provided
            if (repeated == null)
            {
                this.Repeated = false;
            }
            else
            {
                this.Repeated = repeated;
            }
            this.JavaType = javaType;
            // use default value if no "mapField" provided
            if (mapField == null)
            {
                this.MapField = false;
            }
            else
            {
                this.MapField = mapField;
            }
            this.LiteJavaType = liteJavaType;
            // use default value if no "packable" provided
            if (packable == null)
            {
                this.Packable = false;
            }
            else
            {
                this.Packable = packable;
            }
            this.Name = name;
            this.Number = number;
        }
        
        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name="index", EmitDefaultValue=false)]
        public int? Index { get; set; }

        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name="fullName", EmitDefaultValue=false)]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or Sets JsonName
        /// </summary>
        [DataMember(Name="jsonName", EmitDefaultValue=false)]
        public string JsonName { get; set; }

        /// <summary>
        /// Gets or Sets _File
        /// </summary>
        [DataMember(Name="file", EmitDefaultValue=false)]
        public FileDescriptor _File { get; set; }

        /// <summary>
        /// Gets or Sets ExtensionScope
        /// </summary>
        [DataMember(Name="extensionScope", EmitDefaultValue=false)]
        public Descriptor ExtensionScope { get; set; }


        /// <summary>
        /// Gets or Sets ContainingType
        /// </summary>
        [DataMember(Name="containingType", EmitDefaultValue=false)]
        public Descriptor ContainingType { get; set; }

        /// <summary>
        /// Gets or Sets MessageType
        /// </summary>
        [DataMember(Name="messageType", EmitDefaultValue=false)]
        public Descriptor MessageType { get; set; }

        /// <summary>
        /// Gets or Sets ContainingOneof
        /// </summary>
        [DataMember(Name="containingOneof", EmitDefaultValue=false)]
        public OneofDescriptor ContainingOneof { get; set; }

        /// <summary>
        /// Gets or Sets EnumType
        /// </summary>
        [DataMember(Name="enumType", EmitDefaultValue=false)]
        public EnumDescriptor EnumType { get; set; }

        /// <summary>
        /// Gets or Sets DefaultValue
        /// </summary>
        [DataMember(Name="defaultValue", EmitDefaultValue=false)]
        public Object DefaultValue { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public FieldOptions Options { get; set; }

        /// <summary>
        /// Gets or Sets Optional
        /// </summary>
        [DataMember(Name="optional", EmitDefaultValue=false)]
        public bool? Optional { get; set; }

        /// <summary>
        /// Gets or Sets Packed
        /// </summary>
        [DataMember(Name="packed", EmitDefaultValue=false)]
        public bool? Packed { get; set; }

        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; set; }


        /// <summary>
        /// Gets or Sets Extension
        /// </summary>
        [DataMember(Name="extension", EmitDefaultValue=false)]
        public bool? Extension { get; set; }

        /// <summary>
        /// Gets or Sets Repeated
        /// </summary>
        [DataMember(Name="repeated", EmitDefaultValue=false)]
        public bool? Repeated { get; set; }


        /// <summary>
        /// Gets or Sets MapField
        /// </summary>
        [DataMember(Name="mapField", EmitDefaultValue=false)]
        public bool? MapField { get; set; }


        /// <summary>
        /// Gets or Sets Packable
        /// </summary>
        [DataMember(Name="packable", EmitDefaultValue=false)]
        public bool? Packable { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public int? Number { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldDescriptor {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  JsonName: ").Append(JsonName).Append("\n");
            sb.Append("  _File: ").Append(_File).Append("\n");
            sb.Append("  ExtensionScope: ").Append(ExtensionScope).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ContainingType: ").Append(ContainingType).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  ContainingOneof: ").Append(ContainingOneof).Append("\n");
            sb.Append("  EnumType: ").Append(EnumType).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Optional: ").Append(Optional).Append("\n");
            sb.Append("  Packed: ").Append(Packed).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  LiteType: ").Append(LiteType).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  Repeated: ").Append(Repeated).Append("\n");
            sb.Append("  JavaType: ").Append(JavaType).Append("\n");
            sb.Append("  MapField: ").Append(MapField).Append("\n");
            sb.Append("  LiteJavaType: ").Append(LiteJavaType).Append("\n");
            sb.Append("  Packable: ").Append(Packable).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
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
            return this.Equals(input as FieldDescriptor);
        }

        /// <summary>
        /// Returns true if FieldDescriptor instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldDescriptor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldDescriptor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
                ) && 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this.JsonName == input.JsonName ||
                    (this.JsonName != null &&
                    this.JsonName.Equals(input.JsonName))
                ) && 
                (
                    this._File == input._File ||
                    (this._File != null &&
                    this._File.Equals(input._File))
                ) && 
                (
                    this.ExtensionScope == input.ExtensionScope ||
                    (this.ExtensionScope != null &&
                    this.ExtensionScope.Equals(input.ExtensionScope))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ContainingType == input.ContainingType ||
                    (this.ContainingType != null &&
                    this.ContainingType.Equals(input.ContainingType))
                ) && 
                (
                    this.MessageType == input.MessageType ||
                    (this.MessageType != null &&
                    this.MessageType.Equals(input.MessageType))
                ) && 
                (
                    this.ContainingOneof == input.ContainingOneof ||
                    (this.ContainingOneof != null &&
                    this.ContainingOneof.Equals(input.ContainingOneof))
                ) && 
                (
                    this.EnumType == input.EnumType ||
                    (this.EnumType != null &&
                    this.EnumType.Equals(input.EnumType))
                ) && 
                (
                    this.DefaultValue == input.DefaultValue ||
                    (this.DefaultValue != null &&
                    this.DefaultValue.Equals(input.DefaultValue))
                ) && 
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))
                ) && 
                (
                    this.Optional == input.Optional ||
                    (this.Optional != null &&
                    this.Optional.Equals(input.Optional))
                ) && 
                (
                    this.Packed == input.Packed ||
                    (this.Packed != null &&
                    this.Packed.Equals(input.Packed))
                ) && 
                (
                    this.Required == input.Required ||
                    (this.Required != null &&
                    this.Required.Equals(input.Required))
                ) && 
                (
                    this.LiteType == input.LiteType ||
                    (this.LiteType != null &&
                    this.LiteType.Equals(input.LiteType))
                ) && 
                (
                    this.Extension == input.Extension ||
                    (this.Extension != null &&
                    this.Extension.Equals(input.Extension))
                ) && 
                (
                    this.Repeated == input.Repeated ||
                    (this.Repeated != null &&
                    this.Repeated.Equals(input.Repeated))
                ) && 
                (
                    this.JavaType == input.JavaType ||
                    (this.JavaType != null &&
                    this.JavaType.Equals(input.JavaType))
                ) && 
                (
                    this.MapField == input.MapField ||
                    (this.MapField != null &&
                    this.MapField.Equals(input.MapField))
                ) && 
                (
                    this.LiteJavaType == input.LiteJavaType ||
                    (this.LiteJavaType != null &&
                    this.LiteJavaType.Equals(input.LiteJavaType))
                ) && 
                (
                    this.Packable == input.Packable ||
                    (this.Packable != null &&
                    this.Packable.Equals(input.Packable))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
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
                if (this.Index != null)
                    hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.FullName != null)
                    hashCode = hashCode * 59 + this.FullName.GetHashCode();
                if (this.JsonName != null)
                    hashCode = hashCode * 59 + this.JsonName.GetHashCode();
                if (this._File != null)
                    hashCode = hashCode * 59 + this._File.GetHashCode();
                if (this.ExtensionScope != null)
                    hashCode = hashCode * 59 + this.ExtensionScope.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ContainingType != null)
                    hashCode = hashCode * 59 + this.ContainingType.GetHashCode();
                if (this.MessageType != null)
                    hashCode = hashCode * 59 + this.MessageType.GetHashCode();
                if (this.ContainingOneof != null)
                    hashCode = hashCode * 59 + this.ContainingOneof.GetHashCode();
                if (this.EnumType != null)
                    hashCode = hashCode * 59 + this.EnumType.GetHashCode();
                if (this.DefaultValue != null)
                    hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.Optional != null)
                    hashCode = hashCode * 59 + this.Optional.GetHashCode();
                if (this.Packed != null)
                    hashCode = hashCode * 59 + this.Packed.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.LiteType != null)
                    hashCode = hashCode * 59 + this.LiteType.GetHashCode();
                if (this.Extension != null)
                    hashCode = hashCode * 59 + this.Extension.GetHashCode();
                if (this.Repeated != null)
                    hashCode = hashCode * 59 + this.Repeated.GetHashCode();
                if (this.JavaType != null)
                    hashCode = hashCode * 59 + this.JavaType.GetHashCode();
                if (this.MapField != null)
                    hashCode = hashCode * 59 + this.MapField.GetHashCode();
                if (this.LiteJavaType != null)
                    hashCode = hashCode * 59 + this.LiteJavaType.GetHashCode();
                if (this.Packable != null)
                    hashCode = hashCode * 59 + this.Packable.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
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
