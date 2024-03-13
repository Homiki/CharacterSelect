using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Object Data", menuName = "Object Data")]
public class ObjectData : ScriptableObject
{
    public string objectName;
    public MeshRenderer objectMeshRenderer;
    public MeshFilter objectMeshFilter;
}
