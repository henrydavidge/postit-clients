package io.swagger.client.model {

import io.swagger.common.ListWrapper;

    public class PostitRegenerateApiKeyResponseList implements ListWrapper {
        // This declaration below of _postitRegenerateApiKeyResponse_obj_class is to force flash compiler to include this class
        private var _postitRegenerateApiKeyResponse_obj_class: io.swagger.client.model.PostitRegenerateApiKeyResponse = null;
        [XmlElements(name="postitRegenerateApiKeyResponse", type="io.swagger.client.model.PostitRegenerateApiKeyResponse")]
        public var postitRegenerateApiKeyResponse: Array = new Array();

        public function getList(): Array{
            return postitRegenerateApiKeyResponse;
        }

}
        

}
