<?php
require_once __DIR__ . '/vendor/autoload.php';

use Symfony\Component\HttpFoundation\Request;
use Symfony\Component\HttpFoundation\Response;
use Silex\Application;

$app = new Silex\Application();

    
        
            

$app->POST('/api/1.0/create', function(Application $app, Request $request) {
            
            
            return new Response('How about implementing createPostItTable as a POST method ?');
            });

            

$app->POST('/api/1.0/delete', function(Application $app, Request $request) {
            
            
            return new Response('How about implementing deleteApiKey as a POST method ?');
            });

            

$app->POST('/api/1.0/post', function(Application $app, Request $request) {
            
            
            return new Response('How about implementing postIt as a POST method ?');
            });

            

$app->POST('/api/1.0/regenerate', function(Application $app, Request $request) {
            
            
            return new Response('How about implementing regenerateApiKey as a POST method ?');
            });

            

$app->POST('/api/1.0/update', function(Application $app, Request $request) {
            
            
            return new Response('How about implementing updatePostItTable as a POST method ?');
            });

            
        
    

$app->run();
