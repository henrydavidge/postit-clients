package io.swagger.model;

import java.util.Objects;
import java.util.ArrayList;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;




@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaResteasyServerCodegen", date = "2016-05-13T14:31:04.545-07:00")
public class PostitUpdatePostItTable   {
  
  private String apiKey = null;
  private String path = null;
  private String schema = null;

  
  /**
   **/
  
  @JsonProperty("api_key")
  public String getApiKey() {
    return apiKey;
  }
  public void setApiKey(String apiKey) {
    this.apiKey = apiKey;
  }

  
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

