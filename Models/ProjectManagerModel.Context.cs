﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectManager_WebAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ProjectManagerEntities : DbContext
    {
        public ProjectManagerEntities()
            : base("name=ProjectManagerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ParentTask> ParentTasks { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<User> Users { get; set; }
    
        public virtual int AddProjectInfo(string project, Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate, Nullable<int> priority, Nullable<int> managerID)
        {
            var projectParameter = project != null ?
                new ObjectParameter("Project", project) :
                new ObjectParameter("Project", typeof(string));
    
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("StartDate", startDate) :
                new ObjectParameter("StartDate", typeof(System.DateTime));
    
            var endDateParameter = endDate.HasValue ?
                new ObjectParameter("EndDate", endDate) :
                new ObjectParameter("EndDate", typeof(System.DateTime));
    
            var priorityParameter = priority.HasValue ?
                new ObjectParameter("Priority", priority) :
                new ObjectParameter("Priority", typeof(int));
    
            var managerIDParameter = managerID.HasValue ?
                new ObjectParameter("ManagerID", managerID) :
                new ObjectParameter("ManagerID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddProjectInfo", projectParameter, startDateParameter, endDateParameter, priorityParameter, managerIDParameter);
        }
    
        public virtual int DeleteUser(Nullable<int> employeeID)
        {
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("EmployeeID", employeeID) :
                new ObjectParameter("EmployeeID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteUser", employeeIDParameter);
        }
    
        public virtual int EditUser(string firstName, string lastName, Nullable<int> employeeID)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("EmployeeID", employeeID) :
                new ObjectParameter("EmployeeID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EditUser", firstNameParameter, lastNameParameter, employeeIDParameter);
        }
    
        public virtual ObjectResult<GetProjectList_Result> GetProjectList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetProjectList_Result>("GetProjectList");
        }
    
        public virtual ObjectResult<GetUserList_Result> GetUserList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetUserList_Result>("GetUserList");
        }
    
        public virtual int InsertUserInfo(string firstName, string lastName)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertUserInfo", firstNameParameter, lastNameParameter);
        }
    
        public virtual int SuspendProject(Nullable<int> projectID)
        {
            var projectIDParameter = projectID.HasValue ?
                new ObjectParameter("ProjectID", projectID) :
                new ObjectParameter("ProjectID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SuspendProject", projectIDParameter);
        }
    
        public virtual int UpdateProjectInfo(Nullable<int> projectID, string project, Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate, Nullable<int> priority, Nullable<int> isSuspended)
        {
            var projectIDParameter = projectID.HasValue ?
                new ObjectParameter("ProjectID", projectID) :
                new ObjectParameter("ProjectID", typeof(int));
    
            var projectParameter = project != null ?
                new ObjectParameter("Project", project) :
                new ObjectParameter("Project", typeof(string));
    
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("StartDate", startDate) :
                new ObjectParameter("StartDate", typeof(System.DateTime));
    
            var endDateParameter = endDate.HasValue ?
                new ObjectParameter("EndDate", endDate) :
                new ObjectParameter("EndDate", typeof(System.DateTime));
    
            var priorityParameter = priority.HasValue ?
                new ObjectParameter("Priority", priority) :
                new ObjectParameter("Priority", typeof(int));
    
            var isSuspendedParameter = isSuspended.HasValue ?
                new ObjectParameter("IsSuspended", isSuspended) :
                new ObjectParameter("IsSuspended", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateProjectInfo", projectIDParameter, projectParameter, startDateParameter, endDateParameter, priorityParameter, isSuspendedParameter);
        }
    }
}
