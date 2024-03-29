=begin


OpenAPI spec version: 

Generated by: https://github.com/swagger-api/swagger-codegen.git


=end

require 'spec_helper'
require 'json'

# Unit tests for SwaggerClient::PostItServiceApi
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'PostItServiceApi' do
  before do
    # run before each test
    @instance = SwaggerClient::PostItServiceApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of PostItServiceApi' do
    it 'should create an instact of PostItServiceApi' do
      @instance.should be_a(SwaggerClient::PostItServiceApi)
    end
  end

  # unit tests for create_post_it_table
  # PostItService.createPostItTable
  # 
  # @param body 
  # @param [Hash] opts the optional parameters
  # @return [PostitCreatePostItTableResponse]
  describe 'create_post_it_table test' do
    it "should work" do
      # assertion here
      # should be_a()
      # should be_nil
      # should ==
      # should_not ==
    end
  end

  # unit tests for delete_api_key
  # PostItService.deleteApiKey
  # 
  # @param body 
  # @param [Hash] opts the optional parameters
  # @return [PostitDeleteApiKeyResponse]
  describe 'delete_api_key test' do
    it "should work" do
      # assertion here
      # should be_a()
      # should be_nil
      # should ==
      # should_not ==
    end
  end

  # unit tests for post_it
  # PostItService.postIt
  # 
  # @param body 
  # @param [Hash] opts the optional parameters
  # @return [PostitPostItResponse]
  describe 'post_it test' do
    it "should work" do
      # assertion here
      # should be_a()
      # should be_nil
      # should ==
      # should_not ==
    end
  end

  # unit tests for regenerate_api_key
  # PostItService.regenerateApiKey
  # 
  # @param body 
  # @param [Hash] opts the optional parameters
  # @return [PostitRegenerateApiKeyResponse]
  describe 'regenerate_api_key test' do
    it "should work" do
      # assertion here
      # should be_a()
      # should be_nil
      # should ==
      # should_not ==
    end
  end

  # unit tests for update_post_it_table
  # PostItService.updatePostItTable
  # 
  # @param body 
  # @param [Hash] opts the optional parameters
  # @return [PostitUpdatePostItTableResponse]
  describe 'update_post_it_table test' do
    it "should work" do
      # assertion here
      # should be_a()
      # should be_nil
      # should ==
      # should_not ==
    end
  end

end
