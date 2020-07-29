using System.Threading.Tasks;
using zenxu.Models;
using Zenxu.Data.Entities;

namespace zenxu.Interfaces
{
    public interface IPropertyService
    {
        Task Add(PropertyModel model);
    }
}