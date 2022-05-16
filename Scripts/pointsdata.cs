using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class pointsdata
    {
        public static void savepoint(points points)
        {
            BinaryFormatter formatter=new BinaryFormatter();
            string path = Application.persistentDataPath+"/sp.fun";
            FileStream stream = new FileStream(path, FileMode.Create);
            
            savedata data = new savedata(points);

            formatter.Serialize(stream, data);
            stream.Close();
        }

        public static void savepurchase()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Application.persistentDataPath + "/bg.ttt";
            FileStream stream = new FileStream(path, FileMode.Create);

        //ThemeStoreController data = new ThemeStoreController();
        }
        
        public static savedata loaddata ()
        {
            string path = Application.persistentDataPath+"/sp.fun";
            if(File.Exists(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream stream = new FileStream(path, FileMode.Open);

                savedata data = formatter.Deserialize(stream) as savedata;

                stream.Close();
                return data;

            }
            else
            {
                Debug.Log("Save File not found in "+path);
                return null;
            }
        }
    }