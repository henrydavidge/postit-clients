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
  public class PostitUpdatePostItTable {
    
    /// <summary>
    /// Gets or Sets ApiKey
    /// </summary>
    [DataMember(Name="api_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "api_key")]
    public string ApiKey { get; set; }

    
    /// <summary>
    /// Gets or Sets _Path
    /// </summary>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public string _Path { get; set; }

    
    /// <summary>
    /// Gets or Sets Schema
    /// </summary>
    [DataMember(Name="schema", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "schema")]
    public string Schema { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PostitUpdatePostItTable {\n");
      
      sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
      
      sb.Append("  _Path: ").Append(_Path).Append("\n");
      
      sb.Append("  Schema: ").Append(Schema).Append("\n");
      
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
