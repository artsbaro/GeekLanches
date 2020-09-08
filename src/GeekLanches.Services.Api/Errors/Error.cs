using System;

namespace DevWebReceitas.Services.Api.Errors
{
    public class Error
    {
        public string Message { get; }

        public Error(Exception ex)
        {
            Message = ex.Message;
        }

        public Error(string errorMessage)
        {
            Message = errorMessage;
        }
    }
}
