using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectController : MonoBehaviour
{
    public MeshRenderer objectRenderer;
    public MeshFilter objectFilter; 
    public Text objectNameText;
    public ObjectData defaultObjectData; 

    [SerializeField] InputField nameInput;

    private ObjectData currentObjectData; 

    void Start()
    {
        // Set default object data
        SetObjectData(defaultObjectData);
    }

    public void SetObjectData(ObjectData newData)
    {
        currentObjectData = newData;

        // Update mesh renderer data
        if (currentObjectData.objectMeshRenderer != null)
        {
            objectRenderer = currentObjectData.objectMeshRenderer;
        }

        //Update MeshFilter data
        if(currentObjectData.objectMeshFilter != null)
        {
            objectFilter.sharedMesh= currentObjectData.objectMeshFilter.sharedMesh;
        }

        // Update object name
        if (objectNameText != null)
        {
            objectNameText.text = currentObjectData.objectName;
        }
    }

    public void ChangeName()
    {
        //Changing object name on button click
        currentObjectData.objectName = nameInput.text;
        objectNameText.text = currentObjectData.objectName;
        nameInput.text = ""; //Clear input field

    }
}
