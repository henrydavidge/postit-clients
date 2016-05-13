package io.swagger.api;

import io.swagger.model.*;
import io.swagger.api.ApiApiService;
import io.swagger.api.factories.ApiApiServiceFactory;

import io.swagger.annotations.ApiParam;

import com.sun.jersey.multipart.FormDataParam;

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

import com.sun.jersey.core.header.FormDataContentDisposition;
import com.sun.jersey.multipart.FormDataParam;

import javax.ws.rs.core.Context;
import javax.ws.rs.core.Response;
import javax.ws.rs.core.SecurityContext;
import javax.ws.rs.*;

@Path("/api")
@Consumes({ "application/json" })
@Produces({ "application/json" })
@io.swagger.annotations.Api(description = "the api API")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaJerseyServerCodegen", date = "2016-05-13T14:30:58.824-07:00")
public class ApiApi  {
   private final ApiApiService delegate = ApiApiServiceFactory.getApiApi();

    @POST
    @Path("/1.0/create")
    @Consumes({ "application/json" })
    @Produces({ "application/json" })
    @io.swagger.annotations.ApiOperation(value = "PostItService.createPostItTable", notes = "", response = PostitCreatePostItTableResponse.class, tags={ "PostItService",  })
    @io.swagger.annotations.ApiResponses(value = { 
        @io.swagger.annotations.ApiResponse(code = 200, message = "Description", response = PostitCreatePostItTableResponse.class) })
    public Response createPostItTable(
        @ApiParam(value = "" ,required=true) PostitCreatePostItTable body,
        @Context SecurityContext securityContext)
    throws NotFoundException {
        return delegate.createPostItTable(body,securityContext);
    }
    @POST
    @Path("/1.0/delete")
    @Consumes({ "application/json" })
    @Produces({ "application/json" })
    @io.swagger.annotations.ApiOperation(value = "PostItService.deleteApiKey", notes = "", response = PostitDeleteApiKeyResponse.class, tags={ "PostItService",  })
    @io.swagger.annotations.ApiResponses(value = { 
        @io.swagger.annotations.ApiResponse(code = 200, message = "Description", response = PostitDeleteApiKeyResponse.class) })
    public Response deleteApiKey(
        @ApiParam(value = "" ,required=true) PostitDeleteApiKey body,
        @Context SecurityContext securityContext)
    throws NotFoundException {
        return delegate.deleteApiKey(body,securityContext);
    }
    @POST
    @Path("/1.0/post")
    @Consumes({ "application/json" })
    @Produces({ "application/json" })
    @io.swagger.annotations.ApiOperation(value = "PostItService.postIt", notes = "", response = PostitPostItResponse.class, tags={ "PostItService",  })
    @io.swagger.annotations.ApiResponses(value = { 
        @io.swagger.annotations.ApiResponse(code = 200, message = "Description", response = PostitPostItResponse.class) })
    public Response postIt(
        @ApiParam(value = "" ,required=true) PostitPostIt body,
        @Context SecurityContext securityContext)
    throws NotFoundException {
        return delegate.postIt(body,securityContext);
    }
    @POST
    @Path("/1.0/regenerate")
    @Consumes({ "application/json" })
    @Produces({ "application/json" })
    @io.swagger.annotations.ApiOperation(value = "PostItService.regenerateApiKey", notes = "", response = PostitRegenerateApiKeyResponse.class, tags={ "PostItService",  })
    @io.swagger.annotations.ApiResponses(value = { 
        @io.swagger.annotations.ApiResponse(code = 200, message = "Description", response = PostitRegenerateApiKeyResponse.class) })
    public Response regenerateApiKey(
        @ApiParam(value = "" ,required=true) PostitRegenerateApiKey body,
        @Context SecurityContext securityContext)
    throws NotFoundException {
        return delegate.regenerateApiKey(body,securityContext);
    }
    @POST
    @Path("/1.0/update")
    @Consumes({ "application/json" })
    @Produces({ "application/json" })
    @io.swagger.annotations.ApiOperation(value = "PostItService.updatePostItTable", notes = "", response = PostitUpdatePostItTableResponse.class, tags={ "PostItService" })
    @io.swagger.annotations.ApiResponses(value = { 
        @io.swagger.annotations.ApiResponse(code = 200, message = "Description", response = PostitUpdatePostItTableResponse.class) })
    public Response updatePostItTable(
        @ApiParam(value = "" ,required=true) PostitUpdatePostItTable body,
        @Context SecurityContext securityContext)
    throws NotFoundException {
        return delegate.updatePostItTable(body,securityContext);
    }
}
