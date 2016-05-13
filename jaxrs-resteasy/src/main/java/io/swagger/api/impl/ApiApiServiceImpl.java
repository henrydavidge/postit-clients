package io.swagger.api.impl;

import io.swagger.api.*;
import io.swagger.model.*;


import io.swagger.model.PostitCreatePostItTableResponse;
import io.swagger.model.PostitCreatePostItTable;
import io.swagger.model.PostitDeleteApiKey;
import io.swagger.model.PostitDeleteApiKeyResponse;
import io.swagger.model.PostitPostItResponse;
import io.swagger.model.PostitPostIt;
import io.swagger.model.PostitRegenerateApiKeyResponse;
import io.swagger.model.PostitRegenerateApiKey;
import io.swagger.model.PostitUpdatePostItTable;
import io.swagger.model.PostitUpdatePostItTableResponse;

import java.util.List;
import io.swagger.api.NotFoundException;

import java.io.InputStream;

import javax.ws.rs.core.Response;
import javax.ws.rs.core.SecurityContext;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaResteasyServerCodegen", date = "2016-05-13T14:31:04.545-07:00")
public class ApiApiServiceImpl extends ApiApiService {
  
      @Override
      public Response createPostItTable(PostitCreatePostItTable body,SecurityContext securityContext)
      throws NotFoundException {
      // do some magic!
      return Response.ok().entity(new ApiResponseMessage(ApiResponseMessage.OK, "magic!")).build();
  }
  
      @Override
      public Response deleteApiKey(PostitDeleteApiKey body,SecurityContext securityContext)
      throws NotFoundException {
      // do some magic!
      return Response.ok().entity(new ApiResponseMessage(ApiResponseMessage.OK, "magic!")).build();
  }
  
      @Override
      public Response postIt(PostitPostIt body,SecurityContext securityContext)
      throws NotFoundException {
      // do some magic!
      return Response.ok().entity(new ApiResponseMessage(ApiResponseMessage.OK, "magic!")).build();
  }
  
      @Override
      public Response regenerateApiKey(PostitRegenerateApiKey body,SecurityContext securityContext)
      throws NotFoundException {
      // do some magic!
      return Response.ok().entity(new ApiResponseMessage(ApiResponseMessage.OK, "magic!")).build();
  }
  
      @Override
      public Response updatePostItTable(PostitUpdatePostItTable body,SecurityContext securityContext)
      throws NotFoundException {
      // do some magic!
      return Response.ok().entity(new ApiResponseMessage(ApiResponseMessage.OK, "magic!")).build();
  }
  
}
