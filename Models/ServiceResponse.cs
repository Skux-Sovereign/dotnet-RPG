using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Udemy.Models
{
    public class ServiceResponse<T>
    {
        public T? Data { get; set; }

        public bool Success { get; set; } = true;

        public string Message { get; set; } = string.Empty;

    }
}