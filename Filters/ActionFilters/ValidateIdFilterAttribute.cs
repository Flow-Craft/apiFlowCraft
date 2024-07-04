using ApiNet8.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ApiNet8.Filters.ActionFilters
{
    public class ValidateIdFilterAttribute : ActionFilterAttribute
    {
        private readonly ApplicationDbContext db;

        public ValidateIdFilterAttribute(ApplicationDbContext db)
        {
            this.db = db;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            // obtengo el tipo de entidad
            var entityTypeAttribute = context.ActionDescriptor.EndpointMetadata
                .OfType<EntityTypeAttribute>()
                .FirstOrDefault();

            if (entityTypeAttribute != null)
            {
                var entityType = entityTypeAttribute.EntityType;
                var id = context.ActionArguments["id"] as int?; // obtengo id de la solicitud

                // valido si no es null
                if (id.HasValue)
                {
                    // valido que no sea negativo
                    if (id.Value <= 0)
                    {
                        context.ModelState.AddModelError("Id", "Id is invalid.");
                        var problemDetails = new ValidationProblemDetails(context.ModelState)
                        {
                            Status = StatusCodes.Status400BadRequest
                        };
                        context.Result = new BadRequestObjectResult(problemDetails);
                    }
                    else
                    {
                        try
                        {
                            // verifico si existe
                            var entity = db.Find(entityType, id.Value);

                            if (entity == null)
                            {
                                context.ModelState.AddModelError("Id", $"{entityType.Name} no existe.");
                                var problemDetails = new ValidationProblemDetails(context.ModelState)
                                {
                                    Status = StatusCodes.Status404NotFound
                                };
                                context.Result = new NotFoundObjectResult(problemDetails);                                
                            }
                        }
                        catch (Exception e)
                        {
                            context.ModelState.AddModelError("Id", $"Error al buscar {entityType.Name}: {e.Message}");
                            var problemDetails = new ValidationProblemDetails(context.ModelState)
                            {
                                Status = StatusCodes.Status500InternalServerError
                            };
                            context.Result = new ObjectResult(problemDetails) { StatusCode = 500 };
                            return;
                        }                       
                    }
                }
                else
                {
                    context.ModelState.AddModelError("Id", "Id is null.");
                    var problemDetails = new ValidationProblemDetails(context.ModelState)
                    {
                        Status = StatusCodes.Status400BadRequest
                    };
                    context.Result = new BadRequestObjectResult(problemDetails);
                }
            }
            else 
            {
                context.ModelState.AddModelError("EntityType", "No existe el tipo de entidad buscada.");
                var problemDetails = new ValidationProblemDetails(context.ModelState)
                {
                    Status = StatusCodes.Status500InternalServerError
                };
                context.Result = new ObjectResult(problemDetails) { StatusCode = 500 };
            }

         
        }
    }
}
