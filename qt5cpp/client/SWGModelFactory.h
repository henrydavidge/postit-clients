#ifndef ModelFactory_H_
#define ModelFactory_H_


#include "SWGPostitCreatePostItTable.h"
#include "SWGPostitCreatePostItTableResponse.h"
#include "SWGPostitDeleteApiKey.h"
#include "SWGPostitDeleteApiKeyResponse.h"
#include "SWGPostitPostIt.h"
#include "SWGPostitPostItResponse.h"
#include "SWGPostitRegenerateApiKey.h"
#include "SWGPostitRegenerateApiKeyResponse.h"
#include "SWGPostitUpdatePostItTable.h"
#include "SWGPostitUpdatePostItTableResponse.h"

namespace Swagger {
  inline void* create(QString type) {
    if(QString("SWGPostitCreatePostItTable").compare(type) == 0) {
      return new SWGPostitCreatePostItTable();
    }
    if(QString("SWGPostitCreatePostItTableResponse").compare(type) == 0) {
      return new SWGPostitCreatePostItTableResponse();
    }
    if(QString("SWGPostitDeleteApiKey").compare(type) == 0) {
      return new SWGPostitDeleteApiKey();
    }
    if(QString("SWGPostitDeleteApiKeyResponse").compare(type) == 0) {
      return new SWGPostitDeleteApiKeyResponse();
    }
    if(QString("SWGPostitPostIt").compare(type) == 0) {
      return new SWGPostitPostIt();
    }
    if(QString("SWGPostitPostItResponse").compare(type) == 0) {
      return new SWGPostitPostItResponse();
    }
    if(QString("SWGPostitRegenerateApiKey").compare(type) == 0) {
      return new SWGPostitRegenerateApiKey();
    }
    if(QString("SWGPostitRegenerateApiKeyResponse").compare(type) == 0) {
      return new SWGPostitRegenerateApiKeyResponse();
    }
    if(QString("SWGPostitUpdatePostItTable").compare(type) == 0) {
      return new SWGPostitUpdatePostItTable();
    }
    if(QString("SWGPostitUpdatePostItTableResponse").compare(type) == 0) {
      return new SWGPostitUpdatePostItTableResponse();
    }
    
    return NULL;
  }

  inline void* create(QString json, QString type) {
    void* val = create(type);
    if(val != NULL) {
      SWGObject* obj = static_cast<SWGObject*>(val);
      return obj->fromJson(json);
    }
    if(type.startsWith("QString")) {
      return new QString();
    }
    return NULL;
  }
} /* namespace Swagger */

#endif /* ModelFactory_H_ */
