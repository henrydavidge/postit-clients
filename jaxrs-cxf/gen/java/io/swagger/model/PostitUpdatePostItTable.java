package io.swagger.model;




import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlType;

@XmlAccessorType(XmlAccessType.FIELD)
 @XmlType(name = "", propOrder =
	{ "apiKey", "path", "schema"
})

@XmlRootElement(name="PostitUpdatePostItTable")
public class PostitUpdatePostItTable  {
  

  private String apiKey = null;

  private String path = null;

  private String schema = null;

  
  /**
   **/
  
  public String getApiKey() {
    return apiKey;
  }
  public void setApiKey(String apiKey) {
    this.apiKey = apiKey;
  }
  
  /**
   **/
  
  public String getPath() {
    return path;
  }
  public void setPath(String path) {
    this.path = path;
  }
  
  /**
   **/
  
  public String getSchema() {
    return schema;
  }
  public void setSchema(String schema) {
    this.schema = schema;
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
  private static String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }
}

