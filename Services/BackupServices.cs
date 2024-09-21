using ApiNet8.Data;
using ApiNet8.Services.IServices;
using AutoMapper;

namespace ApiNet8.Services
{
    public class BackupServices : IBackupServices
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public BackupServices(ApplicationDbContext db, IConfiguration configuration, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            this._db = db;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }
    }
}
