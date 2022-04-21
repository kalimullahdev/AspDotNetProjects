﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Linq;

public partial class BestMobilePh53Entities : DbContext
{
    public BestMobilePh53Entities()
        : base("name=BestMobilePh53Entities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public virtual DbSet<tbleMobile> tbleMobiles { get; set; }
    public virtual DbSet<tblReferenceSite> tblReferenceSites { get; set; }
    public virtual DbSet<tblSpecification> tblSpecifications { get; set; }
    public virtual DbSet<tblUser> tblUsers { get; set; }
    public virtual DbSet<tblUserType> tblUserTypes { get; set; }

    public virtual int DeleteMobile(Nullable<int> mid)
    {
        var midParameter = mid.HasValue ?
            new ObjectParameter("mid", mid) :
            new ObjectParameter("mid", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteMobile", midParameter);
    }

    public virtual int DeleteUser(Nullable<int> uid)
    {
        var uidParameter = uid.HasValue ?
            new ObjectParameter("uid", uid) :
            new ObjectParameter("uid", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteUser", uidParameter);
    }

    public virtual int DeleteUserType(Nullable<int> uid)
    {
        var uidParameter = uid.HasValue ?
            new ObjectParameter("uid", uid) :
            new ObjectParameter("uid", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteUserType", uidParameter);
    }

    public virtual ObjectResult<GetAllMobiles_Result> GetAllMobiles()
    {
        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllMobiles_Result>("GetAllMobiles");
    }

    public virtual ObjectResult<GetAllUsers_Result> GetAllUsers()
    {
        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllUsers_Result>("GetAllUsers");
    }

    public virtual ObjectResult<GetAUser_Result> GetAUser(Nullable<int> uid)
    {
        var uidParameter = uid.HasValue ?
            new ObjectParameter("uid", uid) :
            new ObjectParameter("uid", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAUser_Result>("GetAUser", uidParameter);
    }

    public virtual int GetLastSpeci()
    {
        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetLastSpeci");
    }

    public virtual int GetLastSpecID()
    {
        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetLastSpecID");
    }

    public virtual ObjectResult<GetUserType_Result> GetUserType()
    {
        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetUserType_Result>("GetUserType");
    }

    public virtual ObjectResult<DoLogin_Result> DoLogin(string email, string password)
    {
        var emailParameter = email != null ?
            new ObjectParameter("email", email) :
            new ObjectParameter("email", typeof(string));

        var passwordParameter = password != null ?
            new ObjectParameter("password", password) :
            new ObjectParameter("password", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DoLogin_Result>("DoLogin", emailParameter, passwordParameter);
    }
}
