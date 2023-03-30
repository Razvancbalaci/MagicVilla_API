using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Repository.IRepository;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Repository
{
    public class VillaNumberRepository : Repository<VillaNumber>, IVillaNumberRepository
    {

        private readonly ApplcationDbContext _db;

        public VillaNumberRepository(ApplcationDbContext db) : base(db)
        {
            _db = db;
        }


        public async Task<VillaNumber> Update(VillaNumber entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.VillaNumber.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
