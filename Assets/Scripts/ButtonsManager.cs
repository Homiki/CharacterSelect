using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsManager : MonoBehaviour
{
    public ObjectController objectController; 
    public ObjectData[] objectOptions; // Table with options of objects

    // Action on button click
    public void ChangeObject(int index)
    {
        if (index >= 0 && index < objectOptions.Length)
        {
            // Update data on scene
            objectController.SetObjectData(objectOptions[index]);
        }
        else
        {
            Debug.LogError("Invalid index: " + index);
        }
    }
}
