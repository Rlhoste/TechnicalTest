using UnityEngine;

[System.Serializable]
public class DataStructure
{
    public int id;
    public string title;
    public string content;
}

[System.Serializable]
public class Data
{
    public DataStructure[] dataStructures;
    public int getDataSize() { return dataStructures.Length; }
    public DataStructure getDataAt(int i) { return dataStructures[i]; }
}
