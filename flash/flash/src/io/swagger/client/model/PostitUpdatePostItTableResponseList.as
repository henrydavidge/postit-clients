package io.swagger.client.model {

import io.swagger.common.ListWrapper;

    public class PostitUpdatePostItTableResponseList implements ListWrapper {
        // This declaration below of _postitUpdatePostItTableResponse_obj_class is to force flash compiler to include this class
        private var _postitUpdatePostItTableResponse_obj_class: io.swagger.client.model.PostitUpdatePostItTableResponse = null;
        [XmlElements(name="postitUpdatePostItTableResponse", type="io.swagger.client.model.PostitUpdatePostItTableResponse")]
        public var postitUpdatePostItTableResponse: Array = new Array();

        public function getList(): Array{
            return postitUpdatePostItTableResponse;
        }

}
        

}
