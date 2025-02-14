﻿using System.Threading.Tasks;
using CG4.DataAccess;
using CG4.DataAccess.Domain;
using CG4.Executor.Story;
using Microsoft.AspNetCore.Mvc;
using ProjectName.Domain.Entities;
using ProjectName.Story.Accounts;

namespace ProjectName.WebApp.Controllers
{
    public class AccountsController : EntityControllerBase<Account>
    {
        private readonly IStoryExecutor _storyExecutor;
        
        public AccountsController(ICrudService crudService, IStoryExecutor storyExecutor) 
            : base(crudService)
        {
            _storyExecutor = storyExecutor;
        }
        
        [HttpGet("page")]
        public Task<PageResult<Account>> GetPage([FromQuery] GetAccountsPageStoryContext context)
        {
            return _storyExecutor.Execute(context);
        }
    }
}
