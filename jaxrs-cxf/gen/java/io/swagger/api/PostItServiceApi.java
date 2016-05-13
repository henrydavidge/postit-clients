package io.swagger.api;

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

import javax.ws.rs.*;
import javax.ws.rs.core.Response;

import org.apache.cxf.jaxrs.ext.multipart.*;

@Path("/")
public interface PostItServiceApi  {
    @POST
    @Path("/api/1.0/create")
    @Consumes({ "application/json" })
    @Produces({ "application/json" })
    public Response createPostItTable(PostitCreatePostItTable body);
    @POST
    @Path("/api/1.0/delete")
    @Consumes({ "application/json" })
    @Produces({ "application/json" })
    public Response deleteApiKey(PostitDeleteApiKey body);
    @POST
    @Path("/api/1.0/post")
    @Consumes({ "application/json" })
    @Produces({ "application/json" })
    public Response postIt(PostitPostIt body);
    @POST
    @Path("/api/1.0/regenerate")
    @Consumes({ "application/json" })
    @Produces({ "application/json" })
    public Response regenerateApiKey(PostitRegenerateApiKey body);
    @POST
    @Path("/api/1.0/update")
    @Consumes({ "application/json" })
    @Produces({ "application/json" })
    public Response updatePostItTable(PostitUpdatePostItTable body);
}

