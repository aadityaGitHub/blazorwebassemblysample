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
    public class UserRepo : IUserRepo
    {
        private readonly AttendancetrackContext _attendancetrackContext;
        private readonly IMapper _mapper;

        public UserRepo(AttendancetrackContext attendancetrackContext, IMapper mapper)
        {
            _attendancetrackContext = attendancetrackContext;
            this._mapper = mapper;
        }
        public async Task<UserModel[]> GetUsers(string name)
        {
            try
            {

                var lst = await _attendancetrackContext.User.Where(o => o.IsActive && o.UserName.Contains(name)).Select(o => _mapper.Map<UserModel>(o)).ToArrayAsync().ConfigureAwait(false);
                return lst;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<bool> Save(UserModel user)
        {
            try
            {
                var dbDeptModel = await _attendancetrackContext.User.FirstOrDefaultAsync(o => o.Id == user.Id).ConfigureAwait(false);
                if (dbDeptModel != null)
                {
                    dbDeptModel = _mapper.Map<UserModel, User>(user, dbDeptModel);
                    dbDeptModel.ModifiedDate = DateTime.Now;
                }
                else
                {
                    await _attendancetrackContext.User.AddAsync(_mapper.Map<User>(user)).ConfigureAwait(false);

                }
                await _attendancetrackContext.SaveChangesAsync().ConfigureAwait(false);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
