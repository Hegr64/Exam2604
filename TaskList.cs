using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class TaskList
    {
        private string name { get; set; }
        private List<Task> tasks = new List<Task>();


        /// <summary>
        /// Конструктор инициализирует список задач с указанным именем.
        /// </summary>
        /// <param name="name"></param>
        public TaskList(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// Возвращает имя списка задач
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// добавляет задачу в список задач
        /// </summary>
        public void AddTask(Task task)
        {
            tasks.Add(task);
        }
        /// <summary>
        /// Возвращает список всех задач
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTask()
        {
            return tasks;
        }
        /// <summary>
        /// Удаляет задачу из списка задач
        /// </summary>
        public void Remove()
        {
            foreach (var task in tasks)
            {
                tasks.Remove(task);
            }
        }

    }
}
