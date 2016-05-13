#ifndef _SWG_SWGPostItServiceApi_H_
#define _SWG_SWGPostItServiceApi_H_

#include "SWGHttpRequest.h"

#include "SWGPostitCreatePostItTableResponse.h"
#include "SWGPostitCreatePostItTable.h"
#include "SWGPostitDeleteApiKeyResponse.h"
#include "SWGPostitDeleteApiKey.h"
#include "SWGPostitPostItResponse.h"
#include "SWGPostitPostIt.h"
#include "SWGPostitRegenerateApiKeyResponse.h"
#include "SWGPostitRegenerateApiKey.h"
#include "SWGPostitUpdatePostItTableResponse.h"
#include "SWGPostitUpdatePostItTable.h"

#include <QObject>

namespace Swagger {

class SWGPostItServiceApi: public QObject {
    Q_OBJECT

public:
    SWGPostItServiceApi();
    SWGPostItServiceApi(QString host, QString basePath);
    ~SWGPostItServiceApi();

    QString host;
    QString basePath;

    void createPostItTable(SWGPostitCreatePostItTable body);
    void deleteApiKey(SWGPostitDeleteApiKey body);
    void postIt(SWGPostitPostIt body);
    void regenerateApiKey(SWGPostitRegenerateApiKey body);
    void updatePostItTable(SWGPostitUpdatePostItTable body);
    
private:
    void createPostItTableCallback (HttpRequestWorker * worker);
    void deleteApiKeyCallback (HttpRequestWorker * worker);
    void postItCallback (HttpRequestWorker * worker);
    void regenerateApiKeyCallback (HttpRequestWorker * worker);
    void updatePostItTableCallback (HttpRequestWorker * worker);
    
signals:
    void createPostItTableSignal(SWGPostitCreatePostItTableResponse* summary);
    void deleteApiKeySignal(SWGPostitDeleteApiKeyResponse* summary);
    void postItSignal(SWGPostitPostItResponse* summary);
    void regenerateApiKeySignal(SWGPostitRegenerateApiKeyResponse* summary);
    void updatePostItTableSignal(SWGPostitUpdatePostItTableResponse* summary);
    
};
}
#endif