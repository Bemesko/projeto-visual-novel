using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Responsible for adding and mantaining characters in the scene.
/// </summary>
public class CharacterManager : MonoBehaviour
{
    public static CharacterManager Instance;

    /// <summary>
    /// All characters must be attached to the character panel.
    /// </summary>
    public RectTransform _characterPanel;

    /// <summary>
    /// A list of all characters currently in our scene.
    /// </summary>
    public List<Character> _characters = new List<Character>();

    /// <summary>
    /// Easy lookup for our characters.
    /// </summary>
    public Dictionary<string, int> _characterDictionary = new Dictionary<string, int>();

    private void Awake()
    {
        Instance = this;
    }

    /// <summary>
    /// Try to get a character by the name provideed from the character list.
    /// </summary>
    public Character GetCharacter(string characterName, bool createCharacterIfDoesNotExist = true)
    {
        int index = -1;
        if (_characterDictionary.TryGetValue(characterName, out index))
        {
            return _characters[index];
        }
        else
        {
            return CreateCharacter(characterName);
        }
    }

    /// <summary>
    /// Creates the character
    /// </summary>
    public Character CreateCharacter(string characterName)
    {
        Character newCharacter = new Character(characterName);

        _characterDictionary.Add(characterName, _characters.Count);
        _characters.Add(newCharacter);

        return newCharacter;
    }
}
