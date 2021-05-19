using Afonsoft.NewTemplate.EntityFrameworkCore;

namespace Afonsoft.NewTemplate.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly NewTemplateDbContext _context;

        public InitialHostDbBuilder(NewTemplateDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
