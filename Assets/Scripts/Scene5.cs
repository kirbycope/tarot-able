using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Scene5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        Button back = root.Q<Button>("Back");
        Button draw = root.Q<Button>("draw");

        back.clicked += () => SceneManager.LoadScene(sceneName: "SampleScene");
        //draw.clicked += () => SceneManager.LoadScene(sceneName: "Scene5");
    }
}
