#include "SWGPostItServiceApi.h"
#include "SWGHelpers.h"
#include "SWGModelFactory.h"

#include <QJsonArray>
#include <QJsonDocument>

namespace Swagger {
SWGPostItServiceApi::SWGPostItServiceApi() {}

SWGPostItServiceApi::~SWGPostItServiceApi() {}

SWGPostItServiceApi::SWGPostItServiceApi(QString host, QString basePath) {
    this->host = host;
    this->basePath = basePath;
}

void
SWGPostItServiceApi::createPostItTable(SWGPostitCreatePostItTable body) {
    QString fullPath;
    fullPath.append(this->host).append(this->basePath).append("/api/1.0/create");

    

    

    HttpRequestWorker *worker = new HttpRequestWorker();
    HttpRequestInput input(fullPath, "POST");

    

    
    
    
    QString output = body.asJson();
    input.request_body.append(output);
    

    

    connect(worker,
            &HttpRequestWorker::on_execution_finished,
            this,
            &SWGPostItServiceApi::createPostItTableCallback);

    worker->execute(&input);
}

void
SWGPostItServiceApi::createPostItTableCallback(HttpRequestWorker * worker) {
    QString msg;
    if (worker->error_type == QNetworkReply::NoError) {
        msg = QString("Success! %1 bytes").arg(worker->response.length());
    }
    else {
        msg = "Error: " + worker->error_str;
    }

    

    
    
    
    QString json(worker->response);
    SWGPostitCreatePostItTableResponse* output = static_cast<SWGPostitCreatePostItTableResponse*>(create(json, QString("SWGPostitCreatePostItTableResponse")));
    
    
    

    worker->deleteLater();

    emit createPostItTableSignal(output);
    
}
void
SWGPostItServiceApi::deleteApiKey(SWGPostitDeleteApiKey body) {
    QString fullPath;
    fullPath.append(this->host).append(this->basePath).append("/api/1.0/delete");

    

    

    HttpRequestWorker *worker = new HttpRequestWorker();
    HttpRequestInput input(fullPath, "POST");

    

    
    
    
    QString output = body.asJson();
    input.request_body.append(output);
    

    

    connect(worker,
            &HttpRequestWorker::on_execution_finished,
            this,
            &SWGPostItServiceApi::deleteApiKeyCallback);

    worker->execute(&input);
}

void
SWGPostItServiceApi::deleteApiKeyCallback(HttpRequestWorker * worker) {
    QString msg;
    if (worker->error_type == QNetworkReply::NoError) {
        msg = QString("Success! %1 bytes").arg(worker->response.length());
    }
    else {
        msg = "Error: " + worker->error_str;
    }

    

    
    
    
    QString json(worker->response);
    SWGPostitDeleteApiKeyResponse* output = static_cast<SWGPostitDeleteApiKeyResponse*>(create(json, QString("SWGPostitDeleteApiKeyResponse")));
    
    
    

    worker->deleteLater();

    emit deleteApiKeySignal(output);
    
}
void
SWGPostItServiceApi::postIt(SWGPostitPostIt body) {
    QString fullPath;
    fullPath.append(this->host).append(this->basePath).append("/api/1.0/post");

    

    

    HttpRequestWorker *worker = new HttpRequestWorker();
    HttpRequestInput input(fullPath, "POST");

    

    
    
    
    QString output = body.asJson();
    input.request_body.append(output);
    

    

    connect(worker,
            &HttpRequestWorker::on_execution_finished,
            this,
            &SWGPostItServiceApi::postItCallback);

    worker->execute(&input);
}

void
SWGPostItServiceApi::postItCallback(HttpRequestWorker * worker) {
    QString msg;
    if (worker->error_type == QNetworkReply::NoError) {
        msg = QString("Success! %1 bytes").arg(worker->response.length());
    }
    else {
        msg = "Error: " + worker->error_str;
    }

    

    
    
    
    QString json(worker->response);
    SWGPostitPostItResponse* output = static_cast<SWGPostitPostItResponse*>(create(json, QString("SWGPostitPostItResponse")));
    
    
    

    worker->deleteLater();

    emit postItSignal(output);
    
}
void
SWGPostItServiceApi::regenerateApiKey(SWGPostitRegenerateApiKey body) {
    QString fullPath;
    fullPath.append(this->host).append(this->basePath).append("/api/1.0/regenerate");

    

    

    HttpRequestWorker *worker = new HttpRequestWorker();
    HttpRequestInput input(fullPath, "POST");

    

    
    
    
    QString output = body.asJson();
    input.request_body.append(output);
    

    

    connect(worker,
            &HttpRequestWorker::on_execution_finished,
            this,
            &SWGPostItServiceApi::regenerateApiKeyCallback);

    worker->execute(&input);
}

void
SWGPostItServiceApi::regenerateApiKeyCallback(HttpRequestWorker * worker) {
    QString msg;
    if (worker->error_type == QNetworkReply::NoError) {
        msg = QString("Success! %1 bytes").arg(worker->response.length());
    }
    else {
        msg = "Error: " + worker->error_str;
    }

    

    
    
    
    QString json(worker->response);
    SWGPostitRegenerateApiKeyResponse* output = static_cast<SWGPostitRegenerateApiKeyResponse*>(create(json, QString("SWGPostitRegenerateApiKeyResponse")));
    
    
    

    worker->deleteLater();

    emit regenerateApiKeySignal(output);
    
}
void
SWGPostItServiceApi::updatePostItTable(SWGPostitUpdatePostItTable body) {
    QString fullPath;
    fullPath.append(this->host).append(this->basePath).append("/api/1.0/update");

    

    

    HttpRequestWorker *worker = new HttpRequestWorker();
    HttpRequestInput input(fullPath, "POST");

    

    
    
    
    QString output = body.asJson();
    input.request_body.append(output);
    

    

    connect(worker,
            &HttpRequestWorker::on_execution_finished,
            this,
            &SWGPostItServiceApi::updatePostItTableCallback);

    worker->execute(&input);
}

void
SWGPostItServiceApi::updatePostItTableCallback(HttpRequestWorker * worker) {
    QString msg;
    if (worker->error_type == QNetworkReply::NoError) {
        msg = QString("Success! %1 bytes").arg(worker->response.length());
    }
    else {
        msg = "Error: " + worker->error_str;
    }

    

    
    
    
    QString json(worker->response);
    SWGPostitUpdatePostItTableResponse* output = static_cast<SWGPostitUpdatePostItTableResponse*>(create(json, QString("SWGPostitUpdatePostItTableResponse")));
    
    
    

    worker->deleteLater();

    emit updatePostItTableSignal(output);
    
}
} /* namespace Swagger */
