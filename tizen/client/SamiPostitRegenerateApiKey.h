/*
 * SamiPostitRegenerateApiKey.h
 * 
 * 
 */

#ifndef SamiPostitRegenerateApiKey_H_
#define SamiPostitRegenerateApiKey_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FWebJson.h>
#include "SamiHelpers.h"
#include "SamiObject.h"

using namespace Tizen::Web::Json;


using Tizen::Base::String;


namespace Swagger {

class SamiPostitRegenerateApiKey: public SamiObject {
public:
    SamiPostitRegenerateApiKey();
    SamiPostitRegenerateApiKey(String* json);
    virtual ~SamiPostitRegenerateApiKey();

    void init();

    void cleanup();

    String asJson ();

    JsonObject* asJsonObject();

    void fromJsonObject(IJsonValue* json);

    SamiPostitRegenerateApiKey* fromJson(String* obj);

    
    String* getPApiKey();
    void setPApiKey(String* pApi_key);
    

private:
    String* pApi_key;
    
};

} /* namespace Swagger */

#endif /* SamiPostitRegenerateApiKey_H_ */
