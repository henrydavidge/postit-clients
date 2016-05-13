package io.swagger.model;

import com.fasterxml.jackson.annotation.JsonProperty;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;

import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;

import java.util.Objects;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.SpringMVCServerCodegen", date = "2016-05-13T14:31:17.548-07:00")
public class PostitCreatePostItTable  {
  
  private String path = null;
  private String schema = null;
  private String shardName = null;

  
  /**
   **/
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
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class PostitCreatePostItTable {\n");
    
    sb.append("  path: ").append(path).append("\n");
    sb.append("  schema: ").append(schema).append("\n");
    sb.append("  shardName: ").append(shardName).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}
