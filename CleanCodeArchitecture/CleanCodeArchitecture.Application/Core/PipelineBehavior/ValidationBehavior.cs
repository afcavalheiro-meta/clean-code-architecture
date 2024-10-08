﻿// using CleanCodeArchitecture.Domain.Core.Commands;
// using CleanCodeArchitecture.Domain.Core.Response;
// using FluentValidation;
// using MediatR;
//
// namespace CleanCodeArchitecture.Application.Core.PipelineBehavior;
//
// public sealed class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
//     where TRequest : class, ICommand<TResponse>
//     where TResponse :  Result, new()
// {
//     private readonly IEnumerable<IValidator<TRequest>> _validators;
//     public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators) => _validators = validators;
//     public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
//     {
//         if (!_validators.Any())
//         {
//             return await next();
//         }
//         var context = new ValidationContext<TRequest>(request);
//
//
//         var errorsDictionary = _validators
//             .Select(x => x.Validate(context))
//             .SelectMany(x => x.Errors);
//             
//         if (errorsDictionary.Any())
//         {
//             return new TResponse() { Errors = errorsDictionary.Select(x => x.ErrorMessage) };
//         }
//         return await next();
//     }
// }
//
