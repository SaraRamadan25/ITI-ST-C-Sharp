using Demo1.Models;

namespace Demo1.BLL
{
    public interface IStudent
    {
        public List<Student> GetAll();

        public Student GetById(int id);

        public Student Update(Student std);

        public Student Add(Student std);

        public void Delete(int id);
    }
}
