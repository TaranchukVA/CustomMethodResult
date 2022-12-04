namespace CustomMethodResult
{
    /// <summary>
    /// Author: Vladimir Taranchuk.<br/>
    /// Author's Git: TaranchukVA.<br/>
    /// Author's LinkedIn: taranchuk. 
    /// </summary>
    /// <typeparam name="T">Type of result</typeparam>
    public interface IMethodResult<T>
    {
        /// <summary>
        /// Gets a value that indicates if the method was successful
        /// </summary>
        public bool IsSuccess { get; }

        /// <summary>
        /// Gets the message with main text information of method result
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// Gets the data that method returned
        /// </summary>
        public T Data { get; }
    }
}
