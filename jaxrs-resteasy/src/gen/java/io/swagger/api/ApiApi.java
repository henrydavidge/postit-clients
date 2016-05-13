package io.swagger.api;

import io.swagger.model.*;
import io.swagger.api.ApiApiService;
import io.swagger.api.factories.ApiApiServiceFactory;

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

import javax.ws.rs.core.Context;
import javax.ws.rs.core.Response;
import javax.ws.rs.core.SecurityContext;
import javax.ws.rs.*;

@Path("/api")
@Consumes({ "application/json" })
@Produces({ "application/json" })
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaResteasyServerCodegen", date = "2016-05-13T14:31:04.545-07:00")
public class ApiApi  {
   private final ApiApiService delegate = ApiApiServiceFactory.getApiApi();

    @POST
    @Path("/1.0/create")
    @Consumes({ "application/json" })
    @Produces({ "application/json" })
    public Response createPostItTable( PostitCreatePostItTable body,@Context SecurityContext securityContext)
    throws NotFoundException {
        return delegate.createPostItTable(body,securityContext);
    }
    @POST
    @Path("/1.0/delete")
    @Consumes({ "application/json" })
    @Produces({ "application/json" })
    public Response deleteApiKey( PostitDeleteApiKey body,@Context SecurityContext securityContext)
    throws NotFoundException {
        return delegate.deleteApiKey(body,securityContext);
    }
    @POST
    @Path("/1.0/post")
    @Consumes({ "application/json" })
    @Produces({ "application/json" })
    public Response postIt( PostitPostIt body,@Context SecurityContext securityContext)
    throws NotFoundException {
        return delegate.postIt(body,securityContext);
    }
    @POST
    @Path("/1.0/regenerate")
    @Consumes({ "application/json" })
    @Produces({ "application/json" })
    public Response regenerateApiKey( PostitRegenerateApiKey body,@Context SecurityContext securityContext)
    throws NotFoundException {
        return delegate.regenerateApiKey(body,securityContext);
    }
    @POST
    @Path("/1.0/update")
    @Consumes({ "application/json" })
    @Produces({ "application/json" })
    public Response updatePostItTable( PostitUpdatePostItTable body,@Context SecurityContext securityContext)
    throws NotFoundException {
        return delegate.updatePostItTable(body,securityContext);
    }
}
