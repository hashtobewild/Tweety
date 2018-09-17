namespace Tweety.Models.Primitives
{
    /// <summary>
    /// Wrapper to wrap any result for better errors underdstanding.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Result<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Result{T}"/> class.
        /// </summary>
        public Result()
        {
            Success = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Result{T}"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public Result(T data)
        {
            Data = data;
            Success = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Result{T}"/> class.
        /// </summary>
        /// <param name="err">The error.</param>
        public Result(TwitterError err)
        {
            Error = err;
            Success = false;
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public T Data { get; private set; }

        /// <summary>
        /// Gets the error.
        /// </summary>
        /// <value>
        /// The error.
        /// </value>
        public TwitterError Error { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="Result{T}"/> is success.
        /// </summary>
        /// <value>
        ///   <c>true</c> if success; otherwise, <c>false</c>.
        /// </value>
        public bool Success { get; private set; }
    }
}