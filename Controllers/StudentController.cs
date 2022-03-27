using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestfulApiWithEFCore.Models;
using RestfulApiWithEFCore.Models.Data;

namespace RestfulApiWithEFCore.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        Context _db;
        public StudentController(Context db)
        {
            _db = db;
        }

        [HttpGet(Name = "GetList")]
        public IEnumerable<Student> GetList()
        {
            return _db.Set<Student>().ToList();
        }

        [HttpGet(Name = "FindStudent")]
        public Student FindStudent(int id)
        {
            return _db.Set<Student>().Find(id);
        }

        [HttpPost(Name = "AddStudent")]
        public Student AddStudent(Student model)
        {
            _db.Set<Student>().Add(model);
            _db.SaveChanges();
            return model;
        }

        [HttpPut(Name = "UpdateStudent")]
        public Student UpdateStudent(Student model)
        {
            _db.Set<Student>().Update(model);
            _db.SaveChanges();
            return model;
        }

        [HttpDelete(Name = "DeleteStudent")]
        public Student DeleteStudent(Student model)
        {
            _db.Set<Student>().Remove(model);
            _db.SaveChanges();
            return model;
        }

    }
}
