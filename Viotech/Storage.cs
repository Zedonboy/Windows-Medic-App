using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Viotech
{
    class Storage
    {
        private DirectoryInfo directoryInfo;
        public Storage() {
            string path = Directory.GetCurrentDirectory();
            var dirInfo = new DirectoryInfo(path + "/data");
            if (dirInfo.Exists)
            {
                directoryInfo = dirInfo;
            }
            else
            {
                var newDirInfo = new DirectoryInfo(path);
                newDirInfo.CreateSubdirectory("/data");
                directoryInfo = newDirInfo;
            }
        }
        public List<User> GetStoredUsers() {
            // read a binary file
            var binaryFormatter = new BinaryFormatter();
            var path = Directory.GetCurrentDirectory();
            // Here check if file exists! possible errors
            var filestream = File.OpenRead(path + "/data.bin");
            Object obj = binaryFormatter.Deserialize(filestream);
            List<User> listofUsers = (List<User>)obj;
            return listofUsers;
        }
        public void SaveUser(User user)
        {

        }
    }
}
//Bit.ly/ssean