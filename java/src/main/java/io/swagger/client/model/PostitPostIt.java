package io.swagger.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-13T14:30:58.052-07:00")
public class PostitPostIt   {
  
  private String apiKey = null;
  private Long eventTime = null;
  private String payload = null;

  
  /**
   **/
  public PostitPostIt apiKey(String apiKey) {
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
  public PostitPostIt eventTime(Long eventTime) {
    this.eventTime = eventTime;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("event_time")
  public Long getEventTime() {
    return eventTime;
  }
  public void setEventTime(Long eventTime) {
    this.eventTime = eventTime;
  }

  
  /**
   **/
  public PostitPostIt payload(String payload) {
    this.payload = payload;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("payload")
  public String getPayload() {
    return payload;
  }
  public void setPayload(String payload) {
    this.payload = payload;
  }

  

  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    PostitPostIt postitPostIt = (PostitPostIt) o;
    return Objects.equals(this.apiKey, postitPostIt.apiKey) &&
        Objects.equals(this.eventTime, postitPostIt.eventTime) &&
        Objects.equals(this.payload, postitPostIt.payload);
  }

  @Override
  public int hashCode() {
    return Objects.hash(apiKey, eventTime, payload);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class PostitPostIt {\n");
    
    sb.append("    apiKey: ").append(toIndentedString(apiKey)).append("\n");
    sb.append("    eventTime: ").append(toIndentedString(eventTime)).append("\n");
    sb.append("    payload: ").append(toIndentedString(payload)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }
}

