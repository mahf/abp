﻿using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Volo.Abp.TestApp.Application
{
    public interface IPeopleAppService : IAsyncCrudAppService<PersonDto>
    {
        Task<ListResultDto<PhoneDto>> GetPhones(Guid id, GetPersonPhonesFilter filter);

        Task<PhoneDto> AddPhone(Guid id, PhoneDto phoneDto);

        Task RemovePhone(Guid id, long phoneId);
    }
}