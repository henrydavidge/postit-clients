package io.swagger.client.model {

import io.swagger.common.ListWrapper;

    public class PostitDeleteApiKeyList implements ListWrapper {
        // This declaration below of _postitDeleteApiKey_obj_class is to force flash compiler to include this class
        private var _postitDeleteApiKey_obj_class: io.swagger.client.model.PostitDeleteApiKey = null;
        [XmlElements(name="postitDeleteApiKey", type="io.swagger.client.model.PostitDeleteApiKey")]
        public var postitDeleteApiKey: Array = new Array();

        public function getList(): Array{
            return postitDeleteApiKey;
        }

}
        

}
