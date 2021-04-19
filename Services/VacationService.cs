using System.Collections.Generic;
using vacaaa.Interfaces;
using vacaaa.Repositories;

namespace vacaaa.Services
{
  public class VacationService
  {
    private readonly VacationRepository _repo;

    public VacationService(VacationRepository repo)
    {
      _repo = repo;
    }

    internal IEnumerable<IInfo> getAll()
    {
      var data = _repo.GetAll();
      return (IEnumerable<IInfo>)data;
    }
  }
}