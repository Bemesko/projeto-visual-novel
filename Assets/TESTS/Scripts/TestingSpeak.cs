using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingSpeak : MonoBehaviour
{
    DialogueSystem dialogueSystem;
    // Start is called before the first frame update
    void Start()
    {
        dialogueSystem = DialogueSystem.Instance;
    }

    public string[] s = new string[]
    {
        "Hi, aeaeafefaefa:Berbão",
        "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
        "oaidfa"
    };

    int index = 0;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!dialogueSystem.isSpeaking || dialogueSystem.isWaitingForUserInput)
            {
                if (index >= s.Length)
                {
                    return;
                }
                Say(s[index]);
                index++;
            }
        }
    }

    void Say(string sayText)
    {
        string[] parts = sayText.Split(':');
        string speech = parts[0];
        string speaker = (parts.Length >= 2) ? parts[1] : "";

        dialogueSystem.Say(speech, true, speaker);
    }
}
