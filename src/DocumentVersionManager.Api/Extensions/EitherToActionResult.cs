
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.DomainBase.Result;
using DocumentVersionManager.Infrastructure.APIResponse;
using DocumentVersionManager.DomainBase.Result;
using Microsoft.AspNetCore.Mvc;
using System.Security.AccessControl;
using LanguageExt;

namespace DocumentVersionManager.Api.Extensions
{
    public static class ResultToActionResult
    {
        public static Task<IActionResult> ToActionResult<L, R>(this Task<Result<L, R>> Result)
        => Result.Map(Match);
        //public static Task<IActionResult> ToActionResult(this Task<Result<GeneralFailure, Task>> Result) =>
        //    Result.Bind(Match);

        private static IActionResult Match<L, R>(this Result<L, R> Result) =>
            Result.Match<IActionResult>(
                l => new OkObjectResult(l),
                r => new BadRequestObjectResult(new ApiBadRequestResponse(400, r)));

        //private async static Task<IActionResult> Match(Result<GeneralFailure, Task> Result) =>
        //    await Result.MatchAsync<IActionResult>(
        //        RightAsync: async t => { await t; return new OkResult(); },
        //        Left: e => new BadRequestObjectResult(e));


        //404
        public static Task<IActionResult> ToActionResult404<L, R>(this Task<Result<L, R>> Result)
         => Result.Map((x) => Match404(x));
        public static Task<IActionResult> ToActionResult404_2<L, R>(this Task<Result<L, R>> Result)
         => Result.Map((x) => Match404_2(x));

        private static IActionResult Match404_2<L, R>(this Result<L, R> Result) =>
             Result.Match<IActionResult>(
                                       l => new OkObjectResult(l),

                                       r => new NotFoundObjectResult(new ApiBadRequestResponse(404, r))
                                       );
        //public static Task<IActionResult> ToActionResult404(this Task<Result<GeneralFailure, Task>> Result) =>
        //    Result.Bind(Match404);

        private static IActionResult Match404<L, R>(this Result<L, R> Result) =>
            Result.Match<IActionResult>(
                               l => new OkObjectResult(l),

                                              r => new NotFoundObjectResult(new ApiBadRequestResponse(404, r)));
        //private async static Task<IActionResult> Match404(Result<GeneralFailure, Task> Result) =>
        //    await Result.MatchAsync<IActionResult>(
        //    RightAsync: async t => { await t; return new OkResult(); },
        //                             Left: e => new NotFoundObjectResult(e));



        //ToActionResultCreated
        public static Task<IActionResult> ToActionResultCreated<L, R>(this Task<Result<L, R>> Result, string endPoint, object data)
         => Result.Map((x) => MatchCreated(x, endPoint, data));

        //public static Task<IActionResult> ToActionResultCreated(this Task<Result<GeneralFailure, Task>> Result) =>
        //    Result.Bind(MatchCreated);

        private static IActionResult MatchCreated<L, R>(this Result<L, R> Result, string endPoint, object data)
        {

            var p = Result;
            var x = endPoint;
            var y = data;

            return Result.Match<IActionResult>(

                                                r =>
                                               {
                                                   var t = r.ToString();
                                                   var p = new CreatedResult($"{endPoint}/{r}", data);
                                                   return p;
                                               },
                                                  l => new BadRequestObjectResult(l)
                                               );
        }

        //private async static Task<IActionResult> MatchCreated(Result<GeneralFailure, Task> Result) =>
        //    await Result.MatchAsync<IActionResult>(
        //    RightAsync: async t => { await t; return new OkResult(); },
        //                             Left: e => new BadRequestObjectResult(e));






        //
    }
}
