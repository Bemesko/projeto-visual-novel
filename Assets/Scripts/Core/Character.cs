using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Character
{
    public string _characterName;
    [HideInInspector]
    public RectTransform _root;

    /// <summary>
    /// Create a new character
    /// </summary>
    public Character(string _name)
    {
        CharacterManager characterManager = CharacterManager.Instance;
        GameObject prefab = Resources.Load($"Characters/Character[{_name}]") as GameObject;

        GameObject characterObject = GameObject.Instantiate(prefab, characterManager._characterPanel);

        _root = characterObject.GetComponent<RectTransform>();
        _characterName = _name;

        renderers.renderer = characterObject.GetComponentInChildren<Image>();
        renderers.bodyRenderer = characterObject.transform.Find("BodyLayer").GetComponent<Image>();
        renderers.bodyRenderer = characterObject.transform.Find("ExpressionLayer").GetComponent<Image>();
    }

    [System.Serializable]
    public class Renderers
    {
        public Image renderer;

        public Image bodyRenderer;
        public Image expressionRenderer;
    }

    public Renderers renderers = new Renderers();
}
