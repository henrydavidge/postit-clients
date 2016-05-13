using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Newtonsoft.Json;
using Swashbuckle.SwaggerGen.Annotations;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class PostItServiceApiController : Controller
    { 

        /// <summary>
        /// PostItService.createPostItTable
        /// </summary>
        
        /// <param name="body"></param>
        /// <response code="0">Description</response>
        [HttpPost]
        [Route("/api/1.0/create")]
        [SwaggerOperation("CreatePostItTable")]
        [SwaggerResponse(200, type: typeof(PostitCreatePostItTableResponse))]
        public IActionResult CreatePostItTable([FromBody]PostitCreatePostItTable body)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PostitCreatePostItTableResponse>(exampleJson)
            : default(PostitCreatePostItTableResponse);
            
            return new ObjectResult(example);
        }


        /// <summary>
        /// PostItService.deleteApiKey
        /// </summary>
        
        /// <param name="body"></param>
        /// <response code="0">Description</response>
        [HttpPost]
        [Route("/api/1.0/delete")]
        [SwaggerOperation("DeleteApiKey")]
        [SwaggerResponse(200, type: typeof(PostitDeleteApiKeyResponse))]
        public IActionResult DeleteApiKey([FromBody]PostitDeleteApiKey body)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PostitDeleteApiKeyResponse>(exampleJson)
            : default(PostitDeleteApiKeyResponse);
            
            return new ObjectResult(example);
        }


        /// <summary>
        /// PostItService.postIt
        /// </summary>
        
        /// <param name="body"></param>
        /// <response code="0">Description</response>
        [HttpPost]
        [Route("/api/1.0/post")]
        [SwaggerOperation("PostIt")]
        [SwaggerResponse(200, type: typeof(PostitPostItResponse))]
        public IActionResult PostIt([FromBody]PostitPostIt body)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PostitPostItResponse>(exampleJson)
            : default(PostitPostItResponse);
            
            return new ObjectResult(example);
        }


        /// <summary>
        /// PostItService.regenerateApiKey
        /// </summary>
        
        /// <param name="body"></param>
        /// <response code="0">Description</response>
        [HttpPost]
        [Route("/api/1.0/regenerate")]
        [SwaggerOperation("RegenerateApiKey")]
        [SwaggerResponse(200, type: typeof(PostitRegenerateApiKeyResponse))]
        public IActionResult RegenerateApiKey([FromBody]PostitRegenerateApiKey body)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PostitRegenerateApiKeyResponse>(exampleJson)
            : default(PostitRegenerateApiKeyResponse);
            
            return new ObjectResult(example);
        }


        /// <summary>
        /// PostItService.updatePostItTable
        /// </summary>
        
        /// <param name="body"></param>
        /// <response code="0">Description</response>
        [HttpPost]
        [Route("/api/1.0/update")]
        [SwaggerOperation("UpdatePostItTable")]
        [SwaggerResponse(200, type: typeof(PostitUpdatePostItTableResponse))]
        public IActionResult UpdatePostItTable([FromBody]PostitUpdatePostItTable body)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PostitUpdatePostItTableResponse>(exampleJson)
            : default(PostitUpdatePostItTableResponse);
            
            return new ObjectResult(example);
        }
    }
}
