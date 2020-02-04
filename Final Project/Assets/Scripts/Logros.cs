using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.UI;

public class Logros : MonoBehaviour
{
public class Archivements
    {
        public string scenename;
        public int status;

        public List<Archivements>  ReadArchivements()
        {
            List<Archivements> archiveInfo = new List<Archivements>();
            
     
            return archiveInfo;
        }
        public void read()
        {
            StreamReader reader = new StreamReader("./objectives.txt");
            string itemStrings = reader.ReadLine();
            char[] delimiter = { ';' };
            string[] fields = itemStrings.Split(delimiter);
            while (itemStrings != null)
            {
                for (int i = 0; i < fields.Length; i++)
                {
                    Debug.Log(fields[i]);
                }
                itemStrings = reader.ReadLine();
            }
           
        }


    }
}
