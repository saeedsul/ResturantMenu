using System.Collections.Generic;
using System.Net;

namespace ResturantMenu.Shared
{
    public class ApiResult<T>
        where T : class
    {
        public ApiResult()
        {
        }

        public ApiResult(int statusCode, IDictionary<string, string> headers, T data)
        {
            StatusCode = (HttpStatusCode)statusCode;
            Headers = headers;
            Item = data;
        }

        public string Error { get; set; }

        public bool IsSuccessful
        {
            get { return string.IsNullOrWhiteSpace(Error); }
        }

        public HttpStatusCode StatusCode { get; set; }

        public T Item { get; set; }

        public IDictionary<string, string> Headers { get; set; }
    }

    public class ApiResponse<T>
    {
        public int StatusCode { get; private set; }

        public IDictionary<string, string> Headers { get; private set; }

        public T Data { get; private set; }

        public ApiResponse(int statusCode, IDictionary<string, string> headers, T data)
        {
            this.StatusCode = statusCode;
            this.Headers = headers;
            this.Data = data;
        }
    }
}