/*
 * SamiPostitUpdatePostItTable.h
 * 
 * 
 */

#ifndef SamiPostitUpdatePostItTable_H_
#define SamiPostitUpdatePostItTable_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FWebJson.h>
#include "SamiHelpers.h"
#include "SamiObject.h"

using namespace Tizen::Web::Json;


using Tizen::Base::String;


namespace Swagger {

class SamiPostitUpdatePostItTable: public SamiObject {
public:
    SamiPostitUpdatePostItTable();
    SamiPostitUpdatePostItTable(String* json);
    virtual ~SamiPostitUpdatePostItTable();

    void init();

    void cleanup();

    String asJson ();

    JsonObject* asJsonObject();

    void fromJsonObject(IJsonValue* json);

    SamiPostitUpdatePostItTable* fromJson(String* obj);

    
    String* getPApiKey();
    void setPApiKey(String* pApi_key);
    
    String* getPPath();
    void setPPath(String* pPath);
    
    String* getPSchema();
    void setPSchema(String* pSchema);
    

private:
    String* pApi_key;
    String* pPath;
    String* pSchema;
    
};

} /* namespace Swagger */

#endif /* SamiPostitUpdatePostItTable_H_ */
