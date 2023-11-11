using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagementApi.Application.Common.DTOs
{
    public class ApiResult
    {
        public bool IsSuccess { get; set; }
        public string? ErrorMessage { get; set; }
        public object? Data { get; set; }
    }
}
