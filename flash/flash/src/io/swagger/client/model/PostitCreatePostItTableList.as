package io.swagger.client.model {

import io.swagger.common.ListWrapper;

    public class PostitCreatePostItTableList implements ListWrapper {
        // This declaration below of _postitCreatePostItTable_obj_class is to force flash compiler to include this class
        private var _postitCreatePostItTable_obj_class: io.swagger.client.model.PostitCreatePostItTable = null;
        [XmlElements(name="postitCreatePostItTable", type="io.swagger.client.model.PostitCreatePostItTable")]
        public var postitCreatePostItTable: Array = new Array();

        public function getList(): Array{
            return postitCreatePostItTable;
        }

}
        

}
