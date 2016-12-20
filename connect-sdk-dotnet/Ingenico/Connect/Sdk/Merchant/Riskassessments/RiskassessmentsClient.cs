/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Errors;
using Ingenico.Connect.Sdk.Domain.Riskassessments;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ingenico.Connect.Sdk.Merchant.Riskassessments
{
    /// <summary>
    /// Riskassessments client. Thread-safe.
    /// </summary>
    public class RiskassessmentsClient : ApiResource
    {
        public RiskassessmentsClient(ApiResource parent, IDictionary<string, string> pathContext) :
            base(parent, pathContext)
        {
        }

        /// <summary>
        /// Resource /{merchantId}/riskassessments/bankaccounts
        /// <a href="https://developer.globalcollect.com/documentation/api/server/#__merchantId__riskassessments_bankaccounts_post">Risk-assess bank account</a>
        /// </summary>
        /// <param name="body">RiskAssessmentBankAccount</param>
        /// <param name="context">CallContext</param>
        /// <returns>RiskAssessmentResponse</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the GlobalCollect platform,
        ///            the GlobalCollect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the GlobalCollect platform returned any other error</exception>
        public async Task<RiskAssessmentResponse> Bankaccounts(RiskAssessmentBankAccount body, CallContext context = null)
        {
            string uri = InstantiateUri("/{apiVersion}/{merchantId}/riskassessments/bankaccounts", null);
            try
            {
                return await _communicator.Post<RiskAssessmentResponse>(
                        uri,
                        ClientHeaders,
                        null,
                        body,
                        context);
            }
            catch (ResponseException e)
            {
                object errorObject;
                switch (e.StatusCode)
                {
                    default:
                        errorObject = _communicator.Marshaller.Unmarshal<ErrorResponse>(e.Body);
                        break;
                }
                throw CreateException(e.StatusCode, e.Body, errorObject, context);
            }
        }

        /// <summary>
        /// Resource /{merchantId}/riskassessments/cards
        /// <a href="https://developer.globalcollect.com/documentation/api/server/#__merchantId__riskassessments_cards_post">Risk-assess card</a>
        /// </summary>
        /// <param name="body">RiskAssessmentCard</param>
        /// <param name="context">CallContext</param>
        /// <returns>RiskAssessmentResponse</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the GlobalCollect platform,
        ///            the GlobalCollect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the GlobalCollect platform returned any other error</exception>
        public async Task<RiskAssessmentResponse> Cards(RiskAssessmentCard body, CallContext context = null)
        {
            string uri = InstantiateUri("/{apiVersion}/{merchantId}/riskassessments/cards", null);
            try
            {
                return await _communicator.Post<RiskAssessmentResponse>(
                        uri,
                        ClientHeaders,
                        null,
                        body,
                        context);
            }
            catch (ResponseException e)
            {
                object errorObject;
                switch (e.StatusCode)
                {
                    default:
                        errorObject = _communicator.Marshaller.Unmarshal<ErrorResponse>(e.Body);
                        break;
                }
                throw CreateException(e.StatusCode, e.Body, errorObject, context);
            }
        }
    }
}
