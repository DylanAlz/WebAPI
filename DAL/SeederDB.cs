
using WebAPI.DAL.Entities;

namespace WebAPI.DAL
{
    public class SeederDB
    {
        private readonly DataBasecontext _context;

        public SeederDB(DataBasecontext context)
        {
            _context = context;            
        }

        /*crearemos el metodo llamado seederasync(), este metodo es una especie de MAIN
        Este metodo tendra la responsabilidad de prepoblar mi BD */
        public async Task SeederAsync()
        {
            //este metodo creara la bd inmediatamente ponga en ejecucion la api
            await _context.Database.EnsureCreatedAsync();

            await PopulateCountriesAsync();
            await _context.SaveChangesAsync();
        }

        #region Private Methods
        private async Task PopulateCountriesAsync()
        {
            if (!_context.Countries.Any())
            {
                //asi creo yo un pais con sus respectivos estados
                _context.Countries.Add(new Country
                {
                    CreatedDate = DateTime.Now,
                    Name = "Colombia",
                    States = new List<State>()
                    {
                        new State
                        {
                            CreatedDate = DateTime.Now,
                            Name = "Antioquia"
                        },

                        new State
                        {
                            CreatedDate = DateTime.Now,
                            Name = "Cundinamarca"
                        }
                    }
                });

                //creando otro pais
                _context.Countries.Add(new Country
                {
                    CreatedDate = DateTime.Now,
                    Name = "Alemania",
                    States = new List<State>()
                    {
                        new State
                        {
                            CreatedDate = DateTime.Now,
                            Name = "Hamburgo"
                        }
                    }
                });
            }
        }

        #endregion
    }
}
