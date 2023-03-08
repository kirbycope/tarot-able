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
        Button button3 = root.Q<Button>("Button3");
        Button button5 = root.Q<Button>("Button5");
        Button button10 = root.Q<Button>("Button10");

        //button3.clicked += () => cube.StartRotate()
        //button5.clicked += () => cube.StopRotate()
        //button10.clicked += () => cube.ChangeColor()
    }
}
