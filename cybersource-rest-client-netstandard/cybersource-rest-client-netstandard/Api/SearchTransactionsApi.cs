/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using CyberSource.Client;
using CyberSource.Model;
using NLog;
using AuthenticationSdk.util;

namespace CyberSource.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISearchTransactionsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a Search Request
        /// </summary>
        /// <remarks>
        /// Create a search request. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createSearchRequest"></param>
        /// <returns>TssV2TransactionsPost201Response</returns>
        TssV2TransactionsPost201Response CreateSearch (CreateSearchRequest createSearchRequest);

        /// <summary>
        /// Create a Search Request
        /// </summary>
        /// <remarks>
        /// Create a search request. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createSearchRequest"></param>
        /// <returns>ApiResponse of TssV2TransactionsPost201Response</returns>
        ApiResponse<TssV2TransactionsPost201Response> CreateSearchWithHttpInfo (CreateSearchRequest createSearchRequest);
        /// <summary>
        /// Get Search Results
        /// </summary>
        /// <remarks>
        /// Include the Search ID in the GET request to retrieve the search results.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchId">Search ID.</param>
        /// <returns>TssV2TransactionsPost201Response</returns>
        TssV2TransactionsPost201Response GetSearch (string searchId);

        /// <summary>
        /// Get Search Results
        /// </summary>
        /// <remarks>
        /// Include the Search ID in the GET request to retrieve the search results.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchId">Search ID.</param>
        /// <returns>ApiResponse of TssV2TransactionsPost201Response</returns>
        ApiResponse<TssV2TransactionsPost201Response> GetSearchWithHttpInfo (string searchId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create a Search Request
        /// </summary>
        /// <remarks>
        /// Create a search request. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createSearchRequest"></param>
        /// <returns>Task of TssV2TransactionsPost201Response</returns>
        System.Threading.Tasks.Task<TssV2TransactionsPost201Response> CreateSearchAsync (CreateSearchRequest createSearchRequest);

        /// <summary>
        /// Create a Search Request
        /// </summary>
        /// <remarks>
        /// Create a search request. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createSearchRequest"></param>
        /// <returns>Task of ApiResponse (TssV2TransactionsPost201Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<TssV2TransactionsPost201Response>> CreateSearchAsyncWithHttpInfo (CreateSearchRequest createSearchRequest);
        /// <summary>
        /// Get Search Results
        /// </summary>
        /// <remarks>
        /// Include the Search ID in the GET request to retrieve the search results.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchId">Search ID.</param>
        /// <returns>Task of TssV2TransactionsPost201Response</returns>
        System.Threading.Tasks.Task<TssV2TransactionsPost201Response> GetSearchAsync (string searchId);

        /// <summary>
        /// Get Search Results
        /// </summary>
        /// <remarks>
        /// Include the Search ID in the GET request to retrieve the search results.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchId">Search ID.</param>
        /// <returns>Task of ApiResponse (TssV2TransactionsPost201Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<TssV2TransactionsPost201Response>> GetSearchAsyncWithHttpInfo (string searchId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SearchTransactionsApi : ISearchTransactionsApi
    {
        private static Logger logger;
        private ExceptionFactory _exceptionFactory = (name, response) => null;
        private int? _statusCode;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchTransactionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SearchTransactionsApi(string basePath)
        {
            Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                Configuration.ApiClient.Configuration = Configuration;
            }

            if (logger == null)
            {
                logger = LogManager.GetCurrentClassLogger();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchTransactionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SearchTransactionsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                Configuration = Configuration.Default;
            else
                Configuration = configuration;

            ExceptionFactory = Configuration.DefaultExceptionFactory;

            Configuration.ApiClient.Configuration = Configuration;

            if (logger == null)
            {
                logger = LogManager.GetCurrentClassLogger();
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(string basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    logger.Error("InvalidOperationException : Multicast delegate for ExceptionFactory is unsupported.");
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<string, string> DefaultHeader()
        {
            return Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Retrieves the status code being set for the most recently executed API request.
        /// </summary>
        /// <returns>Status Code of previous request</returns>
        public int GetStatusCode()
        {
            return this._statusCode == null ? 0 : (int) this._statusCode;
        }

        /// <summary>
        /// Sets the value of status code for the most recently executed API request, in order to be retrieved later.
        /// </summary>
        /// <param name="statusCode">Status Code to be set</param>
        /// <returns></returns>
        public void SetStatusCode(int? statusCode)
        {
            this._statusCode = statusCode;
        }

        /// <summary>
        /// Create a Search Request Create a search request. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createSearchRequest"></param>
        /// <returns>TssV2TransactionsPost201Response</returns>
        public TssV2TransactionsPost201Response CreateSearch (CreateSearchRequest createSearchRequest)
        {
            logger.Debug("CALLING API \"CreateSearch\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<TssV2TransactionsPost201Response> localVarResponse = CreateSearchWithHttpInfo(createSearchRequest);
            logger.Debug("CALLING API \"CreateSearch\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Search Request Create a search request. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createSearchRequest"></param>
        /// <returns>ApiResponse of TssV2TransactionsPost201Response</returns>
        public ApiResponse< TssV2TransactionsPost201Response > CreateSearchWithHttpInfo (CreateSearchRequest createSearchRequest)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'createSearchRequest' is set
            if (createSearchRequest == null)
            {
                logger.Error("ApiException : Missing required parameter 'createSearchRequest' when calling SearchTransactionsApi->CreateSearch");
                throw new ApiException(400, "Missing required parameter 'createSearchRequest' when calling SearchTransactionsApi->CreateSearch");
            }

            var localVarPath = $"/tss/v2/searches";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json;charset=utf-8"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json;charset=utf-8"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (createSearchRequest != null && createSearchRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(createSearchRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createSearchRequest; // byte array
            }

            if (logUtility.IsMaskingEnabled(logger))
            {
                logger.Debug($"HTTP Request Body :\n{logUtility.MaskSensitiveData(localVarPostBody.ToString())}");
            }
            else
            {
                logger.Debug($"HTTP Request Body :\n{localVarPostBody}");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateSearch", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<TssV2TransactionsPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TssV2TransactionsPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TssV2TransactionsPost201Response))); // Return statement
        }

        /// <summary>
        /// Create a Search Request Create a search request. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createSearchRequest"></param>
        /// <returns>Task of TssV2TransactionsPost201Response</returns>
        public async System.Threading.Tasks.Task<TssV2TransactionsPost201Response> CreateSearchAsync (CreateSearchRequest createSearchRequest)
        {
            logger.Debug("CALLING API \"CreateSearchAsync\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<TssV2TransactionsPost201Response> localVarResponse = await CreateSearchAsyncWithHttpInfo(createSearchRequest);
            logger.Debug("CALLING API \"CreateSearchAsync\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Search Request Create a search request. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createSearchRequest"></param>
        /// <returns>Task of ApiResponse (TssV2TransactionsPost201Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TssV2TransactionsPost201Response>> CreateSearchAsyncWithHttpInfo (CreateSearchRequest createSearchRequest)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'createSearchRequest' is set
            if (createSearchRequest == null)
            {
                logger.Error("ApiException : Missing required parameter 'createSearchRequest' when calling SearchTransactionsApi->CreateSearch");
                throw new ApiException(400, "Missing required parameter 'createSearchRequest' when calling SearchTransactionsApi->CreateSearch");
            }

            var localVarPath = $"/tss/v2/searches";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json;charset=utf-8"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json;charset=utf-8"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (createSearchRequest != null && createSearchRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(createSearchRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createSearchRequest; // byte array
            }

            if (logUtility.IsMaskingEnabled(logger))
            {
                logger.Debug($"HTTP Request Body :\n{logUtility.MaskSensitiveData(localVarPostBody.ToString())}");
            }
            else
            {
                logger.Debug($"HTTP Request Body :\n{localVarPostBody}");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateSearch", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<TssV2TransactionsPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TssV2TransactionsPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TssV2TransactionsPost201Response))); // Return statement
        }
        /// <summary>
        /// Get Search Results Include the Search ID in the GET request to retrieve the search results.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchId">Search ID.</param>
        /// <returns>TssV2TransactionsPost201Response</returns>
        public TssV2TransactionsPost201Response GetSearch (string searchId)
        {
            logger.Debug("CALLING API \"GetSearch\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<TssV2TransactionsPost201Response> localVarResponse = GetSearchWithHttpInfo(searchId);
            logger.Debug("CALLING API \"GetSearch\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Search Results Include the Search ID in the GET request to retrieve the search results.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchId">Search ID.</param>
        /// <returns>ApiResponse of TssV2TransactionsPost201Response</returns>
        public ApiResponse< TssV2TransactionsPost201Response > GetSearchWithHttpInfo (string searchId)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'searchId' is set
            if (searchId == null)
            {
                logger.Error("ApiException : Missing required parameter 'searchId' when calling SearchTransactionsApi->GetSearch");
                throw new ApiException(400, "Missing required parameter 'searchId' when calling SearchTransactionsApi->GetSearch");
            }

            var localVarPath = $"/tss/v2/searches/{searchId}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json;charset=utf-8"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "*/*"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (searchId != null)
            {
                localVarPathParams.Add("searchId", Configuration.ApiClient.ParameterToString(searchId)); // path parameter
            }
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarPathParams)}");
            if (Method.GET == Method.POST)
            {
                localVarPostBody = "{}";
            }
            else
            {
                localVarPostBody = null;
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSearch", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<TssV2TransactionsPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TssV2TransactionsPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TssV2TransactionsPost201Response))); // Return statement
        }

        /// <summary>
        /// Get Search Results Include the Search ID in the GET request to retrieve the search results.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchId">Search ID.</param>
        /// <returns>Task of TssV2TransactionsPost201Response</returns>
        public async System.Threading.Tasks.Task<TssV2TransactionsPost201Response> GetSearchAsync (string searchId)
        {
            logger.Debug("CALLING API \"GetSearchAsync\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<TssV2TransactionsPost201Response> localVarResponse = await GetSearchAsyncWithHttpInfo(searchId);
            logger.Debug("CALLING API \"GetSearchAsync\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Get Search Results Include the Search ID in the GET request to retrieve the search results.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchId">Search ID.</param>
        /// <returns>Task of ApiResponse (TssV2TransactionsPost201Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TssV2TransactionsPost201Response>> GetSearchAsyncWithHttpInfo (string searchId)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'searchId' is set
            if (searchId == null)
            {
                logger.Error("ApiException : Missing required parameter 'searchId' when calling SearchTransactionsApi->GetSearch");
                throw new ApiException(400, "Missing required parameter 'searchId' when calling SearchTransactionsApi->GetSearch");
            }

            var localVarPath = $"/tss/v2/searches/{searchId}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json;charset=utf-8"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "*/*"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (searchId != null)
            {
                localVarPathParams.Add("searchId", Configuration.ApiClient.ParameterToString(searchId)); // path parameter
            }
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarPathParams)}");
            if (Method.GET == Method.POST)
            {
                localVarPostBody = "{}";
            }
            else
            {
                localVarPostBody = null;
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSearch", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<TssV2TransactionsPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TssV2TransactionsPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TssV2TransactionsPost201Response))); // Return statement
        }
    }
}