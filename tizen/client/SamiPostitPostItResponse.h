/*
 * SamiPostitPostItResponse.h
 * 
 * 
 */

#ifndef SamiPostitPostItResponse_H_
#define SamiPostitPostItResponse_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FWebJson.h>
#include "SamiHelpers.h"
#include "SamiObject.h"

using namespace Tizen::Web::Json;




namespace Swagger {

class SamiPostitPostItResponse: public SamiObject {
public:
    SamiPostitPostItResponse();
    SamiPostitPostItResponse(String* json);
    virtual ~SamiPostitPostItResponse();

    void init();

    void cleanup();

    String asJson ();

    JsonObject* asJsonObject();

    void fromJsonObject(IJsonValue* json);

    SamiPostitPostItResponse* fromJson(String* obj);

    

private:
    
};

} /* namespace Swagger */

#endif /* SamiPostitPostItResponse_H_ */
