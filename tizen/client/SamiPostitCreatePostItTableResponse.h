/*
 * SamiPostitCreatePostItTableResponse.h
 * 
 * 
 */

#ifndef SamiPostitCreatePostItTableResponse_H_
#define SamiPostitCreatePostItTableResponse_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FWebJson.h>
#include "SamiHelpers.h"
#include "SamiObject.h"

using namespace Tizen::Web::Json;


using Tizen::Base::String;


namespace Swagger {

class SamiPostitCreatePostItTableResponse: public SamiObject {
public:
    SamiPostitCreatePostItTableResponse();
    SamiPostitCreatePostItTableResponse(String* json);
    virtual ~SamiPostitCreatePostItTableResponse();

    void init();

    void cleanup();

    String asJson ();

    JsonObject* asJsonObject();

    void fromJsonObject(IJsonValue* json);

    SamiPostitCreatePostItTableResponse* fromJson(String* obj);

    
    String* getPApiKey();
    void setPApiKey(String* pApi_key);
    

private:
    String* pApi_key;
    
};

} /* namespace Swagger */

#endif /* SamiPostitCreatePostItTableResponse_H_ */
