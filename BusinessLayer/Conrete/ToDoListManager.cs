using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Conrete
{
    public class ToDoListManager : IToDoListService
    {
        IToDoListDal _toDoList;

        public ToDoListManager(IToDoListDal toDoList)
        {
            _toDoList = toDoList;
        }

        public List<ToDoList> GetList()
        {
            return _toDoList.GetList();
        }

        public void TAdd(ToDoList t)
        {
            _toDoList.Insert(t);
        }

        public void TDelete(ToDoList t)
        {
            _toDoList.Delete(t);
        }

        public ToDoList TGetById(int id)
        {
            return _toDoList.GetById(id);
        }

        public void TUpdate(ToDoList t)
        {
            _toDoList.Update(t);
        }
    }
}
