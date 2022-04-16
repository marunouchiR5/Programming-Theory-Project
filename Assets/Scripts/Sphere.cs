using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Sphere : Shape
{
    [SerializeField] private float delay = 1.0f;
    
    public string Color { get; private set; }
    public TMP_Text ColorText;
    
    // Start is called before the first frame update
    void Start()
    {
        Color = "Green";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DisplayText();
        }
    }
    
    protected override void DisplayText()
    {
        ColorText.enabled = true;
        ColorText.text = Color;
        StartCoroutine(EnableText());
    }

    IEnumerator EnableText()
    {
        yield return new WaitForSeconds(delay);
        ColorText.enabled = false;
    }
}
