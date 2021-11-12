using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterTesting : MonoBehaviour
{
    public Character _layton;
    // Start is called before the first frame update
    void Start()
    {
        _layton = CharacterManager.Instance.GetCharacter("Layton");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
