using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using WebAPI.DAL;
using WebAPI.DAL.Entities;
using WebAPI.Domain.Interfaces;

namespace WebAPI.Domain.Services
{
    public class StateService : IStateService
    {
        private readonly DataBasecontext _context;
        public StateService(DataBasecontext context)
        {
            _context = context;
        }

        public async Task<State> CreateStateAsync(Country country, State state)
        {
            throw new NotImplementedException();
        }

        public async Task<State> DeleteStateAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<State> EditStateAsync(Country country, State state)
        {
            throw new NotImplementedException();
        }

        public async Task<State> GetStateByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<State>> GetStatesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
