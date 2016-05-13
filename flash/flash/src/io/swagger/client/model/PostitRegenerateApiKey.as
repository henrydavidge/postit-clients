package io.swagger.client.model {


    [XmlRootNode(name="PostitRegenerateApiKey")]
    public class PostitRegenerateApiKey {
        
        
        
        [XmlElement(name="api_key")]
        
        public var apiKey: String = null;
    

    public function toString(): String {
        var str: String = "PostitRegenerateApiKey: ";
        
        str += " (apiKey: " + apiKey + ")";
        
        return str;
    }

}

}
