<?php
/**
 * 
 * @version 
 */

require_once __DIR__ . '/vendor/autoload.php';

$app = new Slim\App();


/**
 * POST createPostItTable
 * Summary: PostItService.createPostItTable
 * Notes: 
 * Output-Formats: [application/json]
 */
$app->POST('/api/1.0/create', function($request, $response, $args) {
            
            
            
            $body = $request->getParsedBody();
            $response->write('How about implementing createPostItTable as a POST method ?');
            return $response;
            });


/**
 * POST deleteApiKey
 * Summary: PostItService.deleteApiKey
 * Notes: 
 * Output-Formats: [application/json]
 */
$app->POST('/api/1.0/delete', function($request, $response, $args) {
            
            
            
            $body = $request->getParsedBody();
            $response->write('How about implementing deleteApiKey as a POST method ?');
            return $response;
            });


/**
 * POST postIt
 * Summary: PostItService.postIt
 * Notes: 
 * Output-Formats: [application/json]
 */
$app->POST('/api/1.0/post', function($request, $response, $args) {
            
            
            
            $body = $request->getParsedBody();
            $response->write('How about implementing postIt as a POST method ?');
            return $response;
            });


/**
 * POST regenerateApiKey
 * Summary: PostItService.regenerateApiKey
 * Notes: 
 * Output-Formats: [application/json]
 */
$app->POST('/api/1.0/regenerate', function($request, $response, $args) {
            
            
            
            $body = $request->getParsedBody();
            $response->write('How about implementing regenerateApiKey as a POST method ?');
            return $response;
            });


/**
 * POST updatePostItTable
 * Summary: PostItService.updatePostItTable
 * Notes: 
 * Output-Formats: [application/json]
 */
$app->POST('/api/1.0/update', function($request, $response, $args) {
            
            
            
            $body = $request->getParsedBody();
            $response->write('How about implementing updatePostItTable as a POST method ?');
            return $response;
            });



$app->run();
