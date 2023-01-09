using DA.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA.Providers
{
    public class TestProvider
    {
        public async Task<IEnumerable<UserProfile>> LeerPerfiles()
        {
            try
            {
                using (BD_Entities context = new BD_Entities())
                {
                    return await context.UserProfile.ToListAsync();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
