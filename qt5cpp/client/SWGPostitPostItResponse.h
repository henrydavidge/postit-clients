/*
 * SWGPostitPostItResponse.h
 * 
 * 
 */

#ifndef SWGPostitPostItResponse_H_
#define SWGPostitPostItResponse_H_

#include <QJsonObject>



#include "SWGObject.h"


namespace Swagger {

class SWGPostitPostItResponse: public SWGObject {
public:
    SWGPostitPostItResponse();
    SWGPostitPostItResponse(QString* json);
    virtual ~SWGPostitPostItResponse();
    void init();
    void cleanup();

    QString asJson ();
    QJsonObject* asJsonObject();
    void fromJsonObject(QJsonObject &json);
    SWGPostitPostItResponse* fromJson(QString &jsonString);

    

private:
    
};

} /* namespace Swagger */

#endif /* SWGPostitPostItResponse_H_ */
