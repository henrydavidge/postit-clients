using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PostitPostIt {
    
    /// <summary>
    /// Gets or Sets ApiKey
    /// </summary>
    [DataMember(Name="api_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "api_key")]
    public string ApiKey { get; set; }

    
    /// <summary>
    /// Gets or Sets EventTime
    /// </summary>
    [DataMember(Name="event_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event_time")]
    public long? EventTime { get; set; }

    
    /// <summary>
    /// Gets or Sets Payload
    /// </summary>
    [DataMember(Name="payload", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payload")]
    public string Payload { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PostitPostIt {\n");
      
      sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
      
      sb.Append("  EventTime: ").Append(EventTime).Append("\n");
      
      sb.Append("  Payload: ").Append(Payload).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
