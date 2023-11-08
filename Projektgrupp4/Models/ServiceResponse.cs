using Projektgrupp4.Enum;

namespace Projektgrupp4.Models
{
    public class ServiceResponse<T>
    {
        public StatusCode StatusCode {  get; set; } 
        public T? Content { get; set; }
    }
}
