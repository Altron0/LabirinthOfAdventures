using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class Save : MonoBehaviour
{
    [SerializeField] Bar heartsBar;
    [SerializeField] Bar manaBar;
    [SerializeField] Bar expBar;

    string path;


    string jsonFile_Position = "Positions.json";
    string jsonFile_Bar = "Bar.json";

    List<SavableClass> savables = new List<SavableClass>();

    int[] savableBar = new int[3];

    void Start()
    {
        path = Path.GetFullPath("./") + @"Save\";
        if (!Directory.Exists(path)) 
        {
            Directory.CreateDirectory(path);
        }
        Debug.Log(path);

        if (buttonContinue.continues == true)
        {
            ParseFromJSON();
            Debug.Log("Yes, continue");
            buttonContinue.continues = false;
        }
    }


    public void ParseToJSON()
    {

        foreach (ISavable Isavable in GetComponentsInChildren<ISavable>())
        {
            SavableClass savable = Isavable.getPRS();
            savables.Add(savable);
        }

        savableBar[0] = (heartsBar.count);
        savableBar[1] = (heartsBar.count);
        savableBar[2] = (expBar.count);

        string jsonPRS = JsonHelper.ToJson<SavableClass>(savables.ToArray());

        string jsonbar = JsonHelper.ToJson<int>(savableBar);

        SaveFile(jsonFile_Position, jsonPRS); 
        
        SaveFile(jsonFile_Bar, jsonbar);

        savables.Clear();
    }
    public void ParseFromJSON()
    {
        string dataPRS = LoadFile(jsonFile_Position);
        string databar = LoadFile(jsonFile_Bar);

        List<SavableClass> savables = JsonHelper.FromJson<SavableClass>(dataPRS).ToList();

        int counter = 0;

        foreach (ISavable Isavable in GetComponentsInChildren<ISavable>())
        {
            SavableClass savable = savables[counter];
            Isavable.setPRS(savable);
        }

        heartsBar.count = savableBar[0];
        heartsBar.count = savableBar[1];
        expBar.count = savableBar[2];
    }

    void SaveFile(string file, string data)
    {
        StreamWriter sw = new StreamWriter(path + file);
        sw.Write(data);
        sw.Close();
    }

    public string LoadFile(string file)
    {
        StreamReader sr = new StreamReader(path + file);
        string data = sr.ReadLine();
        return data;   
    }

    [Serializable]
    public class SavableClass
    {
        public string name;

        public Vector3 Positions;

        public Quaternion Rotations;

        public Vector3 Scale;

    }


    [Serializable]
    public class JsonHelper
    {
        public static string ToJson<T>(T[] array)
        {
            Wrapper<T> wrapper = new Wrapper<T>();
            wrapper.items = array;
            return JsonUtility.ToJson(wrapper);
        }


        public static T[] FromJson<T>(string json) 
        {
            Wrapper<T> wrapper = JsonUtility.FromJson<Wrapper<T>>(json);
            return wrapper.items;
        }

        public class Wrapper<T>
        {
            public T[] items;
        }
    }
}
