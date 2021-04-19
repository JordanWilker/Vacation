using System.Collections.Generic;
using System.Data;
using Dapper;
using vacaaa.Models;

namespace vacaaa.Repositories
{
  public class VacationRepository
  {
    private readonly IDbConnection _db;

    public VacationRepository(IDbConnection db)
    {
      _db = db;
    }
    internal IEnumerable<Vacation> GetAll()
    {
      // REVIEW 
      // dapper is creating an instance of the class so it requires a non-abstract class. the fix for today was to make the vacation item class non abstract, you can still inherit from it,
      //but now it can be instantiated on its own and map the burgers/drinks/sides propertys over properly. 
      // In our use case here we need dapper to create them on the so it is okay to have it not abstract. 
      //ultimately if we wanted to keep the class as abstract, we would query our 3 tables independantly and then cast the results to VacationItem if we wanted that one big collection.
      //this solution is more complicated and leads us down another rabbit hole.
      // since our tables have different columns, you can specificy the colums you want to select from each table and then form a UNION with another table to bring in the data from that table.
      // this will now just grab the name, price, and id from the 3 tables, cast them to VacationItems and retun the full collection.
      //if our tables had the same columns then we could use SELECT * but since there is differences between burgers - drinks/sides we need to specify the columns we want to retrieve.
      string sql = @"SELECT 
      cruises.name,
      cruises.price,
      cruises.id FROM cruises
      UNION SELECT
      trips.name,
      trips.price,
      trips.id FROM trips;";
      return _db.Query<Vacation>(sql);
    }
  }
}