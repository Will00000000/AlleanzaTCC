using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelfDialogue : MonoBehaviour
{
    public string[] dialogueSelfMorgan;
    public int dialogueIndex;

    public GameObject dialoguePanel;
    public Text dialogueText;

    public Text nameBox;
    public Image speakerImage;
    public Sprite speakerSprite;

    public bool readyToSpeak;
    public bool startDialogue;

    void Start()
    {
        dialoguePanel.SetActive(false);
    }

    void Update()
    {
        
    }
}