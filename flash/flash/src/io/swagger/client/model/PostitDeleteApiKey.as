package io.swagger.client.model {


    [XmlRootNode(name="PostitDeleteApiKey")]
    public class PostitDeleteApiKey {
        
        
        
        [XmlElement(name="api_key")]
        
        public var apiKey: String = null;
    

    public function toString(): String {
        var str: String = "PostitDeleteApiKey: ";
        
        str += " (apiKey: " + apiKey + ")";
        
        return str;
    }

}

}
