package io.swagger.client.model {


    [XmlRootNode(name="PostitUpdatePostItTable")]
    public class PostitUpdatePostItTable {
        
        
        
        [XmlElement(name="api_key")]
        
        public var apiKey: String = null;
    
        
        
        [XmlElement(name="path")]
        
        public var path: String = null;
    
        
        
        [XmlElement(name="schema")]
        
        public var schema: String = null;
    

    public function toString(): String {
        var str: String = "PostitUpdatePostItTable: ";
        
        str += " (apiKey: " + apiKey + ")";
        
        str += " (path: " + path + ")";
        
        str += " (schema: " + schema + ")";
        
        return str;
    }

}

}
