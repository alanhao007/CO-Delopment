using AdminPanel.Models;
using Microsoft.EntityFrameworkCore;
using FileTeach = AdminPanel.Models.FileTeach;


namespace AdminPanel.Services
{
    public class PictureTeachService
    {
        ApplicationContext db;
        public PictureTeachService(ApplicationContext context)
        {
            db = context;
        }
        public List<Models.FileTeach> GetAll(int TeachersId)
        {
            return db.PictureTeach.Where(x => x.TeacherId == TeachersId).ToList();
        }
        public List<Models.FileTeach> GetListForTeacher(int TeachersId)
        {
            //вывести картинки для данной новости
            // учитель определяется по полю Teacher Id
            return db.PictureTeach.Where(x => x.TeacherId == TeachersId).ToList();
        }
        public Models.FileTeach GetDetails(int PicturesId)
        {
            return db.PictureTeach.Where(x => x.Id == PicturesId).FirstOrDefault();
        }

        internal void Delete(FileTeach pictures)
        {
            throw new NotImplementedException();
        }

        public string? Create(Models.FileTeach pictures)
        {
            db.PictureTeach.Add(pictures);
            db.SaveChanges();
            return pictures.FilePath;
        }
       
    }
}
