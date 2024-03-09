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

    GameObject currentObject;


    private void OnEnable()
    {

        for (int i = 0; i < objects.Count; i++)
        {
            GameObject buttonGameObject = Instantiate(buttonPrefab, buttonParent.transform);
            Button button = buttonGameObject.GetComponent<Button>();
            int index = i;
            button.GetComponent<ButtonText>().buttonText.text = objects[index].name.ToString();
            button.onClick.AddListener(() => SpawnOnClick(index));
        }


    }

    public void SpawnOnClick(int index)
    {
        Destroy(currentObject);

        GameObject selectedObject = objects[index];

        currentObject = Instantiate(selectedObject, objectParent.transform);
    }
}
