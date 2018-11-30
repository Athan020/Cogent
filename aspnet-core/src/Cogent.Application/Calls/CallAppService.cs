using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Cogent.Calls.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cogent.Sessions;
using Cogent.Authorization.Users;

namespace Cogent.Calls
{
    public class CallAppService : AsyncCrudAppService<Call, CallDto, int,PagedResultRequestDto>, ICallAppService
    {

        private IRepository<Call,int> _repository;

        public CallAppService(IRepository<Call, int> repository) : base(repository)
        {
            _repository = repository;
        }

        public override Task<CallDto> Create(CallDto input)
        {
               
            return base.Create(input);
        }

        public override Task Delete(EntityDto<int> input)
        {
            return base.Delete(input);
        }

        public override Task<CallDto> Get(EntityDto<int> input)
        {
            return base.Get(input);
        }

        public override Task<PagedResultDto<CallDto>> GetAll(PagedResultRequestDto input)
        {
            return base.GetAll(input);
        }


        public override Task<CallDto> Update(CallDto input)
        {
            return base.Update(input);
        }
    }
}
