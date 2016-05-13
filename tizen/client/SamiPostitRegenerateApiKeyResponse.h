/*
 * SamiPostitRegenerateApiKeyResponse.h
 * 
 * 
 */

#ifndef SamiPostitRegenerateApiKeyResponse_H_
#define SamiPostitRegenerateApiKeyResponse_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FWebJson.h>
#include "SamiHelpers.h"
#include "SamiObject.h"

using namespace Tizen::Web::Json;


using Tizen::Base::String;


namespace Swagger {

class SamiPostitRegenerateApiKeyResponse: public SamiObject {
public:
    SamiPostitRegenerateApiKeyResponse();
    SamiPostitRegenerateApiKeyResponse(String* json);
    virtual ~SamiPostitRegenerateApiKeyResponse();

    void init();

    void cleanup();

    String asJson ();

    JsonObject* asJsonObject();

    void fromJsonObject(IJsonValue* json);

    SamiPostitRegenerateApiKeyResponse* fromJson(String* obj);

    
    String* getPApiKey();
    void setPApiKey(String* pApi_key);
    

private:
    String* pApi_key;
    
};

} /* namespace Swagger */

#endif /* SamiPostitRegenerateApiKeyResponse_H_ */
