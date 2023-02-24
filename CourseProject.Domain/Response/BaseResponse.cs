using CourseProject.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Domain.Response
{
    public class BaseResponse<T> : IBaseResponse<T>
    {
        public string Description { get; set; }
        public int Status { get; set; }
        public StatusCode StatusCode { get; set; }
        public T Data { get; set; }

    }
    public interface IBaseResponse<T>
    {
        T Data { get;  }
        StatusCode StatusCode { get; }

    }
}
