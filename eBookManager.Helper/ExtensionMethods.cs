using eBookManager.Engine;
using System;
using System.Collections.Generic;
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
    }
}
