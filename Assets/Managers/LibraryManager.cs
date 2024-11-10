using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibraryManager : MonoBehaviour
{
    public List<ObjectInfo> RawObjects;
    public Dictionary<ObjectTypes, ObjectInfo> ObjectDict = new Dictionary<ObjectTypes, ObjectInfo>();

    void Awake()
    {
        foreach (ObjectInfo i in RawObjects)
        {
            ObjectDict.Add(i.Type,i);
        }
        God.Library = this;
    }

    public Sprite GetSprite(ObjectTypes t)
    {
        if (ObjectDict.ContainsKey(t)) return ObjectDict[t].S;
        Debug.Log("UNFOUND SPRITE: " + t);
        return null;
    }
    
    public AudioClip GetSFx(ObjectTypes t)
    {
        if (ObjectDict.ContainsKey(t)) return ObjectDict[t].SFx;
        Debug.Log("UNFOUND AUDIO: " + t);
        return null;
    }

}

[System.Serializable]
public class ObjectInfo
{
    public ObjectTypes Type;
    public Sprite S;
    public AudioClip SFx;
}

public enum ObjectTypes
{
    None=0,
    Face=1,
    Vamp=2,
    Cube=3
}