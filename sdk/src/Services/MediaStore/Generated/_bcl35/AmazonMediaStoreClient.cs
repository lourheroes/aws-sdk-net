/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the mediastore-2017-09-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.MediaStore.Model;
using Amazon.MediaStore.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.MediaStore
{
    /// <summary>
    /// Implementation for accessing MediaStore
    ///
    /// An AWS Elemental MediaStore container is a namespace that holds folders and objects.
    /// You use a container endpoint to create, read, and delete objects.
    /// </summary>
    public partial class AmazonMediaStoreClient : AmazonServiceClient, IAmazonMediaStore
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonMediaStoreClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonMediaStoreClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMediaStoreConfig()) { }

        /// <summary>
        /// Constructs AmazonMediaStoreClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaStoreClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMediaStoreConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMediaStoreClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonMediaStoreClient Configuration Object</param>
        public AmazonMediaStoreClient(AmazonMediaStoreConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonMediaStoreClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMediaStoreClient(AWSCredentials credentials)
            : this(credentials, new AmazonMediaStoreConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaStoreClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaStoreClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMediaStoreConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaStoreClient with AWS Credentials and an
        /// AmazonMediaStoreClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMediaStoreClient Configuration Object</param>
        public AmazonMediaStoreClient(AWSCredentials credentials, AmazonMediaStoreConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMediaStoreClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMediaStoreClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMediaStoreConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaStoreClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaStoreClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMediaStoreConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaStoreClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMediaStoreClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMediaStoreClient Configuration Object</param>
        public AmazonMediaStoreClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMediaStoreConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMediaStoreClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMediaStoreClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMediaStoreConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaStoreClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaStoreClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMediaStoreConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaStoreClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMediaStoreClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMediaStoreClient Configuration Object</param>
        public AmazonMediaStoreClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMediaStoreConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }


        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  CreateContainer

        /// <summary>
        /// Creates a storage container to hold objects. A container is similar to a bucket in
        /// the Amazon S3 service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContainer service method.</param>
        /// 
        /// <returns>The response from the CreateContainer service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// Resource already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.LimitExceededException">
        /// A service limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/CreateContainer">REST API Reference for CreateContainer Operation</seealso>
        public virtual CreateContainerResponse CreateContainer(CreateContainerRequest request)
        {
            var marshaller = new CreateContainerRequestMarshaller();
            var unmarshaller = CreateContainerResponseUnmarshaller.Instance;

            return Invoke<CreateContainerRequest,CreateContainerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateContainer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateContainer operation on AmazonMediaStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateContainer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/CreateContainer">REST API Reference for CreateContainer Operation</seealso>
        public virtual IAsyncResult BeginCreateContainer(CreateContainerRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateContainerRequestMarshaller();
            var unmarshaller = CreateContainerResponseUnmarshaller.Instance;

            return BeginInvoke<CreateContainerRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateContainer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateContainer.</param>
        /// 
        /// <returns>Returns a  CreateContainerResult from MediaStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/CreateContainer">REST API Reference for CreateContainer Operation</seealso>
        public virtual CreateContainerResponse EndCreateContainer(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateContainerResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteContainer

        /// <summary>
        /// Deletes the specified container. Before you make a <code>DeleteContainer</code> request,
        /// delete any objects in the container or in any folders in the container. You can delete
        /// only empty containers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContainer service method.</param>
        /// 
        /// <returns>The response from the DeleteContainer service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// Resource already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// Could not perform an operation on a container that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DeleteContainer">REST API Reference for DeleteContainer Operation</seealso>
        public virtual DeleteContainerResponse DeleteContainer(DeleteContainerRequest request)
        {
            var marshaller = new DeleteContainerRequestMarshaller();
            var unmarshaller = DeleteContainerResponseUnmarshaller.Instance;

            return Invoke<DeleteContainerRequest,DeleteContainerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteContainer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteContainer operation on AmazonMediaStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteContainer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DeleteContainer">REST API Reference for DeleteContainer Operation</seealso>
        public virtual IAsyncResult BeginDeleteContainer(DeleteContainerRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteContainerRequestMarshaller();
            var unmarshaller = DeleteContainerResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteContainerRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteContainer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteContainer.</param>
        /// 
        /// <returns>Returns a  DeleteContainerResult from MediaStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DeleteContainer">REST API Reference for DeleteContainer Operation</seealso>
        public virtual DeleteContainerResponse EndDeleteContainer(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteContainerResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteContainerPolicy

        /// <summary>
        /// Deletes the access policy that is associated with the specified container.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContainerPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteContainerPolicy service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// Resource already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// Could not perform an operation on a container that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.PolicyNotFoundException">
        /// Could not perform an operation on a policy that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DeleteContainerPolicy">REST API Reference for DeleteContainerPolicy Operation</seealso>
        public virtual DeleteContainerPolicyResponse DeleteContainerPolicy(DeleteContainerPolicyRequest request)
        {
            var marshaller = new DeleteContainerPolicyRequestMarshaller();
            var unmarshaller = DeleteContainerPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteContainerPolicyRequest,DeleteContainerPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteContainerPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteContainerPolicy operation on AmazonMediaStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteContainerPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DeleteContainerPolicy">REST API Reference for DeleteContainerPolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteContainerPolicy(DeleteContainerPolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteContainerPolicyRequestMarshaller();
            var unmarshaller = DeleteContainerPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteContainerPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteContainerPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteContainerPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteContainerPolicyResult from MediaStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DeleteContainerPolicy">REST API Reference for DeleteContainerPolicy Operation</seealso>
        public virtual DeleteContainerPolicyResponse EndDeleteContainerPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteContainerPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeContainer

        /// <summary>
        /// Retrieves the properties of the requested container. This returns a single <code>Container</code>
        /// object based on <code>ContainerName</code>. To return all <code>Container</code> objects
        /// that are associated with a specified AWS account, use <a>ListContainers</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeContainer service method.</param>
        /// 
        /// <returns>The response from the DescribeContainer service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// Could not perform an operation on a container that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DescribeContainer">REST API Reference for DescribeContainer Operation</seealso>
        public virtual DescribeContainerResponse DescribeContainer(DescribeContainerRequest request)
        {
            var marshaller = new DescribeContainerRequestMarshaller();
            var unmarshaller = DescribeContainerResponseUnmarshaller.Instance;

            return Invoke<DescribeContainerRequest,DescribeContainerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeContainer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeContainer operation on AmazonMediaStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeContainer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DescribeContainer">REST API Reference for DescribeContainer Operation</seealso>
        public virtual IAsyncResult BeginDescribeContainer(DescribeContainerRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeContainerRequestMarshaller();
            var unmarshaller = DescribeContainerResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeContainerRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeContainer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeContainer.</param>
        /// 
        /// <returns>Returns a  DescribeContainerResult from MediaStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DescribeContainer">REST API Reference for DescribeContainer Operation</seealso>
        public virtual DescribeContainerResponse EndDescribeContainer(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeContainerResponse>(asyncResult);
        }

        #endregion
        
        #region  GetContainerPolicy

        /// <summary>
        /// Retrieves the access policy for the specified container. For information about the
        /// data that is included in an access policy, see the <a href="https://aws.amazon.com/documentation/iam/">AWS
        /// Identity and Access Management User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContainerPolicy service method.</param>
        /// 
        /// <returns>The response from the GetContainerPolicy service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// Resource already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// Could not perform an operation on a container that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.PolicyNotFoundException">
        /// Could not perform an operation on a policy that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/GetContainerPolicy">REST API Reference for GetContainerPolicy Operation</seealso>
        public virtual GetContainerPolicyResponse GetContainerPolicy(GetContainerPolicyRequest request)
        {
            var marshaller = new GetContainerPolicyRequestMarshaller();
            var unmarshaller = GetContainerPolicyResponseUnmarshaller.Instance;

            return Invoke<GetContainerPolicyRequest,GetContainerPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetContainerPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContainerPolicy operation on AmazonMediaStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContainerPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/GetContainerPolicy">REST API Reference for GetContainerPolicy Operation</seealso>
        public virtual IAsyncResult BeginGetContainerPolicy(GetContainerPolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetContainerPolicyRequestMarshaller();
            var unmarshaller = GetContainerPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<GetContainerPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetContainerPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContainerPolicy.</param>
        /// 
        /// <returns>Returns a  GetContainerPolicyResult from MediaStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/GetContainerPolicy">REST API Reference for GetContainerPolicy Operation</seealso>
        public virtual GetContainerPolicyResponse EndGetContainerPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetContainerPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  ListContainers

        /// <summary>
        /// Lists the properties of all containers in AWS Elemental MediaStore. 
        /// 
        ///  
        /// <para>
        /// You can query to receive all the containers in one response. Or you can include the
        /// <code>MaxResults</code> parameter to receive a limited number of containers in each
        /// response. In this case, the response includes a token. To get the next set of containers,
        /// send the command again, this time with the <code>NextToken</code> parameter (with
        /// the returned token as its value). The next set of responses appears, with a token
        /// if there are still more containers to receive. 
        /// </para>
        ///  
        /// <para>
        /// See also <a>DescribeContainer</a>, which gets the properties of one container. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContainers service method.</param>
        /// 
        /// <returns>The response from the ListContainers service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/ListContainers">REST API Reference for ListContainers Operation</seealso>
        public virtual ListContainersResponse ListContainers(ListContainersRequest request)
        {
            var marshaller = new ListContainersRequestMarshaller();
            var unmarshaller = ListContainersResponseUnmarshaller.Instance;

            return Invoke<ListContainersRequest,ListContainersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListContainers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListContainers operation on AmazonMediaStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListContainers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/ListContainers">REST API Reference for ListContainers Operation</seealso>
        public virtual IAsyncResult BeginListContainers(ListContainersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListContainersRequestMarshaller();
            var unmarshaller = ListContainersResponseUnmarshaller.Instance;

            return BeginInvoke<ListContainersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListContainers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListContainers.</param>
        /// 
        /// <returns>Returns a  ListContainersResult from MediaStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/ListContainers">REST API Reference for ListContainers Operation</seealso>
        public virtual ListContainersResponse EndListContainers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListContainersResponse>(asyncResult);
        }

        #endregion
        
        #region  PutContainerPolicy

        /// <summary>
        /// Creates an access policy for the specified container to restrict the users and clients
        /// that can access it. For information about the data that is included in an access policy,
        /// see the <a href="https://aws.amazon.com/documentation/iam/">AWS Identity and Access
        /// Management User Guide</a>.
        /// 
        ///  
        /// <para>
        /// For this release of the REST API, you can create only one policy for a container.
        /// If you enter <code>PutContainerPolicy</code> twice, the second command modifies the
        /// existing policy. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutContainerPolicy service method.</param>
        /// 
        /// <returns>The response from the PutContainerPolicy service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// Resource already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// Could not perform an operation on a container that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/PutContainerPolicy">REST API Reference for PutContainerPolicy Operation</seealso>
        public virtual PutContainerPolicyResponse PutContainerPolicy(PutContainerPolicyRequest request)
        {
            var marshaller = new PutContainerPolicyRequestMarshaller();
            var unmarshaller = PutContainerPolicyResponseUnmarshaller.Instance;

            return Invoke<PutContainerPolicyRequest,PutContainerPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutContainerPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutContainerPolicy operation on AmazonMediaStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutContainerPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/PutContainerPolicy">REST API Reference for PutContainerPolicy Operation</seealso>
        public virtual IAsyncResult BeginPutContainerPolicy(PutContainerPolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutContainerPolicyRequestMarshaller();
            var unmarshaller = PutContainerPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<PutContainerPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutContainerPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutContainerPolicy.</param>
        /// 
        /// <returns>Returns a  PutContainerPolicyResult from MediaStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/PutContainerPolicy">REST API Reference for PutContainerPolicy Operation</seealso>
        public virtual PutContainerPolicyResponse EndPutContainerPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutContainerPolicyResponse>(asyncResult);
        }

        #endregion
        
    }
}