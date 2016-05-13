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
  public class PostitCreatePostItTable {
    
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
    /// Gets or Sets ShardName
    /// </summary>
    [DataMember(Name="shard_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shard_name")]
    public string ShardName { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PostitCreatePostItTable {\n");
      
      sb.Append("  _Path: ").Append(_Path).Append("\n");
      
      sb.Append("  Schema: ").Append(Schema).Append("\n");
      
      sb.Append("  ShardName: ").Append(ShardName).Append("\n");
      
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
