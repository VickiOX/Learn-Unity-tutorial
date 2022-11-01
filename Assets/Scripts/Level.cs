using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Level: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int CharacterLevel = 32;
        int NextSkillLevel = GenerateCharacter("Spike", CharacterLevel);

        Debug.Log(NextSkillLevel);
        Debug.Log(GenerateCharacter("Spike", CharacterLevel));
    }
    public int GenerateCharacter(string name, int level)
    {
        Debug.LogFormat("Character:{0} - Level: {1}",name, level);
        return level += 5;
    }
}