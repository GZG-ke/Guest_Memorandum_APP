﻿using Guest_Memorandum_API.Interface;
using Guest_Memorandum_Shared;
using Guest_Memorandum_Shared.Dtos;
using Guest_Memorandum_Shared.Parameters;
using Microsoft.AspNetCore.Mvc;

namespace Guest_Memorandum_API.Controllers
{
    /// <summary>
    /// 待办事项控制器
    /// </summary>
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ToDoController : ControllerBase
    {
        private readonly IToDoService service;

        public ToDoController(IToDoService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ApiResponse> Get(int id) => await service.GetSingleAsync(id);

        [HttpGet]
        public async Task<ApiResponse> GetAll([FromQuery] ToDoParameter param) => await service.GetAllAsync(param);

        [HttpGet]
        public async Task<ApiResponse> Summary() => await service.Summary();

        [HttpPost]
        public async Task<ApiResponse> Add([FromBody] ToDoDto model) => await service.AddAsync(model);

        [HttpPost]
        public async Task<ApiResponse> Update([FromBody] ToDoDto model) => await service.UpdateAsync(model);

        [HttpDelete]
        public async Task<ApiResponse> Delete(int id) => await service.DeleteAsync(id);
    }
}