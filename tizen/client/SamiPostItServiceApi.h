#ifndef SamiPostItServiceApi_H_
#define SamiPostItServiceApi_H_

#include <FNet.h>
#include "SamiApiClient.h"
#include "SamiError.h"

#include "SamiPostitCreatePostItTableResponse.h"
#include "SamiPostitCreatePostItTable.h"
#include "SamiPostitDeleteApiKeyResponse.h"
#include "SamiPostitDeleteApiKey.h"
#include "SamiPostitPostItResponse.h"
#include "SamiPostitPostIt.h"
#include "SamiPostitRegenerateApiKey.h"
#include "SamiPostitRegenerateApiKeyResponse.h"
#include "SamiPostitUpdatePostItTable.h"
#include "SamiPostitUpdatePostItTableResponse.h"

using namespace Tizen::Net::Http;

namespace Swagger {

class SamiPostItServiceApi {
public:
  SamiPostItServiceApi();
  virtual ~SamiPostItServiceApi();

  
  SamiPostitCreatePostItTableResponse* 
  createPostItTableWithCompletion(SamiPostitCreatePostItTable* body, void (* handler)(SamiPostitCreatePostItTableResponse*, SamiError*));
  
  SamiPostitDeleteApiKeyResponse* 
  deleteApiKeyWithCompletion(SamiPostitDeleteApiKey* body, void (* handler)(SamiPostitDeleteApiKeyResponse*, SamiError*));
  
  SamiPostitPostItResponse* 
  postItWithCompletion(SamiPostitPostIt* body, void (* handler)(SamiPostitPostItResponse*, SamiError*));
  
  SamiPostitRegenerateApiKeyResponse* 
  regenerateApiKeyWithCompletion(SamiPostitRegenerateApiKey* body, void (* handler)(SamiPostitRegenerateApiKeyResponse*, SamiError*));
  
  SamiPostitUpdatePostItTableResponse* 
  updatePostItTableWithCompletion(SamiPostitUpdatePostItTable* body, void (* handler)(SamiPostitUpdatePostItTableResponse*, SamiError*));
  
  static String getBasePath() {
    return L"http://localhost";
  }

private:
  SamiApiClient* client;
};


} /* namespace Swagger */

#endif /* SamiPostItServiceApi_H_ */
