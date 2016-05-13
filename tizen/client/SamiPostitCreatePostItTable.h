/*
 * SamiPostitCreatePostItTable.h
 * 
 * 
 */

#ifndef SamiPostitCreatePostItTable_H_
#define SamiPostitCreatePostItTable_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FWebJson.h>
#include "SamiHelpers.h"
#include "SamiObject.h"

using namespace Tizen::Web::Json;


using Tizen::Base::String;


namespace Swagger {

class SamiPostitCreatePostItTable: public SamiObject {
public:
    SamiPostitCreatePostItTable();
    SamiPostitCreatePostItTable(String* json);
    virtual ~SamiPostitCreatePostItTable();

    void init();

    void cleanup();

    String asJson ();

    JsonObject* asJsonObject();

    void fromJsonObject(IJsonValue* json);

    SamiPostitCreatePostItTable* fromJson(String* obj);

    
    String* getPPath();
    void setPPath(String* pPath);
    
    String* getPSchema();
    void setPSchema(String* pSchema);
    
    String* getPShardName();
    void setPShardName(String* pShard_name);
    

private:
    String* pPath;
    String* pSchema;
    String* pShard_name;
    
};

} /* namespace Swagger */

#endif /* SamiPostitCreatePostItTable_H_ */
