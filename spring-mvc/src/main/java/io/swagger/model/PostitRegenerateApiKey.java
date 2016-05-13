package io.swagger.model;

import com.fasterxml.jackson.annotation.JsonProperty;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;

import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;

import java.util.Objects;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.SpringMVCServerCodegen", date = "2016-05-13T14:31:17.548-07:00")
public class PostitRegenerateApiKey  {
  
  private String apiKey = null;

  
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

  

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    PostitRegenerateApiKey postitRegenerateApiKey = (PostitRegenerateApiKey) o;
    return Objects.equals(apiKey, postitRegenerateApiKey.apiKey);
  }

  @Override
  public int hashCode() {
    return Objects.hash(apiKey);
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class PostitRegenerateApiKey {\n");
    
    sb.append("  apiKey: ").append(apiKey).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}
