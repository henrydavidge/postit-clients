package io.swagger.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaInflectorServerCodegen", date = "2016-05-13T14:31:05.332-07:00")
public class PostitUpdatePostItTable   {
  
  private String apiKey = null;
  private String path = null;
  private String schema = null;

  
  /**
   **/
  public PostitUpdatePostItTable apiKey(String apiKey) {
    this.apiKey = apiKey;
    return this;
  }

  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("api_key")
  public String getApiKey() {
    return apiKey;
  }
  public void setApiKey(String apiKey) {
    this.apiKey = apiKey;
  }

  
  /**
   **/
  public PostitUpdatePostItTable path(String path) {
    this.path = path;
    return this;
  }

  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("path")
  public String getPath() {
    return path;
  }
  public void setPath(String path) {
    this.path = path;
  }

  
  /**
   **/
  public PostitUpdatePostItTable schema(String schema) {
    this.schema = schema;
    return this;
  }

  
  @ApiModelProperty(example = "null", value = "")
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
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class PostitUpdatePostItTable {\n");
    
    sb.append("    apiKey: ").append(toIndentedString(apiKey)).append("\n");
    sb.append("    path: ").append(toIndentedString(path)).append("\n");
    sb.append("    schema: ").append(toIndentedString(schema)).append("\n");
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

