﻿using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using LitJson;

public class SkillJson
{
    public object getSkillJson()
    {
        string jsonString = File.ReadAllText(Application.dataPath + "/Resources/Data/Skill.json");
        SkillUser skillObject = JsonMapper.ToObject<SkillUser>(jsonString);
        Debug.Log(skillObject.Character01[0].Name);
        return skillObject;
    }
}
[Serializable]
public class Skill
{
    public string ID;
    public string Name;
    public List<string> ParentID;

}

[Serializable]
public class SkillUser
{
    public List<Skill> Character01;
}
