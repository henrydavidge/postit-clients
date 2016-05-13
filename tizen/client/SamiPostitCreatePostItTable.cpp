
#include "SamiPostitCreatePostItTable.h"
#include <FLocales.h>

using namespace Tizen::Base;
using namespace Tizen::System;
using namespace Tizen::Base::Utility;
using namespace Tizen::Base::Collection;
using namespace Tizen::Web::Json;
using namespace Tizen::Locales;


namespace Swagger {

SamiPostitCreatePostItTable::SamiPostitCreatePostItTable() {
    init();
}

SamiPostitCreatePostItTable::~SamiPostitCreatePostItTable() {
    this->cleanup();
}

void
SamiPostitCreatePostItTable::init() {
    pPath = null;
    pSchema = null;
    pShard_name = null;
    
}

void
SamiPostitCreatePostItTable::cleanup() {
    if(pPath != null) {
        
        delete pPath;
        pPath = null;
    }
    if(pSchema != null) {
        
        delete pSchema;
        pSchema = null;
    }
    if(pShard_name != null) {
        
        delete pShard_name;
        pShard_name = null;
    }
    
}


SamiPostitCreatePostItTable*
SamiPostitCreatePostItTable::fromJson(String* json) {
    this->cleanup();
    String str(json->GetPointer());
    int length = str.GetLength();

    ByteBuffer buffer;
    buffer.Construct(length);

    for (int i = 0; i < length; ++i) {
       byte b = str[i];
       buffer.SetByte(b);
    }

    IJsonValue* pJson = JsonParser::ParseN(buffer);
    fromJsonObject(pJson);
    if (pJson->GetType() == JSON_TYPE_OBJECT) {
       JsonObject* pObject = static_cast< JsonObject* >(pJson);
       pObject->RemoveAll(true);
    }
    else if (pJson->GetType() == JSON_TYPE_ARRAY) {
       JsonArray* pArray = static_cast< JsonArray* >(pJson);
       pArray->RemoveAll(true);
    }
    delete pJson;
    return this;
}


void
SamiPostitCreatePostItTable::fromJsonObject(IJsonValue* pJson) {
    JsonObject* pJsonObject = static_cast< JsonObject* >(pJson);

    if(pJsonObject != null) {
        JsonString* pPathKey = new JsonString(L"path");
        IJsonValue* pPathVal = null;
        pJsonObject->GetValue(pPathKey, pPathVal);
        if(pPathVal != null) {
            
            pPath = new String();
            jsonToValue(pPath, pPathVal, L"String", L"String");
        }
        delete pPathKey;
        JsonString* pSchemaKey = new JsonString(L"schema");
        IJsonValue* pSchemaVal = null;
        pJsonObject->GetValue(pSchemaKey, pSchemaVal);
        if(pSchemaVal != null) {
            
            pSchema = new String();
            jsonToValue(pSchema, pSchemaVal, L"String", L"String");
        }
        delete pSchemaKey;
        JsonString* pShard_nameKey = new JsonString(L"shard_name");
        IJsonValue* pShard_nameVal = null;
        pJsonObject->GetValue(pShard_nameKey, pShard_nameVal);
        if(pShard_nameVal != null) {
            
            pShard_name = new String();
            jsonToValue(pShard_name, pShard_nameVal, L"String", L"String");
        }
        delete pShard_nameKey;
        
    }
}

SamiPostitCreatePostItTable::SamiPostitCreatePostItTable(String* json) {
    init();
    String str(json->GetPointer());
    int length = str.GetLength();

    ByteBuffer buffer;
    buffer.Construct(length);

    for (int i = 0; i < length; ++i) {
       byte b = str[i];
       buffer.SetByte(b);
    }

    IJsonValue* pJson = JsonParser::ParseN(buffer);
    fromJsonObject(pJson);
    if (pJson->GetType() == JSON_TYPE_OBJECT) {
       JsonObject* pObject = static_cast< JsonObject* >(pJson);
       pObject->RemoveAll(true);
    }
    else if (pJson->GetType() == JSON_TYPE_ARRAY) {
       JsonArray* pArray = static_cast< JsonArray* >(pJson);
       pArray->RemoveAll(true);
    }
    delete pJson;
}

String
SamiPostitCreatePostItTable::asJson ()
{
    JsonObject* pJsonObject = asJsonObject();

    char *pComposeBuf = new char[256];
    JsonWriter::Compose(pJsonObject, pComposeBuf, 256);
    String s = String(pComposeBuf);

    delete pComposeBuf;
    pJsonObject->RemoveAll(true);
    delete pJsonObject;

    return s;
}

JsonObject*
SamiPostitCreatePostItTable::asJsonObject() {
    JsonObject *pJsonObject = new JsonObject();
    pJsonObject->Construct();

    
    JsonString *pPathKey = new JsonString(L"path");
    pJsonObject->Add(pPathKey, toJson(getPPath(), "String", ""));

    
    JsonString *pSchemaKey = new JsonString(L"schema");
    pJsonObject->Add(pSchemaKey, toJson(getPSchema(), "String", ""));

    
    JsonString *pShard_nameKey = new JsonString(L"shard_name");
    pJsonObject->Add(pShard_nameKey, toJson(getPShardName(), "String", ""));

    
    return pJsonObject;
}

String*
SamiPostitCreatePostItTable::getPPath() {
    return pPath;
}
void
SamiPostitCreatePostItTable::setPPath(String* pPath) {
    this->pPath = pPath;
}

String*
SamiPostitCreatePostItTable::getPSchema() {
    return pSchema;
}
void
SamiPostitCreatePostItTable::setPSchema(String* pSchema) {
    this->pSchema = pSchema;
}

String*
SamiPostitCreatePostItTable::getPShardName() {
    return pShard_name;
}
void
SamiPostitCreatePostItTable::setPShardName(String* pShard_name) {
    this->pShard_name = pShard_name;
}



} /* namespace Swagger */

