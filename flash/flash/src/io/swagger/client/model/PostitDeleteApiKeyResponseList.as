package io.swagger.client.model {

import io.swagger.common.ListWrapper;

    public class PostitDeleteApiKeyResponseList implements ListWrapper {
        // This declaration below of _postitDeleteApiKeyResponse_obj_class is to force flash compiler to include this class
        private var _postitDeleteApiKeyResponse_obj_class: io.swagger.client.model.PostitDeleteApiKeyResponse = null;
        [XmlElements(name="postitDeleteApiKeyResponse", type="io.swagger.client.model.PostitDeleteApiKeyResponse")]
        public var postitDeleteApiKeyResponse: Array = new Array();

        public function getList(): Array{
            return postitDeleteApiKeyResponse;
        }

}
        

}
