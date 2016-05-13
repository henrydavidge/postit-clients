/*
 * SamiPostitDeleteApiKey.h
 * 
 * 
 */

#ifndef SamiPostitDeleteApiKey_H_
#define SamiPostitDeleteApiKey_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FWebJson.h>
#include "SamiHelpers.h"
#include "SamiObject.h"

using namespace Tizen::Web::Json;


using Tizen::Base::String;


namespace Swagger {

class SamiPostitDeleteApiKey: public SamiObject {
public:
    SamiPostitDeleteApiKey();
    SamiPostitDeleteApiKey(String* json);
    virtual ~SamiPostitDeleteApiKey();

    void init();

    void cleanup();

    String asJson ();

    JsonObject* asJsonObject();

    void fromJsonObject(IJsonValue* json);

    SamiPostitDeleteApiKey* fromJson(String* obj);

    
    String* getPApiKey();
    void setPApiKey(String* pApi_key);
    

private:
    String* pApi_key;
    
};

} /* namespace Swagger */

#endif /* SamiPostitDeleteApiKey_H_ */
