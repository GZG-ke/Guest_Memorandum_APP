namespace Guest_Memorandum_Shared
{
    public class ApiResponse
    {
        public ApiResponse(string message, object result, bool status = false)
        {
            this.Message = message;
            this.Status = status;
            this.Result = result;
        }

        public ApiResponse(string message, bool status = false)
        {
            this.Message = message;
            this.Status = status;
        }

        public ApiResponse(bool status, object result)
        {
            this.Status = status;
            this.Result = result;
        }

        public ApiResponse()
        { }

        public string Message { get; set; }

        public bool Status { get; set; }

        public object Result { get; set; }
    }

    public class ApiResponse<T>
    {
        public ApiResponse(string message, T result, bool status = false)
        {
            this.Message = message;
            this.Status = status;
            this.Result = result;
        }

        public ApiResponse(string message, bool status = false)
        {
            this.Message = message;
            this.Status = status;
        }

        public ApiResponse(bool status, T result)
        {
            this.Status = status;
            this.Result = result;
        }

        public ApiResponse()
        { }

        public string Message { get; set; }

        public bool Status { get; set; }

        public T Result { get; set; }
    }
}