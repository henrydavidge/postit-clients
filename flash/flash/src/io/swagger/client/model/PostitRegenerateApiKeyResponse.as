package io.swagger.client.model {


    [XmlRootNode(name="PostitRegenerateApiKeyResponse")]
    public class PostitRegenerateApiKeyResponse {
        
        
        
        [XmlElement(name="api_key")]
        
        public var apiKey: String = null;
    

    public function toString(): String {
        var str: String = "PostitRegenerateApiKeyResponse: ";
        
        str += " (apiKey: " + apiKey + ")";
        
        return str;
    }

}

}
