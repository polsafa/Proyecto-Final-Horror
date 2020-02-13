using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Objectives : MonoBehaviour
{
    public class objetive
    {
        private string sceneName;
        private int status;

        static public List<Objectives> pets = new List<Objectives>()
    {
            
    };
    } 
    
   /* private void Read()
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
    }*/
}

