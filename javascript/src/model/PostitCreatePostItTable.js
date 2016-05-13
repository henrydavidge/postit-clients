(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'));
  } else {
    // Browser globals (root is window)
    if (!root.SwaggerJsClient) {
      root.SwaggerJsClient = {};
    }
    root.SwaggerJsClient.PostitCreatePostItTable = factory(root.SwaggerJsClient.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The PostitCreatePostItTable model module.
   * @module model/PostitCreatePostItTable
   * @version 1.0.0
   */

  /**
   * Constructs a new <code>PostitCreatePostItTable</code>.
   * @alias module:model/PostitCreatePostItTable
   * @class
   */
  var exports = function() {




  };

  /**
   * Constructs a <code>PostitCreatePostItTable</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/PostitCreatePostItTable} obj Optional instance to populate.
   * @return {module:model/PostitCreatePostItTable} The populated <code>PostitCreatePostItTable</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('path')) {
        obj['path'] = ApiClient.convertToType(data['path'], 'String');
      }
      if (data.hasOwnProperty('schema')) {
        obj['schema'] = ApiClient.convertToType(data['schema'], 'String');
      }
      if (data.hasOwnProperty('shard_name')) {
        obj['shard_name'] = ApiClient.convertToType(data['shard_name'], 'String');
      }
    }
    return obj;
  }


  /**
   * @member {String} path
   */
  exports.prototype['path'] = undefined;

  /**
   * @member {String} schema
   */
  exports.prototype['schema'] = undefined;

  /**
   * @member {String} shard_name
   */
  exports.prototype['shard_name'] = undefined;




  return exports;
}));
