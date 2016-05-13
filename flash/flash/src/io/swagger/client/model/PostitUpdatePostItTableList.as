package io.swagger.client.model {

import io.swagger.common.ListWrapper;

    public class PostitUpdatePostItTableList implements ListWrapper {
        // This declaration below of _postitUpdatePostItTable_obj_class is to force flash compiler to include this class
        private var _postitUpdatePostItTable_obj_class: io.swagger.client.model.PostitUpdatePostItTable = null;
        [XmlElements(name="postitUpdatePostItTable", type="io.swagger.client.model.PostitUpdatePostItTable")]
        public var postitUpdatePostItTable: Array = new Array();

        public function getList(): Array{
            return postitUpdatePostItTable;
        }

}
        

}
