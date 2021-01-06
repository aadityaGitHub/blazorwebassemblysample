using AtndTrackBlazorApp.Shared.Models;
using AutoMapper;
using DataAccess.Context;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class OrganizationRepo : IOrganizationRepo
    {
        private readonly AttendancetrackContext _attendancetrackContext;
        private readonly IMapper _mapper;

        public OrganizationRepo(AttendancetrackContext attendancetrackContext,IMapper mapper)
        {
            _attendancetrackContext = attendancetrackContext;
            this._mapper = mapper;
        }
        public async Task<DepartmentModel[]> GetDepartments(string name)
        {
            var lst = await _attendancetrackContext.Department.Where(o => o.Name.Contains(name)).Select(o=>_mapper.Map<DepartmentModel>(o)).ToArrayAsync().ConfigureAwait(false);
            return lst;
        }

        public async Task<bool> Save(DepartmentModel departmentModel)
        {
            var dbDeptModel = await _attendancetrackContext.Department.FirstOrDefaultAsync(o => o.Id == departmentModel.Id).ConfigureAwait(false);
            if (dbDeptModel != null)
                dbDeptModel.Name = departmentModel.Name;
            else
            {
                var countId = await _attendancetrackContext.Department.CountAsync().ConfigureAwait(false);
                await _attendancetrackContext.Department.AddAsync(_mapper.Map<Department>(departmentModel)).ConfigureAwait(false);

            }
            await _attendancetrackContext.SaveChangesAsync().ConfigureAwait(false);
            return true;
        }

        public async Task<DesignationModel[]> GetDesignations(string name)
        {
            var lst = await _attendancetrackContext.Designation.Where(o => o.Name.Contains(name)).Select(o => _mapper.Map<DesignationModel>(o)).ToArrayAsync().ConfigureAwait(false);
            return lst;
        }

        public async Task<bool> SaveDesignation(DesignationModel departmentModel)
        {
            var dbDeptModel = await _attendancetrackContext.Designation.FirstOrDefaultAsync(o => o.DesignationId == departmentModel.DesignationId).ConfigureAwait(false);
            if (dbDeptModel != null)
                dbDeptModel.Name = departmentModel.Name;
            else
            {
                var countId = await _attendancetrackContext.Designation.CountAsync().ConfigureAwait(false);
                await _attendancetrackContext.Designation.AddAsync(new Models.Designation() { Name = departmentModel.Name }).ConfigureAwait(false);

            }
            await _attendancetrackContext.SaveChangesAsync().ConfigureAwait(false);
            return true;
        }


        public async Task<RoleModel[]> GetRoles(string name)
        {
            var lst = await _attendancetrackContext.Roles.Where(o => o.Name.Contains(name)).Select(o => _mapper.Map<RoleModel>(o)).ToArrayAsync().ConfigureAwait(false);
            return lst;
        }

    }
}
