package io.swagger.client.model {

import io.swagger.common.ListWrapper;

    public class PostitPostItList implements ListWrapper {
        // This declaration below of _postitPostIt_obj_class is to force flash compiler to include this class
        private var _postitPostIt_obj_class: io.swagger.client.model.PostitPostIt = null;
        [XmlElements(name="postitPostIt", type="io.swagger.client.model.PostitPostIt")]
        public var postitPostIt: Array = new Array();

        public function getList(): Array{
            return postitPostIt;
        }

}
        

}
