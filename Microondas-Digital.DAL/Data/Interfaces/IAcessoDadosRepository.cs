using Microondas_Digital.DAL.Models;

namespace Microondas_Digital.DAL.Data.Interfaces;

public interface IAcessoDadosRepository
{
    List<ProgramaPersonalizado> GetAll();
    ProgramaPersonalizado? GetById(long id);
    bool Create(ProgramaPersonalizado programaPersonalizado);
    bool Update(ProgramaPersonalizado programaPersonalizado);
    bool Delete(long id);
}
