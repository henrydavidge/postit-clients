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
    public partial class PostitPostIt :  IEquatable<PostitPostIt>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PostitPostIt" /> class.
        /// Initializes a new instance of the <see cref="PostitPostIt" />class.
        /// </summary>
        /// <param name="ApiKey">ApiKey.</param>
        /// <param name="EventTime">EventTime.</param>
        /// <param name="Payload">Payload.</param>

        public PostitPostIt(string ApiKey = null, long? EventTime = null, string Payload = null)
        {
            this.ApiKey = ApiKey;
            this.EventTime = EventTime;
            this.Payload = Payload;
            
        }
        
    
        /// <summary>
        /// Gets or Sets ApiKey
        /// </summary>
        [DataMember(Name="api_key", EmitDefaultValue=false)]
        public string ApiKey { get; set; }
    
        /// <summary>
        /// Gets or Sets EventTime
        /// </summary>
        [DataMember(Name="event_time", EmitDefaultValue=false)]
        public long? EventTime { get; set; }
    
        /// <summary>
        /// Gets or Sets Payload
        /// </summary>
        [DataMember(Name="payload", EmitDefaultValue=false)]
        public string Payload { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostitPostIt {\n");
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
            sb.Append("  EventTime: ").Append(EventTime).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            
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
            return this.Equals(obj as PostitPostIt);
        }

        /// <summary>
        /// Returns true if PostitPostIt instances are equal
        /// </summary>
        /// <param name="other">Instance of PostitPostIt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostitPostIt other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ApiKey == other.ApiKey ||
                    this.ApiKey != null &&
                    this.ApiKey.Equals(other.ApiKey)
                ) && 
                (
                    this.EventTime == other.EventTime ||
                    this.EventTime != null &&
                    this.EventTime.Equals(other.EventTime)
                ) && 
                (
                    this.Payload == other.Payload ||
                    this.Payload != null &&
                    this.Payload.Equals(other.Payload)
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
                
                if (this.EventTime != null)
                    hash = hash * 59 + this.EventTime.GetHashCode();
                
                if (this.Payload != null)
                    hash = hash * 59 + this.Payload.GetHashCode();
                
                return hash;
            }
        }

    }
}
