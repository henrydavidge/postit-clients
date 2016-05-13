package io.swagger.client.model {

import io.swagger.common.ListWrapper;

    public class PostitRegenerateApiKeyList implements ListWrapper {
        // This declaration below of _postitRegenerateApiKey_obj_class is to force flash compiler to include this class
        private var _postitRegenerateApiKey_obj_class: io.swagger.client.model.PostitRegenerateApiKey = null;
        [XmlElements(name="postitRegenerateApiKey", type="io.swagger.client.model.PostitRegenerateApiKey")]
        public var postitRegenerateApiKey: Array = new Array();

        public function getList(): Array{
            return postitRegenerateApiKey;
        }

}
        

}
