package io.swagger.api;

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

import io.swagger.annotations.Api;
import io.swagger.annotations.ApiOperation;
import io.swagger.annotations.ApiParam;
import io.swagger.annotations.ApiResponses;
import io.swagger.annotations.Authorization;
import io.swagger.annotations.AuthorizationScope;

import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestHeader;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RequestPart;
import org.springframework.web.multipart.MultipartFile;

import java.util.List;

import static org.springframework.http.MediaType.*;

@Controller
@RequestMapping(value = "/api", produces = {APPLICATION_JSON_VALUE})
@Api(value = "/api", description = "the api API")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.SpringMVCServerCodegen", date = "2016-05-13T14:31:17.548-07:00")
public class ApiApi {
  

  @ApiOperation(value = "PostItService.createPostItTable", notes = "", response = PostitCreatePostItTableResponse.class)
  @io.swagger.annotations.ApiResponses(value = { 
    @io.swagger.annotations.ApiResponse(code = 200, message = "Description") })
  @RequestMapping(value = "/1.0/create", 
    produces = { "application/json" }, 
    consumes = { "application/json" },
    method = RequestMethod.POST)
  public ResponseEntity<PostitCreatePostItTableResponse> createPostItTable(

@ApiParam(value = "" ,required=true ) @RequestBody PostitCreatePostItTable body
)
      throws NotFoundException {
      // do some magic!
      return new ResponseEntity<PostitCreatePostItTableResponse>(HttpStatus.OK);
  }

  

  @ApiOperation(value = "PostItService.deleteApiKey", notes = "", response = PostitDeleteApiKeyResponse.class)
  @io.swagger.annotations.ApiResponses(value = { 
    @io.swagger.annotations.ApiResponse(code = 200, message = "Description") })
  @RequestMapping(value = "/1.0/delete", 
    produces = { "application/json" }, 
    consumes = { "application/json" },
    method = RequestMethod.POST)
  public ResponseEntity<PostitDeleteApiKeyResponse> deleteApiKey(

@ApiParam(value = "" ,required=true ) @RequestBody PostitDeleteApiKey body
)
      throws NotFoundException {
      // do some magic!
      return new ResponseEntity<PostitDeleteApiKeyResponse>(HttpStatus.OK);
  }

  

  @ApiOperation(value = "PostItService.postIt", notes = "", response = PostitPostItResponse.class)
  @io.swagger.annotations.ApiResponses(value = { 
    @io.swagger.annotations.ApiResponse(code = 200, message = "Description") })
  @RequestMapping(value = "/1.0/post", 
    produces = { "application/json" }, 
    consumes = { "application/json" },
    method = RequestMethod.POST)
  public ResponseEntity<PostitPostItResponse> postIt(

@ApiParam(value = "" ,required=true ) @RequestBody PostitPostIt body
)
      throws NotFoundException {
      // do some magic!
      return new ResponseEntity<PostitPostItResponse>(HttpStatus.OK);
  }

  

  @ApiOperation(value = "PostItService.regenerateApiKey", notes = "", response = PostitRegenerateApiKeyResponse.class)
  @io.swagger.annotations.ApiResponses(value = { 
    @io.swagger.annotations.ApiResponse(code = 200, message = "Description") })
  @RequestMapping(value = "/1.0/regenerate", 
    produces = { "application/json" }, 
    consumes = { "application/json" },
    method = RequestMethod.POST)
  public ResponseEntity<PostitRegenerateApiKeyResponse> regenerateApiKey(

@ApiParam(value = "" ,required=true ) @RequestBody PostitRegenerateApiKey body
)
      throws NotFoundException {
      // do some magic!
      return new ResponseEntity<PostitRegenerateApiKeyResponse>(HttpStatus.OK);
  }

  

  @ApiOperation(value = "PostItService.updatePostItTable", notes = "", response = PostitUpdatePostItTableResponse.class)
  @io.swagger.annotations.ApiResponses(value = { 
    @io.swagger.annotations.ApiResponse(code = 200, message = "Description") })
  @RequestMapping(value = "/1.0/update", 
    produces = { "application/json" }, 
    consumes = { "application/json" },
    method = RequestMethod.POST)
  public ResponseEntity<PostitUpdatePostItTableResponse> updatePostItTable(

@ApiParam(value = "" ,required=true ) @RequestBody PostitUpdatePostItTable body
)
      throws NotFoundException {
      // do some magic!
      return new ResponseEntity<PostitUpdatePostItTableResponse>(HttpStatus.OK);
  }

  
}
