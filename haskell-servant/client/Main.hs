{-# LANGUAGE DataKinds #-}
{-# LANGUAGE DeriveGeneric #-}
{-# LANGUAGE TypeOperators #-}

module Main where

import Control.Monad (void)
import Control.Monad.Trans.Either
import Control.Monad.IO.Class
import Servant.API
import Servant.Client

import Data.List.Split (splitOn)
import Network.URI (URI (..), URIAuth (..), parseURI)
import Data.Maybe (fromMaybe)
import Test.QuickCheck
import Control.Monad
import Model.PostitCreatePostItTable
import Model.PostitCreatePostItTableResponse
import Model.PostitDeleteApiKey
import Model.PostitDeleteApiKeyResponse
import Model.PostitPostIt
import Model.PostitPostItResponse
import Model.PostitRegenerateApiKey
import Model.PostitRegenerateApiKeyResponse
import Model.PostitUpdatePostItTable
import Model.PostitUpdatePostItTableResponse
import Api.PostItServiceApi

-- userClient :: IO ()
-- userClient = do 
--     users <- sample' (arbitrary :: Gen String)
--     let user = last users
--     void . runEitherT $ do
--         getUserByName user >>= (liftIO . putStrLn . show)

main :: IO ()
main = putStrLn "Hello Server!"
