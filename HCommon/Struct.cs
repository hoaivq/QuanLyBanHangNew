using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCommon
{
    public class MsgResult
    {
        public MsgResult() { }
        public MsgResult(bool _Success, string _Message = "", object _Value = null)
        {
            Success = _Success;
            Message = _Message;
            Value = _Value;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
        public object Value { get; set; }
    }

    public class MsgResult<T>
    {
        public MsgResult() { }
        public MsgResult(bool _Success, string _Message = "", T _Value = default(T))
        {
            Success = _Success;
            Message = _Message;
            Value = _Value;
        }

        public MsgResult(bool _Success, Exception ex)
        {
            Success = _Success;
            Message = ex.Message;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
        public T Value { get; set; }
    }
}
