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
    public partial class PostitCreatePostItTable :  IEquatable<PostitCreatePostItTable>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostitCreatePostItTable" /> class.
        /// </summary>
        /// <param name="Path">Path.</param>
        /// <param name="Schema">Schema.</param>
        /// <param name="ShardName">ShardName.</param>
        public PostitCreatePostItTable(string Path = null, string Schema = null, string ShardName = null)
        {
            this.Path = Path;
            this.Schema = Schema;
            this.ShardName = ShardName;
            
        }

        
        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        public string Path { get; set; }

        
        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        public string Schema { get; set; }

        
        /// <summary>
        /// Gets or Sets ShardName
        /// </summary>
        public string ShardName { get; set; }

        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostitCreatePostItTable {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  ShardName: ").Append(ShardName).Append("\n");
            
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
            return Equals((PostitCreatePostItTable)obj);
        }

        /// <summary>
        /// Returns true if PostitCreatePostItTable instances are equal
        /// </summary>
        /// <param name="other">Instance of PostitCreatePostItTable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostitCreatePostItTable other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Path == other.Path ||
                    this.Path != null &&
                    this.Path.Equals(other.Path)
                ) && 
                (
                    this.Schema == other.Schema ||
                    this.Schema != null &&
                    this.Schema.Equals(other.Schema)
                ) && 
                (
                    this.ShardName == other.ShardName ||
                    this.ShardName != null &&
                    this.ShardName.Equals(other.ShardName)
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
                
                    if (this.Path != null)
                    hash = hash * 59 + this.Path.GetHashCode();
                
                    if (this.Schema != null)
                    hash = hash * 59 + this.Schema.GetHashCode();
                
                    if (this.ShardName != null)
                    hash = hash * 59 + this.ShardName.GetHashCode();
                
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(PostitCreatePostItTable left, PostitCreatePostItTable right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PostitCreatePostItTable left, PostitCreatePostItTable right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
