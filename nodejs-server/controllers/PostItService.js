'use strict';

var url = require('url');


var PostItService = require('./PostItServiceService');


module.exports.createPostItTable = function createPostItTable (req, res, next) {
  PostItService.createPostItTable(req.swagger.params, res, next);
};

module.exports.deleteApiKey = function deleteApiKey (req, res, next) {
  PostItService.deleteApiKey(req.swagger.params, res, next);
};

module.exports.postIt = function postIt (req, res, next) {
  PostItService.postIt(req.swagger.params, res, next);
};

module.exports.regenerateApiKey = function regenerateApiKey (req, res, next) {
  PostItService.regenerateApiKey(req.swagger.params, res, next);
};

module.exports.updatePostItTable = function updatePostItTable (req, res, next) {
  PostItService.updatePostItTable(req.swagger.params, res, next);
};
