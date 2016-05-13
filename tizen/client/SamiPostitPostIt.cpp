
#include "SamiPostitPostIt.h"
#include <FLocales.h>

using namespace Tizen::Base;
using namespace Tizen::System;
using namespace Tizen::Base::Utility;
using namespace Tizen::Base::Collection;
using namespace Tizen::Web::Json;
using namespace Tizen::Locales;


namespace Swagger {

SamiPostitPostIt::SamiPostitPostIt() {
    init();
}

SamiPostitPostIt::~SamiPostitPostIt() {
    this->cleanup();
}

void
SamiPostitPostIt::init() {
    pApi_key = null;
    pEvent_time = null;
    pPayload = null;
    
}

void
SamiPostitPostIt::cleanup() {
    if(pApi_key != null) {
        
        delete pApi_key;
        pApi_key = null;
    }
    if(pEvent_time != null) {
        
        delete pEvent_time;
        pEvent_time = null;
    }
    if(pPayload != null) {
        
        delete pPayload;
        pPayload = null;
    }
    
}


SamiPostitPostIt*
SamiPostitPostIt::fromJson(String* json) {
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
SamiPostitPostIt::fromJsonObject(IJsonValue* pJson) {
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
        JsonString* pEvent_timeKey = new JsonString(L"event_time");
        IJsonValue* pEvent_timeVal = null;
        pJsonObject->GetValue(pEvent_timeKey, pEvent_timeVal);
        if(pEvent_timeVal != null) {
            
            pEvent_time = new Long();
            jsonToValue(pEvent_time, pEvent_timeVal, L"Long", L"Long");
        }
        delete pEvent_timeKey;
        JsonString* pPayloadKey = new JsonString(L"payload");
        IJsonValue* pPayloadVal = null;
        pJsonObject->GetValue(pPayloadKey, pPayloadVal);
        if(pPayloadVal != null) {
            
            pPayload = new String();
            jsonToValue(pPayload, pPayloadVal, L"String", L"String");
        }
        delete pPayloadKey;
        
    }
}

SamiPostitPostIt::SamiPostitPostIt(String* json) {
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
SamiPostitPostIt::asJson ()
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
SamiPostitPostIt::asJsonObject() {
    JsonObject *pJsonObject = new JsonObject();
    pJsonObject->Construct();

    
    JsonString *pApi_keyKey = new JsonString(L"api_key");
    pJsonObject->Add(pApi_keyKey, toJson(getPApiKey(), "String", ""));

    
    JsonString *pEvent_timeKey = new JsonString(L"event_time");
    pJsonObject->Add(pEvent_timeKey, toJson(getPEventTime(), "Long", ""));

    
    JsonString *pPayloadKey = new JsonString(L"payload");
    pJsonObject->Add(pPayloadKey, toJson(getPPayload(), "String", ""));

    
    return pJsonObject;
}

String*
SamiPostitPostIt::getPApiKey() {
    return pApi_key;
}
void
SamiPostitPostIt::setPApiKey(String* pApi_key) {
    this->pApi_key = pApi_key;
}

Long*
SamiPostitPostIt::getPEventTime() {
    return pEvent_time;
}
void
SamiPostitPostIt::setPEventTime(Long* pEvent_time) {
    this->pEvent_time = pEvent_time;
}

String*
SamiPostitPostIt::getPPayload() {
    return pPayload;
}
void
SamiPostitPostIt::setPPayload(String* pPayload) {
    this->pPayload = pPayload;
}



} /* namespace Swagger */

