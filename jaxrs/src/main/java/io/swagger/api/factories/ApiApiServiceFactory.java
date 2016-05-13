package io.swagger.api.factories;

import io.swagger.api.ApiApiService;
import io.swagger.api.impl.ApiApiServiceImpl;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaJerseyServerCodegen", date = "2016-05-13T14:30:58.824-07:00")
public class ApiApiServiceFactory {

   private final static ApiApiService service = new ApiApiServiceImpl();

   public static ApiApiService getApiApi()
   {
      return service;
   }
}
