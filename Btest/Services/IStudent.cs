using BtestShared.Models;
 
namespace Btest.Services
{

    public interface IStudent
    {
        Task<IEnumerable<Students>> GetStudentsAsync();

    }
}
