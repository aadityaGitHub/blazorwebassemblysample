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
    public class LeaveRequestRepo : ILeaveRequestRepo
    {
        private readonly AttendancetrackContext _attendancetrackContext;
        private readonly IMapper _mapper;

        public LeaveRequestRepo(AttendancetrackContext attendancetrackContext, IMapper mapper)
        {
            _attendancetrackContext = attendancetrackContext;
            this._mapper = mapper;
        }
        public async Task<LeaveRequestModel[]> GetLeaveRequests(string name)
        {
            try
            {

                var lst = await _attendancetrackContext.LeaveRequests.Include(o => o.Employee).Where(o => o.IsActive ?? false).Select(o => _mapper.Map<LeaveRequestModel>(o)).ToArrayAsync().ConfigureAwait(false);
                return lst;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<LeaveRequestModel> GetLeaveRequest(int LeaveRequestId)
        {
            var lst = await _attendancetrackContext.LeaveRequests.Where(o => o.Id == LeaveRequestId && (o.IsActive ?? false)).Select(o => _mapper.Map<LeaveRequestModel>(o)).FirstOrDefaultAsync().ConfigureAwait(false);
            return lst;
        }

        public async Task<bool> Save(LeaveRequestModel leaveRequestModel)
        {
            var dbDeptModel = await _attendancetrackContext.LeaveRequests.FirstOrDefaultAsync(o => o.Id == leaveRequestModel.Id).ConfigureAwait(false);
            if (dbDeptModel != null)
            {
                dbDeptModel = _mapper.Map<LeaveRequestModel, LeaveRequests>(leaveRequestModel, dbDeptModel); // dbDeptModel.FirstName = LeaveRequestModel.FirstName;
                dbDeptModel.ModifiedDate = DateTime.Now;
            }
            else
            {
                var countId = await _attendancetrackContext.LeaveRequests.CountAsync().ConfigureAwait(false);
                await _attendancetrackContext.LeaveRequests.AddAsync(_mapper.Map<LeaveRequests>(leaveRequestModel)).ConfigureAwait(false);

            }
            await _attendancetrackContext.SaveChangesAsync().ConfigureAwait(false);
            return true;
        }


    }
}
