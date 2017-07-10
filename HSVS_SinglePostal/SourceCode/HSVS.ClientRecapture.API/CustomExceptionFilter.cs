using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http.Filters;

namespace HSVS.SinglePostal.API
{
    public class CustomExceptionFilter : ExceptionFilterAttribute
    {
        public CustomExceptionFilter()
        {
            Mappings = new Dictionary<Type, HttpStatusCode>();
            Mappings.Add(typeof(ArgumentNullException), HttpStatusCode.BadRequest);
            Mappings.Add(typeof(ArgumentException), HttpStatusCode.BadRequest);
            Mappings.Add(typeof(DivideByZeroException), HttpStatusCode.BadRequest);
        }

        public IDictionary<Type, HttpStatusCode> Mappings
        {
            get;
            private set;
        }

        public override void OnException(HttpActionExecutedContext cntxt)
        {
            if (cntxt.Exception != null)
            {
                var exception = cntxt.Exception;
                string type = exception.GetType().ToString();
                if (cntxt != null)
                {
                    // LookUp Mapping Dictionary to get exception type
                    if (Mappings.ContainsKey(exception.GetType()))
                    {
                        //Get Status code from Dictionary
                        var httpStatusCode = Mappings[exception.GetType()];
                        // Create Message Body with information
                        cntxt.Response = new HttpResponseMessage(httpStatusCode)
                        {
                            Content = new StringContent(cntxt.Exception.Message),
                            ReasonPhrase = cntxt.Exception.Message
                        };
                    }
                    else
                    {
                        cntxt.Response = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                        {
                            Content = new StringContent(cntxt.Exception.Message)
                        };
                    }
                }
            }
        }
    }
}