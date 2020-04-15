using DashboardDevOps.Data;

namespace DashboardDevOps.Interface
{
    public interface ILogin
    {    
        MiddleOneReturn CheckAccess(string user, string pass);
    }
}