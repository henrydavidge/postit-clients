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
    public partial class PostitUpdatePostItTableResponse :  IEquatable<PostitUpdatePostItTableResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostitUpdatePostItTableResponse" /> class.
        /// </summary>
        public PostitUpdatePostItTableResponse()
        {
            
        }

        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostitUpdatePostItTableResponse {\n");
            
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
            return Equals((PostitUpdatePostItTableResponse)obj);
        }

        /// <summary>
        /// Returns true if PostitUpdatePostItTableResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PostitUpdatePostItTableResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostitUpdatePostItTableResponse other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return false;
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
                
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(PostitUpdatePostItTableResponse left, PostitUpdatePostItTableResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PostitUpdatePostItTableResponse left, PostitUpdatePostItTableResponse right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
