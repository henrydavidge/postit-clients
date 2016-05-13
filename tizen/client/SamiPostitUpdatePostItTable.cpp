
#include "SamiPostitUpdatePostItTable.h"
#include <FLocales.h>

using namespace Tizen::Base;
using namespace Tizen::System;
using namespace Tizen::Base::Utility;
using namespace Tizen::Base::Collection;
using namespace Tizen::Web::Json;
using namespace Tizen::Locales;


namespace Swagger {

SamiPostitUpdatePostItTable::SamiPostitUpdatePostItTable() {
    init();
}

SamiPostitUpdatePostItTable::~SamiPostitUpdatePostItTable() {
    this->cleanup();
}

void
SamiPostitUpdatePostItTable::init() {
    pApi_key = null;
    pPath = null;
    pSchema = null;
    
}

void
SamiPostitUpdatePostItTable::cleanup() {
    if(pApi_key != null) {
        
        delete pApi_key;
        pApi_key = null;
    }
    if(pPath != null) {
        
        delete pPath;
        pPath = null;
    }
    if(pSchema != null) {
        
        delete pSchema;
        pSchema = null;
    }
    
}


SamiPostitUpdatePostItTable*
SamiPostitUpdatePostItTable::fromJson(String* json) {
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
SamiPostitUpdatePostItTable::fromJsonObject(IJsonValue* pJson) {
    JsonObject* pJsonObject = static_cast< JsonObject* >(pJson);

    if(pJsonObject != null) {
        JsonString* pApi_keyKey = new JsonString(L"api_key");
        IJsonValue* pApi_keyVal = null;
        pJsonObject->GetValue(pApi_keyKey, pApi_keyVal);
        if(pApi_keyVal != null) {
            
            pApi_key = new String();
            jsonToValue(pApi_key, pApi_keyVal, L"String", L"String");
        }
        delete pApi_keyKey;
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
        
    }
}

SamiPostitUpdatePostItTable::SamiPostitUpdatePostItTable(String* json) {
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
SamiPostitUpdatePostItTable::asJson ()
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
SamiPostitUpdatePostItTable::asJsonObject() {
    JsonObject *pJsonObject = new JsonObject();
    pJsonObject->Construct();

    
    JsonString *pApi_keyKey = new JsonString(L"api_key");
    pJsonObject->Add(pApi_keyKey, toJson(getPApiKey(), "String", ""));

    
    JsonString *pPathKey = new JsonString(L"path");
    pJsonObject->Add(pPathKey, toJson(getPPath(), "String", ""));

    
    JsonString *pSchemaKey = new JsonString(L"schema");
    pJsonObject->Add(pSchemaKey, toJson(getPSchema(), "String", ""));

    
    return pJsonObject;
}

String*
SamiPostitUpdatePostItTable::getPApiKey() {
    return pApi_key;
}
void
SamiPostitUpdatePostItTable::setPApiKey(String* pApi_key) {
    this->pApi_key = pApi_key;
}

String*
SamiPostitUpdatePostItTable::getPPath() {
    return pPath;
}
void
SamiPostitUpdatePostItTable::setPPath(String* pPath) {
    this->pPath = pPath;
}

String*
SamiPostitUpdatePostItTable::getPSchema() {
    return pSchema;
}
void
SamiPostitUpdatePostItTable::setPSchema(String* pSchema) {
    this->pSchema = pSchema;
}



} /* namespace Swagger */

