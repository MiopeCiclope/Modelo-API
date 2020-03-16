﻿using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SandBoxAPI.Common;
using SandBoxAPI.Interfaces;

namespace SandBoxAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class CustomController<TEntity, TService> : ControllerBase
        where TEntity : class, IEntity
        where TService : IService<TEntity>
    {
        public readonly TService service;
        public readonly ILogger logger;


        public CustomController(TService _service, ILogger _logger)
        {
            this.service = _service;
            this.logger = _logger;
        }

        public virtual HttpResponse<List<TEntity>> Get()
        {
            logger.LogInformation($"{this.GetType().Name} - GetAll");
            var dataList = service.GetAll();

            return new HttpResponse<List<TEntity>>
            {
                IsStatusCodeSuccess = true,
                statusCode = HttpStatusCode.OK,
                data = dataList
            };
        }

        [HttpGet("{id}")]
        public virtual HttpResponse<TEntity> Get(int id)
        {
            logger.LogInformation($"{this.GetType().Name} - Get - {id}");
            var data = service.Get(id);
            var statusRequest = (data == null) ? HttpStatusCode.NotFound : HttpStatusCode.OK;
            
            return new HttpResponse<TEntity>
            {
                IsStatusCodeSuccess = (statusRequest == HttpStatusCode.OK),
                statusCode = statusRequest,
                data = data
            };
        }

        [HttpPut("{id}")]
        public virtual HttpResponse<TEntity> Put(int id, TEntity entity)
        {
            logger.LogInformation($"{this.GetType().Name} - Put - {id}");

            var statusRequest = (id != entity.Id) ? HttpStatusCode.BadRequest : HttpStatusCode.OK;
            var updatedData = service.Update(entity);

            return new HttpResponse<TEntity>
            {
                IsStatusCodeSuccess = (statusRequest == HttpStatusCode.OK),
                statusCode = statusRequest,
                data = updatedData
            };
        }

        [HttpPost]
        public virtual HttpResponse<TEntity> Post(TEntity entity)
        {
            logger.LogInformation($"{this.GetType().Name} - Post - {entity.ToString()}");

            var statusRequest = HttpStatusCode.Created;
            var createdData = service.Add(entity);

            return new HttpResponse<TEntity>
            {
                IsStatusCodeSuccess = true,
                statusCode = statusRequest,
                data = createdData
            };
        }

        [HttpDelete("{id}")]
        public virtual HttpResponse<TEntity> Delete(int id)
        {
            logger.LogInformation($"{this.GetType().Name} - Delete - {id}");

            var statusRequest = HttpStatusCode.OK;
            var createdData = service.Delete(id);

            return new HttpResponse<TEntity>
            {
                IsStatusCodeSuccess = true,
                statusCode = statusRequest,
                data = createdData
            };
        }

    }
}
