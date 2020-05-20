using AtndTrackBlazorApp.Shared.Models;
using DataAccess.Context;
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

        public OrganizationRepo(AttendancetrackContext attendancetrackContext)
        {
            _attendancetrackContext = attendancetrackContext;
        }
        public async Task<DepartmentModel[]> GetDepartments(string name)
        {
            var lst = await _attendancetrackContext.Departments.Where(o => o.Name.Contains(name)).Select(o => new DepartmentModel
            {
                Name = o.Name,
                Id = o.Id
            }).ToArrayAsync().ConfigureAwait(false);
            return lst;
        }

        public async Task<bool> Save(DepartmentModel departmentModel)
        {
            var dbDeptModel = await _attendancetrackContext.Departments.FirstOrDefaultAsync(o => o.Id == departmentModel.Id).ConfigureAwait(false);
            if (dbDeptModel != null)
                dbDeptModel.Name = departmentModel.Name;
            else
            {
                var countId = await _attendancetrackContext.Departments.CountAsync().ConfigureAwait(false);
                await _attendancetrackContext.Departments.AddAsync(new Models.Departments() { Id = countId+1, Name = departmentModel.Name }).ConfigureAwait(false);

            }
            await _attendancetrackContext.SaveChangesAsync().ConfigureAwait(false);
            return true;
        }

    }
}
