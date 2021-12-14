using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadanie.Данные;

namespace Zadanie.Сервис
{
    class FitServise
    {

        private readonly string PATH;

        public FitServise(string path)
        {
            PATH = path;
        }
    
        public BindingList<Date> LoadDate()
        {
            var fileExists = File.Exists(PATH);
            if(!fileExists)
            {
                File.CreateText(PATH).Dispose();
                return new BindingList<Date>();
            }

            using (var reader = File.OpenText(PATH)) 
            
            {
                var fileText = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<Date>>(fileText);
            }

        }

        public void SaveDate(object toDataList)
        {
            using (StreamWriter writer = File.CreateText(PATH)) 
            {
                string output = JsonConvert.SerializeObject(toDataList);
                writer.Write(output);
            }
        }
       

    }
}
