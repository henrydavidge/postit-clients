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
    public partial class PostitRegenerateApiKeyResponse :  IEquatable<PostitRegenerateApiKeyResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostitRegenerateApiKeyResponse" /> class.
        /// </summary>
        /// <param name="ApiKey">ApiKey.</param>
        public PostitRegenerateApiKeyResponse(string ApiKey = null)
        {
            this.ApiKey = ApiKey;
            
        }

        
        /// <summary>
        /// Gets or Sets ApiKey
        /// </summary>
        public string ApiKey { get; set; }

        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostitRegenerateApiKeyResponse {\n");
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
            
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
            return Equals((PostitRegenerateApiKeyResponse)obj);
        }

        /// <summary>
        /// Returns true if PostitRegenerateApiKeyResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PostitRegenerateApiKeyResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostitRegenerateApiKeyResponse other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.ApiKey == other.ApiKey ||
                    this.ApiKey != null &&
                    this.ApiKey.Equals(other.ApiKey)
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
                
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(PostitRegenerateApiKeyResponse left, PostitRegenerateApiKeyResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PostitRegenerateApiKeyResponse left, PostitRegenerateApiKeyResponse right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
