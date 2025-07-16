using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest_TOP_OCR;

namespace UnitTest_TOP_OCR.dbService
{
    public class TestModel_Repository
    {
        public readonly TestDBContext _context;

        public TestModel_Repository(TestDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Test_Model> GetAllList() => _context.TestModel.ToList();
        public Test_Model GetByID(int id) => _context.TestModel.Find(id); 

        public void Add(Test_Model item)
        {
            if (item == null) return;
            _context.TestModel.Add(item);
            _context.SaveChanges(); 
        }
        public void Update(Test_Model item)
        {
            _context.Entry(item).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges(); 
        }
        public void Delete(int id)
        {
            var item = GetByID(id);
            if(item != null)
            {
                _context.TestModel.Remove(item);
                _context.SaveChanges();
            }
        }
    }
}
