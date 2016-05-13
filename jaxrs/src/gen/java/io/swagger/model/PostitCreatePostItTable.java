package io.swagger.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaJerseyServerCodegen", date = "2016-05-13T14:30:58.824-07:00")
public class PostitCreatePostItTable   {
  
  private String path = null;
  private String schema = null;
  private String shardName = null;

  
  /**
   **/
  public PostitCreatePostItTable path(String path) {
    this.path = path;
    return this;
  }

  
  @ApiModelProperty(value = "")
  @JsonProperty("path")
  public String getPath() {
    return path;
  }
  public void setPath(String path) {
    this.path = path;
  }

  
  /**
   **/
  public PostitCreatePostItTable schema(String schema) {
    this.schema = schema;
    return this;
  }

  
  @ApiModelProperty(value = "")
  @JsonProperty("schema")
  public String getSchema() {
    return schema;
  }
  public void setSchema(String schema) {
    this.schema = schema;
  }

  
  /**
   **/
  public PostitCreatePostItTable shardName(String shardName) {
    this.shardName = shardName;
    return this;
  }

  
  @ApiModelProperty(value = "")
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

