using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class sample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // https://www.youtube.com/watch?v=yUXFHAOXhcA
    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        Button buttonStart = root.Q<Button>("ButtonStart");
        Button buttonStop = root.Q<Button>("ButtonStop");
        Button buttonColor = root.Q<Button>("ButtonColor");

        //buttonStart.clicked += () => cube.StartRotate()
        //buttonStop.clicked += () => cube.StopRotate()
        //buttonColor.clicked += () => cube.ChangeColor()
    }
}
