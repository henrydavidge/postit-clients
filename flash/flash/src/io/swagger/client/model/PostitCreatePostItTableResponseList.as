package io.swagger.client.model {

import io.swagger.common.ListWrapper;

    public class PostitCreatePostItTableResponseList implements ListWrapper {
        // This declaration below of _postitCreatePostItTableResponse_obj_class is to force flash compiler to include this class
        private var _postitCreatePostItTableResponse_obj_class: io.swagger.client.model.PostitCreatePostItTableResponse = null;
        [XmlElements(name="postitCreatePostItTableResponse", type="io.swagger.client.model.PostitCreatePostItTableResponse")]
        public var postitCreatePostItTableResponse: Array = new Array();

        public function getList(): Array{
            return postitCreatePostItTableResponse;
        }

}
        

}
