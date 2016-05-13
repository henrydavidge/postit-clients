'use strict';

exports.createPostItTable = function(args, res, next) {
  /**
   * parameters expected in the args:
  * body (PostitCreatePostItTable)
  **/
  
  
  var examples = {};
  examples['application/json'] = {
  "api_key" : "aeiou"
};
  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}

exports.deleteApiKey = function(args, res, next) {
  /**
   * parameters expected in the args:
  * body (PostitDeleteApiKey)
  **/
  
  
  var examples = {};
  examples['application/json'] = { };
  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}

exports.postIt = function(args, res, next) {
  /**
   * parameters expected in the args:
  * body (PostitPostIt)
  **/
  
  
  var examples = {};
  examples['application/json'] = { };
  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}

exports.regenerateApiKey = function(args, res, next) {
  /**
   * parameters expected in the args:
  * body (PostitRegenerateApiKey)
  **/
  
  
  var examples = {};
  examples['application/json'] = {
  "api_key" : "aeiou"
};
  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}

exports.updatePostItTable = function(args, res, next) {
  /**
   * parameters expected in the args:
  * body (PostitUpdatePostItTable)
  **/
  
  
  var examples = {};
  examples['application/json'] = { };
  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}

