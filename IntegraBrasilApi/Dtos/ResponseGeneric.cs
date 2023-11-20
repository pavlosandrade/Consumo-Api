using System.Dynamic;
using System.Net;

namespace IntegraBrasilApi.Dtos{

    public class ResponseGeneric<T> where T:class {
       public HttpStatusCode CodeHttp {get;set;}
       public T? DataReturn {get;set;}
       public ExpandoObject? ErrorReturn { get; set; }
    }
}