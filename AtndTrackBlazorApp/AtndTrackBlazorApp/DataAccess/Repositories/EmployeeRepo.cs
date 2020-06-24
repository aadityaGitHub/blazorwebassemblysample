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
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly AttendancetrackContext _attendancetrackContext;
        private readonly IMapper _mapper;

        public EmployeeRepo(AttendancetrackContext attendancetrackContext, IMapper mapper)
        {
            _attendancetrackContext = attendancetrackContext;
            this._mapper = mapper;
        }
        public async Task<EmployeeModel[]> GetEmployees(string name)
        {
            try
            {

                var lst = await _attendancetrackContext.Employee.Include(o => o.JobDetail).Where(o => o.IsActive && o.FirstName.Contains(name)).Select(o => _mapper.Map<EmployeeModel>(o)).ToArrayAsync().ConfigureAwait(false);
                return lst;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<EmployeeModel> GetEmployee(int employeeId)
        {
            var lst = await _attendancetrackContext.Employee.Where(o => o.Id == employeeId && o.IsActive).Select(o => _mapper.Map<EmployeeModel>(o)).FirstOrDefaultAsync().ConfigureAwait(false);
            return lst;
        }

        public async Task<bool> Save(EmployeeModel EmployeeModel)
        {
            var dbDeptModel = await _attendancetrackContext.Employee.FirstOrDefaultAsync(o => o.Id == EmployeeModel.Id).ConfigureAwait(false);
            if (dbDeptModel != null)
            {
                dbDeptModel = _mapper.Map<EmployeeModel, Employee>(EmployeeModel, dbDeptModel); // dbDeptModel.FirstName = EmployeeModel.FirstName;
                dbDeptModel.ModifiedDate = DateTime.Now;
                if (dbDeptModel.JobDetail?.FirstOrDefault() != null)
                    dbDeptModel.JobDetail.FirstOrDefault().IsActive = true;
            }
            else
            {
                var countId = await _attendancetrackContext.Employee.CountAsync().ConfigureAwait(false);
                await _attendancetrackContext.Employee.AddAsync(_mapper.Map<Employee>(EmployeeModel)).ConfigureAwait(false);

            }
            await _attendancetrackContext.SaveChangesAsync().ConfigureAwait(false);
            return true;
        }


    }
}
