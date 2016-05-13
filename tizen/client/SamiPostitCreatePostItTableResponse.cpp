
#include "SamiPostitCreatePostItTableResponse.h"
#include <FLocales.h>

using namespace Tizen::Base;
using namespace Tizen::System;
using namespace Tizen::Base::Utility;
using namespace Tizen::Base::Collection;
using namespace Tizen::Web::Json;
using namespace Tizen::Locales;


namespace Swagger {

SamiPostitCreatePostItTableResponse::SamiPostitCreatePostItTableResponse() {
    init();
}

SamiPostitCreatePostItTableResponse::~SamiPostitCreatePostItTableResponse() {
    this->cleanup();
}

void
SamiPostitCreatePostItTableResponse::init() {
    pApi_key = null;
    
}

void
SamiPostitCreatePostItTableResponse::cleanup() {
    if(pApi_key != null) {
        
        delete pApi_key;
        pApi_key = null;
    }
    
}


SamiPostitCreatePostItTableResponse*
SamiPostitCreatePostItTableResponse::fromJson(String* json) {
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
SamiPostitCreatePostItTableResponse::fromJsonObject(IJsonValue* pJson) {
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
        
    }
}

SamiPostitCreatePostItTableResponse::SamiPostitCreatePostItTableResponse(String* json) {
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
SamiPostitCreatePostItTableResponse::asJson ()
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
SamiPostitCreatePostItTableResponse::asJsonObject() {
    JsonObject *pJsonObject = new JsonObject();
    pJsonObject->Construct();

    
    JsonString *pApi_keyKey = new JsonString(L"api_key");
    pJsonObject->Add(pApi_keyKey, toJson(getPApiKey(), "String", ""));

    
    return pJsonObject;
}

String*
SamiPostitCreatePostItTableResponse::getPApiKey() {
    return pApi_key;
}
void
SamiPostitCreatePostItTableResponse::setPApiKey(String* pApi_key) {
    this->pApi_key = pApi_key;
}



} /* namespace Swagger */

