using System;
using System.Threading.Tasks;
using zenxu.Interfaces;
using zenxu.Models;
using Zenxu.Data.DatabaseContexts.ApplicationDbContext;
using Zenxu.Data.Entities;

namespace zenxu.Services
{
    public class PropertyService : IPropertyService
    {
        private readonly ApplicationDbContext _context;

        public PropertyService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Add(PropertyModel model)
        {
            if(model is null) throw new ArgumentNullException(message:"Invalid input", null);

            var property = new Property{
                Id = Guid.NewGuid().ToString(),
                Title = model.Title,
                NumberOfBaths = model.NumberOfBaths,
                NumberOfRooms = model.NumberOfRooms,
                NumberOfToilets = model.NumberOfToilets,
                ContantPhoneNumber = model.ContantPhoneNumber,
                CreatedAt = DateTime.Now,
                Address = model.Address,
                Price = model.Price,
                Description = model.Description
            };
            await _context.AddAsync(property);
            await _context.SaveChangesAsync();
        }
    }
}