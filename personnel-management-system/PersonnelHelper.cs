using Microsoft.EntityFrameworkCore;

namespace personnel_management_system
{
    public class PersonnelHelper
    {
        private readonly DataContext _context;

        public PersonnelHelper(DataContext context)
        {
            _context = context;
        }

        public async Task Add(Personnel personnel)
        {
            await _context.Personnels.AddAsync(personnel);
            await _context.SaveChangesAsync();
        }

        public async Task<Personnel> GetById(int id)
        {
            return await _context.Personnels.FindAsync(id);
        }

        public async Task<List<Personnel>> GetAll()
        {
            return await _context.Personnels.ToListAsync();
        }

        public async Task Update(Personnel personnel)
        {
            Personnel currentPersonnel = await _context.Personnels.FindAsync(personnel.Id);

            if (currentPersonnel != null)
            {
                _context.Entry(currentPersonnel).CurrentValues.SetValues(personnel);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteById(int id)
        {
            Personnel personnel = await _context.Personnels.FindAsync(id);

            if (personnel != null) 
            {
                _context.Personnels.Remove(personnel);
                await _context.SaveChangesAsync();
            }
        }
    }
}
