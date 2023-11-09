using DocumentVersionManager.Application.Contracts.RequestDTO;
"using DocumentVersionManager.Application.Contracts.ResponsetDTO;
using  DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS.HigherModel.Queries
{
    public  record GetAllHigherModelQuery(ApplicationRequestHigherModelDTO : RequestHigherModelDTO) :  IRequest<Either<GeneralFailures, IEnumerable<ApplicationRequestHigherModelDTO>>>;
}