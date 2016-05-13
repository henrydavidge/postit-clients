/*
 * SamiPostitPostIt.h
 * 
 * 
 */

#ifndef SamiPostitPostIt_H_
#define SamiPostitPostIt_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FWebJson.h>
#include "SamiHelpers.h"
#include "SamiObject.h"

using namespace Tizen::Web::Json;


using Tizen::Base::Long;
using Tizen::Base::String;


namespace Swagger {

class SamiPostitPostIt: public SamiObject {
public:
    SamiPostitPostIt();
    SamiPostitPostIt(String* json);
    virtual ~SamiPostitPostIt();

    void init();

    void cleanup();

    String asJson ();

    JsonObject* asJsonObject();

    void fromJsonObject(IJsonValue* json);

    SamiPostitPostIt* fromJson(String* obj);

    
    String* getPApiKey();
    void setPApiKey(String* pApi_key);
    
    Long* getPEventTime();
    void setPEventTime(Long* pEvent_time);
    
    String* getPPayload();
    void setPPayload(String* pPayload);
    

private:
    String* pApi_key;
    Long* pEvent_time;
    String* pPayload;
    
};

} /* namespace Swagger */

#endif /* SamiPostitPostIt_H_ */
