using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectsList : MonoBehaviour
{
    public List<GameObject> objects;

    public GameObject buttonPrefab;
    public GameObject buttonParent;

    public GameObject objectParent;

    public InputField nameInput;
    public Button submitButton;
    public Text nameHandler;

    GameObject currentObject;

    private void OnEnable()
    {
        for (int i = 0; i < objects.Count; i++)
        {
            GameObject buttonGameObject = Instantiate(buttonPrefab, buttonParent.transform);
            Button button = buttonGameObject.GetComponent<Button>();
            int index = i;
            button.onClick.AddListener(() => SpawnOnClick(index));
            button.GetComponent<ButtonText>().buttonText.text = objects[index].name.ToString();

        }
        submitButton.onClick.AddListener(() => GetInputNameOnClick());
        
    }

    public void SpawnOnClick(int index)
    {
        Destroy(currentObject);

        GameObject selectedObject = objects[index];

        currentObject = Instantiate(selectedObject, objectParent.transform);

        nameHandler.text = objects[index].name;

    }

    public void GetInputNameOnClick()
    {
        //Name object with text from input field
        currentObject.name = nameInput.text;
        nameHandler.text = currentObject.name;
        //objects[index].name = nameInput.text;

    }
}
