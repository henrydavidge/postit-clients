package io.swagger.model;

import com.fasterxml.jackson.annotation.JsonProperty;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;

import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;

import java.util.Objects;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.SpringMVCServerCodegen", date = "2016-05-13T14:31:17.548-07:00")
public class PostitPostIt  {
  
  private String apiKey = null;
  private Long eventTime = null;
  private String payload = null;

  
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
  @JsonProperty("event_time")
  public Long getEventTime() {
    return eventTime;
  }
  public void setEventTime(Long eventTime) {
    this.eventTime = eventTime;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("payload")
  public String getPayload() {
    return payload;
  }
  public void setPayload(String payload) {
    this.payload = payload;
  }

  

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    PostitPostIt postitPostIt = (PostitPostIt) o;
    return Objects.equals(apiKey, postitPostIt.apiKey) &&
        Objects.equals(eventTime, postitPostIt.eventTime) &&
        Objects.equals(payload, postitPostIt.payload);
  }

  @Override
  public int hashCode() {
    return Objects.hash(apiKey, eventTime, payload);
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class PostitPostIt {\n");
    
    sb.append("  apiKey: ").append(apiKey).append("\n");
    sb.append("  eventTime: ").append(eventTime).append("\n");
    sb.append("  payload: ").append(payload).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}
