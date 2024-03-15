﻿using DocumentVersionManager.Domain.Errors;
using LanguageExt;


namespace DocumentVersionManager.DomainBase.Result
{
    public readonly struct Result<TError, TValue> : IResult<TError, TValue>

    //public readonly struct Result<TError, TValue>
    {
        private readonly TValue? _value;
        private readonly TError? _error;
        private readonly bool _isSuccess;
        private readonly string? _message;


        public Result(TValue value, string? message = "")
        {
            //if (_isSuccess & _error != null ||
            //                   !_isSuccess & _error == null)
            //{
            //    throw new ArgumentException("Attempt to call an error a success");
            //}
            _isSuccess = true;
            _value = value;
            _message = message;
        }
        public bool IsSuccess => _isSuccess;

        public static implicit operator Result<TError, TValue>(TValue value) => new(value);
        public static implicit operator Result<TError, TValue>(TError error) => new(error);

        public TResult Match<TResult>(Func<TValue, TResult> onSuccess, Func<TError, TResult> onError)
        {
            if (_isSuccess)
            {
                return onSuccess(_value!);
            }
            else
            {
                return onError(_error!);
            }
        }

        //        private static IActionResult Match<L, R>(this Result<L, R> Result) =>
        //        public static Task<IActionResult> ToActionResult<L, R>(this Task<Result<L, R>> Result)
        //=> Result.Map(Match);

        //public TResult Map<TResult>(Func<TValue, TResult> map)
        //{
        //    return

        //        _isSuccess ? map(_value!) : default!;

        //}

        public TResult Map<TResult>(Func<TValue, TResult> map)
        {
            return

                _isSuccess ? map(_value!) : default!;

        }




        public TValue GetValueOrDefault(TValue value) => _isSuccess ? _value! : value;

        public TValue GetValueOrDefault(Func<TValue> valueFactory) => _isSuccess ? _value! : valueFactory();

        public TError GetErrorOrDefault(TError error) => !_isSuccess ? _error! : error;

        public TError GetErrorOrDefault(Func<TError> errorFactory) => !_isSuccess ? _error! : errorFactory();

        public override string ToString() => _isSuccess ? _value!.ToString() : _error!.ToString();

        public override int GetHashCode() => _isSuccess ? _value!.GetHashCode() : _error!.GetHashCode();



        public Result(TError error, string? message = "")
        {
            //if (_isSuccess & _error != null ||
            //                   !_isSuccess & _error == null)
            //{
            //    throw new ArgumentException("Attempt to call an error a success");
            //}
            _isSuccess = false;
            _error = error;
            _message = message;
        }

    }
    public class Result2<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T Value { get; set; }
        public GeneralFailure ErrorMessage { get; set; }

        //private Result()
        //{
        //    IsSuccess = false;
        //    Message = string.Empty;
        //    Value = default(T);
        //    ErrorMessage = string.Empty;
        //}
        //private Result(bool isSuccess, string message, T data, GeneralFailure errorMessage)
        //{
        //    if (isSuccess & errorMessage != GeneralFailure.None ||
        //        !isSuccess & errorMessage == GeneralFailure.None)
        //    {
        //        throw new ArgumentException("Attempt to call an error a success");
        //    }
        //    IsSuccess = isSuccess;
        //    Message = message;
        //    Value = data;
        //    ErrorMessage = errorMessage;
        //}
        //public static Result<T> Success(T data, string? message = "") => new Result<T>(true, message, data, GeneralFailure.None)
        //{ IsSuccess = true, Value = data, Message = message, ErrorMessage = GeneralFailure.None };

        //public static Result<T> Failure(GeneralFailure errorMessage, string? message = "")
        //  => new Result<T>(false, message, default, errorMessage) { IsSuccess = false, Message = message, ErrorMessage = errorMessage };


        //public static Result<T> Success(T data, string? message = "") => new()
        //{ IsSuccess = true, Value = data, Message = message, ErrorMessage = GeneralFailure.None };

        //public static Result<T> Failure(GeneralFailure errorMessage, string? message = "")
        //  => new()
        //  { IsSuccess = false, Message = message, ErrorMessage = errorMessage };


        //public Result(bool isSuccess, string message, T data)
        //{
        //    IsSuccess = isSuccess;
        //    Message = message;
        //    Value = data;
        //}
    }
}
