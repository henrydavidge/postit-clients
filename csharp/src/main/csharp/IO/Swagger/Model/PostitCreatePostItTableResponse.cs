using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IO.Swagger.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class PostitCreatePostItTableResponse :  IEquatable<PostitCreatePostItTableResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PostitCreatePostItTableResponse" /> class.
        /// Initializes a new instance of the <see cref="PostitCreatePostItTableResponse" />class.
        /// </summary>
        /// <param name="ApiKey">ApiKey.</param>

        public PostitCreatePostItTableResponse(string ApiKey = null)
        {
            this.ApiKey = ApiKey;
            
        }
        
    
        /// <summary>
        /// Gets or Sets ApiKey
        /// </summary>
        [DataMember(Name="api_key", EmitDefaultValue=false)]
        public string ApiKey { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostitCreatePostItTableResponse {\n");
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
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as PostitCreatePostItTableResponse);
        }

        /// <summary>
        /// Returns true if PostitCreatePostItTableResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PostitCreatePostItTableResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostitCreatePostItTableResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

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

    }
}
