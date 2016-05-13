package io.swagger.client.model {

import io.swagger.common.ListWrapper;

    public class PostitPostItResponseList implements ListWrapper {
        // This declaration below of _postitPostItResponse_obj_class is to force flash compiler to include this class
        private var _postitPostItResponse_obj_class: io.swagger.client.model.PostitPostItResponse = null;
        [XmlElements(name="postitPostItResponse", type="io.swagger.client.model.PostitPostItResponse")]
        public var postitPostItResponse: Array = new Array();

        public function getList(): Array{
            return postitPostItResponse;
        }

}
        

}
