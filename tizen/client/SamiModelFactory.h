#ifndef ModelFactory_H_
#define ModelFactory_H_

#include "SamiObject.h"

#include "SamiPostitCreatePostItTable.h"
#include "SamiPostitCreatePostItTableResponse.h"
#include "SamiPostitDeleteApiKey.h"
#include "SamiPostitDeleteApiKeyResponse.h"
#include "SamiPostitPostIt.h"
#include "SamiPostitPostItResponse.h"
#include "SamiPostitRegenerateApiKey.h"
#include "SamiPostitRegenerateApiKeyResponse.h"
#include "SamiPostitUpdatePostItTable.h"
#include "SamiPostitUpdatePostItTableResponse.h"

namespace Swagger {
  void*
  create(String type) {
    if(type.Equals(L"SamiPostitCreatePostItTable", true)) {
      return new SamiPostitCreatePostItTable();
    }
    if(type.Equals(L"SamiPostitCreatePostItTableResponse", true)) {
      return new SamiPostitCreatePostItTableResponse();
    }
    if(type.Equals(L"SamiPostitDeleteApiKey", true)) {
      return new SamiPostitDeleteApiKey();
    }
    if(type.Equals(L"SamiPostitDeleteApiKeyResponse", true)) {
      return new SamiPostitDeleteApiKeyResponse();
    }
    if(type.Equals(L"SamiPostitPostIt", true)) {
      return new SamiPostitPostIt();
    }
    if(type.Equals(L"SamiPostitPostItResponse", true)) {
      return new SamiPostitPostItResponse();
    }
    if(type.Equals(L"SamiPostitRegenerateApiKey", true)) {
      return new SamiPostitRegenerateApiKey();
    }
    if(type.Equals(L"SamiPostitRegenerateApiKeyResponse", true)) {
      return new SamiPostitRegenerateApiKeyResponse();
    }
    if(type.Equals(L"SamiPostitUpdatePostItTable", true)) {
      return new SamiPostitUpdatePostItTable();
    }
    if(type.Equals(L"SamiPostitUpdatePostItTableResponse", true)) {
      return new SamiPostitUpdatePostItTableResponse();
    }
    
    if(type.Equals(L"String", true)) {
      return new String();
    }
    if(type.Equals(L"Integer", true)) {
      return new Integer();
    }
    if(type.Equals(L"Long", true)) {
      return new Long();
    }
    if(type.Equals(L"DateTime", true)) {
      return new DateTime();
    }
    return null;
  }
} /* namespace Swagger */

#endif /* ModelFactory_H_ */
