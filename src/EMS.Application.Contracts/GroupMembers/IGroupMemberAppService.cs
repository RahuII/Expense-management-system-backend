﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace EMS.GroupMembers
{
    public interface IGroupMemberAppService : IApplicationService
    {
        Task<GroupMemberDto> GetAsync(Guid id);

        Task<PagedResultDto<GroupMemberDto>> GetListAsync(GetGroupMemberListDto input);

        //Task<GroupMemberDto> CreateAsync(CreateGroupMemberDto input);

        //Task UpdateAsync(int id, UpdateGroupMemberDto input);

        //Task DeleteAsync(int id);
    }
}
