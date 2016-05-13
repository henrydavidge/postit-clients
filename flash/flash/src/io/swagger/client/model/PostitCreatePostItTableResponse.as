package io.swagger.client.model {


    [XmlRootNode(name="PostitCreatePostItTableResponse")]
    public class PostitCreatePostItTableResponse {
        
        
        
        [XmlElement(name="api_key")]
        
        public var apiKey: String = null;
    

    public function toString(): String {
        var str: String = "PostitCreatePostItTableResponse: ";
        
        str += " (apiKey: " + apiKey + ")";
        
        return str;
    }

}

}
