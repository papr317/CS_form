using System;
using System.Collections.Generic;
using System.Linq;

namespace exam
{
    // Обобщенный интерфейс для CRUD-операций с любой сущностью T
    public interface IGenericRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        T GetById(int id); // Добавим для удобства поиска
        List<T> GetAll();
    }

    internal class ex_2
    {
        public class People
        {
            public int ID { get; protected set; }
            public string NAME { get; set; }
            public string DATEBIRTH { get; set; }

            public People(int iD, string nAME, string dATEBIRTH)
            {
                ID = iD;
                NAME = nAME;
                DATEBIRTH = dATEBIRTH;
            }

            public override string ToString() => $"ID: {ID}, Имя: {NAME}, Дата рождения: {DATEBIRTH}";
        }

        public class Student : People
        {
            public string Group { get; set; }

            public Student(int iD, string nAME, string dATEBIRTH, string group)
                : base(iD, nAME, dATEBIRTH)
            {
                Group = group;
            }

            public override string ToString() => $"{base.ToString()}, Группа: {Group}";
        }
        public class EMPLOYER : People
        {
            public string Position { get; set; }
            public EMPLOYER(int iD, string nAME, string dATEBIRTH, string position)
                : base(iD, nAME, dATEBIRTH)
            {
                Position = position;
            }
            public override string ToString() => $"{base.ToString()}, Должность: {Position}";
        }
        public class PUPIL : People
        {
            public string Class { get; set; }
            public PUPIL(int iD, string nAME, string dATEBIRTH, string classs)
                : base(iD, nAME, dATEBIRTH)
            {
                Class = classs;
            }
            public override string ToString() => $"{base.ToString()}, Класс: {Class}";
        }
        public class DRIVER : People
        {
            public string LicenseNumber { get; set; }
            public DRIVER(int iD, string nAME, string dATEBIRTH, string licenseNumber)
                : base(iD, nAME, dATEBIRTH)
            {
                LicenseNumber = licenseNumber;
            }
            public override string ToString() => $"{base.ToString()}, Номер лицензии: {LicenseNumber}";
        }


        public class PeopleManager<T> : IGenericRepository<T> where T : People
        {
            private List<T> _entities = new List<T>();

            public void Add(T entity)
            {
                _entities.Add(entity);
                Console.WriteLine($"Добавлена сущность {entity.NAME}.");
            }

            public void Update(T newEntity)
            {
                var existing = _entities.FirstOrDefault(e => e.ID == newEntity.ID);
                if (existing != null)
                {
                    // Обновляем свойства существующего объекта
                    existing.NAME = newEntity.NAME;
                    existing.DATEBIRTH = newEntity.DATEBIRTH;

                    // Если это студент, обновляем и его свойства
                    if (newEntity is Student newStudent && existing is Student existingStudent)
                    {
                        existingStudent.Group = newStudent.Group;
                    }
                    Console.WriteLine($"Сущность ID {newEntity.ID} обновлена.");
                }
                else
                {
                    Console.WriteLine($"Сущность ID {newEntity.ID} не найдена для обновления.");
                }
            }

            public void Delete(int id)
            {
                var entityToRemove = _entities.FirstOrDefault(e => e.ID == id);
                if (entityToRemove != null)
                {
                    _entities.Remove(entityToRemove);
                    Console.WriteLine($"Сущность ID {id} удалена.");
                }
                else
                {
                    Console.WriteLine($"Сущность ID {id} не найдена для удаления.");
                }
            }

            public T GetById(int id)
            {
                return _entities.FirstOrDefault(e => e.ID == id);
            }

            public List<T> GetAll()
            {
                return _entities;
            }
        }

    }
}