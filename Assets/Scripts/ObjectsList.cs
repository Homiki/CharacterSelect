using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectsList : MonoBehaviour
{
    public List<GameObject> objects;

    public GameObject buttonPrefab;
    public GameObject buttonParent;

    public GameObject objectSpawner;

    private void OnEnable()
    {
        for(int i = 0; i < objects.Count; i++)
        {
            GameObject newButton = Instantiate(buttonPrefab, buttonParent.transform);

            newButton.GetComponent<Button>().onClick.AddListener(() => SpawnOnClick());
            
            
        }
    }

    private void SpawnOnClick()
    {
        //GetComponent<Button>().onClick.Invoke();
        for(int j = 0; j < objects.Count; j++)
        {
            int objectToSpawn = objects.Count + 1;

            //GameObject newObject =  Instantiate(objects, objectSpawner.transform);
        }


    }
}
