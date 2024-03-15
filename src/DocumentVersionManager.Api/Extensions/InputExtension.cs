using DocumentVersionManager.DomainBase.Result;

namespace DocumentVersionManager.Api.Extentions
{
    public static class InputExtension
    {
        public static Result<L, R> EnsureInputIsNotNull<L, R>(this R theInput, L errorMsg)
        {
            if (theInput != null)
            {
                return errorMsg;
            }
            return theInput;


        }
        public static Result<Task<L>, Task<R>> EnsureInputIsNotNullAsync<L, R>(this R theInput, L errorMsg)
        {
            if (theInput != null)
            {
                return Task.FromResult(errorMsg);
            }
            return Task.FromResult(theInput);


        }
        public static Result<L, R> EnsureInputIsNotEmpty<L, R>(this R theInput, L errorMsg)
        {
            if (theInput.ToString() == string.Empty)
            {
                return errorMsg;
            }
            return theInput;


        }


    }
}
