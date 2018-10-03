using eBookManager.Engine;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace eBookManager.Helper
{
    public static  class ExtensionMethods
    {
        public static int ToInt(this string value, int defaultInteger = 0)
        {
            try
            {
                if (int.TryParse(value, out int validInteger))
                {
                    return validInteger;
                }
                else
                {
                    return defaultInteger;
                }
            }
            catch 
            {
                return defaultInteger;
            }
        }
        public static double ToMegaBytes(this long bytes)
        {
            return (bytes > 0) ? (bytes / 1024f) / 1024f : bytes;
        }
        public static bool StorageSpaceExists(this List<StorageSpace> space, 
            string nameValueToCheck, out int storageSpaceId)
        {
            bool exists = false;
            storageSpaceId = 0;
            if (space.Count() != 0)
            {
                int count = (from r in space
                             where r.Name.Equals(nameValueToCheck)
                             select r).Count();

                if (count > 0)
                {
                    exists = true;
                }
                storageSpaceId = (from r in space select r.ID).Max() + 1;
            }
            return false;
        }
        public static void WriteToDataStore(this List<StorageSpace> value,
            string storagePath, bool appendToExistingFile = false)
        {
            
         
            var json = new JsonSerializer();
            json.Formatting = Formatting.Indented;
            using (StreamWriter sw = new StreamWriter(storagePath,appendToExistingFile))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    json.Serialize(writer, value);
                }
            }
        }

        public static List<StorageSpace> ReadFromDataStore(this List<StorageSpace> value,
            string storagePath)
        {
            JsonSerializer json = new JsonSerializer();
            if (!File.Exists(storagePath))
            {
                var newFile = File.Create(storagePath);
                newFile.Close();
            }
            using (StreamReader sr = new StreamReader(storagePath))
            {
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    var retVal = json.Deserialize<List<StorageSpace>>(reader);
                    if (retVal is null)
                    {
                        retVal = new List<StorageSpace>();
                    }
                    return retVal;
                }
            }
        }
    }
}
