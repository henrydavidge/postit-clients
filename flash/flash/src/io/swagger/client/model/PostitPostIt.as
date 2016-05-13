package io.swagger.client.model {


    [XmlRootNode(name="PostitPostIt")]
    public class PostitPostIt {
        
        
        
        [XmlElement(name="api_key")]
        
        public var apiKey: String = null;
    
        
        
        [XmlElement(name="event_time")]
        
        public var eventTime: Number = 0;
    
        
        
        [XmlElement(name="payload")]
        
        public var payload: String = null;
    

    public function toString(): String {
        var str: String = "PostitPostIt: ";
        
        str += " (apiKey: " + apiKey + ")";
        
        str += " (eventTime: " + eventTime + ")";
        
        str += " (payload: " + payload + ")";
        
        return str;
    }

}

}
