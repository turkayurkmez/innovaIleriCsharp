using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Role
    {
        public List<Permission> Permissions { get; set; }
    }

    public class Admin : Role
    {
        public Admin()
        {
            this.Permissions = new List<Permission>();
            this.Permissions.Add(new ReadDataPermission());
            this.Permissions.Add(new WriteDataPermission());

        }
    }

    public class Standard: Role
    {
        public Standard()
        {
            this.Permissions = new List<Permission>();
            Permissions.Add(new ReadDataPermission());
        }
    }

    public abstract class Permission
    {
        public abstract bool IsAvilable();
    }

    public class ReadDataPermission : Permission
    {
        public override bool IsAvilable()
        {
            throw new NotImplementedException();
        }
    }

    public class WriteDataPermission : Permission
    {
        public override bool IsAvilable()
        {
            throw new NotImplementedException();
        }
    }


    public class GenerateRole<T> where T: Permission, new()
    {
        private T permission;
        public GenerateRole()
        {
            permission = new T();
            
        }
        public bool IsAvailable()
        {
            return permission.IsAvilable();
           
        }
    }
}
