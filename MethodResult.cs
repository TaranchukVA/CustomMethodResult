namespace CustomMethodResult
{
    /// <summary>
    /// Author: Vladimir Taranchuk.<br/>
    /// Author's Git: TaranchukVA.<br/>
    /// Author's LinkedIn: taranchuk.
    /// 
    /// </summary>
    /// <typeparam name="T">Type of result</typeparam>
    public class MethodResult<T> : IMethodResult<T>
    {
        public bool IsSuccess { get; }
        public string Message { get; }
        public T Data { get; } = default;

        /// <param name="isSuccess">If does not declare success, it sets false</param>
        public MethodResult(bool isSuccess = false) =>
            IsSuccess = isSuccess;

        /// <param name="isSuccess">If does not declare success, it sets false</param>
        /// <param name="message">If message is null, it sets empty string</param>
        public MethodResult(string message, bool isSuccess = false) : this(isSuccess) =>
            Message = message ?? string.Empty;

        /// <param name="isSuccess">If does not declare success, it sets false</param>
        /// <param name="message"> If message is null, it sets empty string </param>
        public MethodResult(T data, string message = null, bool isSuccess = false) : this(message, isSuccess) =>
            Data = data;

    }
}
