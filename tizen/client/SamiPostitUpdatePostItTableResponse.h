/*
 * SamiPostitUpdatePostItTableResponse.h
 * 
 * 
 */

#ifndef SamiPostitUpdatePostItTableResponse_H_
#define SamiPostitUpdatePostItTableResponse_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FWebJson.h>
#include "SamiHelpers.h"
#include "SamiObject.h"

using namespace Tizen::Web::Json;




namespace Swagger {

class SamiPostitUpdatePostItTableResponse: public SamiObject {
public:
    SamiPostitUpdatePostItTableResponse();
    SamiPostitUpdatePostItTableResponse(String* json);
    virtual ~SamiPostitUpdatePostItTableResponse();

    void init();

    void cleanup();

    String asJson ();

    JsonObject* asJsonObject();

    void fromJsonObject(IJsonValue* json);

    SamiPostitUpdatePostItTableResponse* fromJson(String* obj);

    

private:
    
};

} /* namespace Swagger */

#endif /* SamiPostitUpdatePostItTableResponse_H_ */
