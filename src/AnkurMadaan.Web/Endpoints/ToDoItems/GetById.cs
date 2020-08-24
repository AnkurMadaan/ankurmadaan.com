﻿using System.Threading;
using Ardalis.ApiEndpoints;
using AnkurMadaan.Core.Entities;
using AnkurMadaan.SharedKernel.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;

namespace AnkurMadaan.Web.Endpoints.ToDoItems
{
    public class GetById : BaseAsyncEndpoint<int,ToDoItemResponse>
    {
        private readonly IRepository _repository;

        public GetById(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("/ToDoItems/{id:int}")]
        [SwaggerOperation(
            Summary = "Gets a single ToDoItem",
            Description = "Gets a single ToDoItem by Id",
            OperationId = "ToDoItem.GetById",
            Tags = new[] { "ToDoItemEndpoints" })
        ]
        public override async Task<ActionResult<ToDoItemResponse>> HandleAsync(int id, CancellationToken cancellationToken)
        {
            var item = await _repository.GetByIdAsync<ToDoItem>(id);

            var response = new ToDoItemResponse
            {
                Id = item.Id,
                Description = item.Description,
                IsDone = item.IsDone,
                Title = item.Title
            };
            return Ok(response);
        }
    }
}
