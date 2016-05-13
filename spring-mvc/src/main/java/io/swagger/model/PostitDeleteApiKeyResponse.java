package io.swagger.model;


import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;

import java.util.Objects;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.SpringMVCServerCodegen", date = "2016-05-13T14:31:17.548-07:00")
public class PostitDeleteApiKeyResponse  {
  

  

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    PostitDeleteApiKeyResponse postitDeleteApiKeyResponse = (PostitDeleteApiKeyResponse) o;
    return true;
  }

  @Override
  public int hashCode() {
    return Objects.hash();
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class PostitDeleteApiKeyResponse {\n");
    
    sb.append("}\n");
    return sb.toString();
  }
}
