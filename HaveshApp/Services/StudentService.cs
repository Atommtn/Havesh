using Microsoft.EntityFrameworkCore;
using HaveshApp.Model;
using Olive;
using HaveshApp.Classes;
using System.Xml;
using System.Linq;

namespace HaveshApp.Services
{
    public class StudentService
    {
        readonly MyDbContext _dbConntext;

        public StudentService(MyDbContext dbConntext)
        {
            _dbConntext = dbConntext;
        }

        public List<ShokouhPardisStudentClass> GetStudents()
        {
            var list = _dbConntext.ShokouhPardisStudentClasses.ToList();
            return list;
        }


        public void NormalData()
        {
            var list = _dbConntext.FormShokouhOnlinePortalStudentNameTels.ToList();
            foreach (var studentRec in list)
            {
                for (var i = 0; i < 17; i++)
                {
                    var name = studentRec.GetProperty<FormShokouhOnlinePortalStudentNameTel, string>("StdName" + i);
                    var tel = studentRec.GetProperty<FormShokouhOnlinePortalStudentNameTel, string>("Tel" + i);
                    List<string>? mobileList = new();
                    List<string>? fixList = new();
                    if (tel.IsNullOrEmpty()) continue;

                    var phones = tel.Split(new[] { ' ', '\r', '\n', '/' }, StringSplitOptions.RemoveEmptyEntries);
                    if (phones.Length > 1)
                    {
                        foreach (var phone in phones)
                        {
                            if (phone.StartsWith("09"))
                                mobileList.Add(phone.GetTelephone());
                            else
                                fixList.Add(phone.GetTelephone());
                        }
                    }
                    else
                    {
                        while (tel.Length > 0)
                        {
                            if (tel.StartsWith("09"))
                            {
                                var min = Math.Min(tel.Length, 11);
                                var part1 = tel.Substring(0, min).GetTelephone();
                                tel = tel.Substring(min);
                                mobileList.Add(part1);
                            }
                            else
                            {
                                var min = Math.Min(tel.Length, 8);
                                var part1 = tel.Substring(0, min).GetTelephone();
                                tel = tel.Substring(min);
                                fixList.Add(part1);
                            }
                        }
                    }

                    var newStudent = new ShokouhPardisStudentClass
                    {
                        StudentName = name.RemoveFromAfter(" ").Trim(),
                        StudentFamily = name.RemoveBeforeAndIncluding(" "),
                        StudentClassGuid = Guid.NewGuid(),
                        StudentClassLastModified = DateTime.Now,
                        HomePhone = fixList.FirstOrDefault()
                    };

                    foreach (var mobile in mobileList)
                    {
                        if (newStudent.MotherPhone is null)
                        {
                            newStudent.MotherPhone = mobile;
                            continue;
                        }
                        if (newStudent.FatherPhone is null)
                        {
                            newStudent.FatherPhone = mobile;
                            continue;
                        }
                        if (newStudent.StudentPhone is null)
                        {
                            newStudent.StudentPhone = mobile;
                        }
                    }

                    _dbConntext.ShokouhPardisStudentClasses.Add(newStudent);
                }
            }

            _dbConntext.SaveChanges();
        }
        public int GetTotalStudentCount( List<int?>? studentIds = null)
        {
            var iQ = _dbConntext.ShokouhPardisStudentClasses.AsQueryable();
            if (studentIds is { })
            {
                iQ = iQ.Where(x => studentIds.Contains(x.StudentClassId));
            }
            
            return iQ.Count();
        }

