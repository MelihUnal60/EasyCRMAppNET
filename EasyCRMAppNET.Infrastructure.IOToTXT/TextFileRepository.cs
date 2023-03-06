using EasyCRMAppNET.Domain.Entities;
using EasyCRMAppNET.Domain.Entities.Base;
using EasyCRMAppNET.Domain.Interfaces;
using System.Text.Json;

namespace EasyCRMAppNET.Infrastructure.IOToTXT
{
    public class TextFileRepository<T> : IRepository<T> where T : BaseEntity
    {
        private static string FileName
        {
            get
            {
                return typeof(T).FullName.Replace(".","") + ".txt";
            }
        }

        private static List<T> Items = new List<T>();

        private static void LoadListFromFile()

        {
            if(!File.Exists(FileName)) 
            {
                Items = new List<T>();
                return;
            }
            var json = File.ReadAllText(FileName);
            Items = JsonSerializer.Deserialize<List<T>>(json);

        }

        private static void WriteListToTxt()
        {
            var jsonText = JsonSerializer.Serialize(Items);
            File.WriteAllText(FileName, jsonText);
        }

        static TextFileRepository()

        {
            LoadListFromFile();
        }

        public T Add(T entity)
        {
            LoadListFromFile();
            Items.Add(entity);
            WriteListToTxt();
            return entity;
        }

        public T GetById(int id)
        {
            LoadListFromFile();
            var entity = Items.FirstOrDefault(x => x.Id == id);
            return entity;
        }

        public ICollection<T> GetList(Func<T, bool> expression = null)
        {
            LoadListFromFile();

            return expression == null ? Items : Items.Where(expression).ToList(); //daha sade yazımı

            //if(expression == null)
            //{
            //    return Items;
            //}
            //else
            //{
            //    return Items.Where(expression).ToList();
            //}
        }

        public bool Remove(int id)
        {
            LoadListFromFile();
            var deletedItem = Items.FirstOrDefault(x => x.Id == id);

            if (deletedItem != null)
            {
                Items.Remove(deletedItem);
                WriteListToTxt();
                return true;
            }
            return false;
            
        }

        public T Update(int id, T entity)
        {
            if(id != entity.Id)
                throw new ArgumentException("Id değerleri uyuşmuyor!!");

            LoadListFromFile();
            var updatedItem = Items.FirstOrDefault(x =>x.Id == id);
            if (updatedItem == null)
                throw new Exception("Güncellenecek varlık bulunamadı!!");

            Items.Remove(updatedItem);
            Items.Add(entity);
            WriteListToTxt();
            return entity;
            
        }
    }
}