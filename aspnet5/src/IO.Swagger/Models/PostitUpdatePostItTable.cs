using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class PostitUpdatePostItTable :  IEquatable<PostitUpdatePostItTable>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostitUpdatePostItTable" /> class.
        /// </summary>
        /// <param name="ApiKey">ApiKey.</param>
        /// <param name="Path">Path.</param>
        /// <param name="Schema">Schema.</param>
        public PostitUpdatePostItTable(string ApiKey = null, string Path = null, string Schema = null)
        {
            this.ApiKey = ApiKey;
            this.Path = Path;
            this.Schema = Schema;
            
        }

        
        /// <summary>
        /// Gets or Sets ApiKey
        /// </summary>
        public string ApiKey { get; set; }

        
        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        public string Path { get; set; }

        
        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        public string Schema { get; set; }

        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostitUpdatePostItTable {\n");
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((PostitUpdatePostItTable)obj);
        }

        /// <summary>
        /// Returns true if PostitUpdatePostItTable instances are equal
        /// </summary>
        /// <param name="other">Instance of PostitUpdatePostItTable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostitUpdatePostItTable other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.ApiKey == other.ApiKey ||
                    this.ApiKey != null &&
                    this.ApiKey.Equals(other.ApiKey)
                ) && 
                (
                    this.Path == other.Path ||
                    this.Path != null &&
                    this.Path.Equals(other.Path)
                ) && 
                (
                    this.Schema == other.Schema ||
                    this.Schema != null &&
                    this.Schema.Equals(other.Schema)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                    if (this.ApiKey != null)
                    hash = hash * 59 + this.ApiKey.GetHashCode();
                
                    if (this.Path != null)
                    hash = hash * 59 + this.Path.GetHashCode();
                
                    if (this.Schema != null)
                    hash = hash * 59 + this.Schema.GetHashCode();
                
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(PostitUpdatePostItTable left, PostitUpdatePostItTable right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PostitUpdatePostItTable left, PostitUpdatePostItTable right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
