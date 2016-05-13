package io.swagger.client.model {


    [XmlRootNode(name="PostitCreatePostItTable")]
    public class PostitCreatePostItTable {
        
        
        
        [XmlElement(name="path")]
        
        public var path: String = null;
    
        
        
        [XmlElement(name="schema")]
        
        public var schema: String = null;
    
        
        
        [XmlElement(name="shard_name")]
        
        public var shardName: String = null;
    

    public function toString(): String {
        var str: String = "PostitCreatePostItTable: ";
        
        str += " (path: " + path + ")";
        
        str += " (schema: " + schema + ")";
        
        str += " (shardName: " + shardName + ")";
        
        return str;
    }

}

}
