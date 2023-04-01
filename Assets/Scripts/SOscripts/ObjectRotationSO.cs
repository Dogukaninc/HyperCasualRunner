using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptbleObjects/ObjectRotationAxis", fileName = "ObjectRotation")]
public class ObjectRotationSO : ScriptableObject
{
    public bool rotatingX, rotatingY, rotatingZ;
}
