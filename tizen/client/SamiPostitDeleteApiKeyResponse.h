/*
 * SamiPostitDeleteApiKeyResponse.h
 * 
 * 
 */

#ifndef SamiPostitDeleteApiKeyResponse_H_
#define SamiPostitDeleteApiKeyResponse_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FWebJson.h>
#include "SamiHelpers.h"
#include "SamiObject.h"

using namespace Tizen::Web::Json;




namespace Swagger {

class SamiPostitDeleteApiKeyResponse: public SamiObject {
public:
    SamiPostitDeleteApiKeyResponse();
    SamiPostitDeleteApiKeyResponse(String* json);
    virtual ~SamiPostitDeleteApiKeyResponse();

    void init();

    void cleanup();

    String asJson ();

    JsonObject* asJsonObject();

    void fromJsonObject(IJsonValue* json);

    SamiPostitDeleteApiKeyResponse* fromJson(String* obj);

    

private:
    
};

} /* namespace Swagger */

#endif /* SamiPostitDeleteApiKeyResponse_H_ */
