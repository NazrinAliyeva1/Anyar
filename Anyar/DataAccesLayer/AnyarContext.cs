using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;

namespace Anyar.DataAccesLayer
{
    public class AnyarContext : DbContext
    {
        private readonly DbContextOptions _options;

        public AnyarContext(DbContextOptions options): base(options)
        {
           _options = options;
        }

    }
}
