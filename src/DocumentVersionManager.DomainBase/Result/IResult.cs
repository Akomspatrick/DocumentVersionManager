
namespace DocumentVersionManager.DomainBase.Result
{
    public interface IResult<TError, TValue>
    {
        bool IsSuccess { get; }

        TError GetErrorOrDefault(Func<TError> errorFactory);
        TError GetErrorOrDefault(TError error);
        int GetHashCode();
        TValue GetValueOrDefault(Func<TValue> valueFactory);
        TValue GetValueOrDefault(TValue value);
        TResult Map<TResult>(Func<TValue, TResult> map);
        TResult Match<TResult>(Func<TValue, TResult> onSuccess, Func<TError, TResult> onError);
        string ToString();
    }
}