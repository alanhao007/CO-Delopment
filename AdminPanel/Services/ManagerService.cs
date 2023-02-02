using AdminPanel.Models;
namespace AdminPanel.Services
{
    public class ManagerService
    {
        ApplicationContext db;

        public ManagerService(ApplicationContext context)
        {
            db = context;
        }
        public List<Managers> GetAll() =>  db.Managers.ToList() ;

        public Managers GetDetails(int ManagerId)
        {
            return db.Managers.Where(x => x.Id == ManagerId).FirstOrDefault();
        }
        public void DeleteManagers(Managers managers)
        {
            db.Managers.Remove(managers);
            db.SaveChanges();
        }
        public int Create(Managers managers)
        {
            db.Managers.Add(managers);
            db.SaveChanges();
            return managers.Id;
        }
        public int Edit(Managers managers)
        {
            var oldId = db.Managers.Where(x => x.Id == managers.Id).FirstOrDefault();
            var oldmanager = GetDetails(managers.Id);
            db.Entry(oldmanager).CurrentValues.SetValues(managers);
            db.SaveChanges();
            return managers.Id;
        }
    }
}
