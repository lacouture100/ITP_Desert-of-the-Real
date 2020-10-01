using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptB : MonoBehaviour
{
    public string name;
    // Define a ScriptA type of Object
    [SerializeField]
    private ScriptA scriptA;

    // Start is called before the first frame update
    void Start()
    {
        scriptA = FindObjectOfType<ScriptA>();

        scriptA.Function1(name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