        public List<ShokouhPardisStudentClass> GetStudentPaged(int page, int size, string? searchText,
            List<int?>? studentIds = null)
        {
            var queryable = _dbConntext.ShokouhPardisStudentClasses.AsQueryable();
            if (studentIds is { })
            {
                queryable = queryable.Where(x => studentIds.Contains(x.StudentClassId));
            }

           
            if (searchText is not null)
            {
                var words = searchText.Trim().Split(new[] { ' ', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var word in words)
                {
                    queryable = queryable.Where(x => x.StudentName.Contains(word) ||
                                                     x.StudentFamily.Contains(word) ||
                                                     x.StudentPhone.Contains(word) ||
                                                     x.FatherPhone.Contains(word) ||
                                                     x.MotherPhone.Contains(word) ||
                                                     x.HomePhone.Contains(word) ||
                                                     x.StudentIdno.Contains(word) ||
                                                     x.StudentMotherFullName.Contains(word));

                }
            }
            var list = queryable

                .Skip(page * size).Take(size).ToList();
            return list;
        }

        public void SaveStudent(ShokouhPardisStudentClass student)
        {
            student.StudentClassLastModified = DateTime.Now;
            _dbConntext.ShokouhPardisStudentClasses.Update(student);
            _dbConntext.SaveChanges();
        }

        public int GetStudentsInTimeTableCount(ShokouhPardisTimeTable timeTable)
        {
            var students = GetStudentInTimeTableQuery(timeTable);
            
            return students.Count();
        }

        public List<ShokouhPardisStudentClass> GetStudentsInTimeTable(ShokouhPardisTimeTable timeTable)
        {
            var students = GetStudentInTimeTableQuery(timeTable);
            
            var data = students.Select(x => x.Student)
            .ToList();
            return data;
        }

        public List<ShokouhPardisStudentClass> GetStudentsInTimeTablePaged(ShokouhPardisTimeTable timeTable, int page,
            int pageSize, string? searchText)
        {
            var students = GetStudentInTimeTableQuery(timeTable, searchText);
            
            var data = students
                .Skip(page * pageSize)
                .Take(pageSize)
                .Select(x => x.Student)
                .ToList();
            return data;
        }

        IQueryable<ShokouhPardisTimeTableStudent> GetStudentInTimeTableQuery(ShokouhPardisTimeTable timeTable)
        {
            var students = _dbConntext
                .ShokouhPardisTimeTableStudents
                .Include(x => x.Student)
                .Where(x => x.TimeTableId == timeTable.TimeTableId);
            return students;
        }
        IQueryable<ShokouhPardisTimeTableStudent> GetStudentInTimeTableQuery(ShokouhPardisTimeTable timeTable, string? searchText)
        {
            var queryable = _dbConntext
                .ShokouhPardisTimeTableStudents
                .Include(x => x.Student)
                .Where(x => x.TimeTableId == timeTable.TimeTableId);
            if (searchText is not null)
            {
                queryable = queryable.Where(x => x.Student.StudentName.Contains(searchText) ||
                                                 x.Student.StudentFamily.Contains(searchText) ||
                                                 (x.Student.StudentPhone != null && x.Student.StudentPhone.Contains(searchText)) ||
                                                 (x.Student.FatherPhone != null && x.Student.FatherPhone.Contains(searchText)) ||
                                                 (x.Student.MotherPhone != null && x.Student.MotherPhone.Contains(searchText)) ||
                                                 (x.Student.HomePhone != null && x.Student.HomePhone.Contains(searchText)) ||
                                                 (x.Student.StudentIdno != null && x.Student.StudentIdno.Contains(searchText)) ||
                                                 (x.Student.StudentMotherFullName != null && x.Student.StudentMotherFullName.Contains(searchText)));
            }
            return queryable;
           
        }
        public bool IsDuplicatedStudent(ShokouhPardisStudentClass student, int stuId = 0)
        {
            var iQueryable = _dbConntext.ShokouhPardisStudentClasses
                .Where(x =>
                    x.StudentName.Contains(student.StudentName) &&
                    x.StudentFamily.Contains(student.StudentFamily));
            if (student.StudentFatherName is { })
                iQueryable = iQueryable.Where(x => x.StudentFatherName.Contains(student.StudentFatherName));
            var result = iQueryable.ToList();

            if (!result.Any()) return false;

            if (result.Count == 1 && result.First().StudentClassId == stuId) return false;

            return true;
        }

        public void DeleteStudent(ShokouhPardisStudentClass student)
        {
            _dbConntext.ShokouhPardisStudentClasses.Remove(student);
            _dbConntext.SaveChanges();
        }

        public List<ShokouhPardisStudentClassOnlineForm> GetStudentsprofile()
        {

            var list = _dbConntext.ShokouhPardisStudentClassOnlineForms.ToList();
            return list;
        }

        public int GetTotalStudentsProfile(List<int> studentIds = null)
        {
            var iQ = _dbConntext.ShokouhPardisStudentClassOnlineForms.AsQueryable();
            if (studentIds is { })
            {
                iQ = iQ.Where(x => studentIds.Contains(x.StudentClassId));
            }
            return iQ.Count();
        }

        public List<ShokouhPardisStudentClassOnlineForm> GetPagedStudentProfile(int page, int size, string? searchText, List<int> studentIds)
        {

            var queryable = _dbConntext.ShokouhPardisStudentClassOnlineForms.AsQueryable();
            if (studentIds is { })
            {
                queryable = queryable.Where(x => studentIds.Contains(x.StudentClassId));
            }
            if (searchText is not null)
            {
                queryable = queryable.Where(x => x.StudentName.Contains(searchText) ||
                                                 x.StudentFamily.Contains(searchText) ||
                                                 x.StudentPhone.Contains(searchText) ||
                                                 x.FatherPhone.Contains(searchText) ||
                                                 x.MotherPhone.Contains(searchText) ||
                                                 x.HomePhone.Contains(searchText) ||
                                                 x.StudentAddress.Contains(searchText) ||
                                                 x.StudentMotherFullName.Contains(searchText));
            }
            var list = queryable.Skip(page * size).Take(size).ToList();
            return list;
        }

        public void SaveOnlineProfile(ShokouhPardisStudentClassOnlineForm student)
        {
            _dbConntext.ShokouhPardisStudentClassOnlineForms.Update(student);
            _dbConntext.SaveChanges();
        }

        public int GetStudentsInTermCount(ShokouhPardisTermClass term, string? search, bool hasnotIdNo)
        {
            var count = StudentsInTermQuery(term, search, hasnotIdNo).Count();
            return count;

        }
        public List<ShokouhPardisStudentClass> GetStudentsInTerm(ShokouhPardisTermClass term, string? search)
        {
            var students = StudentsInTermQuery(term,search,false);
            var data = students
                .Select(x => x.Student)
                .ToList();
            return data;

        }
        public List<ShokouhPardisStudentClass> GetStudentsInTermPaged(ShokouhPardisTermClass term, int page,
            int pageSize, string? search, bool hasnotIdNo)
        {
            var students = StudentsInTermQuery(term, search, hasnotIdNo);
            var data = students
                .Skip(page * pageSize)
                .Take(pageSize)
                .Select(x => x.Student)
                .ToList();
            return data;

        }

        IQueryable<ShokouhPardisTimeTableStudent> StudentsInTermQuery(ShokouhPardisTermClass term,string? searchText,bool hasnotIdNo)
        {
            var queryable = _dbConntext
                    .ShokouhPardisTimeTableStudents
                    .Include(x => x.Student)
                    .Include(x => x.TimeTable)
                    .ThenInclude(x => x.Term)
                    .Where(x => x.TimeTable.Term.TermClassId == term.TermClassId)
                ;
            if (searchText is not null)
            {
                queryable = queryable.Where(x => x.Student.StudentName.Contains(searchText) ||
                                                 x.Student.StudentFamily.Contains(searchText) ||
                                                 (x.Student.StudentPhone != null && x.Student.StudentPhone.Contains(searchText)) ||
                                                 (x.Student.FatherPhone != null && x.Student.FatherPhone.Contains(searchText)) ||
                                                 (x.Student.MotherPhone !=null && x.Student.MotherPhone.Contains(searchText)) ||
                                                 (x.Student.HomePhone !=null && x.Student.HomePhone.Contains(searchText)) ||
                                                 (x.Student.StudentIdno !=null && x.Student.StudentIdno.Contains(searchText)) ||
                                                 (x.Student.StudentMotherFullName!=null && x.Student.StudentMotherFullName.Contains(searchText)));
            }
            if (hasnotIdNo)
            {
                queryable = queryable.Where(x => x.Student.StudentIdno.Length <= 9);
            }
            return queryable;
        }

        public int GetTotalPreRegisterStudentCount(ShokouhPardisTimeTable tt)
        {
            var iQ = _dbConntext.PreRegistrations.AsQueryable();
            if (tt.Level is { })
            {
                iQ = iQ.Where(x => (x.IsArchive == null || x.IsArchive == false) &&
                                   x.Level.LevelClassId == tt.Level.LevelClassId);
            }
            return iQ.Count();
        }

        public List<ShokouhPardisStudentClass> GetPreRegisterStudentPaged(int page, int size, string? searchText, ShokouhPardisTimeTable tt)
        {


            IQueryable<ShokouhPardisStudentClass> queryable = _dbConntext.PreRegistrations
                .Include(x => x.Student)
                .Where(x => (x.IsArchive == null || x.IsArchive == false) &&
                            x.LevelFk == tt.Level.LevelClassId &&
                            x.TermFk == tt.TermId)
                .Select(x => x.Student).AsQueryable();
            
            if (searchText is not null)
            {
                var words = searchText.Trim().Split(new[] { ' ', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var word in words)
                {
                    queryable = queryable.Where(x => x.StudentName.Contains(word) ||
                                                     x.StudentFamily.Contains(word) ||
                                                     x.StudentPhone.Contains(word) ||
                                                     x.FatherPhone.Contains(word) ||
                                                     x.MotherPhone.Contains(word) ||
                                                     x.HomePhone.Contains(word) ||
                                                     x.StudentIdno.Contains(word) ||
                                                     x.StudentMotherFullName.Contains(word));

                }
            }
            var list = queryable.Skip(page * size).Take(size).ToList();
            return list;
        }
    }
}
