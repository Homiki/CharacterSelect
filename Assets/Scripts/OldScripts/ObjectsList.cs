using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectsList : MonoBehaviour
{
    [SerializeField] List<GameObject> objects;  //List of GameObjects
    [SerializeField] List<Button> buttons;

    [SerializeField] GameObject buttonPrefab; //Prefab of buttons in menu
    [SerializeField] GameObject buttonParent; //UI panel with Vertical Layer Group

    [SerializeField] GameObject objectParent; //Objects spawner (empty object)

    [SerializeField] InputField nameInput;
    [SerializeField] Button submitButton;
    [SerializeField] Text nameHandler;

    GameObject currentObject; //Current spawned object
    int positionInList; //Index of object in list

    private void OnEnable()
    {
        for (int i = 0; i < objects.Count; i++)
        {
            //Spawning buttons with listeners to each object in list
            GameObject buttonGameObject = Instantiate(buttonPrefab, buttonParent.transform);
            Button spawnedButton = buttonGameObject.GetComponent<Button>();
            int index = i;
            spawnedButton.onClick.AddListener(() => SpawnOnClick(index));
            spawnedButton.GetComponent<ButtonText>().buttonText.text = objects[index].name.ToString();
            buttons.Add(spawnedButton);
        }
        // Add listener to "Submit name" button
        submitButton.onClick.AddListener(() => GetInputNameOnClick());
        
    }

    public void SpawnOnClick(int index)
    {
        //Behavior of instantiated buttons
        Destroy(currentObject);
        GameObject selectedObject = objects[index];
        currentObject = Instantiate(selectedObject, objectParent.transform);
        positionInList = index;
        nameHandler.text = objects[index].name;
    }

    public void GetInputNameOnClick()
    {
        //Name object with text from input field
        currentObject.name = nameInput.text;
        nameHandler.text = currentObject.name;
        objects[positionInList].name = nameHandler.text;
        nameInput.text = ""; //Clear input field
        buttons[positionInList].GetComponent<ButtonText>().buttonText.text = nameHandler.text; //Change text inside the button
    }
}
