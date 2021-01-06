using AtndTrackBlazorApp.Shared.Models;
using AutoMapper;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DataAccess
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<JobDetail, JobDetailModel>();
            CreateMap<Employee, EmployeeModel>()
                .ForMember(dest => dest.JobDetail, src => src.MapFrom(s => s.JobDetail))
                ;
            CreateMap<Department, DepartmentModel>();
            CreateMap<Roles, RoleModel>();
            CreateMap<DepartmentModel, Department>();
            CreateMap<Designation, DesignationModel>();
            CreateMap<User, UserModel>();
            CreateMap<JobDetailModel, JobDetail>()
                .ForMember(dest => dest.CreatedDate, src => src.MapFrom(s => DateTime.Now))
                ;
            CreateMap<LeaveRequestModel, LeaveRequests>()
                .ForMember(dest => dest.DateFrom, src => src.MapFrom(s => s.DateFrom.Value.UtcDateTime))
                .ForMember(dest => dest.DateTo, src => src.MapFrom(s => s.DateTo.Value.UtcDateTime))
                .ForMember(dest => dest.CreatedDate, src => src.MapFrom(s => DateTime.Now))
                .ForMember(dest => dest.IsActive, src => src.MapFrom(s => true))
                .ForSourceMember(src=>src.EmployeeName,s=>s.DoNotValidate())
                ;
            //.ForMember(dest => dest.IsActive, src => src.MapFrom(s => true));
            CreateMap<LeaveRequests,LeaveRequestModel>()
                .ForMember(dest => dest.DateFrom, src => src.MapFrom(s => DateTime.SpecifyKind(s.DateFrom.Value, DateTimeKind.Local)))
                .ForMember(dest => dest.DateTo, src => src.MapFrom(s => DateTime.SpecifyKind(s.DateTo.Value, DateTimeKind.Local)))
                .ForMember(dest => dest.IsActive, src => src.MapFrom(s => true))
                .ForMember(dest=>dest.EmployeeName,src=>src.MapFrom(s=>s.Employee.FirstName))
                ;
            CreateMap<EmployeeModel, Employee>()
                .ForMember(dest => dest.CreatedDate, src => src.MapFrom(s => DateTime.Now))
                .ForMember(dest => dest.IsActive, src => src.MapFrom(s => true))
                .ForMember(dest => dest.Gender, src => src.MapFrom(s => s.IsMale ? "Male" : "FeMale"))
                .ForMember(dest => dest.JobDetail, src => src.MapFrom(s => s.JobDetail));
            CreateMap<UserModel, User>()
                 .ForMember(dest => dest.CreatedDate, src => src.MapFrom(s => DateTime.Now))
                 .ForMember(dest => dest.IsActive, src => src.MapFrom(s => true));
        }
    }
}
