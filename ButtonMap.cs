
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ExampleClass : MonoBehaviour
{
    public Text text;
    void OnGUI()
    {
        Event e = Event.current;
        if (e.isKey)
        {
            text.text = (e.keyCode).ToString();
        }
    }
}
