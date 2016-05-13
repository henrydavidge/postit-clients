require 'json'


MyApp.add_route('POST', '/api/1.0/create', {
  "resourcePath" => "/PostItService",
  "summary" => "PostItService.createPostItTable",
  "nickname" => "create_post_it_table", 
  "responseClass" => "postitCreatePostItTableResponse", 
  "endpoint" => "/api/1.0/create", 
  "notes" => "",
  "parameters" => [
    
    
    
    
    {
      "name" => "body",
      "description" => "",
      "dataType" => "PostitCreatePostItTable",
      "paramType" => "body",
    }
    
    ]}) do
  cross_origin
  # the guts live here

  {"message" => "yes, it worked"}.to_json
end


MyApp.add_route('POST', '/api/1.0/delete', {
  "resourcePath" => "/PostItService",
  "summary" => "PostItService.deleteApiKey",
  "nickname" => "delete_api_key", 
  "responseClass" => "postitDeleteApiKeyResponse", 
  "endpoint" => "/api/1.0/delete", 
  "notes" => "",
  "parameters" => [
    
    
    
    
    {
      "name" => "body",
      "description" => "",
      "dataType" => "PostitDeleteApiKey",
      "paramType" => "body",
    }
    
    ]}) do
  cross_origin
  # the guts live here

  {"message" => "yes, it worked"}.to_json
end


MyApp.add_route('POST', '/api/1.0/post', {
  "resourcePath" => "/PostItService",
  "summary" => "PostItService.postIt",
  "nickname" => "post_it", 
  "responseClass" => "postitPostItResponse", 
  "endpoint" => "/api/1.0/post", 
  "notes" => "",
  "parameters" => [
    
    
    
    
    {
      "name" => "body",
      "description" => "",
      "dataType" => "PostitPostIt",
      "paramType" => "body",
    }
    
    ]}) do
  cross_origin
  # the guts live here

  {"message" => "yes, it worked"}.to_json
end


MyApp.add_route('POST', '/api/1.0/regenerate', {
  "resourcePath" => "/PostItService",
  "summary" => "PostItService.regenerateApiKey",
  "nickname" => "regenerate_api_key", 
  "responseClass" => "postitRegenerateApiKeyResponse", 
  "endpoint" => "/api/1.0/regenerate", 
  "notes" => "",
  "parameters" => [
    
    
    
    
    {
      "name" => "body",
      "description" => "",
      "dataType" => "PostitRegenerateApiKey",
      "paramType" => "body",
    }
    
    ]}) do
  cross_origin
  # the guts live here

  {"message" => "yes, it worked"}.to_json
end


MyApp.add_route('POST', '/api/1.0/update', {
  "resourcePath" => "/PostItService",
  "summary" => "PostItService.updatePostItTable",
  "nickname" => "update_post_it_table", 
  "responseClass" => "postitUpdatePostItTableResponse", 
  "endpoint" => "/api/1.0/update", 
  "notes" => "",
  "parameters" => [
    
    
    
    
    {
      "name" => "body",
      "description" => "",
      "dataType" => "PostitUpdatePostItTable",
      "paramType" => "body",
    }
    
    ]}) do
  cross_origin
  # the guts live here

  {"message" => "yes, it worked"}.to_json
end

