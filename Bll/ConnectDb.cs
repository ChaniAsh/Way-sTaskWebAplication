using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;

namespace Bll
{
    public class ConnectDb
    {
        Entities db = new Entities();
        public List<Task_Dto> GetAllTasks()
        {

            List<Dto.Task_Dto> lst = new List<Dto.Task_Dto>();
            foreach (var item in db.Task.ToList())
            {
                lst.Add(Task_Dto.DaltoDto(item));
            }

            return lst;
        }

        public List<Position_Dto> GetAllPositions()
        {
            List<Position_Dto> lst = new List<Position_Dto>();
            foreach (var item in db.Position.ToList())
            {
                lst.Add(Position_Dto.DaltoDto(item));
            }
            return lst;
        }

        public void AddPosition(Position_Dto position)
        {
            DalInstance.db.Position.Add(position.DtoToDal());
            DalInstance.db.SaveChanges();
        }
        public void AddTask(Task_Dto task)
        {
            DalInstance.db.Task.Add(task.DtoToDal());
            DalInstance.db.SaveChanges();
        }
        //public Task_Dto GetCustomerById(string id)
        //{
        //    Dto.Task_Dto customer = new Dto.Task_Dto();
        //    List<Dto.Task_Dto> lst = GetAllCustomers();
        //    foreach (var item in lst)
        //    {
        //        if (item.id == id)
        //        {
        //            customer = item;
        //        }               
        //    }
        //    return customer;
        //}

        //public Task_Dto GetCustomerByName(string name)
        //{
        //    Dto.Task_Dto customer = new Dto.Task_Dto();
        //    List<Dto.Task_Dto> lst = GetAllCustomers();
        //    foreach (var item in lst)
        //    {
        //        if (item.name == name)
        //        {
        //            customer = item;
        //        }
        //    }
        //    return customer;
        //}



    }
}
