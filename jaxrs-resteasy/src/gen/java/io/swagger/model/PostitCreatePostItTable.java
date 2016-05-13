package io.swagger.model;

import java.util.Objects;
import java.util.ArrayList;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;




@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaResteasyServerCodegen", date = "2016-05-13T14:31:04.545-07:00")
public class PostitCreatePostItTable   {
  
  private String path = null;
  private String schema = null;
  private String shardName = null;

  
  /**
   **/
  
  @JsonProperty("path")
  public String getPath() {
    return path;
  }
  public void setPath(String path) {
    this.path = path;
  }

  
  /**
   **/
  
  @JsonProperty("schema")
  public String getSchema() {
    return schema;
  }
  public void setSchema(String schema) {
    this.schema = schema;
  }

  
  /**
   **/
  
  @JsonProperty("shard_name")
  public String getShardName() {
    return shardName;
  }
  public void setShardName(String shardName) {
    this.shardName = shardName;
  }

  

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    PostitCreatePostItTable postitCreatePostItTable = (PostitCreatePostItTable) o;
    return Objects.equals(path, postitCreatePostItTable.path) &&
        Objects.equals(schema, postitCreatePostItTable.schema) &&
        Objects.equals(shardName, postitCreatePostItTable.shardName);
  }

  @Override
  public int hashCode() {
    return Objects.hash(path, schema, shardName);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class PostitCreatePostItTable {\n");
    
    sb.append("    path: ").append(toIndentedString(path)).append("\n");
    sb.append("    schema: ").append(toIndentedString(schema)).append("\n");
    sb.append("    shardName: ").append(toIndentedString(shardName)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }
}

