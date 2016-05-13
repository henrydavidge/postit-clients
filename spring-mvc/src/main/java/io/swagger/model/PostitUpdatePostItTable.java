package io.swagger.model;

import com.fasterxml.jackson.annotation.JsonProperty;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;

import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;

import java.util.Objects;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.SpringMVCServerCodegen", date = "2016-05-13T14:31:17.548-07:00")
public class PostitUpdatePostItTable  {
  
  private String apiKey = null;
  private String path = null;
  private String schema = null;

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("api_key")
  public String getApiKey() {
    return apiKey;
  }
  public void setApiKey(String apiKey) {
    this.apiKey = apiKey;
  }

  
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

  

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    PostitUpdatePostItTable postitUpdatePostItTable = (PostitUpdatePostItTable) o;
    return Objects.equals(apiKey, postitUpdatePostItTable.apiKey) &&
        Objects.equals(path, postitUpdatePostItTable.path) &&
        Objects.equals(schema, postitUpdatePostItTable.schema);
  }

  @Override
  public int hashCode() {
    return Objects.hash(apiKey, path, schema);
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class PostitUpdatePostItTable {\n");
    
    sb.append("  apiKey: ").append(apiKey).append("\n");
    sb.append("  path: ").append(path).append("\n");
    sb.append("  schema: ").append(schema).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}
