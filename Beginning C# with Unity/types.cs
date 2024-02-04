using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public bool statement = false;
    public string verb = "eat";
    public string noun = "mustache";
    public string adjective = "smelly";
    public int number = 100;
    public string pluralNoun = "clowns";
    public float percent = 43.4F;
    private TextMeshProUGUI textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = $"This is statement is {statement}. I did not {verb} the {noun}. I am not guily. I am a {adjective} person. The act was performed by {number} wandering {pluralNoun}. I am {percent}% sure of this."; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
